// See https://aka.ms/new-console-template for more information
int numberOfItems = 6;
int minNumber = 1;
int maxNumber = 45;

Random rando = new Random();
Console.WriteLine(rando.Next(minNumber,maxNumber+1));