using _02_Challenge_Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Challenge_Console
{
    public class ProgramUI
    {
        ClaimRepository _claimRepo = new ClaimRepository();


        public void Run()
        {
            _claimRepo.SeedList();
            RunMenu();
        }

        public void RunMenu()
        {
            bool continueToRun = true;
            while (continueToRun)
            {
                Console.WriteLine("Enter the number of the method you would like to run\n" +
                    "1. See All Claims\n" +
                    "2. Take Care of Next Claim\n" +
                    "3. Enter New Claim");

                string userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1":
                        SeeQueue();
                        break;
                    case "2":
                        TakeCareOfNextClaim();
                        break;
                    case "3":
                        AddClaim();
                        break;
                }
            }
        }

        public void AddClaim()
        {
            Console.WriteLine("What is the Claim ID?");
            string userClaimId = Console.ReadLine();
            int claimId = int.Parse(userClaimId);

            Console.WriteLine("What is the Type?");
            string type = Console.ReadLine();

            Console.WriteLine("Describe the incident");
            string description = Console.ReadLine();

            Console.WriteLine("What us the total amount of the claim?");
            string userAmount = Console.ReadLine();
            double amount = double.Parse(userAmount);

            Console.WriteLine("When was the date of the accident?");
            string userDateAccident = Console.ReadLine();
            DateTime dateAccident = DateTime.Parse(userDateAccident);

            Console.WriteLine("When was the date of the claim?");
            string userDateClaim = Console.ReadLine();
            DateTime dateClaim = DateTime.Parse(userDateClaim);

            Claim incident = new Claim(claimId, type, description, amount, dateAccident, dateClaim);

            _claimRepo.AddClaim(incident);
            Console.ReadKey();
        }

        public void SeeQueue()
        {
            Queue<Claim> claimQueue = _claimRepo.SeeQueue(); 
            Console.WriteLine("Claim ID \t Claim type \t Description \t\t Claim amount \t\t Date of incident \t\t Date of claim \t\t Valid claim?\n");
            foreach (Claim incident in claimQueue)
            {
                Console.WriteLine($"{incident.ClaimId} \t\t {incident.Type} \t\t {incident.Description} \t\t {incident.Amount} \t {incident.DateAccident} \t {incident.DateClaim} \t\t {incident.IsValid}\n");
            }
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            Console.Clear();
        }

        public void TakeCareOfNextClaim()
        {
            Queue<Claim> incidentQueue = _claimRepo.SeeQueue();
            Claim incident = incidentQueue.Peek();

            Console.WriteLine($"Claim ID: {incident.ClaimId}, Claim Type: {incident.Type}, Claim Amount: {incident.Amount}, Date of Incident: {incident.DateAccident}, Date of Claim: {incident.DateClaim}, Valid Claim: {incident.IsValid}");

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();

            Console.WriteLine("Would you like to deal with this claim now? (y/n)?");
            string userInput = Console.ReadLine();

            switch (userInput)
            {
                case "y":
                    RemoveFromQueue();
                    break;
                case "n":
                    break;
            }
            Console.Clear();
        }

        public void RemoveFromQueue()
        {
            Queue<Claim> incidentQueue = _claimRepo.SeeQueue();
            Claim incident = incidentQueue.Dequeue();
            Console.WriteLine("You have successfully removed this claim from the queue. Press any key to continue...");
            Console.ReadKey();
        }
    }
}
