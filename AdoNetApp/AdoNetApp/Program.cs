// See https://aka.ms/new-console-template for more information
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Data;
using System.Data.SqlClient;

// Esto es para poder usar el archivo del configuración
using IHost host= Host.CreateDefaultBuilder(args).Build();

var configuracion = host.Services.GetService<IConfiguration>();

var cadenaConexion = configuracion.GetConnectionString("cadenaDeConexion");



try
{
    using (SqlConnection conexion = new SqlConnection(cadenaConexion))
    {
        conexion.Open();
        Console.WriteLine("Conexion Abierta");

        bool insertarPersona = false;
        string strSQL = "";

        if (insertarPersona)
        {
            Console.WriteLine("Ingrese un nombre para agregarlo en la BD:");
            var strNuevoNombre = Console.ReadLine();
            //string strSQL = "insert personas values (@nom)";
            // Ahora llamo al SP
            strSQL = "PersonaInsertar";
            using (SqlCommand comm = new(strSQL, conexion))
            {
                comm.CommandType= CommandType.StoredProcedure;

                SqlParameter param = new SqlParameter("@nom", strNuevoNombre);
                comm.Parameters.Add(param);

                SqlParameter param2 = new SqlParameter();
                param2.ParameterName = "@Id";
                param2.Direction = ParameterDirection.Output;
                param2.DbType=DbType.Int32;
                comm.Parameters.Add(param2);

                await comm.ExecuteNonQueryAsync();
            
                Console.WriteLine($"Id insertado:{param2.Value}");
            }
        }
        bool traerEscalar = false;
        if (traerEscalar )
        {
            strSQL = "select count(*) from Personas";
            using (SqlCommand comm = new(strSQL, conexion))
            {
                var cantidad = comm.ExecuteScalar();
                Console.WriteLine($"Cantidad de Personas:{cantidad}");
            }
        }
        bool traerTabla = false;
        if (traerTabla)
        {
            using (SqlCommand comm = new(strSQL, conexion))
            {
                comm.CommandType = CommandType.StoredProcedure;
                comm.CommandText = "PersonasYPreciosLeer";

                SqlDataAdapter adapter = new(comm);

                DataTable dt = new();

                adapter.Fill(dt);

                foreach (DataRow item in dt.Rows)
                {
                    Console.WriteLine($"{item[0]} ! {item[1]}" );
                }
            }
        }
        bool traerTablas = true;
        if (traerTablas)
        {
            using (SqlCommand comm = new(strSQL, conexion))
            {
                comm.CommandType = CommandType.StoredProcedure;
                comm.CommandText = "PersonasYPreciosLeer";

                SqlDataAdapter adapter = new(comm);

                DataSet ds = new();

                adapter.Fill(ds);

                DataTable Personas = ds.Tables[0];
                DataTable Precios = ds.Tables[1];

                foreach (DataRow item in Personas.Rows)
                {
                    Console.WriteLine($"{item["Id"]} ! {item["Nombre"]}");
                }

                Console.WriteLine("-----------------------------------------------------");

                foreach (DataRow item in Precios.Rows)
                {
                    Console.WriteLine($"{item["Id"]} ! {item["Producto"]} ! {item["Precio"]}");
                }
            }
        }
    }
}
catch (Exception ex)
{
    Console.WriteLine("Error abriendo conexion");
    Console.WriteLine( ex.Message );
}

Console.WriteLine("Finalesima54");

await host.RunAsync();  

