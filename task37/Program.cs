using System;
void array(int a){
    int mlt = 0;
    int[] arr  = new int[a];
    int[] arr2 = new int[a/2];

    for (int i = 0; i < a; i++){
        arr[i] = new Random().Next(0, 123);
        }
    Console.WriteLine("[{0}]", string.Join(", ", arr));
    int count1 = 0;
    int count2 = a;
      for (int j = 0; j < a/2; j++){
            mlt = arr[count1] * arr[count2];
            arr2[j] = mlt;
            count1++;
            count2--;
        }
        Console.WriteLine("[{0}]", string.Join(", ", arr2));
}
array(10);