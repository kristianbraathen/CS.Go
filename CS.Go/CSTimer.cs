using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;

namespace CS.Go
{
    class CSTimer
    {
     

        public CSTimer()
        {
           
        }
        
        public Action<object, ElapsedEventArgs> Elapsed { get; private set; }
        public bool Enabled { get; set; }
        public int timeUnit = 10;
        public System.Timers.Timer timer { get; private set; }
        public void StartTimer(int Interval,int TimeUnit)
        {
            int interval = 3000;
            timeUnit = 10;
            int i = timeUnit * interval;

            timer = new System.Timers.Timer();
            Enabled = true;
            timer.Interval = interval;
            timer.Elapsed += Timer_Elapsed;
            timer.Start();
            if(timeUnit == 0)
            {
                timer.Stop();
               
            }
          
       
        }
         void Timer_Elapsed(object sender,ElapsedEventArgs e)

        {
            
           timeUnit--;

            Console.Clear();
            Console.WriteLine("=================================================");
            Console.WriteLine("                  DEFUSE THE BOMB");
            Console.WriteLine("");
            Console.WriteLine("                Time Remaining:  " + timeUnit.ToString());
            Console.WriteLine("");
            Console.WriteLine("=================================================");

            if (timeUnit == 0)
            {
                Console.Clear();
                Console.WriteLine("");
                Console.WriteLine("==============================================");
                Console.WriteLine("         B O O O O O M M M M M ! ! ! !");
                Console.WriteLine("");
                Console.WriteLine("               G A M E  O V E R");
                Console.WriteLine("==============================================");
                StopTimer();
                string text = System.IO.File.ReadAllText(@"C:\Users\Krist\Downloads\ascii-art.txt");
                Console.Write(text);

            }

            }
        public void StopTimer()
        {

            
            timer.Stop();
            Enabled = false;
        }
    }
}
