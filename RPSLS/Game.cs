﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Game
    {

        ////Member Variables
        
        Player playerOne = new Human();
        Player playerTwo;

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
            playerOne.ChooseName();
            playerTwo.ChooseName();
            while (playerOne.score < 3 || playerTwo.score < 3)
            {
                playerOne.ChooseGesture();
                playerTwo.ChooseGesture();
                ComparingGestures();
                GameWinner();
                
            }
                
            
              

























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
                playerTwo = new Computer();

            } 
            else if (numberofPlayers == 2)
            {
                playerTwo = new Human();
            }
        }



            public void ComparingGestures()
        {

            





            if (playerOne.gesture == "Rock" && playerTwo.gesture == "Scissors" || playerOne.gesture == "Rock" && playerTwo.gesture == "Lizard")
            {
                Console.WriteLine(playerOne.name + "Wins!");
                playerOne.score++;
                    
            }
            else if(playerOne.gesture == "Rock" && playerTwo.gesture == "Paper" || playerOne.gesture == "Rock" && playerTwo.gesture == "Spock")
            {

                Console.WriteLine(playerTwo.name + "Wins!");
                playerTwo.score++;
                
            }

            
            if (playerOne.gesture == "Paper" && playerTwo.gesture == "Rock" || playerOne.gesture == "Paper" && playerTwo.gesture == "Spock")
            {
                Console.WriteLine(playerOne.name +"Wins!");
                playerOne.score++;
              
            }
            else if (playerOne.gesture == "Paper" && playerTwo.gesture == "Scissors" || playerOne.gesture == "Paper" && playerTwo.gesture == "Lizard")
            {
                Console.WriteLine(playerTwo.name  + "Wins!");
                playerTwo.score++;
                

            }
            if (playerOne.gesture == "Scissors" && playerTwo.gesture == "Paper" || playerOne.gesture == "Scissors" && playerTwo.gesture == "Lizard")
            {
                Console.WriteLine(playerOne.name + "Wins!");
                playerOne.score++;
                
            }       
             else if (playerOne.gesture == "Scissors" && playerTwo.gesture == "Rock"|| playerOne.gesture == "Scissors" && playerTwo.gesture == "Spock")
            {
                Console.WriteLine(playerTwo.name + "Wins!");
                playerTwo.score++;
                
            }

            if (playerOne.gesture == "Lizard" && playerTwo.gesture == "Spock" || playerOne.gesture == "Lizard" && playerTwo.gesture == "Paper")
            {
                Console.WriteLine(playerOne.name + "Wins!");
                playerOne.score++;
                
            }
            else if (playerOne.gesture == "Lizard" && playerTwo.gesture == "Scissors" || playerOne.gesture == "Lizard" && playerTwo.gesture == "Rock")
            {
                Console.WriteLine(playerTwo.name + "Wins");
                playerTwo.score++;
                
            }
            if (playerOne.gesture == "Spock" && playerTwo.gesture == "Rock" || playerOne.gesture == "Spock" && playerTwo.gesture == "Scissors")
            {
                Console.WriteLine(playerOne.name + "Wins!");
                playerOne.score++;
               
            }
            else if (playerOne.gesture == "Spock" && playerTwo.gesture == "Paper" || playerOne.gesture == "Spock" && playerTwo.gesture == "Lizard")
            {
                Console.WriteLine(playerTwo.name + "Wins");
                playerTwo.score++;
                
            }

            if (playerOne.gesture == playerTwo.gesture)
            {
                Console.WriteLine("Tie!");
               
            }
            
                  
        }
        public void GameWinner()
        {
           if (playerOne.score == 2)
            {
                Console.WriteLine(playerOne.name + "Winner of the game");
            }
           else if (playerTwo.score == 2)
            {
                Console.WriteLine(playerTwo.name + "Winner of the game");
            }
                
        }
       
        

            

    
    }
}

