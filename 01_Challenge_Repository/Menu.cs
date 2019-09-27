using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Challenge_Repository
{
    class Menu
    {
        public Menu(string mealName, string description, double price, int mealNumber)
        {
            MealName = mealName;
            Description = description;
            Price = price;
            MealNumber = mealNumber;

        }

        public Menu()
        {

        }

        public string MealName { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public int MealNumber { get; set; }
    }
}
