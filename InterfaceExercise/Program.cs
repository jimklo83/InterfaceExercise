using System;
using System.Collections.Generic;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //Create 2 Interfaces called IVehicle & ICompany

            //Create 3 classes called Car , Truck , & SUV

            //In your IVehicle

            /* Create 4 members that Car, Truck, & SUV all have in common.
             * Example: All vehicles have a number of wheels... for now..
             */


            //In ICompany

            /*Create 2 members that are specific to each every company
             * regardless of vehicle type.
             *
             *
             * Example: public string Logo { get; set; }
             */

            //In each of your car, truck, and suv classes

            /*Create 2 members that are specific to each class
             * Example: truck has a bed size while car has a trunk while suv has a cargo hold size
             *
             * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
             * 
             */

            //Now, create objects of your 3 classes and give their members values;
            //Creatively display and organize their values

            var mustang = new Car()
            {
                IsConvertible = true,
                SedanOrCoupe = false,
                Year = 1978,
                Model = "Mustang",
                Wheels = 4,
                EngineCylinders = 8,
                Name = "Ford",
                Country = "America",
            };

            var cClass = new Car()
            {
                IsConvertible = false,
                SedanOrCoupe = true,
                Year = 2016,
                Model = "C-Class",
                Wheels = 4,
                EngineCylinders = 4,
                Name = "Mercedes-Benz",
                Country = "Germany",
            };
            
            var santaCruz = new Truck() 
            {
                TowingCapacity = 8000,
                CargoBedCover = false,
                Year = 2015,
                Model = "Santa Cruz",
                Wheels = 4,
                EngineCylinders = 6,
                Name = "Hyundai",
                Country = "Korea",
            };

            var ram = new Truck()
            {
                TowingCapacity = 19000,
                CargoBedCover = true,
                Year = 2007,
                Model = "Ram 2500",
                Wheels = 4,
                EngineCylinders = 8,
                Name = "Dodge",
                Country = "America",
            };

            var rogue = new SUV() 
            {
                TotalSeating = 7,
                AWD = true,
                Year = 2013,
                Model = "Rogue",
                Wheels = 4,
                EngineCylinders = 4,
                Name = "Nissan",
                Country = "Japan",
            };

            var discovery = new SUV()
            {
                TotalSeating = 7,
                AWD = false,
                Year = 2003,
                Model = "Discovery",
                Wheels = 4,
                EngineCylinders = 6,
                Name = "Land Rover",
                Country = "The United Kingdom",
            };

            mustang.Features();
            santaCruz.Features();
            rogue.Features();
            cClass.Features();
            ram.Features();
            discovery.Features();
        }
    }
}
