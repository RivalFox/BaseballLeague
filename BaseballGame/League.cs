using System;
using System.Collections.Generic;
using System.Text;

namespace BaseballLeague
{
	class League
	{
		private string _name;
		private List<Player> _players;
		private Dictionary<string, Coach> _coaches;
		private List<Team> _teams;
		public string Name { get; set; }
		public League() : this("NO NAME") { }
		// Designated Constructor
		public League(string name)
		{
			Name = name;
			_players = new List<Player>();
			_coaches = new Dictionary<string, Coach>();
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

		public string ListOfAllPlayers
		{
			get
			{
				string list = "";
				foreach(Player player in _players)
				{
					list += player + "\n";
				}
				return list;
			}
		}

		public void DisplayListOfAllPlayers()
		{
			Console.WriteLine("The List of all Players is \n");
			Console.WriteLine(ListOfAllPlayers);
		}

		public bool ChangePositionToPlayer(string firstName, string lastName, string position)
		{
			bool success = false;
			Player foundPlayer = FindPlayer(firstName,lastName);
			if (foundPlayer != null)
			{
				string UpperCasePosition = position.ToUpper();
				// Enum.TryParse()
				POSITION desiredPosition;
				if(Enum.TryParse(UpperCasePosition, out desiredPosition))
				{
					foundPlayer.Position = desiredPosition;
					success = true;
				}
			}

			return success;
		}

		public bool CreateCoach(string lastName, string firstName)
		{
			bool success = false;
			if(FindCoach(firstName,lastName) == null)
            {
				Coach coach = new Coach(lastName, firstName);
				_coaches[coach.FullName] = coach;
				success = true;
            }

			return success;
		}

		public string ListOfAllCoaches
		{
			get
			{
				string list = "";
				foreach(Coach coach in _coaches.Values)
				{
					list += coach + "\n";
				}
				return list;
			}
		}

		public void DisplayListOfAllCoaches()
		{
			Console.WriteLine("The List of all Coaches is \n");
			Console.WriteLine(ListOfAllCoaches);
		}

		public bool ChangeTitleToCoaches(string firstName, string lastName, string newtitle)
		{
			bool success = false;
			Coach foundCoach = FindCoach(firstName,lastName);
			if(foundCoach != null)
			{
				string UpperCasePosition = newtitle.ToUpper();
				TITLE desiredTitle;
				if(Enum.TryParse(UpperCasePosition, out desiredTitle))
				{
					foundCoach.Title = desiredTitle;
					success = true;
				}
			}

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

		public string ListOfAllTeams
		{
			get
			{
				string list = "";
				foreach(Team team in _teams)
				{
					list += team + "\n";
				}
				return list;
			}
		}

		public void DisplayListOfAllTeams()
		{
			Console.WriteLine("The List of all Teams in \n");
			Console.WriteLine(ListOfAllTeams);
		}

		public bool AddCoachToTeam(string firstName, string lastName, string teamName)
		{
			bool success = false;
			Coach foundCoach = FindCoach(firstName, lastName);
			if (foundCoach != null)
			{
				Team foundTeam = FindTeam(teamName);
				if(foundTeam != null)
				{
					foundTeam.Add(foundCoach);
					success = true;
				}
			}

			return success;
		}

		public bool AddPlayerToTeam(string firstName, string lastName, string teamName)
		{
			bool success = false;
			Player foundPlayer = FindPlayer(firstName, lastName);
			if (foundPlayer != null)
			{
				Team foundTeam = FindTeam(teamName);
				if (foundTeam != null)
				{
					foundTeam.Add(foundPlayer);
					success = true;
				}
			}

			return success;
		}

		public void DisplayTeamRoster(string teamName)
        {
			Team foundTeam = FindTeam(teamName);
			if(foundTeam != null)
            {
				Console.WriteLine("The roster of team " + teamName + " is:");
				Console.WriteLine(foundTeam.TeamRoster);
            }
            else
            {
				Console.WriteLine("The team " + teamName + " was not found.");
            }
		}

		public Coach FindCoach(string firstName, string lastName)
		{
			Coach foundCoach = null;
			_coaches.TryGetValue(firstName + " " + lastName, out foundCoach);
			/*
			foreach (Coach coach in _coaches)
			{
				if (coach.FirstName.Equals(firstName) && coach.LastName.Equals(lastName))
				{
					foundCoach = coach;
				}
			}
			*/
			return foundCoach;
		}

		public Player FindPlayer(string firstName, string lastName)
        {
			Player foundPlayer = null;
			foreach(Player player in _players)
            {
				if(player.FirstName.Equals(firstName) && player.LastName.Equals(lastName))
                {
					foundPlayer = player;
                }
            }
			return foundPlayer;
        }

		public Team FindTeam(string teamName)
        {
			Team foundTeam = null;
			foreach(Team team in _teams)
            {
                if (team.Name.Equals(teamName))
                {
					foundTeam = team;
                }
            }
			return foundTeam;
        }

	}
}
