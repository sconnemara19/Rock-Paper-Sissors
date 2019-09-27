using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Computer : Player
    {

        //Member Variables (Has A)
        public int RandomNumber;
        Random rng = new Random();






        //Constructor (Spawner)
        public Computer()
        {
           
            RandomNumber = rng.Next(6);
        }




        //Member Methods

        public override void ChooseGesture()
        {
            int result =  rng.Next(4);
            gesture = choices[result];

        }

        public override void ChooseName()
        {
            throw new NotImplementedException();
        }




    }
}
