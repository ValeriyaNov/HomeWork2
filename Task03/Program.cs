﻿// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, 
//является ли этот день выходным.
//6 -> да
//7 -> да
//1 -> нет
using static System.Console;
Clear();
WriteLine("Введите цифру");
int day=Convert.ToInt32(ReadLine());
if ((day>7) | (day<1))
{
    WriteLine("Данная цифра не соответсвует дню недели");
}
if ((day>=1) && (day<6))
{
    WriteLine("НЕТ");
}
if ((day>5) && (day<8))
{
    WriteLine("ДА");
}