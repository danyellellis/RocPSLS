using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Game
    {
        //Member Variables (HAS A)
        public int pointsNeededtoWin;
        public Player player1;
        public Player player2;
        
        
        



        //Constructor
        public Game()
        {
            pointsNeededtoWin = 3;
            player1 = new Human();
            
            
        }


        //Member Methods (CAN DO)
        public void RunGame() // Master Method
        {
            DisplayRules();
            ChooseGameMode();
            player1.ChooseGesture();
            player2.ChooseGesture();
        }

        public void DisplayRules()
        {
            Console.WriteLine("These are the rules! Rock crushes Scissors. Scissors cut Paper. Rock crushes Lizard." +
                " Lizard poisons Spock. Spock smashes Scissors. Scissor decpitates Lizard. Lizard eats Paper." +
                " Paper disproves Spock. Spock vaporize Rock. ");
            Console.ReadLine();
        }

        public void ChooseGameMode()
        {
            Console.WriteLine("Please enter 1 for human vs Computer, or enter 2 for Human vs Human");
            string userInput = Console.ReadLine();
            if(userInput == "1")
            {
                player2 = new Computer();
            }
            else if(userInput == "2")
            {
                player2 = new Human();
            }
            else
            {
                Console.WriteLine("ERROR  Please press 1 or 2.");
             
            }
            Console.ReadLine();


        }

       
            
        
    }
}