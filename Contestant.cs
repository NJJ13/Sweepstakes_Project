﻿using System;
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

        string FirstName { get; set; }
        string LastName { get; set; }
        string EmailAddress { get; set; }
        int RegistrationNumber { get; set; }

        public Contestant(string FirstName, string LastName, string EmailAddress, int RegistrationNumber)
        {
            FirstName = UserInterface.GetUserInputFor("first name");
            LastName = UserInterface.GetUserInputFor("last name");
            EmailAddress = UserInterface.GetUserInputFor("email address");
            RegistrationNumber =
        }
        
    }
}
