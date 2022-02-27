using System;
using System.Collections.Generic;
using System.Text;

namespace BaseballLeague
{
	public class Team
	{
		private string _name;
		public string Name { set { _name = value; } get { return _name; } }
		private Dictionary<string, Coach> _coaches;
		private Dictionary<string, Player> _players;
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
				foreach (Coach coach in _coaches.Values)
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
				foreach (Player player in _players.Values)
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
			_coaches = new Dictionary<string, Coach>();
			_players = new Dictionary<string, Player>();	
		}

		public bool Add(Coach coach)
		{
			bool success = false;
			_coaches.Add(coach.FullName, coach);
			coach.Team = this;
			success = true;

			return success;
		}

		public bool Remove(Coach coach)
        {
			bool success = _coaches.Remove(coach.FullName);
            if (success)
            {
				coach.Team = null;
            }
			return success;
        }

		public bool Add(Player player)
		{
			bool success = false;
			_players.Add(player.FullName, player);
			player.Team = this;
			success = true;

			return success;
		}

		public bool Remove(Player player)
        {
			bool success = false;
            if (success)
            {
				player.Team = null;
            }
			return success;
        }

		override
		public string ToString()
		{
			return "Team name: " + Name;
		}

		public Coach FindCoach(string firstName, string lastName)
        {
			Coach foundCoach = null;
			_coaches.TryGetValue(firstName + " " + lastName, out foundCoach);
			return foundCoach;
        }

		public Player FindPlayer(string firstName, string lastName)
		{
			Player foundPlayer = null;
			_players.TryGetValue(firstName + " " + lastName, out foundPlayer);
			return foundPlayer;
		}
	}
}
