using System;
using System.Collections.Generic;
namespace PlanetWeight
{
    enum Planet
    {
        MERCURY,
        VENUS,
        EARTH,
        MARS,
        JUPITER,
        SATURN,
        URANUS,
        NEPTUNE
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<Planet, double> gravity = new Dictionary<Planet, double>()
            {
                { Planet.MERCURY, 0.38 },
                { Planet.VENUS, 0.91 },
                { Planet.EARTH, 1.00 },
                { Planet.MARS, 0.38 },
                { Planet.JUPITER, 2.34 },
                { Planet.SATURN, 1.06 },
                { Planet.URANUS, 0.92 },
                { Planet.NEPTUNE, 1.19 }
            };

            Console.Write("Enter your weight on Earth: ");
            double earthWeight = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\nWeight on different planets:");
            foreach (Planet p in Enum.GetValues(typeof(Planet)))
            {
                double planetWeight = earthWeight * gravity[p];
                Console.WriteLine($"{p}: {planetWeight:F2} kg");
            }
            Console.ReadLine();
        }
    }
}





