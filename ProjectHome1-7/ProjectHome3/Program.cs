namespace ProjectHome3
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Введіть першу цифру: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Введіть другу цифру: ");
            int b = int.Parse(Console.ReadLine());

            Console.Write("Введіть третю цифру: ");
            int c = int.Parse(Console.ReadLine());

            Console.Write("Введіть четверту цифру: ");
            int d = int.Parse(Console.ReadLine());

            int number = a * 1000 + b * 100 + c * 10 + d;
            Console.WriteLine("Сформоване число: " + number);
        }
    }
}
