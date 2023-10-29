//void dot (int X, int Y){
    System.Console.Write("Задай координату точки 1 оси X:");
    int AX = int.Parse(Console.ReadLine());
    System.Console.Write("Задай координату точки 1 оси Y:");
    int AY = int.Parse(Console.ReadLine());

    System.Console.Write("Задай координату точки 2 оси X:");
    int BX = int.Parse(Console.ReadLine());
    System.Console.Write("Задай координату точки 2 оси Y:");
    int BY = int.Parse(Console.ReadLine());

    //int sqrX = (BX - AX)*(BX - AX)
    double sqrX = Math.Pow(BX-AX, 2); // Math.Pow(a,2) функция возводит в степень
    double sqrY = Math.Pow(BY-AY, 2);
    double root = Math.Sqrt(sqrX + sqrY);
    System.Console.Write($"Расстояние между двумя точками: {Math.Round(root,2)}");
//}
