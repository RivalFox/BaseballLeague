using System;
using System.Collections.Generic;
using System.Text;

namespace BaseballLeague
{

	public enum POSITION { DESIGNATED_HITTER, PITCHER, CATCHER, RIGHT_FIELDER, LEFT_FIELDER, SHORT_STOP, FIRST_BASE, SECOND_BASE, THIRD_BASE }

	public class Player : IPeople
	{
		private string _firstname;
		private string _lastname;
		private POSITION _position;
		private Team _team;
		public Team Team
        {
            set
            {
				if(_team != null)
                {
					Team tempTeam = _team;
					_team = null;
					tempTeam.Remove(this);
                }
				_team = value;
            }
			get
            {
				return _team;
            }
        }

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

		public POSITION Position
		{
			set { _position = value; }
			get { return _position; }
		}


		public Player() : this("NO LAST NAME") { }
		public Player(string lastName) : this(lastName, "NO FIRST NAME") { }
		public Player(string lastName, string firstName) : this(lastName, firstName, POSITION.FIRST_BASE) { }


		// Designated Constructor
		public Player(string lastName, string firstName, POSITION position)
		{
			FirstName = firstName;
			LastName = lastName;
			Position = position;
		}

		override
		public string ToString()
		{
			return FirstName + " " + LastName + " " + Position;
		}
	}	
		
}
