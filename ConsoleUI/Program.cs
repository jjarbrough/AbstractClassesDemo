using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Todo follow all comments!! 
             */

            #region Vehicles

            /*
             * Create an abstract class called Vehicle
             * The vehicle class shall have three string properties Year, Make, and Model
             * Set the defaults to something generic in the Vehicle class
             * Vehicle shall have an abstract method called DriveAbstract with no implementation
             * Vehicle shall have a virtual method called DriveVirtual with a base implementation.
             */

            /* 
             * Now create 2 non-abstract classes: Car and Motorcycle, that inherit from Vehicle
             * Add a distict property in the 2 derived classes such as HasTrunk for Car and HasSideCart for Motorcycle
             * Provide the implementations for the abstract methods
             * Only in the Motorcycle class will you override the virtual drive method
            */

            // Create a list of Vehicle called vehicles
            List<Vehicle> vehicle = new List<Vehicle>();
            /*
             * Create 4 instances: 1 Car, 1 Motorcycle, and then 2 instances of type Vehicle (use explicit typing) but use constuctors from derived classes
             * 
             * Set the properties with object initializer syntax
             */
            Car toyota = new Car { hasFourWheels = true, hasTrunk = true, make = "toyota", model = "Camry", year = "2004" };
            Motorcycle indian = new Motorcycle { hasSideCart = false, hasTwoWheels = true, make = "Indian", model = "Chieftan", year = "2020" };
            Vehicle truck = new Car { hasFourWheels = true, hasTrunk = false, make = "Dodge", model = "Ram", year = "2016" };
            Vehicle trike = new Motorcycle { hasSideCart = true, hasTwoWheels = false, make = "Harley Davidson", model = "Freewheeler", year ="2022" };

            vehicle.Add(toyota);
            vehicle.Add(truck);
            vehicle.Add(trike);
            vehicle.Add(indian);

            /*
             * Add the 4 vehicles to the list
             * Using a foreach loop iterate over each of the properties
             */
            foreach(Vehicle v in vehicle) 
            {
                Console.WriteLine($"The vehicle is a {v.year}, {v.make} {v.model}");
            }
            // Call each of the drive methods for one car and one motorcycle
            toyota.DriveVirtual();
            toyota.DriveAbstract();
            indian.DriveVirtual();
            indian.DriveAbstract();
            #endregion            
            Console.ReadLine();
        }
    }
}
