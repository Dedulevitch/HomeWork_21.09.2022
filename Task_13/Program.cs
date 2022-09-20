/* // Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6 */
internal partial class Program
{
    private static void Main(string[] args)
    {
       Console.WriteLine("Напишите число ");
        int limit = int.Parse(Console.ReadLine());
        int count = 999;

        while (count < limit)
        {
            limit = limit / 10;
        }
        /* int result = limit % 10; */
        /* Console.WriteLine(limit); */
        if (limit < 99)
        {
            Console.WriteLine("Такой цифры нету");
        }
        else
        {
            Console.WriteLine(limit % 10);
        }
    }

}






