using System;
void array(int a){

    int[] arr  = new int[a];

    for (int i = 0; i < a; i++){
        arr[i] = new Random().Next(-100, 100);
    }
    Console.WriteLine("[{0}]", string.Join(", ", arr));

    for (int i = 0; i < a; i++){
        arr[i] = arr[i] * (-1);
    }
    Console.WriteLine("[{0}]", string.Join(", ", arr));
}
array(5);