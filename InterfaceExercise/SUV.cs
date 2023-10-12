using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public class SUV : IVehicle, ICompany
    {
        public int TotalSeating {  get; set; }
        public bool AWD {  get; set; }
        public int Year { get; set; }
        public string Model { get; set; }
        public int Wheels { get; set; }
        public int EngineCylinders { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }

        public void Features()
        {
            Console.WriteLine($"Made in {Country}, this {Year} {Name} {Model} comes equipped with a V{EngineCylinders} engine.");

            if (AWD) 
            {
                Console.WriteLine($"Complete with all wheel drive (AWD), this rugged {Model} is perfect for all terrain and weather.\nSeats a maximum of {TotalSeating} passengers.");
            }
            else
            {
                Console.WriteLine($"This {Model} seats a maximum of {TotalSeating} passengers.");
            }
            Console.WriteLine();
        }
        
    }
}
