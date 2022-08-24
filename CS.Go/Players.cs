using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS.Go
{
    public class Players
    {
        
       public string Name { get; set; }
       public bool IsDead { get; set; }
       
       

        public Players(string name, bool isDead)
        {
            Name = name;
            IsDead = isDead;
           
        }





    }
}
