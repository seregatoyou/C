int number = new Random().Next(10, 100);
Console.WriteLine($"Наше число: {number} ");
int a = number % 10;
int b = number / 10;
if (a > b) {
    Console.WriteLine($"Наибольшая цифра числа: {a} ");
}
else if (a < b) {
    Console.WriteLine($"Наибольшая цифра числа: {b} ");
}
else {
    Console.WriteLine("Цифры числа равны.");
}