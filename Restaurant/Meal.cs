using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    class Meal
    {
        private string name;
        private double price;

        public Meal(string name, double price)
        {
            this.name = name;
            this.price = price;
        }

        public Meal()
        {

        }

        public string getMealInfo()
        {
            return $"{name}: Euro {price}";
        }

        public string getName()
        {
            return name;
        }

        public double getPrice()
        {
            return price;
        }
    }
}
