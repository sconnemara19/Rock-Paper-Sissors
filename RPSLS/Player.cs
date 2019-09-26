using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    abstract class  Player
    {
        //Member Variables (Has A)
        //score
        public int score;        
        public string name;
        public string Gesture;

     


        //Constructor (Spawner)

        public Player()
        {
            score = 0;
            name = null;
            Gesture = null;
        }

        //Member Methods (Can Do)

        public abstract void ChooseGesture();



        public abstract void ChooseName()

        

       

    

    }
}
