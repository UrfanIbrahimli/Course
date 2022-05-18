using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Intervali daxil edin\n");
                Console.Write("a -dan = ");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.Write("b -ye = ");
                int b = Convert.ToInt32(Console.ReadLine());
                int counter = 0;
                Console.WriteLine("\n-----------------------");
                for (int i = a; i < b; i++)
                {
                    var result = GetArmstrongNumber(i);
                    if (result.Item1)
                    {
                        counter++;
                        Console.WriteLine(result.Item2);
                    }
                }
                Console.WriteLine($"\nArmstronq ededlerin sayi: {counter}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception: {ex.Message}");
            }
        }


        private static Tuple<bool, int> GetArmstrongNumber(int number)
        {
            int sum = 0;
            int currentNumber = number;
            while (number > 0)
            {
                int current_digit = number % 10;
                number /= 10;
                sum += CustomPow(current_digit, 3);
            }
            if (currentNumber == sum)
                return Tuple.Create<bool, int>(true, sum);
            return Tuple.Create<bool, int>(false, sum);
        }


        private static int CustomPow(int x, short y)
        {
            int result = 1;
            for (int i = 0; i < y; i++)
            {
                result *= x;
            }
            return result;
        }
}
}
