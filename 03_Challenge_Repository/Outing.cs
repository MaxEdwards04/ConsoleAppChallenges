using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Challenge_Repository
{
    public enum ActivityType { Golf = 1, Bowling, AmusementPark, Concert }
    public class Outing
    {
        public int Attendees { get; set; }
        public DateTime Date { get; set; }
        public double TotalCost { get; set; }
        public double CostPer { get; set; }
        public ActivityType Activity { get; set; }
        public string Category { get; set; }

        public Outing()
        {

        }

        public Outing(int attendees, DateTime date, double totalCost, double costPer, ActivityType activity, string category)
        {
            Attendees = attendees;
            Date = date;
            TotalCost = totalCost;
            CostPer = costPer;
            Activity = activity;
            Category = category;
        }
    }
}
