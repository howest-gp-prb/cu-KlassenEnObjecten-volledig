using System;
using System.Collections.Generic;
using System.Text;

namespace Prb.ClassesAndObjects.CORE
{
    public partial class Car
    {
        public string brand;
        public string color;
        public decimal price;
        public static int carCount;

        public Car()  // dit is het equivalent van de default constructor
        {
            brand = null;
            color = null;
            price = 0;
            carCount++;
        }

        public Car(string brand) : this() // Constructor ontvangt 1 parameter
        {
            this.brand = brand;
        }

        public Car(string brand, string color) : this() // Constructor ontvangt 2 parameters
        {
            this.brand = brand;
            this.color = color;
        }

        public Car(string brand, string color, decimal price) : this() // Constructor ontvangt 3 parameters
        {
            this.brand = brand;
            this.color = color;
            this.price = price;
        }


    }
}
