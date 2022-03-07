using System;
using System.Collections.Generic;
using System.Text;

namespace BaseballLeague
{
    public class AddPlayerToTeamCommand : Command
    {
        override
        public bool Undoable
        { get { return true; } }
        public AddPlayerToTeamCommand() : base("AddPlayerToTeam") { }

        override
        public bool Execute(League league)
        {
            bool success = false;
            if (Param0 != null && Param1 != null && Param2 != null)
            {
                success = league.AddPlayerToTeam(Param0, Param1, Param2);
            }
            else
            {
                Console.WriteLine("There is input missing to add a Player to a Team");
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
