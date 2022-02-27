using System;
using System.Collections.Generic;
using System.Text;

namespace BaseballLeague
{
    public class CreateTeamCommand : Command
    {
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
    }
}
