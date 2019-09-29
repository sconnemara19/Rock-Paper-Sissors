using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Human : Player
    {

        //Member variables











        //Constructor (Spawner)











        //Member Methods (Can Do)

        public override void ChooseGesture()
        {
            Console.WriteLine(name +"Choose a gesture");
            gesture = Console.ReadLine();
           
        }

        public override void ChooseName()
        {
            Console.WriteLine("Enter Name");
            name = Console.ReadLine();
        
        
        } 














    }




}
