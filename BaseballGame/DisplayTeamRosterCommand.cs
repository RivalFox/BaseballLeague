using System;
using System.Collections.Generic;
using System.Text;

namespace BaseballLeague
{
    public class DisplayTeamRosterCommand : Command
    {
        override
        public bool Undoable
        { get { return false; } }
        public DisplayTeamRosterCommand() : base("DisplayTeamRoster") { }

        override
        public bool Execute(League league)
        {
            bool success = false;
            if (Param0 != null)
            {
                success = true;
                league.DisplayTeamRoster(Param0);
            }
            else
            {
                Console.WriteLine("There was an error executing the Display Team Roster command.");
            }
            return success;
        }

        override
        public bool Undo(League league)
        {
            bool success = false;

            return success;
        }
    }
}
