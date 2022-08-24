using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS.Go
{
    class ExitGame: ICommand
    {
        private Game _game;

        public char Character { get; } = 'X';
        
        public ExitGame(Game game)
        {
            _game = game;


        }
        public void Run()
        {
            _game.ExitGame();
        }
    }
}
    

