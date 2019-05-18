using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Lab_13
{
    class RandomPlayer:Player
    {
    
        public RandomPlayer(string _name)
        {
            Name = "Computer";
        }
        Random randomRoll = new Random();

        public override Roshambo GenerateRoshambo()
        {
            return (Roshambo)randomRoll.Next(0, 3);
        }
 
    }
}
