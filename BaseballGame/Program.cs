using System;

namespace BaseballLeague
{
	class Program
	{
		static void Main(string[] args)
		{
			League league = new League("OOD League");
			bool finished = false;

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
							Console.WriteLine();
                        }
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

