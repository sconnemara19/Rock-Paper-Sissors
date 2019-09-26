using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Game
    {

        ////Member Variables

           List<string> displayRules = new List<string>();
            int numberOfPlayers = 0;



        //Player playerOne;
        Human player = new Human();
        




        
        //Player playerTwo;

        //public int scorekeeper;
        //public int rounds;




        ////list of gestures 
        ////






        //Constructor (Spawner)







        //Member Methods


        public void DisplayRules()
        {
            displayRules.Add("Rock crushes Scissors "); 
            displayRules.Add("Scissors cuts Paper");
            displayRules.Add("Paper covers Rock");
            displayRules.Add("Rock crushes Lizard");
            displayRules.Add("Lizard poisons Spock");
            displayRules.Add("Spock smashes Scissors");
            displayRules.Add("Scissors decapitates Lizard");
            displayRules.Add("Lizard eats Paper");
            displayRules.Add("Paper disproves Spock");
            displayRules.Add("Spock vaporizes Rock");
                Console.WriteLine( );








        }





        public void RunGame()
        {

        }



    }
}
