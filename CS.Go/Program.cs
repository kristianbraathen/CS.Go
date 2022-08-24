using System;
using System.Collections.Generic;
using System.Linq;



namespace CS.Go
{
    class Program
    {


        static void Main(string[] args)
        {
            string text = System.IO.File.ReadAllText(@"C:\Users\Krist\Downloads\ascii-art.txt");
            Console.Write(text);
            Console.WriteLine();
            Random random = new Random();
            var turn = random.Next(0, 2);



            var game = new Game();
            var commands = new Commands(game);
            var commands2 = new Commands2(game);



            while (true)
            {
                 //commands = new Commands(game);
                 //commands2 = new Commands2(game);
                if (turn % 2 == 0)
                {
                  
                    Console.WriteLine("Go Terrorist\r\n\r\n  Kommandoer:\r\n - C = Try to Kill a counterTerroist" +
                " \r\n - F = Find BombSite  \r\n - X = avslutt applikasjonen ");
                    Console.WriteLine(" -Trykk tast for ønsket kommando.\r\n");
                    var command2 = Console.ReadKey().KeyChar;
                    commands2.Run(command2);
                  
                }
                else
                {
                    Console.WriteLine("Go CounterTerrorist\r\n\r\n  Kommandoer:\r\n - T = Try to kill a Terrorist" +
                " \r\n - D = Defuse Bomb  \r\n - X = avslutt applikasjonen");
                    Console.WriteLine(" -Trykk tast for ønsket kommando.\r\n");

                    var command = Console.ReadKey().KeyChar;
                    commands.Run(command);
                }
                turn++;


                //Console.Clear();
                //Console.WriteLine("Kommandoer:\r\n - T = Try to kill a Terrorist\r\n - C = Try to Kill a counterTerroist" +
                //" \r\n - F = Find BombSite  \r\n - D = Defuse Bomb \r\n - X = avslutt applikasjonen");

                //
                //Console.WriteLine(" -Trykk tast for ønsket kommando.\r\n");
                Console.WriteLine("\r\n");
                Console.WriteLine("  O  ¤                                      *");
                Console.WriteLine("  4\\== ..      ...           ______        O/");
                Console.WriteLine("  |    ¤                    | ¤  . |  ---v¤=");
                Console.WriteLine(" / \\     .                  | . . ¤|       /|_");     
               // var command = Console.ReadKey().KeyChar;
                //commands.Run(command);
                Console.WriteLine("\r\n");
                Console.ReadLine();

            }




        }

        
    }
}
