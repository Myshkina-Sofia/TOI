namespace lab2_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите значение N:");
            int n = Convert.ToInt32(Console.ReadLine());

            int makkarty(int n)
            {
                if (n > 100) return n - 10;
                else return makkarty(makkarty(n + 11));
            }

            Console.Write($"Функция Аккермана равно {makkarty(n)} ");
        }
    }
}