using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public class Human : Player
    {

        //Member Variables (HAS A)

        public string choice;

        //Constructor
        public Human()
        {
          


            
        }




        //Member Methods (CAN DO)

        public override void ChooseGesture()
        {
            //Console writeline to display message asking human to choose a gesture
            //Save the player's choice as the "choice" member variable using a console readline
            Console.WriteLine("Choose a Gesture.");
            chosenGesture = Console.ReadLine();
          
        }


    }
}
