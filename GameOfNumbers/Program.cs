using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var num1 = int.Parse(Console.ReadLine());
            var num2 = int.Parse(Console.ReadLine());
            var magical = int.Parse(Console.ReadLine());
            var found = "";
            var counter = 0;
            for (int i = num1; i <= num2; i++)
            {
                for (int j = num1; j <= num2; j++)
                {
                    counter++;
                    if (i + j == magical)
                    {
                        found = $"{i} + {j}";
                    }
                }
            }
            if (found != "")
            {
                Console.WriteLine($"Number found! {found} = {magical}");
            }
            else
            {
                Console.WriteLine($"{counter} combinations - neither equals {magical}");
            }
        }
    }
}
