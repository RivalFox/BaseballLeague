using System;
using System.Collections.Generic;
using System.Text;

namespace BaseballLeague
{
    public class ChangePlayerPositionCommand : Command
    {
        public ChangePlayerPositionCommand() : base("ChangePlayerPosition") { }

        override
        public bool Execute(League league)
        {
            bool success = false;
            if(Param0 != null && Param1 != null && Param2 != null)
            {
                success = league.ChangePositionToPlayer(Param0, Param1, Param2);
            }
            else
            {
                Console.WriteLine("There is input missing to change the position of a player");
            }

            return success;
        }
    }
}
