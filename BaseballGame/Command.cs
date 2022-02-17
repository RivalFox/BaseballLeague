using System;
using System.Collections.Generic;
using System.Text;

namespace BaseballLeague
{
    public abstract class Command
    {
        public string Name { set; get; }
        public string Param0 { set; get; }
        public string Param1 { set; get; }
        public string Param2 { set; get; }
        public abstract bool Execute(League league);

        public Command() : this("Nameless")
        {
        }

        // Designated Contructor
        public Command(string name)
        {
            Name = name;
            Param0 = null;
            Param1 = null;
            Param2 = null;
        }
    }
}
