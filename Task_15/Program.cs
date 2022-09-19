// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
Console.WriteLine("Укажите число недели от 1 до 7");
int num = int.Parse(Console.ReadLine());
switch (num)
{
    case 1:
        Console.Write("Понедельник");
        break;

    case 2:
        Console.Write("Вторник");
        break;

    case 3:
        Console.Write("Среда");
        break;

    case 4:
        Console.Write("Четверг");
        break;

    case 5:
        Console.Write("Пятница");
        break;

    case 6:
        Console.Write("Суббота - Выходной");
        break;

    case 7:
        Console.Write("Воскресенье - Выходной");
        break;
}
Console.ReadLine();
