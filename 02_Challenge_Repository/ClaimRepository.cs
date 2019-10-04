using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Challenge_Repository
{
    public class ClaimRepository
    {
        Queue<Claim> _claimQueue = new Queue<Claim>();

        public Queue<Claim> SeeQueue()
        { 
            return _claimQueue;
        }

        public void TakeCareOfNextClaim()
        {
            _claimQueue.Peek();
        }

        public void AddClaim(Claim content)
        {
            _claimQueue.Enqueue(content);
        }

        public void SeedList()
        {
            Claim incident = new Claim(1, "Car", "Crash on highway", 1000, new DateTime(2019, 9, 10), new DateTime(2019, 9, 11));
            Claim incidentTwo = new Claim(2, "Home", "Waterbed busted", 500, new DateTime(2019, 9, 12), new DateTime(2019, 9, 13));
            Claim incidentThree = new Claim(3, "Theft", "Stolen Pokemon Go Account", 2000, new DateTime(2019, 9, 14), new DateTime(2019, 9, 15));

            AddClaim(incident);
            AddClaim(incidentTwo);
            AddClaim(incidentThree);
        }
    }
}
