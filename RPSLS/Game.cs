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

        Computer playerOne = new Computer();
       Human playerTwo = new Human();
        int numberofPlayers;


        //  int numberOfPlayers = 0;


        //Player playerOne;



        //Player playerTwo;

        //public int scorekeeper;
        //public int rounds;



        //Constructor (Spawner
        public Game()
        {
            numberofPlayers = 0;
        }
       
            

        //Member Methods

        public void RunGame()
        {
            DisplayRules();
            int numberofPlayers = GetNumberPlayers();
            CreateNumberOfPlayers(numberofPlayers);

            
        }
        public void DisplayRules()
        {
            Console.WriteLine("Rules of the Game\n: Rock crushes Scissors\n:Sissors cuts Paper\n:Paper covers Rock\n:Rock crushes Lizard\n:Spock smashes Scissors\n:Scissors decapitates Lizard\n:Lizard eats paper\n:Paper disproves Spock\n: Spock vaporizes Rock");
            
        }

        public int GetNumberPlayers()
        {
            Console.WriteLine("How Many Players, 1 or 2");
            // Error handling
            numberofPlayers = int.Parse(Console.ReadLine());
            return numberofPlayers;
        }
        
           
        public void CreateNumberOfPlayers(int numberPlayer)
        {
            if (numberofPlayers == 1)
            {
                playerOne = new Computer();

            } 
            else if (numberofPlayers == 2)
            {
                playerTwo = new Human();
            }
        }

    }
}

