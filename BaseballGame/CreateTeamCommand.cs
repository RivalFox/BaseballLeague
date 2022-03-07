using System;
using System.Collections.Generic;
using System.Text;

namespace BaseballLeague
{
    public class CreateTeamCommand : Command
    {
        override
        public bool Undoable
        { get { return true; } }
        public CreateTeamCommand() : base("CreateTeam") { }

        override
        public bool Execute(League league)
        {
            bool success = false;
            if(Param0 != null)
            {
                success = league.CreateTeam(Param0);
            }
            else
            {
                Console.WriteLine("There was an error executing Create Team Command");
            }
            return success;
        }

        override
        public bool Undo(League league)
        {
            bool success = false;
            if(Param0 != null)
            {
                success = league.DeleteTeam(Param0);
            }
            else
            {
                Console.WriteLine("There was an error executing the undo of the Create Team command.");
            }
            return success;
        }
    }
}
