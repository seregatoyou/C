// Введите два числа, проверьте, является ли первое число квадратом второго:
Console.WriteLine("Введите два числа: ");
int a = int.Parse(System.Console.ReadLine());
int b = int.Parse(System.Console.ReadLine());

if (a == b*b) {
    Console.WriteLine($"Да, {a} является квадратом {b}. ");
}

else {
    Console.WriteLine($"Нет, {a} не является квадратом {b}. ");
}