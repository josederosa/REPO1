// See https://aka.ms/new-console-template for more information



Console.WriteLine("Hello, World!");

bool DiferredExecution = false;

if (DiferredExecution)
{ 
    var someNumbers = Enumerable.Range(1, 10);

    var pairNumbers = someNumbers.Where((i) => { Console.WriteLine($" En el Where:{i}");return (i % 2 == 0); });
    var pairNumbersDirect = someNumbers.Where((i) => { Console.WriteLine($" En el Where:{i}"); return (i % 2 == 0); }).ToList();

    foreach (var number in pairNumbers)
        Console.WriteLine( $" Foreach Pair: {number} ");

    Console.WriteLine("--------------------------------------");

    foreach (var number in pairNumbersDirect)
        Console.WriteLine($" Foreach Pair: {number} ");
}

var Personas = new List<dynamic>() { new { Nom = "pepe", Eda = 10 }, new { Nom = "paco", Eda = 20 } };

var personasmayores = Personas.Where(p => p.Eda > 18);

foreach (var p in personasmayores)
{
    Console.WriteLine( $"{p.Nom} - {p.Eda}" );
}
