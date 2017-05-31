using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChooseDrink2
{
    class Program
    {
        static void Main(string[] args)
        {
            var proffession = Console.ReadLine();
            var quantity = int.Parse(Console.ReadLine());
            var drink = "";
            double cost = 0;

            if (proffession == "Athlete")
            {
                drink = "Water";
                cost = quantity * 0.7;

            }
            else if (proffession == "Businessman" || proffession == "Businesswoman")
            {
                drink = "Coffee";
                cost = quantity * 1.0;
            }
            else if (proffession == "SoftUni Student")
            {
                drink = "Beer";
                cost = quantity * 1.7;
            }
            else
            {
                drink = "Tea";
                cost = quantity * 1.2;
            }
            Console.WriteLine($"The {proffession} has to pay {cost:F2}.");
        }
    }
    
}
