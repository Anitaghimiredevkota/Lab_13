using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_13
{
    class Program
    {

        static void Main(string[] args)
        {
            bool run = true;
            string response;
           // string Name = "";
            RandomPlayer randomPlayer = new RandomPlayer("computer");
            RockPlayer rockPlayer = new RockPlayer();
            UserPlayer userPlayer = new UserPlayer();


            Roshambo user;
            Roshambo computer;

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

                    Console.WriteLine($"{userPlayer.Name}: {user = userPlayer.GenerateRoshambo()}");
                    Console.WriteLine($"{randomPlayer.Name}: {computer = randomPlayer.GenerateRoshambo()}");
                    Console.ReadKey();
                    Console.WriteLine(PickWinner(user, computer));
                    Console.WriteLine("Would you like to play again(y/n)");
                    string choice = Console.ReadLine();
                    if (choice == "y")
                    {
                        run = true;
                    }

                    else
                    {

                        run = false;
                    }
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
                return "You Lost :";
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

            
            
                

