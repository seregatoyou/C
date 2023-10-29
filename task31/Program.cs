using System;
void ArrSum(){

    int totalPos = 0;
    int totalNeg = 0;

    int[] array = new int[12];
    for (int i = 0; i < 12; i++){

        array[i] = new Random().Next(-10,10);
        if (array[i] > 0) {
            totalPos = totalPos + array[i];
        }
        else if (array[i] < 0) {
            totalNeg = totalNeg + array[i];
        }
    }
    Console.WriteLine($"Сумма отрицательных элеменов: {totalNeg}");
    Console.WriteLine($"Сумма положительных элеменов: {totalPos}");
}
ArrSum();