using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAMERO_PropertiesAndEncapsulation
{
    internal class Program
    {
        //Mary Joyce E. Camero
        //IT306
        //EXER_04: Basics on Encapsulation
        static void Main(string[] args)
        {
            //Instantiate the book class
            Shoe myShoe = new Shoe();

            //Set the properties
            myShoe.Brand = "FUMA";
            myShoe.Size = 40;

            //Display the Book Information
            myShoe.DisplayInfo();

            Console.ReadKey();

                
        }
    }
}
