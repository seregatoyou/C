// Введите число n, которое формирует интервал значений от -n до n.
Console.WriteLine("Введите число: ");
int a = int.Parse(System.Console.ReadLine());
int i = -a;

while (i <= a ){
    Console.WriteLine($" {i}");
    i++;
};