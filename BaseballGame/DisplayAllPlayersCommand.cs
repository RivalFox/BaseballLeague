using System;
using System.Collections.Generic;
using System.Text;

namespace BaseballLeague
{
    class DisplayAllPlayersCommand : Command
    {
        override
        public bool Undoable
        { get { return false; } }
        public DisplayAllPlayersCommand() : base("DisplayAllPlayers") { }

        override
        public bool Execute(League league)
        {
            bool success = true;
            league.DisplayListOfAllPlayers();

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
