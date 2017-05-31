using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChooseDrink
{
    class Program
    {
        static void Main(string[] args)
        {
            var proffession = Console.ReadLine();
            var drink = "";

            if (proffession == "Athlete")
            {
                drink = "Water";
            }
            else if (proffession == "Businessman" || proffession == "Businesswoman")
            {
                drink = "Coffee";
            }
            else if (proffession == "SoftUni Student")
            {
                drink = "Beer";
            }
            else
            {
                drink = "Tea";
            }
            Console.WriteLine(drink);
        }
    }
}
