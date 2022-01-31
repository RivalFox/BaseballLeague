using System;
using System.Collections.Generic;
using System.Text;

namespace BaseballLeague
{
	public class Player : IPeople
	{
		private string _firstname;
		private string _lastname;


		public string FirstName
		{
			set { _firstname = value; }
			get { return _firstname; }
		}

		public string LastName
		{
			set { _lastname = value; }
			get { return _lastname; }
		}

		public string FullName
		{
			get { return _firstname + " " + _lastname; }
		}

		public Player() : this("NO LAST NAME") { }

		public Player(string lastName) : this(lastName, "NO FIRST NAME") { }
		
		// Designated Constructor
		public Player(string lastName, string firstName)
		{
			_firstname = firstName;
			_lastname = lastName;
		}

	}	
		
}
