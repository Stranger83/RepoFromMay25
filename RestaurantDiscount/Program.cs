using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantDiscount
{
    class Program
    {
        static void Main(string[] args)
        {
            var people = int.Parse(Console.ReadLine());
            var package = Console.ReadLine();
            var hallName = "";
            var smallHallPrice = 2500;
            var terracePrice = 5000;
            var greatHallPrice = 7500;
            var normalPrice = 500;
            var goldPrice = 750;
            var platinumPrice = 1000;
            double totalPrice = 0.0;

            if (people > 120)
            {
                Console.WriteLine("We do not have an appropriate hall.");
            }
            else
            {
                if (people <= 50)
                {
                    hallName = "Small Hall";
                    switch (package)
                    {
                        case "Normal":
                            totalPrice = (smallHallPrice + normalPrice) * 95.0 / 100.0;
                            break;
                        case "Gold":
                            totalPrice = (smallHallPrice + goldPrice) * 90.0 / 100.0;
                            break;
                        case "Platinum":
                            totalPrice = (smallHallPrice + platinumPrice) * 85.0 / 100.0;
                            break;
                    }
                }
                else if (people > 50 && people <= 100)
                {
                    hallName = "Terrace";
                    switch (package)
                    {
                        case "Normal":
                            totalPrice = (terracePrice + normalPrice) * 95.0 / 100.0;
                            break;
                        case "Gold":
                            totalPrice = (terracePrice + goldPrice) * 90.0 / 100.0;
                            break;
                        case "Platinum":
                            totalPrice = (terracePrice + platinumPrice) * 85.0 / 100.0;
                            break;
                    }
                }
                else if (people > 100 && people <= 120)
                {
                    hallName = "Great Hall";
                    switch (package)
                    {
                        case "Normal":
                            totalPrice = (greatHallPrice + normalPrice) * 95.0 / 100.0;
                            break;
                        case "Gold":
                            totalPrice = (greatHallPrice + goldPrice) * 90.0 / 100.0;
                            break;
                        case "Platinum":
                            totalPrice = (greatHallPrice + platinumPrice) * 85.0 / 100.0;
                            break;
                    }
                }

                double pricePerPerson = totalPrice / people;
                Console.WriteLine($"We can offer you the {hallName}");
                Console.WriteLine($"The price per person is {pricePerPerson:F2}$");
            }
        }
    }
}
