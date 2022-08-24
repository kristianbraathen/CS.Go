using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS.Go
{
    class PlantBomb : ICommand
    {
        private Game _game;
        public char Character { get; } = 'p';
        public PlantBomb(Game game)
        {
            
                _game = game;
        }
        public void Run()
        {
            _game.PlantBomb();
        }
    }
}
