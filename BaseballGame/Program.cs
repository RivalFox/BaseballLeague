using System;

namespace BaseballLeague
{
	class Program
	{
		static void Main(string[] args)
		{

			Team team = new Team("OOD Team");
			Player player = new Player();
			Coach coach = new Coach();

			// Player Object
			//Player player = new Player();
			Console.WriteLine("The name of the player is " + player.FullName);
			player.FirstName = "Tim";
			player.LastName = "Potter";
			team.Add(player);
			Console.WriteLine("The name of the player is " + player.FullName);
			player = new Player("Wolfgang");
			team.Add(player);
			Console.WriteLine("The name of the player is " + player.FullName);
			player = new Player("Vivaldi", "Antonio");
			team.Add(player);
			Console.WriteLine("The name of the player is " + player.FullName);

			// Coach Object
			//Coach coach = new Coach();
			Console.WriteLine("The name of the coach is " + coach.FullName);
			coach.FirstName = "Joe";
			coach.LastName = "Shmo";
			team.Add(coach);
			Console.WriteLine("The name of the coach is " + coach.FullName);
			coach = new Coach("Duck");
			team.Add(coach);
			Console.WriteLine("The name of the coach is " + coach.FullName);
			coach = new Coach("Time", "Will");
			team.Add(coach);
			Console.WriteLine("The name of the coach is " + coach.FullName);

			// Add ToString method to player
			Console.WriteLine("The last player is " + player.ToString());


		}
	}
}
