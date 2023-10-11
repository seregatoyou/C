Console.WriteLine("Введите число 1: ");
int a = int.Parse(System.Console.ReadLine());
Console.WriteLine("Введите число 2: ");
int b = int.Parse(System.Console.ReadLine());

if (a == b*b || b == a*a){
   Console.WriteLine("Одно число является квадратом другого.");
}
else{
   Console.WriteLine("Ни одно число не является квадратом другого.");
}