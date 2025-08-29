using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAMERO_PropertiesAndEncapsulation
{
    internal class Shoe
    {
        //Encapsulation
        private string brand;
        private int size;

        //Set the properties for the Book class fields
        public string Brand
        {
            get { return brand; }
            set { brand = value; }
        }   
        public int Size
        {
            get { return size; }
            set { size = value; }
        }
        //Method to display book information
        public void DisplayInfo()
        {
            Console.WriteLine($"Brand: {brand} \nSize: {size}");
        }
    }

}
