using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Camero_MyClassAndObject
{
    internal class Vehicle
    {
        public string brand;
        public string color;
        public string speed;

        public void DisplayInfo()
        {
            Console.WriteLine("\nBRAND: " + brand + "\n" + "COLOR: " + color + "\n" + "SPEED: " + speed);
        }
    }
}
