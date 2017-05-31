using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeighbourWars
{
    class Program
    {
        static void Main(string[] args)
        {
            var PeshoDmg = int.Parse(Console.ReadLine());
            var GoshoDmg = int.Parse(Console.ReadLine());
            var PeshoHealth = 100;
            var GoshoHealth = 100;
            var rounds = 1;
            var winner = "";

            while (true)
            {
                
                if (rounds % 2 == 0)
                {
                    PeshoHealth -= GoshoDmg;
                    if (PeshoHealth <= 0)
                    {
                        break;
                    }
                    Console.WriteLine($"Gosho used Thunderous fist and reduced Pesho to {PeshoHealth} health.");

                }
                else
                {
                    GoshoHealth -= PeshoDmg;
                    if (GoshoHealth <= 0)
                    {
                        break;
                    }
                    Console.WriteLine($"Pesho used Roundhouse kick and reduced Gosho to {GoshoHealth} health.");
                }
                if (rounds % 3 == 0)
                {
                    PeshoHealth += 10;
                    GoshoHealth += 10;
                }
                rounds++;
            }
            if (PeshoHealth <= 0)
            {
                winner = "Gosho";
            }
            else
            {
                winner = "Pesho";
            }
            Console.WriteLine($"{winner} won in {rounds}th round.");
        }
    }
}
