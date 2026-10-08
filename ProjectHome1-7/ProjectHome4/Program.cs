namespace ProjectHome4
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Введіть шестизначне число: ");
            string number = Console.ReadLine();

            if (number.Length != 6) 
            { 
                Console.WriteLine("Помилка! Число повинно бути шестизначним."); 
                return; 
            }
            Console.Write("Введіть номер першого розряду (1-6): "); 
            int first = int.Parse(Console.ReadLine());

            Console.Write("Введіть номер другого розряду (1-6): ");
            int second = int.Parse(Console.ReadLine());

            if (first < 1 || first > 6 || second < 1 || second > 6) 
            { 
                Console.WriteLine("Помилка! Номер розряду повинен бути від 1 до 6."); 
                return; 
            }
            char[] digits = number.ToCharArray();
            char temp = digits[first - 1]; 
            digits[first - 1] = digits[second - 1]; 
            digits[second - 1] = temp;
            string result = new string(digits); 
            Console.WriteLine("Результат: " + result);
        }
    }
}
