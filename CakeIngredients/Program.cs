using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CakeIngredients
{
    class Program
    {
        static void Main(string[] args)
        {
            var counter = 0;
            var ingredient = "";
            while (true)
            {
                ingredient = Console.ReadLine();
                if (ingredient == "Bake!")
                    break;
                Console.WriteLine($"Adding ingredient {ingredient}.");
                counter++;
            }

            Console.WriteLine($"Preparing cake with {counter} ingredients.");
        }
    }
}
