using System;
using System.Collections.Generic;
using System.Text;

namespace BaseballLeague
{
    public class DisplayAllTeamsCommand : Command
    {
        override
        public bool Undoable
        { get { return false; } }
        public DisplayAllTeamsCommand() : base("DisplayAllTeams") { }

        override
        public bool Execute(League league)
        {
            bool success = true;
            league.DisplayListOfAllTeams();

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
