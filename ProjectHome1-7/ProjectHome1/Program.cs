namespace ProjectHome1
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Введіть число від 1 до 100: ");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number < 1 || number > 100) 
            {
                Console.WriteLine("Помилка! Число повинно бути від 1 до 100.");
            }
            else if (number % 3 == 0 && number % 5 == 0) 
            {
                Console.WriteLine("Fizz Buzz");
            }
            else if (number % 3 == 0) 
            { 
                Console.WriteLine("Fizz"); 
            }
            else if (number % 5 == 0) 
            { 
                Console.WriteLine("Buzz"); 
            }
            else 
            { 
                Console.WriteLine(number); 
            }
        }
    }
}
