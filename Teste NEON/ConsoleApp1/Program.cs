// See https://aka.ms/new-console-template for more information
using ConsoleApp1;

Console.WriteLine("Hello, World!");

Palindromo p = new Palindromo();

Console.WriteLine(p.VerificaPalindromo() ? "SIM" : "NÂO");

p.GetFibonacci(6);

Console.ReadKey();
