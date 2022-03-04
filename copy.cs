using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{

    class Vehicle
    {
        private string name;
        private string color;
        private int quantity;

        //copy constructor
        public Vehicle(Vehicle a)
        {
            name = a.name;
            color = a.color;
            quantity = a.quantity;
        }

        public Vehicle(string name, string color, int quantity)
        {
            this.name = name;
            this.color = color;
            this.quantity = quantity;
        }
        public string DetailsofVehicle
        {
            get
            {
                return "Type:" + name.ToString() + "\nColor: " + color.ToString() + " \nQuantity: " + quantity.ToString();

            }
        }
        public static void Main()
        {
            Vehicle v1 = new Vehicle("bike", "black", 40);
            Vehicle v2 = new Vehicle(v1);
            Console.WriteLine(v2.DetailsofVehicle);
            Console.ReadLine();
        }
    }
}
    
    







