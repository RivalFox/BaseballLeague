using System;
using System.Collections.Generic;
using System.Text;

namespace BaseballLeague
{
    public class DisplayAllTeamsCommand : Command
    {
        public DisplayAllTeamsCommand() : base("DisplayAllTeams") { }

        override
        public bool Execute(League league)
        {
            bool success = true;
            league.DisplayListOfAllTeams();

            return success;
        }
    }
}
