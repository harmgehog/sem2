// Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

// this is the best first option

Console.WriteLine(Console.ReadLine()[1]);

// one other option with math

int num;

num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(num % 100 / 10);