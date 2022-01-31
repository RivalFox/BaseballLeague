using System;

namespace BaseballLeague
{
	class Program
	{
		static void Main(string[] args)
		{

			// Player Object
			Player player = new Player();
			Console.WriteLine("The name of the player is " + player.FullName);
			player.FirstName = "Tim";
			player.LastName = "Potter";
			Console.WriteLine("The name of the player is " + player.FullName);
			player = new Player("Wolfgang");
			Console.WriteLine("The name of the player is " + player.FullName);
			player = new Player("Vivaldi", "Antonio");
			Console.WriteLine("The name of the player is " + player.FullName);

			// Coach Object
			Coach coach = new Coach();
			Console.WriteLine("The name of the coach is " + coach.FullName);
			coach.FirstName = "Joe";
			coach.LastName = "Shmo";
			Console.WriteLine("The name of the coach is " + coach.FullName);
			coach = new Coach("Duck");
			Console.WriteLine("The name of the coach is " + coach.FullName);
			coach = new Coach("Time", "Will");
			Console.WriteLine("The name of the coach is " + coach.FullName);


		}
	}
}
