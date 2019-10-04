using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Challenge_Repository
{
    public class Claim
    {
        public int ClaimId { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
        public double Amount { get; set; }
        public DateTime DateAccident { get; set; }
        public DateTime DateClaim { get; set; }
        public bool IsValid { get; set; }

        public Claim()
        {

        }

        public Claim(int claimId, string type, string description, double amount, DateTime dateAccident, DateTime dateClaim)
        {
            ClaimId = claimId;
            Type = type;
            Description = description;
            Amount = amount;
            DateAccident = dateAccident;
            DateClaim = dateClaim;
            IsValid = (dateClaim - dateAccident).Days <=30;
        }
        
        
    }
}
