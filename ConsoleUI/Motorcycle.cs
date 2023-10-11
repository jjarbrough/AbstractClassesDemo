using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    internal class Motorcycle : Vehicle
    {
        public bool hasTwoWheels { get; set; }
        public bool hasSideCart { get; set; }
        public override void DriveAbstract()
        {
            Console.WriteLine("Motorcycling Abstract");
        }

        public override void DriveVirtual()
        {
            Console.WriteLine("Motorcycling Virtual");
        }
    }
}
