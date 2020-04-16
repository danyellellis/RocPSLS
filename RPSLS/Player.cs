using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public abstract class Player
    {// Human human;
     // Computer computer;


        //Member Variables (HAS A)
        public int score;
        public string chosenGesture;
        public string viewGestures;
        public List<string> objectsGestures;
        





        //public string objectsGestures;
        //public List<string> objectsGestures = new List<string>();
        // public string choice;

        //Constructor
        public  Player()
        {
            objectsGestures = new List<string>();
            objectsGestures.Add("Rock");
            objectsGestures.Add("Paper");
            objectsGestures.Add("Scissors");
            objectsGestures.Add("Lizard");
            objectsGestures.Add("Spock");
       
            
        }


        //Member Methods (CAN DO)



        public abstract void ChooseGesture();



    }
}