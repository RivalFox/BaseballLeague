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

		public Command Clone
        {
            get
            {
				Command clone = (Command)this.MemberwiseClone();
				// We know String.Copy is obsolete, we saw it in class
				clone.Name = Name == null ? null : String.Copy(Name);
				clone.Param0 = Param0 == null ? null : String.Copy(Param0);
				clone.Param1 = Param1 == null ? null : String.Copy(Param1);
				clone.Param2 = Param2 == null ? null : String.Copy(Param2);

				return clone;
			}
        }

		public abstract bool Undoable { get; }
		public abstract bool Execute(League league);
		public abstract bool Undo(League league);
		public Command() : this("Nameless") { }

		// Designated Constructor
		public Command(string name)
        {
			Name = name;
			Param0 = null;
			Param1 = null;
			Param2 = null;
        }

		override
		public string ToString()
        {
			string output = Name;
			if(Param0 != null)
            {
				output += " " + Param0;
				if(Param1 != null)
                {
					output += " " + Param1;
					if(Param2 != null)
                    {
						output += " " + Param2;
                    }
                }
            }

			return output;
        }
	}
}
