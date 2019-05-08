using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_13
{
    class Validator
    {
        public static Roshambo GetSelection()
        {
            string selection = Console.ReadLine().ToLower();

            if (selection == "rock" || selection == "1")
            {
                return Roshambo.Rock;
            }
            else if (selection == "paper" || selection == "2")
            {
                return Roshambo.Paper;
            }
            else if (selection == "scissors" || selection == "3")
            {
                return Roshambo.Scissors;
            }
            else
            {
                Console.WriteLine("Invalid Input");
                return GetSelection();
            }
        }
    }
}
