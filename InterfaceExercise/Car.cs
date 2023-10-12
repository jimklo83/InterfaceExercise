using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public class Car : IVehicle, ICompany
    {
        public bool IsConvertible { get; set; }
        public bool SedanOrCoupe { get; set; }
        public int Year { get; set; }
        public string Model { get; set; }
        public int Wheels { get; set; }
        public int EngineCylinders { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }

        public void Features()
        {
            Console.WriteLine($"Made in {Country}, this {Year} {Name} {Model} comes equipped with a V{EngineCylinders} engine.");
            if (IsConvertible && !SedanOrCoupe)
            {
                Console.WriteLine($"The perfect sports car, this {Model} is a convertible coupe.");
            }
            else if (!IsConvertible && !SedanOrCoupe) 
            {
                Console.WriteLine($"This {Model} sports coupe features a hard top.");
            }
            else if (IsConvertible && SedanOrCoupe)
            {
                Console.WriteLine("This sporty four-door sedan features a convertible roof!");
            }
            else 
            {
                Console.WriteLine($"The perfect sedan for families and luxury.");
            }
            Console.WriteLine();

        }
    }
}
