using System;
namespace ProjectHome7
{
    internal class Program
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("Введіть початок діапазону:");
            int number1 = int.Parse(Console.ReadLine()!);

            Console.WriteLine("Введіть кінець діапазону:"); 
            int number2 = int.Parse(Console.ReadLine()!);
            int start = Math.Min(number1, number2); 
            int end = Math.Max(number1, number2);

            Console.WriteLine("Парні числа у діапазоні:");
            start += start % 2; 
            for (int i = start; i <= end; i += 2) 
            {
                Console.Write(i + " ");
            }
        }
    }
}
