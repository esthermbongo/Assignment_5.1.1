using System;

namespace Assignment_5._1._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number: ");
            int x = Convert.ToInt32(Console.ReadLine());
            

            bool result = IfPalindrome(x);
            Console.WriteLine(result);
        }

        public static bool IfPalindrome(int x)
        {
            int reverse = 0;
            int temp = x;

            while (temp > 0)
            {
               reverse = reverse*10 + temp % 10;
               temp = temp / 10;
            }

            return reverse == x;
            //updated

        }

    }
}
