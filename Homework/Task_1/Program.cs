﻿// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Write("Введите пятизначное число - ");
int n=Convert.ToInt32(Console.ReadLine());
if (n>9999&&n<100000){
    if (n%10==n/10000 && (n%100)/10==(n/1000)%10){
            Console.WriteLine("Да");
    }
        
    else{
    Console.WriteLine("Нет");
    }
}
else { 
    Console.WriteLine("Число не пятизначное");
}
//System.Console.WriteLine((n%100)/10);