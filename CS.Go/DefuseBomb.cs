using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CS.Go.Successful;

namespace CS.Go
{
    class DefuseBomb : ICommand
    {
        private Game _game;

        public char Character { get; } = 'd';

        public DefuseBomb(Game game)
        {
            _game = game;

            
           
        }
        public void Run()
        {
            _game.DefuseBomb();
        }
    }
}
