// See https://aka.ms/new-console-template for more information
Console.WriteLine("Ejemplo de ejecución condicional");
Console.WriteLine("Se pide imprimir las duplas con iguales números");

Console.WriteLine("Inicio");

// Con este ejemplo se ve la ejecución condicional

(int, int)[] a = { (1, 1), (1, 2), (1, 3), (2, 1), (2, 2), (2, 3) };


var p = a.Where((x) => {Console.WriteLine($"Leyendo las duplas;{x}"); return (x.Item1.Equals(x.Item2)); });

//foreach ((int i, int j) in p)
foreach (var j in p)
    Console.WriteLine($"Imprimiendo las duplas iguales:{j}");



Console.WriteLine("Fin");
Console.ReadLine();
