using System;
using _03_Challenge_Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _03_Challenge_Tests
{
    [TestClass]
    public class Outing_Tests
    {
        [TestMethod]
        public void AddToList()
        {
            Outing activity = new Outing();

            activity.Category = "Golf";
            string expected = "Golf";

            Assert.AreEqual(expected, activity.Category);

            Outing activityTwo = new Outing(20, )
        }
    }
}
