using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_13
{
    class Program
    {
        private static object Player;

        static void Main(string[] args)
        {
            bool run = true;
            string response;
            RandomPlayer randomPlayer = new RandomPlayer();
            RockPlayer rockPlayer = new RockPlayer();
            UserPlayer userPlayer = new UserPlayer();

            Console.WriteLine("Welcome to Roshambo");
            Console.Write("Please enter your name ");
            userPlayer.Name = Console.ReadLine();
            while (run)
            {
                Console.WriteLine($"{userPlayer.Name} are you ready to Roshambo? \nEnter y to go. Press any other key twice to exit");
                response = Console.ReadLine();
                if (response == "y")
                {
                    Console.WriteLine("Enter your selection: (1)rock  (2)paper (3)scissors");

                    Console.WriteLine(userPlayer.GenerateRoshambo());
                    Console.ReadKey();

                    for (int i = 0; i < 2; i++)
                    {
                        Console.WriteLine(randomPlayer.GenerateRoshambo());
                    }
                    for (int i = 0; i < 2; i++)
                    {
                        Console.WriteLine(rockPlayer.GenerateRoshambo());
                    }

                    Console.ReadKey();
                }
                else
                {
                    break;
                }
            }
        }

        public static string PickWinner(Roshambo user, Roshambo computer)
        {
            if (user == computer)
            {
                return "draw";
            }
            else if (user == Roshambo.Rock)
            {
                if (EvaluateRock(computer) == true)
                {
                    return "You Won!!!";
                }
                return "You Lost :(";
            }
            else if (user == Roshambo.Paper)
            {
                if (EvaluatePaper(computer) == true)
                {
                    return "You Won!!!";
                }
                return "You Lost :(";
            }
            else if (user == Roshambo.Scissors)
            {
                if (EvaluateScissors(computer) == true)
                {
                    return "You Won!!!";
                }
                return "You Lost:(";
            }
            return "You did something wrong";
        }
        public static bool EvaluateRock(Roshambo computer)
        {
            if (computer == Roshambo.Paper)
            {
                return false;
            }
            return true;
        }
        public static bool EvaluatePaper(Roshambo computer)
        {
            if (computer == Roshambo.Scissors)
            {
                return false;
            }
            return true;
        }
        public static bool EvaluateScissors(Roshambo computer)
        {
            if (computer == Roshambo.Rock)
            {
                return false;
            }
            return true;
        }
    }

}
//RandomPlayer rp = new RandomPlayer();
//            RockPlayer rock = new RockPlayer();
//            UserPlayer up = new UserPlayer();
//            Console.WriteLine("Welcome to Rock Paper Scissor!(R/P/S)");
//            Console.WriteLine("Enter your Name");
//            Player.Name = Console.ReadLine();
//            Console.WriteLine($"Would you like to play against Thejets or TheSharks (j/s)?:");
//            choice1 = Console.ReadLine();

            
            
                
//                Console.WriteLine("Enter rock(1) paper(2) Scissors(3)");
//            //Console.WriteLine($"UserPlayer : {up.Name}");
//               Console.WriteLine(up.GenersteRoshambo());

//            for (int i = 0; i < 10; i++)
//            {
//                Console.WriteLine(rp.GenersteRoshambo());
//            }

//        }
//        }
//    }

