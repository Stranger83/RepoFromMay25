using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var num1 = int.Parse(Console.ReadLine());
            var num2 = int.Parse(Console.ReadLine());
            var max = int.Parse(Console.ReadLine());
            var total = 0;
            var counter = 0;
            for (int i = num1; i > 0; i--)
            {
                for (int j = 1; j <= num2; j++)
                {
                    total += i * j * 3;
                    counter++;
                    if (total >= max)
                    {
                        break;
                    }
                }
                if (total >= max)
                {
                    break;
                }
            }
            if (total >= max)
            {
                Console.WriteLine($"{counter} combinations");
                Console.WriteLine($"Sum: {total} >= {max}");
            }
            else
            {
                Console.WriteLine($"{counter} combinations");
                Console.WriteLine($"Sum: {total}");
            }
        }
    }
}
