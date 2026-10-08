using System;
namespace ProjectHome6
{
    internal class Program
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("Введіть температуру:");
            double temperature = double.Parse(Console.ReadLine()!);
            Console.WriteLine("Оберіть конвертацію:"); 
            Console.WriteLine("1 - Фаренгейт -> Цельсій"); 
            Console.WriteLine("2 - Цельсій -> Фаренгейт");

            int choice = int.Parse(Console.ReadLine()!);

            switch (choice) 
            {
                case 1: 
                    Console.WriteLine("Результат: " + ((temperature - 32) * 5 / 9) + " °C"); 
                    break;
                case 2: 
                    Console.WriteLine("Результат: " + (temperature * 9 / 5 + 32) + " °F"); 
                    break;
                default: Console.WriteLine("Невірний вибір."); 
                    break;
            }
        }
    }
}
