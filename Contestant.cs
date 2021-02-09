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


        string FirstName 
        { get { return firstName; }
          set { firstName = UserInterface.GetUserInputFor("first name");  }
        }
        string LastName
        {
            get { return lastName; }
            set { firstName = UserInterface.GetUserInputFor("last name"); }
        }
        string EmailAddress
        {
            get { return emailAddress; }
            set { firstName = UserInterface.GetUserInputFor("email address"); }
        }
        int RegistrationNumber
        {
            get { return registrationNumber; }
            set { registrationNumber = value; }
        }
    }
}
