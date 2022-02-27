using System;
using System.Collections.Generic;
using System.Text;

namespace BaseballLeague
{
    public class CreateCoachCommand : Command
    {
        public CreateCoachCommand() : base("CreatePlayer") { }

        override
        public bool Execute(League league)
        {
            bool success = false;
            if(Param0 != null && Param1 != null)
            {
                success = league.CreateCoach(Param0, Param1);
            }
            else
            {
                Console.WriteLine("There was an error executing the Create Coach Command");
            }
            return success;
        }
    }
}
