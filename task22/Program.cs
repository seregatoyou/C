void square(int number){
    double[] sqr = new double[number];
    for (int i = 1; i < number; i++){
            sqr[i] = Math.Pow (i, 2);
            Console.WriteLine($"{sqr[i]}");
            }
    }
square(9);