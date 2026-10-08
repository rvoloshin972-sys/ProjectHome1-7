namespace ProjectHome2
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Введіть число: ");
            double number = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введіть відсоток: "); 
            double percent = Convert.ToDouble(Console.ReadLine());

            double result = number * percent / 100;
            Console.WriteLine("Результат: " + result);
        }
    }
}
