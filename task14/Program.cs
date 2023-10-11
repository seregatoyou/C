Console.WriteLine("Введите число: ");
int b = int.Parse(System.Console.ReadLine());

if (b%7 == 0 && b%23 == 0){
    Console.WriteLine("Наше число одновременно кратно 7-и и 23-м.");
}
else{
    Console.WriteLine("Наше число одновременно не кратно 7-и и 23-м. ");
}