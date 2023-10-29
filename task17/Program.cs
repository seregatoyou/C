int Part(int X, int Y){
    int number = 0;
    if (X == 0 || Y == 0){
        Console.WriteLine("Точка лежит на одной из осей!");
    } 
    else if ( X > 0 && Y > 0){
            Console.WriteLine("Точка лежит в первой четверти.");
            number = 1;
        }
    else if ( X > 0 && Y < 0){
            Console.WriteLine("Точка лежит в четвертой четверти.");
            number = 4;
        }
    else if ( X < 0 && Y > 0){
            Console.WriteLine("Точка лежит во второй четверти.");
            number = 2;
        }
    else if ( X < 0 && Y < 0){
            Console.WriteLine("Точка лежит в первой четверти.");
            number = 1;
        }
    return number;
    }
Part(-3, 4);