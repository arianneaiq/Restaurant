using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    class Person
    {
        private string name;
        Meal meal;
       
        

        public void Setname (string name)
        {
            this.name = name;

        }

         public string getName()
         {
                return name;
         }

        public void setMeal()
        {
            meal = new Meal();
        }

        public Meal GetMeal()
        {
            return meal;
        }
    }
}
