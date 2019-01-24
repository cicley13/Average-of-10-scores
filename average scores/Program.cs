using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace average_scores
{
    class Program
    {
        static void Main(string[] args)
        {
            int max = 10;
            Console.WriteLine($"Write 10 numbers between 0 to 100");
            double a = Numbers(1);
            a += Numbers(2);
            a += Numbers(3);
            a += Numbers(4);
            a += Numbers(5);
            a += Numbers(6);
            a += Numbers(7);
            a += Numbers(8);
            a += Numbers(9);
            a += Numbers(10);
            Console.WriteLine(a / max);
            Grade(a / max);
            Console.ReadLine();
        }
        static double Numbers(int k)
        {
            Console.WriteLine($"Entry #{k}  ");
            double a = double.Parse(Console.ReadLine());
            if (a < 0 || a > 100)
            {
                Console.WriteLine("Invalid number. Choose a number between 0 to 100");
                a = double.Parse(Console.ReadLine());
            }
            return a;
        }

        private static void Grade(double a)
        {
            Console.WriteLine($"Your grade is : {a}");
            if (a > 90 || a > 100)
            {
                Console.WriteLine("That's a A!");
            }
            else if (a > 80 || a > 90)
            {
                Console.WriteLine("That's a B!");
            }
            else if (a > 70 || a > 80)
            {
                Console.WriteLine("THat's a C!");
            }
            else if (a > 60 || a > 70)
            {
                Console.WriteLine("That's a D!");
            }
            else if (a > 0 || a > 60)
            {
                Console.WriteLine("That's a F!");
            }
        }

    }
}
