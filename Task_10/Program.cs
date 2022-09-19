/* // Задача 10: Напишите программу, которая принимает на вход 
трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1 */
internal class Program
{
    private static void Main(string[] args)
    {
        // Ответ 1 
        int num = new Random().Next(100, 1000);
        int num1 = num % 100 / 10;

        Console.WriteLine(num);
        Console.Write($"ответ {num1}"); 

       /*  // Ответ 2. 
        Console.WriteLine("Введите трёхзначное число");
        string str = Console.ReadLine();
        Console.WriteLine("Ответ: \t" + str[^2]);    */
    }
}





