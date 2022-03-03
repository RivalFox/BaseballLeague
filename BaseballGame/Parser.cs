using System;
using System.Collections.Generic;
using System.Text;

namespace BaseballLeague
{
    public class Parser
    {
        private Dictionary<string, Command> _commands;
        private static Command[] defaultCommand =
        {
            new CreatePlayerCommand(),
            new DisplayAllPlayersCommand(),
            new ChangePlayerPositionCommand(),
            new CreateCoachCommand(),
            new DisplayAllCoachesCommand(),
            new ChangeCoachTitleCommand(),
            new CreateTeamCommand(),
            new DisplayAllTeamsCommand(),
            new AddCoachToTeamCommand(),
            new AddPlayerToTeamCommand(),
            new DisplayTeamRosterCommand()
        };

        public Parser() : this(defaultCommands) { }


        // Designated Constructor
        public Parser(Command[] inputCommands)
        {
            _commands = new Dictionary<string, Command>();
            foreach(Command command in inputCommands)
            {
                _commands.TryAdd(command.Name, command);
            }
        }

        public Command parse(string inputString)
        {
            Command command = null;
            string[] words = inputString.Split(" ");
            _commands.TryGetValue(words[0], out command);
            if(command != null)
            {
                Command newCommand = command;

                command.Param0 = null;
                command.Param1 = null;
                command.Param2 = null;
                if(words.Length > 1)
                {
                    command.Param0 = words[1];
                    if(words.Length > 2)
                    {
                        command.Param1 = words[2];
                        if(words.Length > 3)
                        {
                            command.Param2 = words[3];
                        }
                    }
                }
            }

            return command;
        }
    }
}
