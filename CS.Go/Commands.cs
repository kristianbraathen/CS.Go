using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS.Go
{
     class Commands
    {
        private ICommand[] _commands;

        public Commands(Game game)
        {
            _commands = new ICommand[]
            {
               
                new KillTerrorist(game),
               
                new ExitGame(game),
                new DefuseBomb(game),
                new PlayAgain(game)
            };
        }
        
        public void Run(char commandChar)
        {
            var command = FindCommand(commandChar);
            if (command != null) command.Run();
        }
        private ICommand FindCommand(char commandChar)
        {
            foreach (var command in _commands)
            {
                if (command.Character == commandChar) return command;
            }
            return null;
        }
    }
}
