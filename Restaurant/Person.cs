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
       
        public Person(string name)
        {
            this.name = name;
        }
        
        public Person()
        {

        }

        public void Setname (string name)
        {
            this.name = name;

        }

         public string getName()
         {
                return name;
         }

        public void setMeal(Meal mealOrder)
        {
            meal = mealOrder;
        }

        public Meal GetMeal()
        {
            return meal;
        }

        public string GetMealNameInfo()
        {
            return $"{meal.getName()   }";
        }

        public string getMealPriceInfo()
        {
            return $"Euro {meal.getPrice()}";
        }

        public double getMealPrice()
        {
            return meal.getPrice();
        } 

    }
}
