using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class Simulation
    {
        public void CreateMarketingFirmWithManager()
        {
            ISweepstakesManager manager;
            bool selector = UserInterface.QueueOrStackSelector();
            if (selector == true)
            {
                SweepstakesQueueManager queueManager = new SweepstakesQueueManager();
                manager = queueManager;
                MarketingFirm marketingFirm = new MarketingFirm(manager);
            }
            if (selector == false)
            {
                SweepstakesStackManager stackmanager = new SweepstakesStackManager();
                manager = stackmanager;
                MarketingFirm marketingFirm = new MarketingFirm(manager);
            }
        }
    }
}
