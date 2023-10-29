int Part(int number){
    if (number == 1){
       // double X = new Random().Next(0, int.MaxValue);
       // double Y = new Random().Next(0, int.MaxValue);
        //Console.WriteLine($"Точка лежит в первой четверти: ({X};{Y})");
        Console.WriteLine($"Точка лежит в первой четверти: X > 0, Y > 0");
        }
    else if (number == 2){
         //   int X = new Random().Next(0, int.MaxValue);
         //   int Y = new Random().Next(0, int.MinValue);
            // Console.WriteLine($"Точка лежит во второй четверти: ({X};{Y})");
            Console.WriteLine($"Точка лежит во второй четверти: X > 0, Y < 0");
        }
    else if (number == 3){
         //   int X = new Random().Next(0, int.MinValue);
         //   int Y = new Random().Next(0, int.MaxValue);
          //   Console.WriteLine($"Точка лежит в третьей четверти: ({X};{Y})");
          Console.WriteLine($"Точка лежит в третьей четверти: X < 0, Y > 0");
        }
    else if (number == 4){
        //    int X = new Random().Next(0, int.MinValue);
        //    int Y = new Random().Next(0, int.MinValue);
         //   Console.WriteLine($"Точка лежит в четвёртой четверти: ({X};{Y})");
         Console.WriteLine($"Точка лежит в четвёртой четверти: X < 0, Y < 0");
        }
    return number;
    }
Part(3);