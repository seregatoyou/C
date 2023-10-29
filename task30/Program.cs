using System;
void number1(){
    int[] array = new int[8];
    for(int i = 0; i <=7; i++){
        array[i] = new Random().Next(0, 2);
        //Console.WriteLine($"{array[i]}");
    }
    Console.WriteLine("[{0}]", string.Join(", ", array));
}
number1();