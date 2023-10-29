using System;
void array(int a){

    int b = 0;
    int[] arr  = new int[a];

    for (int i = 0; i < a; i++){
        arr[i] = new Random().Next(-100, 100);
    }
  //  Console.WriteLine("[{0}]", string.Join(", ", arr));
    Console.WriteLine("Введите число: ");
    b = int.Parse(System.Console.ReadLine());

    for (int i = 0; i < a; i++){
        if (b == arr[i]){
            Console.WriteLine($"Число {b} присутствует в массиве.");
            break;
            }
        if (i == (a-1)){
            Console.WriteLine($"Число {b} не присутствует в массиве.");
        }
    }
    Console.WriteLine("[{0}]", string.Join(", ", arr));
}
array(15);