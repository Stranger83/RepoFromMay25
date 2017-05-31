using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicLetter
{
    class Program
    {
        static void Main(string[] args)
        {
            char letter1 = char.Parse(Console.ReadLine());
            char letter2 = char.Parse(Console.ReadLine());
            char magicLetter = char.Parse(Console.ReadLine());

            for (char i = letter1; i <= letter2; i++)
            {
                for (char j = letter1; j <= letter2; j++)
                {
                    for (char k = letter1; k <= letter2; k++)
                    {
                        if (i == magicLetter || j == magicLetter || k == magicLetter)
                        {
                            continue;
                        }
                        else
                        {
                            Console.Write("{0}{1}{2} ", i, j, k);
                        }
                    }
                    
                }
            }

        }
    }
}
