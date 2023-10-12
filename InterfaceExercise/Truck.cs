using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public class Truck : IVehicle, ICompany
    {
        public int TowingCapacity { get; set; }
        public bool CargoBedCover { get; set; }
        public int Year { get; set; }
        public string Model { get; set; }
        public int Wheels { get; set; }
        public int EngineCylinders { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }

        public void Features()
        {
            Console.WriteLine($"Made in {Country}, this {Year} {Name} {Model} comes equipped with a V{EngineCylinders} engine.");
            if (CargoBedCover)
            {
                Console.WriteLine($"Features a cover for it's cargo bed and up to {TowingCapacity} lbs towing capacity.");
            }
            else
            {
                Console.WriteLine($"Features up to {TowingCapacity} lbs towing capacity.");
            }
            Console.WriteLine();
        }
        
    }
}
