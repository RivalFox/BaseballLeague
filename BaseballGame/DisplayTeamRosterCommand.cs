using System;
using System.Collections.Generic;
using System.Text;

namespace BaseballLeague
{
    public class DisplayTeamRosterCommand : Command
    {
        public DisplayTeamRosterCommand() : base("DisplayTeamRoster") { }

        override
        public bool Execute(League league)
        {
            bool success = true;
            if(Param0 != null)
            {
                league.DisplayTeamRoster(Param0);
                success = true;
            }

            return success;
        }
    }
}
