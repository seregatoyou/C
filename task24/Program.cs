﻿using System;
int number(int a){
    int total = 0;
    for(int i = 1; i <=a ; i++){
        total = total + i;
    }
    Console.WriteLine($"{total}");
    return total;   
}
number(7);