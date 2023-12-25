namespace WebConAPI.Shared
{
    public class Agente
    {
        public string Codigo { get; set; }

        public string Nombre { get; set; }

        public bool EsVendedorBool;

        public int EsVendedor 
        { 
            get
            {
                return EsVendedorBool ? 1 : 0;
            }
                 
            set
            {
                EsVendedorBool = (value == 1) ;
            }
        }

        
        public bool EsCobradorBool;

        public int EsCobrador 
        { 
            get
            {
                return EsCobradorBool ? 1 : 0;
            }
                 
            set
            {
                EsCobradorBool = (value == 1) ;
            }
        }

       
        public string Email { get; set; }


        public bool EsRendicionGastosBool;

        public int EsRendicionGastos
        {
            get
            {
                return EsRendicionGastosBool ? 1 : 0;
            }

            set
            {
                EsRendicionGastosBool = (value == 1);
            }
        }

        
        
        public bool EsDespachanteAduanaBool;

        public int EsDespachanteAduana
        {
            get
            {
                return EsDespachanteAduanaBool ? 1 : 0;
            }

            set
            {
                EsDespachanteAduanaBool = (value == 1);
            }
        }

       
        public bool EsDestinoMaterialesBool;

        public int EsDestinoMateriales
        {
            get
            {
                return EsDestinoMaterialesBool ? 1 : 0;
            }

            set
            {
                EsDestinoMaterialesBool = (value == 1);
            }
        }

        
        public bool EsTransportistaBool;

        public int EsTransportista
        {
            get
            {
                return EsTransportistaBool ? 1 : 0;
            }

            set
            {
                EsTransportistaBool = (value == 1);
            }
        }

        public bool EsConductorRepartidorBool;

        public int EsConductorRepartidor
        {
            get
            {
                return EsConductorRepartidorBool ? 1 : 0;
            }

            set
            {
                EsConductorRepartidorBool = (value == 1);
            }
        }

        public bool EsPreventistaBool;

        public int EsPreventista
        {
            get
            {
                return EsPreventistaBool ? 1 : 0;
            }

            set
            {
                EsPreventistaBool = (value == 1);
            }
        }

        public bool EsCompradorBool;

        public int EsComprador
        {
            get
            {
                return EsCompradorBool ? 1 : 0;
            }

            set
            {
                EsCompradorBool = (value == 1);
            }
        }
        //public string codigoSeleccion { get; set; }

        //public string numeroImpositivoTipo { get; set; }

        //public string numeroImpositivo1 { get; set; }

        //public float sueldo { get; set; }

        //public string observacionViaticos { get; set; }

        //public string zona { get; set; }

        //public DateTime fechaIngreso { get; set; }

        //public int permisoPrecios { get; set; }

        //public int permisoCondicionVenta { get; set; }

        //public int permisoCreditoMaximo { get; set; }

        //public int permisoRuta { get; set; }

        //public int talonarioPedidos { get; set; }

        //public string tipoVinculo { get; set; }

        //public int empresaAlta { get; set; }

    }
}