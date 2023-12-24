// See https://aka.ms/new-console-template for more information
using System.Collections.Generic;
using System.Dynamic;

bool mostrarExpandible=false;
if (mostrarExpandible)
{ 
    dynamic expandible = new ExpandoObject();

    expandible.Name = "Pepe";
    expandible.Description = "descri";

    foreach (dynamic item in expandible)
        Console.WriteLine($"{item.Key}-{item.Value}");

    expandible.Edad = 53;

    // Es un diccionario
    foreach (dynamic item in expandible)
        Console.WriteLine($"{item.Key}-{item.Value}");
}

Dictionary<string,string> d = new();
d.Add("el1", "Jose");
d.Add("el2", "Daniel");
foreach (var item in d)
    Console.WriteLine(item.Key+item.Value);

if  (d.ContainsKey("el1"))
    Console.WriteLine(  "Si la contiene");



