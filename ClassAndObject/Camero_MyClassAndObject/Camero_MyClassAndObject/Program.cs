using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Camero_MyClassAndObject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Instantiation an object
            Vehicle vehicle1 = new Vehicle();
            Vehicle vehicle2 = new Vehicle();

            //Initialize the value of fields
            vehicle1.brand = "Honda";
            vehicle1.color = "Black";
            vehicle1.speed = "High";

            vehicle2.brand = "Ford";
            vehicle2.color = "Gray";
            vehicle2.speed = "High";

            //call the method to display information
            Console.WriteLine("The fastest vehicle in history");
            vehicle1.DisplayInfo();
            vehicle2.DisplayInfo();

            Console.ReadKey();
        }
    }
}
