﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BaseballLeague
{
	class Program
	{
		static void Main(string[] args)
        {
			League league = new League("OOD League");
			bool finished = false;
			Parser parser = new Parser();
			Stack<Command> commandStack = new Stack<Command>();
			List<string> log = new List<String>();
			Console.WriteLine("Welcome to our League Management System.\n");
            while (!finished)
            {
				Console.WriteLine("\nPlease, enter a command:\n");
				string commandString = Console.ReadLine();
                //Console.WriteLine("You enter the command -> " + commandString);
                switch (commandString)
                {
					case "exit":
						finished = true;
						break;
					case "log":
						foreach(string loggedCommand in log)
                        {
							Console.WriteLine(loggedCommand);
                        }
						break;
					case "undo":
						Command poppedCommand = null;
						commandStack.TryPop(out poppedCommand);
						if(poppedCommand != null)
                        {
							poppedCommand.Undo(league);
							Console.WriteLine("\nUndoing the command " + poppedCommand + "\n");
                        }
                        else
                        {
							Console.WriteLine("\nThere is no command to undo.\n");
                        }
						log.Add(commandString);
						break;
					default:
						Command command = parser.parse(commandString);
						if(command != null)
                        {
							command.Execute(league);
                            if (command.Undoable)
                            {
								commandStack.Push(command);
                            }
							log.Add(command.ToString());
                        }
                        else
                        {
							Console.WriteLine("\nI do not recognize that command.\n");
                        }
						break;
                }
            }
			Console.WriteLine("Thank you for using League Management System (LMS)");
        }

		
	}
}
	
		//static void Main(string[] args)
		//{
		//	League league = new League("OOD League");
		//	bool finished = false;
		//	Console.WriteLine("Welcome to our League Management System.\n");
		//	while (!finished)
		//	{
		//		Console.WriteLine("Enter your choice:");
		//		Console.WriteLine("1. Players");
		//		Console.WriteLine("2. Coaches");
		//		Console.WriteLine("3. Teams");
		//		Console.WriteLine("9. Exit");
		//		string inputLine = Console.ReadLine();
		//		switch (inputLine)
		//		{
		//			case "1":
		//				Console.WriteLine("We now deal with Players.");
		//				bool inputPlayers = false;
		//				while (!inputPlayers)
		//				{
		//					string inputFirstName = "";
		//					string inputLastName = "";
		//					Command command;
		//					Console.WriteLine("\nEnter your choice:");
		//					Console.WriteLine("1. Create Player");
		//					Console.WriteLine("2. List All players");
		//					Console.WriteLine("3. Change Position to Players");
		//					Console.WriteLine("9. Exit");
		//					string inputLinePlayers = Console.ReadLine();
		//					switch (inputLinePlayers)
		//					{
		//						case "1":
		//							Console.WriteLine("\nLet's create a player\n");
		//							Console.WriteLine("Please, enter the first name:\n");
		//							inputFirstName = Console.ReadLine();
		//							Console.WriteLine("Please, enter the last name:\n");
		//							inputLastName = Console.ReadLine();
		//							command = new CreatePlayerCommand();
		//							command.Param0 = inputLastName;
		//							command.Param1 = inputFirstName;
		//							//bool playerCreated = league.CreatePlayer(inputLastName, inputFirstName);
		//							bool playerCreated = command.Execute(league);
		//							if (playerCreated)
		//							{
		//								Console.WriteLine("The player's " + inputFirstName + " " + inputLastName + " was successfully created.");
		//							}
		//							else
		//							{
		//								Console.WriteLine("There was an error creating the new player.");
		//							}
		//							break;
		//						case "2":
		//							Console.WriteLine("Let's list all players");
		//							command = new DisplayAllPlayersCommand();
		//							command.Execute(league);
		//							//league.DisplayListOfAllPlayers();
		//							break;
		//						case "3":
		//							Console.WriteLine("\nLet's change a position to a player.\n");
		//							Console.WriteLine("Enter player first name:\n");
		//							string playerFirstName = Console.ReadLine();
		//							Console.WriteLine("Enter player last name:\n");
		//							string playerLastName = Console.ReadLine();
		//							Console.WriteLine("Please, enter position (DESIGNATED_HITTER, PITCHER, CATCHER, RIGHT_FIELDER, LEFT_FIELDER, SHORT_STOP, FIRST_BASE, SECOND_BASE, THIRD_BASE):\n");
		//							string newPosition = Console.ReadLine();
		//							command = new ChangePlayerPositionCommand();
		//							command.Param0 = inputFirstName;
		//							command.Param1 = inputLastName;
		//							command.Param2 = newPosition;
		//							//bool changePosition = league.ChangePositionToPlayer(playerFirstName, playerLastName, newPosition);
		//							bool changePosition = command.Execute(league);
		//							if (changePosition)
		//							{
		//								Console.WriteLine("Position successfully changed.");
		//							}
		//							else
		//							{
		//								Console.WriteLine("There was an error adding the position.");
		//							}
		//							break;
		//						case "9":
		//							inputPlayers = true;
		//							break;
		//						default:
		//							Console.WriteLine("\nI do not understand that choice.\n");
		//							break;
		//					}
		//				}
		//				Console.WriteLine("\nReturning to the Main Menu\n");
		//				break;
		//			case "2":
		//				Console.WriteLine("We now deal with Coaches.");
		//				bool inputCoaches = false;
		//				while (!inputCoaches)
		//				{
		//					string inputFirstName = "";
		//					string inputLastName = "";
		//					Command command;
		//					Console.WriteLine("\nEnter your choice:");
		//					Console.WriteLine("1. Create Coach");
		//					Console.WriteLine("2. List All coaches");
		//					Console.WriteLine("3. Change Title to Coaches");
		//					Console.WriteLine("9. Exit");
		//					string inputLineCoaches = Console.ReadLine();
		//					switch (inputLineCoaches)
		//					{
		//						case "1":
		//							Console.WriteLine("\nLet's create a coach\n");
		//							Console.WriteLine("Please, enter the first name:\n");
		//							inputFirstName = Console.ReadLine();
		//							Console.WriteLine("Please, enter the last name:\n");
		//							inputLastName = Console.ReadLine();
		//							command = new CreateCoachCommand();
		//							command.Param0 = inputFirstName;
		//							command.Param1 = inputLastName;
		//							//bool coachCreated = league.CreateCoach(inputLastName, inputFirstName);
		//							bool coachCreated = command.Execute(league);
		//							if (coachCreated)
		//							{
		//								Console.WriteLine("The coach's " + inputFirstName + " " + inputLastName + " was successfully created.");
		//							}
		//							else
		//							{
		//								Console.WriteLine("There was an error creating the new coach.");
		//							}
		//							break;
		//						case "2":
		//							Console.WriteLine("Let's list all coaches");
		//							command = new DisplayAllCoachesCommand();
		//							command.Execute(league);
		//							break;
		//						case "3":
		//							Console.WriteLine("\nLet's change a title to a coach.\n");
		//							Console.WriteLine("Enter coach's first name:\n");
		//							string coachFirstName = Console.ReadLine();
		//							Console.WriteLine("Enter coach's last name:\n");
		//							string coachLastName = Console.ReadLine();
		//							Console.WriteLine("Please, enter position (MAIN, ASSISTANT):\n");
		//							string inputTitle = Console.ReadLine();
		//							command = new ChangeCoachTitleCommand();
		//							command.Param0 = coachFirstName;
		//							command.Param1 = coachLastName;
		//							command.Param2 = inputTitle;
		//							// bool changeTitle = league.ChangeTitleToCoaches(coachFirstName, coachLastName, inputTitle);
		//							bool changeTitle = command.Execute(league);
		//							if (changeTitle)
		//							{
		//								Console.WriteLine("The coach's " + coachFirstName + " " + coachLastName + " is at position " + inputTitle);
		//							}
		//							else
		//							{
		//								Console.WriteLine("There was an error adding the title.");
		//							}
		//							break;
		//						case "9":
		//							inputCoaches = true;
		//							break;
		//						default:
		//							Console.WriteLine("\nI do not understand that choice.\n");
		//							break;
		//					}
		//				}
		//				Console.WriteLine("\nReturning to the Main Menu\n");
		//				break;
		//			case "3":
		//				Console.WriteLine("We now deal with Teams.");
		//				bool inputTeams = false;
		//				while (!inputTeams)
		//				{
		//					string inputTeamName = "";
		//					string inputFirstName = "";
		//					string inputLastName = "";
		//					Command command;
		//					Console.WriteLine("\nEnter your choice:");
		//					Console.WriteLine("1. Create Team");
		//					Console.WriteLine("2. List All teams");
		//					Console.WriteLine("3. Add coach to a team");
		//					Console.WriteLine("4. Add player to a team");
		//					Console.WriteLine("5. Display a team's roster");
		//					Console.WriteLine("9. Exit");
		//					string inputLineTeams = Console.ReadLine();
		//					switch (inputLineTeams)
		//					{
		//						case "1":
		//							Console.WriteLine("\nLet's create a Team\n");
		//							Console.WriteLine("Please, enter the team name:\n");
		//							inputTeamName = Console.ReadLine();
		//							command = new CreateTeamCommand();
		//							command.Param0 = inputTeamName;
		//							//bool teamCreated = league.CreateTeam(inputTeamName);
		//							bool teamCreated = command.Execute(league);
		//							if (teamCreated)
		//							{
		//								Console.WriteLine("Team successfully created.");
		//							}
		//							else
		//							{
		//								Console.WriteLine("There was an error creating the new team.");
		//							}
		//							break;
		//						case "2":
		//							Console.WriteLine("Let's list all teams");
		//							command = new DisplayAllTeamsCommand();
		//							command.Execute(league);
		//							break;
		//						case "3":
		//							Console.WriteLine("Let's add a coach to a team.\n");
		//							Console.WriteLine("Please, enter the first name:\n");
		//							inputFirstName = Console.ReadLine();
		//							Console.WriteLine("Please, enter the last name:\n");
		//							inputLastName = Console.ReadLine();
		//							Console.WriteLine("Enter the team's name\n");
		//							inputTeamName = Console.ReadLine();
		//							command = new AddCoachToTeamCommand();
		//							command.Param0 = inputFirstName;
		//							command.Param1 = inputLastName;
		//							command.Param2 = inputTeamName;
		//							bool addedCoachToTeam = command.Execute(league);
		//							if(addedCoachToTeam)
		//							{
		//								Console.WriteLine("Coach successfully added to the team.");
		//							}
		//							else
		//							{
		//								Console.WriteLine("There was an error adding the coach.");
		//							}
		//							break;
		//						case "4":
		//							Console.WriteLine("Let's add a player to a team.\n");
		//							Console.WriteLine("Please, enter the first name:\n");
		//							inputFirstName = Console.ReadLine();
		//							Console.WriteLine("Please, enter the last name:\n");
		//							inputLastName = Console.ReadLine();
		//							Console.WriteLine("Enter the team's name\n");
		//							inputTeamName = Console.ReadLine();
		//							command = new AddPlayerToTeamCommand();
		//							command.Param0 = inputFirstName;
		//							command.Param1 = inputLastName;
		//							command.Param2 = inputTeamName;
		//							bool addedPlayerToTeam = command.Execute(league);
		//							if(addedPlayerToTeam)
  //                                  {
		//								Console.WriteLine("Player successfully added to the team.");
  //                                  }
  //                                  else
  //                                  {
		//								Console.WriteLine("There was an error adding the player.");
		//							}
		//							break;
		//						case "5":
		//							Console.WriteLine("Let's display a team's roster.\n");
		//							Console.WriteLine("Enter the team's name\n");
		//							inputTeamName = Console.ReadLine();
		//							league.DisplayTeamRoster(inputTeamName);
		//							break;
		//						case "9":
		//							inputTeams = true;
		//							break;
		//						default:
		//							Console.WriteLine("\nI do not understand that choice.\n");
		//							break;
		//					}
		//				}
		//				Console.WriteLine("\nReturning to the Main Menu\n");
		//				break;
		//			case "9":
		//				finished = true;
		//				break;
		//			default:
		//				Console.WriteLine("\nI do not understand that choice.\n");
		//				break;
		//		}
		//	}
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

