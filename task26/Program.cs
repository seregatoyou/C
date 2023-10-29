using System;
int number(int a){
    int total = 0;
    while(a>0){
        a = a / 10;
        total++;
    }
    Console.WriteLine($"{total}");
    return total;   
}
number(456);