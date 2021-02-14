using System;

namespace Perfect_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter The Number");
            long Number = Convert.ToInt64(Console.ReadLine());
            long sum = 0;
            for ( long i = 1; i < Number; i++)
            {
                if ( Number % i == 0)
                {
                    sum += i;
                }
            }
            if (sum == Number)
            {
                Console.WriteLine("It's a Perfect Number");
            }
            else
            {
                Console.WriteLine("It is NOT a Perfect Number");
            }
            Console.ReadKey();
        }
    }
}
