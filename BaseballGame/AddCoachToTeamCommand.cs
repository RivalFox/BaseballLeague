using System;
using System.Collections.Generic;
using System.Text;

namespace BaseballLeague
{
    public class AddCoachToTeamCommand : Command
    {
        public AddCoachToTeamCommand() : base("AddCoachToTeam") { }

        override
        public bool Execute(League league)
        {
            bool success = false;
            if(Param0 != null && Param1 != null && Param2 != null)
            {
                success = league.AddCoachToTeam(Param0, Param1, Param2);
            }
            else
            {
                Console.WriteLine("There is input missing to add a Coach to a Team");
            }
            return success;
        }

    }
}
