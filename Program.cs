using System.Security.Cryptography.X509Certificates;

namespace Assignment_5._1._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number: ");
            int x = Convert.ToInt32(Console.ReadLine());
            int reverse = 0;

            bool result = IfPalindrome(x);
            Console.WriteLine(result);
        }

        public static bool IfPalindrome(int x)
        {
            while (x > 0)
            {
               x = x % 10;
            }

        }

    }
}
