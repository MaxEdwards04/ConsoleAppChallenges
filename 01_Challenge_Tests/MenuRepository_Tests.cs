using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _01_Challenge_Tests
{
    [TestClass]
    public class MenuRepository_Tests
    {
        [TestMethod]
        public void CreateMenuContentObject()
        {
            Menu content = new Menu();

            content.MealName = "Burrito";
            string expected = "Burrito";

            Assert.AreEqual(expected, content.MealName);

            Menu contentTwo = new Menu("Burrito", "Beef and bean burrito", 3.50);
        }

        public void AddToList_AddMenuContent()
        {
            MenuRepository
        }
    }

    internal class Menu
    {
    }
}
