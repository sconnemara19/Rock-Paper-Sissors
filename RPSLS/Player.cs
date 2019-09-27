using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    abstract class Player
    {
        //Member Variables (Has A)
        //score
        public int score;
        public string name;
        public string gesture;
        public List<string> choices;




        //Constructor (Spawner)

        public Player()
        {
            score = 0;
            name = null;
            gesture = null;
            choices = new List<string>() {"Rock", "Paper", "Sissors", "Lizard", "Spock"};
        }

        //Member Methods (Can Do)

       




        public abstract void ChooseName();

        public abstract void ChooseGesture();

    }
    
}