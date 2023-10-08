// Напишите программу, которая принимает на вход трёхзнрачное число и на выходе показывает последнюю цифру этого числа.
Console.WriteLine("Введите число: ");
int a = int.Parse(System.Console.ReadLine());
Console.WriteLine("Последняя цифра трёхзначного числа: ");
Console.WriteLine($"{a%10}");