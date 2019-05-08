using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Lab_13
{
    class RandomPlayer:Player
    {
        //public static int GetRandomNum()
        //{
        //    Random rnd = new Random();
        //    int value = rnd.Next(1, 4);
        //    return value;
        //}
        Random randomRoll = new Random();

        public override Roshambo GenerateRoshambo()
        {
            return (Roshambo)randomRoll.Next(0, 3);
        }

       
    }
}
