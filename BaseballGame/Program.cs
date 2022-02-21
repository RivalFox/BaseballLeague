using System;

namespace BaseballLeague
{
	class Program
	{
		static void Main(string[] args)
		{
			League league = new League("OOD League");
			bool finished = false;
			Console.WriteLine("Welcome to our League Management System.\n");
			while (!finished)
			{
				Console.WriteLine("Enter your choice:");
				Console.WriteLine("1. Players");
				Console.WriteLine("2. Coaches");
				Console.WriteLine("3. Teams");
				Console.WriteLine("9. Exit");
				string inputLine = Console.ReadLine();
				switch (inputLine)
				{
					case "1":
						Console.WriteLine("We now deal with Players.");
						bool inputPlayers = false;
						while (!inputPlayers)
						{
							string inputFirstName = "";
							string inputLastName = "";
							Command command;
							Console.WriteLine("\nEnter your choice:");
							Console.WriteLine("1. Create Player");
							Console.WriteLine("2. List All players");
							Console.WriteLine("3. Change Position to Players");
							Console.WriteLine("9. Exit");
							string inputLinePlayers = Console.ReadLine();
							switch (inputLinePlayers)
							{
								case "1":
									Console.WriteLine("\nLet's create a player\n");
									Console.WriteLine("Please, enter the first name:\n");
									inputFirstName = Console.ReadLine();
									Console.WriteLine("Please, enter the last name:\n");
									inputLastName = Console.ReadLine();
									command = new CreatePlayerCommand();
									command.Param0 = inputLastName;
									command.Param1 = inputFirstName;
									//bool playerCreated = league.CreatePlayer(inputLastName, inputFirstName);
									bool playerCreated = command.Execute(league);
									if (playerCreated)
									{
										Console.WriteLine("The player's " + inputFirstName + " " + inputLastName + " was successfully created.");
									}
									else
									{
										Console.WriteLine("There was an error creating the new player.");
									}
									break;
								case "2":
									Console.WriteLine("Let's list all players");
									command = new DisplayAllPlayersCommand();
									command.Execute(league);
									//league.DisplayListOfAllPlayers();
									break;
								case "3":
									Console.WriteLine("\nLet's change a position to a player.\n");
									Console.WriteLine("\nLet's create a player\n");
									Console.WriteLine("Enter player first name:\n");
									inputFirstName = Console.ReadLine();
									Console.WriteLine("Enter player last name:\n");
									inputLastName = Console.ReadLine();
									Console.WriteLine("Please, enter position (DESIGNATED_HITTER, PITCHER, CATCHER, RIGHT_FIELDER, LEFT_FIELDER, SHORT_STOP, FIRST_BASE, SECOND_BASE, THIRD_BASE):\n");
									string newPosition = Console.ReadLine();
									command = new ChangePlayerPositionCommand();
									command.Param0 = inputFirstName;
									command.Param1 = inputLastName;
									command.Param2 = newPosition;
									//bool changePosition = league.ChangePositionToPlayer(inputFirstName, inputLastName, inputPosition);
									bool positionChanged = command.Execute(league);
									if (positionChanged)
									{
										Console.WriteLine("Position successfully changed.");
									}
									else
									{
										Console.WriteLine("There was an error adding the position.");
									}
									break;
								case "9":
									inputPlayers = true;
									break;
								default:
									Console.WriteLine("\nI do not understand that choice.\n");
									break;
							}
						}
						Console.WriteLine("\nReturning to the Main Menu\n");
						break;
					case "2":
						Console.WriteLine("We now deal with Coaches.");
						bool inputCoaches = false;
						while (!inputCoaches)
						{
							string inputFirstName = "";
							string inputLastName = "";
							Console.WriteLine("\nEnter your choice:");
							Console.WriteLine("1. Create Coach");
							Console.WriteLine("2. List All coaches");
							Console.WriteLine("3. Change Title to Coaches");
							Console.WriteLine("9. Exit");
							string inputLineCoaches = Console.ReadLine();
							switch (inputLineCoaches)
							{
								case "1":
									Console.WriteLine("\nLet's create a coach\n");
									Console.WriteLine("Please, enter the first name:\n");
									inputFirstName = Console.ReadLine();
									Console.WriteLine("Please, enter the last name:\n");
									inputLastName = Console.ReadLine();
									bool coachCreated = league.CreateCoach(inputLastName, inputFirstName);
									if (coachCreated)
									{
										Console.WriteLine("The coach's " + inputFirstName + " " + inputLastName + " was successfully created.");
									}
									else
									{
										Console.WriteLine("There was an error creating the new coach.");
									}
									break;
								case "2":
									Console.WriteLine("Let's list all coaches");
									league.DisplayListOfAllCoaches();
									break;
								case "3":
									Console.WriteLine("\nLet's change a title to a coach.\n");
									Console.WriteLine("Enter coach's first name:\n");
									inputFirstName = Console.ReadLine();
									Console.WriteLine("Enter coach's last name:\n");
									inputLastName = Console.ReadLine();
									Console.WriteLine("Please, enter position (MAIN, ASSISTANT):\n");
									string inputTitle = Console.ReadLine();
									bool changeTitle = league.ChangeTitleToCoaches(inputFirstName, inputLastName, inputTitle);
									if (changeTitle)
									{
										Console.WriteLine("The coach's " + inputFirstName + " " + inputLastName + " is at position " + inputTitle);
									}
									else
									{
										Console.WriteLine("There was an error adding the title.");
									}
									break;
								case "9":
									inputCoaches = true;
									break;
								default:
									Console.WriteLine("\nI do not understand that choice.\n");
									break;
							}
						}
						Console.WriteLine("\nReturning to the Main Menu\n");
						break;
					case "3":
						Console.WriteLine("We now deal with Teams.");
						bool inputTeams = false;
						while (!inputTeams)
						{
							string inputTeamName = "";
							string inputFirstName = "";
							string inputLastName = "";
							Console.WriteLine("\nEnter your choice:");
							Console.WriteLine("1. Create Team");
							Console.WriteLine("2. List All teams");
							Console.WriteLine("3. Add coach to a team");
							Console.WriteLine("4. Add player to a team");
							Console.WriteLine("5. Display a team's roster");
							Console.WriteLine("9. Exit");
							string inputLineTeams = Console.ReadLine();
							switch (inputLineTeams)
							{
								case "1":
									Console.WriteLine("\nLet's create a Team\n");
									Console.WriteLine("Please, enter the team name:\n");
									bool teamCreated = league.CreateTeam(inputTeamName);
									if (teamCreated)
									{
										Console.WriteLine("The team's name " + inputTeamName);
									}
									else
									{
										Console.WriteLine("There was an error creating the new team.");
									}
									break;
								case "2":
									Console.WriteLine("Let's list all teams");
									league.DisplayListOfAllTeams();
									break;
								case "3":
									Console.WriteLine("Let's add a coach to a team.\n");
									Console.WriteLine("Please, enter the first name:\n");
									inputFirstName = Console.ReadLine();
									Console.WriteLine("Please, enter the last name:\n");
									inputLastName = Console.ReadLine();
									Console.WriteLine("Enter the team's name\n");
									inputTeamName = Console.ReadLine();
									if(league.AddCoachToTeam(inputFirstName, inputLastName, inputTeamName))
									{
										Console.WriteLine("Coach successfully added to the team.");
									}
									else
									{
										Console.WriteLine("There was an error adding the coach.");
									}
									break;
								case "4":
									Console.WriteLine("Let's add a player to a team.\n");
									Console.WriteLine("Please, enter the first name:\n");
									inputFirstName = Console.ReadLine();
									Console.WriteLine("Please, enter the last name:\n");
									inputLastName = Console.ReadLine();
									Console.WriteLine("Enter the team's name\n");
									inputTeamName = Console.ReadLine();
									if(league.AddPlayerToTeam(inputFirstName, inputLastName, inputTeamName))
                                    {
										Console.WriteLine("Player successfully added to the team.");
                                    }
                                    else
                                    {
										Console.WriteLine("There was an error adding the player.");
									}
									break;
								case "5":
									Console.WriteLine("Let's display a team's roster.\n");
									Console.WriteLine("Enter the team's name\n");
									inputTeamName = Console.ReadLine();
									league.DisplayTeamRoster(inputTeamName);
									break;
								case "9":
									inputTeams = true;
									break;
								default:
									Console.WriteLine("\nI do not understand that choice.\n");
									break;
							}
						}
						Console.WriteLine("\nReturning to the Main Menu\n");
						break;
					case "9":
						finished = true;
						break;
					default:
						Console.WriteLine("\nI do not understand that choice.\n");
						break;
				}
			}

			Console.WriteLine("Thank you for using League Management System (LMS)");
		}
	}
}
	

