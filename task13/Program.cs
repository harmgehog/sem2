// Задача 13: Напишите программу, которая выводит третью 
// цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

// this is the best first option

try 
{
Console.WriteLine(Console.ReadLine()![2]);
}
catch (IndexOutOfRangeException)
{
    Console.WriteLine("третьей цифры нет");
}

// Another option with butthurt and while

int num;
num = Convert.ToInt32(Console.ReadLine());

while (num > 999) num /= 10;
if (num < 100) Console.WriteLine("третьей цифры нет");
else Console.WriteLine(num%10);