using _03_Challenge_Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Challenge_Console
{
    public class ProgramUI
    {
        Outing_Repository _outingRepo = new Outing_Repository();

        public void RunProgram()
        {
            Run();
        }

        public void Run()
        {
            bool continueToRun = true;
            while (continueToRun)
            {
                Console.WriteLine("Enter the number off the method you would like to run\n" +
                    "1. See All Outings\n" +
                    "2. Add New Outing\n" +
                    "3. See Calculations");

                string userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1":
                        GetList();
                        break;
                    case "2":
                        AddToList();
                        break;
                    case "3":
                        
                        break;
                }
            }
        }

        public void AddToList()
        {
            Console.WriteLine("What type of event is it?");
            string eventType = Console.ReadLine();

            Console.WriteLine("How many people are coming?");
            string userAttendees = Console.ReadLine();
            int attendees = int.Parse(userAttendees);

            Console.WriteLine("When is the date of this event?");
            string userDate = Console.ReadLine();
            DateTime date = DateTime.Parse(userDate);

            Console.WriteLine("What is the total cost of this event?");
            string userTotalCost = Console.ReadLine();
            double totalCost = double.Parse(userTotalCost);

            Console.WriteLine("What is the cost per person?");
            string userCostPer = Console.ReadLine();
            double costPer = double.Parse(userCostPer);

            Console.WriteLine("What kind of Activity\n" +
                "1. Golf\n" +
                "2. Bowling\n" +
                "3. Amusement Park\n" +
                "4. Concert");
            string activityAsString = Console.ReadLine();
            int activityAsInt = int.Parse(activityAsString);

            ActivityType activity = (ActivityType)activityAsInt;

            Outing newItem = new Outing();

            Outing item = new Outing(attendees, date, totalCost, costPer, activity, category);
            Console.ReadKey();
        }

        public void GetList()
        {
            List<Outing> outingList = _outingRepo.GetList();

            foreach (Outing name in outingList)
            {
                Console.WriteLine($"Number of Attendees: {name.Attendees}\n" +
                    $"Date of Event: {name.Date}\n" +
                    $"Total Cost of Event: {name.TotalCost}\n" +
                    $"Cost Per Person: {name.CostPer}\n" +
                    $"Type of Activity: {name.Activity}");
            }
        }

        public void CombinedCost()
        {
            List<Outing> outingList = _outingRepo.GetList();
            double cost = outingList.Sum(outing => outing.TotalCost);
            Console.WriteLine($"The combined total cost is {cost}\n");
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            Console.Clear();
        }

        public void CostByType()
        {
            Console.WriteLine("Enter the number of the outing type you would like to see the cost of\n" +
                "1. Golf\n" +
                "2. Bowling\n" +
                "3. Amusement Park\n" +
                "4. Concert");
            string userInput = Console.ReadLine();
            Console.Clear();
            switch (userInput)
            {
                case "1":
                    CombinedCostByType((ActivityType)int.Parse(userInput));
                    break;
                case "2":
                    CombinedCostByType((ActivityType)int.Parse(userInput));
                    break;
                case "3":
                    CombinedCostByType((ActivityType)int.Parse(userInput));
                    break;
                case "4":
                    CombinedCostByType((ActivityType)int.Parse(userInput));
                    break;

            }
        }

        public void CombinedCostByType(ActivityType eventType)
        {
            List<Outing> _outingList = _outingRepo.GetList();
            double sum = _outingList.Sum(outings =>
            {
                if (outings.Activity == eventType)
                {
                    return outings.TotalCost;
                }
                else { return 0; }
            });
            Console.WriteLine(sum);
        }
    }
}
