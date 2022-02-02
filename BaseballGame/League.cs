using System;
using System.Collections.Generic;
using System.Text;

namespace BaseballLeague
{
	class League
	{
		private string _name;
		private List<Player> _players;
		private List<Coach> _coaches;
		private List<Team> _teams;
		public string Name { set { _name = value; } get { return _name; } }
		public League() : this ("NO NAME") { }

		// Designated Constructor
		public League(string name)
		{
			Name = name;
			_players = new List<Player>();
			_coaches = new List<Coach>();
			_teams = new List<Team>();
		}

		public bool CreatePlayer(string lastName, string firstName)
		{
			bool success = false;
			Player player = new Player(lastName, firstName);
			_players.Add(player);
			success = true;

			return success;
		}

		public bool CreateCoach(string lastName, string firstName)
		{
			bool success = false;
			Coach coach = new Coach(lastName, firstName);
			_coaches.Add(coach);
			success = true;

			return success;
		}

		public bool CreateTeam(string name)
		{
			bool success = false;
			Team team = new Team(name);
			_teams.Add(team);
			success = true;

			return success;
		}
	}
}
