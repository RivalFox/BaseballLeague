using System;
using System.Collections.Generic;
using System.Text;

namespace BaseballLeague
{
	public class Team
	{
		private string _name;
		public string Name { set { _name = value; } get { return _name; } }
		private List<Coach> _coaches;
		private List<Player> _players;
		public string TeamRoster
        {
            get
            {
				string roster = "";
				roster += "<<< " + Name + ">>>";
				roster += "*** Coaches ***\n";
				roster += ListOfAllCoaches;
				roster += "... Players ...\n";
				roster += ListOfAllPlayers;

				return roster;
            }
        }

		public string ListOfAllCoaches
		{
			get
			{
				string list = "";
				foreach (Coach coach in _coaches)
				{
					list += coach + "\n";
				}
				return list;
			}
		}

		public string ListOfAllPlayers
		{
			get
			{
				string list = "";
				foreach (Player player in _players)
				{
					list += player + "\n";
				}
				return list;
			}
		}

		public Team() : this("No Team Name") { }

		// Designated Constructor
		public Team(string name)
		{
			Name = name;
			_coaches = new List<Coach>();
			_players = new List<Player>();	
		}

		public bool Add(Coach coach)
		{
			bool success = false;
			_coaches.Add(coach);
			success = true;

			return success;
		}

		public bool Add(Player player)
		{
			bool success = false;
			_players.Add(player);
			success = true;

			return success;
		}

		override
		public string ToString()
		{
			return "Team name: " + Name;
		}
	}
}
