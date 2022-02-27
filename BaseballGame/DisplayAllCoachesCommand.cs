using System;
using System.Collections.Generic;
using System.Text;

namespace BaseballLeague
{
    public class DisplayAllCoachesCommand : Command
    {
        public DisplayAllCoachesCommand() : base("DisplayAllCoaches") { }

        override
        public bool Execute(League league)
        {
            bool success = true;
            league.DisplayListOfAllCoaches();

            return success;
        }
    }
}
