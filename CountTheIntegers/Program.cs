using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountTheIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int i;
            var counter = 0;
            while (int.TryParse(input, out i))
            {
                counter++;
                input = Console.ReadLine();
            }
            Console.WriteLine(counter);
        }
    }
}
