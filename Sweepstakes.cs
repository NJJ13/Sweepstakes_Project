using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class Sweepstakes
    {
        private Dictionary<int, Contestant> contestants;
        private string name;
        string Name 
        { 
            get => name; 
            set { name = value;}
        }

        public Sweepstakes(string name)
        {
            name = Name;
        }
        public void RegisterContestant(Contestant contestant)
        {
            contestants.Add(contestant.RegistrationNumber, contestant);
        }
        public Contestant PickWinner()
        {
            ISweepstakesManager manager;
            Sweepstakes winningSweepstakes = manager.GetSweepstakes();
            
            return contestants[winner.RegistrationNumber];
        }
        public void PrintContestantInformation(Contestant contestant)
        {
            Console.WriteLine(contestant.FirstName);
            Console.WriteLine(contestant.LastName);
            Console.WriteLine(contestant.EmailAddress);
            Console.WriteLine(contestant.RegistrationNumber);
        }
    }
}
