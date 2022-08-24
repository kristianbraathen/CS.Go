using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS.Go
{
     class Commands2
    {
        private ICommand[] _commands;

        public Commands2(Game game)
        {
            _commands = new ICommand[]
            {
                new KillCounterT(game),
               
                new FindBombSite(game),
                new ExitGame(game),
               
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

