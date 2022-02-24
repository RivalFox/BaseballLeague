using System;
using System.Collections.Generic;
using System.Text;

namespace BaseballLeague
{
    public class DisplayAllPlayersCommand : Command
    {
        public DisplayAllPlayersCommand() : base("DisplayAllPlayers") { }

        override
        public bool Execute(League league)
        {
            bool success = true;
            league.DisplayListOfAllPlayers();

            return success;
        }
    }
}
