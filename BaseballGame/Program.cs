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
									string inputFirstName = Console.ReadLine();
									Console.WriteLine("Please, enter the last name:\n");
									string inputLastName = Console.ReadLine();
									bool playerCreated = league.CreatePlayer(inputLastName, inputFirstName);
                                    if (playerCreated)
                                    {
										Console.WriteLine("The player " + inputFirstName + " " + inputLastName + " was successfully created.");
                                    }
                                    else
                                    {
										Console.WriteLine("There was an error creating the new player.");
                                    }
									break;
								case "2":
									Console.WriteLine("Let's list all players");
									league.DisplayListOfAllPlayers();
									break;
								case "3":
									Console.WriteLine("Let's change a position to a player.");
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
						break;
					case "3":
						Console.WriteLine("We now deal with Teams.");
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

