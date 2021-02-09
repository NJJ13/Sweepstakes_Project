using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class Contestant
    {
        private string firstName;
        private string lastName;
        private string emailAddress;
        private int registrationNumber;

        public string FirstName
        { 
            get => firstName;
        }
        public string LastName
        {
            get => lastName;
        }
        public string EmailAddress
        {
            get => emailAddress;
        }
        public int RegistrationNumber
        {
            get => registrationNumber;
        }

        public Contestant()
        {
            firstName = UserInterface.GetUserInputFor("first name");
            lastName = UserInterface.GetUserInputFor("last name");
            emailAddress = UserInterface.GetUserInputFor("email address");
            registrationNumber = 
        }
        
    }
}
