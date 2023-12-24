// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


List<int> list = new() { 11, 12, 13, 14 };

var primero = list.First();

Console.WriteLine(primero);

var vacio = new List<int>();

var primervacio = vacio.FirstOrDefault();

Console.WriteLine(primervacio);

var strings = new List<string>();

var primeracadena= strings.FirstOrDefault();

if (primeracadena != null)  
    Console.WriteLine(primeracadena);
else
    Console.WriteLine("Primera cadena nula");




