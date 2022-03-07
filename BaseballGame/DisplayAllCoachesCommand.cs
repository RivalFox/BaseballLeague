using System;
using System.Collections.Generic;
using System.Text;

namespace BaseballLeague
{
    public class DisplayAllCoachesCommand : Command
    {
        override
        public bool Undoable
        { get { return false; } }
        public DisplayAllCoachesCommand() : base("DisplayAllCoaches") { }

        override
        public bool Execute(League league)
        {
            bool success = true;
            league.DisplayListOfAllCoaches();

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
