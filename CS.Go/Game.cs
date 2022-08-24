using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using static CS.Go.Successful;


namespace CS.Go
{
    class Game
    {
        public bool isDead = false;
        public bool IsRunning = true;


       public List<Terror> Terrorist { get; set; }
     
       public List<CounterTerror> CounterTerrorist{ get; set; }

        CSTimer timer = new CSTimer();

        public Game()
        {
            Terrorist = new List<Terror>();
            var Terror1 = new Terror("ABB", false);
            var Terror2 = new Terror("Ted Kaklinsky", false);
            var Terror3 = new Terror("Saddam", false);
            var Terror4 = new Terror("Stalin", false);
            var Terror5 = new Terror("Doffen", false);
            Terrorist.Add(Terror1);
            Terrorist.Add(Terror2);
            Terrorist.Add(Terror3);
            Terrorist.Add(Terror4);
            Terrorist.Add(Terror5);


            CounterTerrorist = new List<CounterTerror>();
            var ct1 = new CounterTerror("G.I Joe", false);
            var ct2 = new CounterTerror("Private Joker", false);
            var ct3 = new CounterTerror("Johann Galtung", false);
            var ct4 = new CounterTerror("John Sinclair", false);
            var ct5 = new CounterTerror("ActionMan",false);
            CounterTerrorist.Add(ct1);
            CounterTerrorist.Add(ct2);
            CounterTerrorist.Add(ct3);
            CounterTerrorist.Add(ct4);
            CounterTerrorist.Add(ct5);

           
        }
        public void GameOn()
        {
            

            IsRunning = true;
           

            if (Terrorist.Count < 1)
            {
                IsRunning = false;
                Console.WriteLine("\r\n CounterTerrorist Win");
                Console.WriteLine("\r\n Wanna Play again? y/X");
                string text = System.IO.File.ReadAllText(@"C:\Users\Krist\Downloads\ascii-art.txt");
                Console.Write(text);
            }
            if (CounterTerrorist.Count < 1)
            {
                IsRunning = false;
                Console.WriteLine("\r\n Terrorist Win");
                Console.WriteLine("\r\n Wanna Play again? y/X");
                string text = System.IO.File.ReadAllText(@"C:\Users\Krist\Downloads\ascii-art.txt");
                Console.Write(text);
            }



        }
        public void KillTerrorist()
        {
             
            var random = new Random();
            int randomIndex = random.Next(0,Terrorist.Count);
           
           
                var success = IsSuccessful(7);
                if (success == true)
                {
                 Terrorist.Remove(Terrorist[randomIndex]);
                 Console.WriteLine("\r\n One Terrorist down");

                }
                else { Console.WriteLine("\r\n Shots Missed"); }
            GameOn();
            }
        public void KillCounterT()
        {
            var random = new Random();
            int randomIndex = random.Next(0, CounterTerrorist.Count);
            var success = IsSuccessful(5);

            if (success == true)

            {
                CounterTerrorist.Remove(CounterTerrorist[randomIndex]);
                Console.WriteLine("\r\n One CounterTerrorist down");

            }
            else { Console.WriteLine(" \r\n Shots Missed"); }
            GameOn();

        }
        public void DefuseBomb()
        
        {
            var success = IsSuccessful(10);
         
            if (success == true)
            {
                
                Console.WriteLine("\r\n Bomb is defused");
             
                timer.StopTimer();
             

            }
            else
            Console.WriteLine("\r\n Could not defused Bomb");
            GameOn();
        }
        public void FindBombSite()
        {
            var success = IsSuccessful(10);
            if (success == true)
            {
                Console.WriteLine("\r\n Bombsite found");
                PlantBomb();
            }
            else
                Console.WriteLine("\r\n Bombsite not found");
            GameOn();
        }
        public void PlantBomb()
        {
            var success = IsSuccessful(10);

            if(success == true)
            {
                Console.WriteLine("\r\n Bomb is planted.......\r\n countdown started!");
              
                timer.StartTimer(3000,10);
                //DefuseBomb();
            }
            else
            {
                Console.WriteLine("\r\n ..but Bomb could not be planted");
            }
        }
        public void PlayAgain()
        {
            var info = new System.Diagnostics.ProcessStartInfo(Environment.GetCommandLineArgs()[0]);
            System.Diagnostics.Process.Start(info);
            //_ = System.Diagnostics.Process.Start(AppDomain.CurrentDomain.FriendlyName);
            //var fileName = Assembly.GetExecutingAssembly().Location;
            //System.Diagnostics.Process.Start(fileName);
        }
        public void ExitGame()
        {
            Environment.Exit(0);
        }
    }
}
