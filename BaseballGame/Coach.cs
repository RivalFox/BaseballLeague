using System;
using System.Collections.Generic;
using System.Text;

namespace BaseballLeague
{
	public enum TITLE { MAIN, ASSISTANT }

	public class Coach : IPeople
	{
		private string _firstname;
		private string _lastname;
		private TITLE _title;
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
		//
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

		public TITLE Title
		{
			set { _title = value; }
			get { return _title; }
		}

		//
		public Coach() : this("NO LAST NAME") { }
		public Coach(string lastName) : this(lastName, "NO FIRST NAME") { }
		public Coach(string lastName, string firstName) : this(lastName, firstName, TITLE.ASSISTANT) { }

		// Designated Contructor
		public Coach(string lastName, string firstName, TITLE title)
		{
			_firstname = firstName;
			_lastname = lastName;
			Title = title;
			Team = null;
		}

		override
		public string ToString()
		{
			return FirstName + " " + LastName + " " + Title;
		}
	}
}
