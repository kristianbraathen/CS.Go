using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CS.Go.Successful;

namespace CS.Go
{
     class KillCounterT : ICommand
    {
        private Game _game;

      
        public char Character { get; } = 'c';

        public KillCounterT(Game game)
        {
            _game = game;

           
        }
        public void Run()
        {
            _game.KillCounterT();
        }

        
    }

}
