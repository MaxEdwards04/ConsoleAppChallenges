using _01_Challenge_Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_ConsoleAppChalleneges
{
    class ProgramUI
    {
        MenuRepository _menuRepo = new MenuRepository();

        public void Run()
        {
            RunMenu();
        }

        private void RunMenu()
        {
            Console.WriteLine("Enter the number of the item you would like to see\n" +
                "1. Add Item\n" +
                "2. Remove Item\n" +
                "3. See Menu");

            string userInput = Console.ReadLine();

            switch (userInput)
            {
                case "1":
                    AddNewItem();
                    break;
                case "2":
                    RemoveItem();
                    break;
                case "3":
                    SeeAllItems();
                    break;
            }
        }

        public void AddNewItem()
        {
            Console.WriteLine("Name of Item: ");
            string.mealName = Console.ReadLine();

            Console.WriteLine("Description of Item: ");
            string.description = Console.ReadLine();

            Console.WriteLine("Price of Item:");
            double.price = Console.ReadLine();

            Console.WriteLine("What is the number of the Item");
            int.mealNumber = Console.ReadLine();
        }

        public void RemoveItem()
        {
            SeeAllItems();

            Console.WriteLine("What item would you like to remove? Please enter a name");

            string mealName = Console.ReadLine();

            _menuRepo.RemoveFromList(mealName);

            SeeAllItems();
        }

        public void SeeAllItems()
        {
            List<Menu> menuList = _menuRepo.GetMenuList();

            foreach(MenuRepository name in menuList)
            {
                Console.WriteLine($"{name.MealName}\n" +
                    $"Description: {name.Description}\n" +
                    $"Price: {name.Price}\n" +
                    $"Meal Number: {name.MealNumber");
            }
        }
    }
}
