using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_13
{
    abstract class Player
    {
        private string name;
        private Roshambo pick;
        public string Name
        {
            set { name = value; }
            get { return name; }
        }
        public Roshambo Pick
        {
            set { pick = value; }
            get { return pick; }
        }
        public Player(string _name,Roshambo _pick)
        {
            name = _name;
            pick = _pick;
        }
        public Player()
        {

        }

        public abstract Roshambo GenerateRoshambo();
     
    }
}
