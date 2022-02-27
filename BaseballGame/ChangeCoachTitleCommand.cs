using System;
using System.Collections.Generic;
using System.Text;

namespace BaseballLeague
{
    public class ChangeCoachTitleCommand : Command
    {
        public ChangeCoachTitleCommand() : base("ChangeCoachTitle") { }

        override
        public bool Execute(League league)
        {
            bool success = false;
            if(Param0 != null && Param1 != null && Param2 != null)
            {
                success = league.ChangeTitleToCoaches(Param0, Param1, Param2);
            }
            else
            {
                Console.WriteLine("There is input missing to change Coach Title");
            }

            return success;
        }
    }
}