// Old Main

	//Team team = new Team("OOD Team");
	//Player player = new Player();
	//Coach coach = new Coach();

	//// Player Object
	////Player player = new Player();
	//Console.WriteLine("The name of the player is " + player.FullName);
	//player.FirstName = "Tim";
	//player.LastName = "Potter";
	//team.Add(player);
	//Console.WriteLine("The name of the player is " + player.FullName);
	//player = new Player("Wolfgang");
	//team.Add(player);
	//Console.WriteLine("The name of the player is " + player.FullName);
	//player = new Player("Vivaldi", "Antonio");
	//team.Add(player);
	//Console.WriteLine("The name of the player is " + player.FullName);

	//// Coach Object
	////Coach coach = new Coach();
	//Console.WriteLine("The name of the coach is " + coach.FullName);
	//coach.FirstName = "Joe";
	//coach.LastName = "Shmo";
	//team.Add(coach);
	//Console.WriteLine("The name of the coach is " + coach.FullName);
	//coach = new Coach("Duck");
	//team.Add(coach);
	//Console.WriteLine("The name of the coach is " + coach.FullName);
	//coach = new Coach("Time", "Will");
	//team.Add(coach);
	//Console.WriteLine("The name of the coach is " + coach.FullName);

	//// Add ToString method to player
	//Console.WriteLine("The last player is " + player.ToString());

