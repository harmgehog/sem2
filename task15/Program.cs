// Задача 15: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

int num = Convert.ToInt32(Console.ReadLine());
string rslt = num == 6 || num == 7 ? "да" : "нет";
Console.WriteLine(rslt);

// another option switch case

switch (num)
{
    case 6:
        goto case 7;
    case 7:
        Console.WriteLine("да");
        break;
    default:
        Console.WriteLine("нет");
        break;
};