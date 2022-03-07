using System;
using System.Collections.Generic;
using System.Text;

namespace BaseballLeague
{
    public class CreatePlayerCommand : Command
    {
        override
        public bool Undoable
        { get { return true; } }
        public CreatePlayerCommand() : base("CreatePlayer") { }

        override
        public bool Execute(League league)
        {
            bool success = false;
            if(Param0 != null && Param1 != null)
            {
                success = league.CreatePlayer(Param0, Param1);
            }
            else
            {
                Console.WriteLine("There was an error executing the Create Player command");
            }
            return success;
        }

        override
        public bool Undo(League league)
        {
            bool success = false;
            if(Param0 != null && Param1 != null)
            {
                success = league.DeletePlayer(Param0, Param1);
            }
            else
            {
                Console.WriteLine("There was an error executing the undo of the Create Player command.");
            }

            return success;
        }
    }
}
