using System;
namespace ProjectHome5
{
    internal class Program
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("Введіть дату у форматі ДД.ММ.РРРР:");
            DateTime date = DateTime.Parse(Console.ReadLine()!);

            string[] seasons = { "Winter", "Spring", "Summer", "Autumn" };
            string[] days = { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };

            int seasonNumber = (date.Month % 12) / 3; 
            string season = seasons[seasonNumber];
            string day = days[(int)date.DayOfWeek]; 
            Console.WriteLine(); 
            Console.WriteLine("Пора року: " + season); 
            Console.WriteLine("День тижня: " + day);
        }
    }
}
