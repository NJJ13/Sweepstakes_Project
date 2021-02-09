using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    public static class UserInterface
    {
        public static string GetUserInputFor(string prompt)
        {
            Console.WriteLine("Please enter the " + prompt + ":");
            return Console.ReadLine();
        }
        public static bool QueueOrStackSelector()
        {
            string selector;
            do
            {
                Console.WriteLine("Would you like to manage the Sweepstakes as a Queue or a Stack? 1 or 2");
                Console.WriteLine("1: Queue");
                Console.WriteLine("2: Stack");
                selector = Console.ReadLine();
            } while (selector != "1" && selector != "2");

            if(selector == "1")
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }
    }
}
