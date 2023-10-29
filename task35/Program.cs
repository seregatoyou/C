using System;
void array(int a){
    int total = 0;
    int[] arr  = new int[a];

    for (int i = 0; i < a; i++){
        arr[i] = new Random().Next(0, 123);
        if (10 <= arr[i] & arr[i] <= 99){
            total++;
        }
    }
    Console.WriteLine("[{0}]", string.Join(", ", arr));
    Console.WriteLine($"Количество элементов, входящих в отрезок [10,99] - {total}");
}
array(10);