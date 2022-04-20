Console.WriteLine("Bir sayi giriniz: ");

int input = int.Parse(Console.ReadLine());
var result = Recursion.Math.Factorial(input);

Console.WriteLine($"{input}! = {result}");
