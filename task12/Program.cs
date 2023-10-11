Console.WriteLine("Введите число 1: ");
int a = int.Parse(System.Console.ReadLine());
Console.WriteLine("Введите число 2: ");
int b = int.Parse(System.Console.ReadLine());

if (b%a == 0){
   Console.WriteLine("Второе число кратно первому числу.");
}
else{
    Console.WriteLine($"Остаток от деления: {b%a}");
}