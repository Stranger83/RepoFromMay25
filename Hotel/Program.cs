using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
    class Program
    {
        static void Main(string[] args)
        {
            var month = Console.ReadLine();
            var nights = int.Parse(Console.ReadLine());
            var studioPrice = 0.0;
            var doublePrice = 0.0;
            var suitePrice = 0.0;
            switch (month)
            {
                case "May":
                case "October":
                    studioPrice = 50;
                    doublePrice = 65;
                    suitePrice = 75;

                    if (nights > 7)
                    {
                        studioPrice *= 95.0 / 100.0;
                    }
                    break;
                case "June":
                case "September":
                    studioPrice = 60;
                    doublePrice = 72;
                    suitePrice = 82;

                    if (nights > 14)
                    {
                        doublePrice *= 90.0 / 100.0;
                    }
                    break;
                case "July":
                case "August":
                case "December":
                    studioPrice = 68;
                    doublePrice = 77;
                    suitePrice = 89;
                    if (nights > 14)
                    {
                        suitePrice *= 85.0 / 100.0;
                    }
                    break;
            }

            var totalStudioPrice = studioPrice * nights;
            var totalDoublePrice = doublePrice * nights;
            var totalSuitePrice = suitePrice * nights;

            if ((month == "September" || month == "October") && nights > 7)
            {
                totalStudioPrice -= studioPrice;
            }

            Console.WriteLine($"Studio: {totalStudioPrice:F2} lv.");
            Console.WriteLine($"Double: {totalDoublePrice:F2} lv.");
            Console.WriteLine($"Suite: {totalSuitePrice:F2} lv.");
        }
    }
}
