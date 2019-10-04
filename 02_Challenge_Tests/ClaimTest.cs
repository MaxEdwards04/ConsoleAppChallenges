using System;
using System.Collections.Generic;
using _02_Challenge_Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _02_Challenge_Tests
{
    [TestClass]
    public class Claim_Tests
    {
        [TestMethod]
        public void CreateClaimContentObject()
        {
            Claim incident = new Claim();

            incident.Type = "Car";
            string expected = "Car";

            Assert.AreEqual(expected, incident.Type);

            Claim incidentTwo = new Claim(1, "Car", "Crash on 465", 1000, new DateTime(2019, 9, 8), new DateTime(2019, 9, 9));
        }

        public void AddToQueue_AddClaimIncident_QueueShouldBeinCorrectInt()
        {
            ClaimRepository claimRepo = new ClaimRepository();
            Queue<Claim> incidents = claimRepo.SeeQueue();

            Claim incident = new Claim(1, "Car", "Crash on highway", 1000, new DateTime(2019, 9, 10), new DateTime(2019, 9, 11));
            Claim incidentTwo = new Claim(2, "Home", "Waterbed busted", 500, new DateTime(2019, 9, 12), new DateTime(2019, 9, 13));
            Claim incidentThree = new Claim(3, "Theft", "Stolen Pokemon Go Account", 2000, new DateTime(2019, 9, 14), new DateTime(2019, 9, 15));

            int expected = 3;

            int actual = incidents.Count;

            Assert.AreEqual(expected, actual);
        }


    }
}
