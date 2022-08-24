using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CS.Go.Successful;

namespace CS.Go
{
    public class Terror : Players
    {
     

        public Terror(string name,bool IsDead):base(name,false)
        {
            
        }
        public List<Terror> Terrorist { get; set; }

        public void ShowPlayerandAction()
        {
            Console.WriteLine($"{Name},did fire: ");

        }
    }
}
