using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class MarketingFirm
    {
        private ISweepstakesManager _manager;
        public MarketingFirm(ISweepstakesManager _manager)
        {
            this._manager = _manager;
        }

        //MarketingFirm Class has dependency injection.  This allows it to use the ISweepstakesManger interface to instantiate a manager object.
        //This will allow it to function with the SweepstakesStackManager and SweepstakesQueueManager classes.
        //By having this dependency injection, I will beable to implement the factory design pattern.
        public void CreateSweepstakes()
        {
            string sweepstakesName = UserInterface.GetUserInputFor("Sweepstakes' name");
            Sweepstakes createdSweepstakes = new Sweepstakes(sweepstakesName);
            createdSweepstakes = _manager.GetSweepstakes();
            _manager.InsertSweepstakes(createdSweepstakes);
        }
    }
}
