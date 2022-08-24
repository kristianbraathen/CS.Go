using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CS.Go.Successful;

namespace CS.Go
{
    class CounterTerror : Players
    {
       

       
        public CounterTerror(string name,bool IsDead):base(name,false)
        {
             
        }
       


        public void ShowPlayerandAction()
        {
            Console.WriteLine($"{Name},did fire: ");

        }


    }
}
