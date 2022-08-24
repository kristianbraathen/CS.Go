using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CS.Go.Successful;


namespace CS.Go
{
     class FindBombSite : ICommand
    {
        private Game _game;
        public char Character { get; } = 'f';

        public FindBombSite(Game game)
        {
            _game = game;

          
        }
        public void Run()
        {
            _game.FindBombSite();
        }
    }
}
