using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    abstract class Player
    {// Human human;
     // Computer computer;


        //Member Variables (HAS A)
        public int score;
        public string objectsGestures;



        //Constructor
        public void viewGestures(List<string> objectGestures)

        {


            List<string> objectsGestures = new List<string>();
            objectsGestures.Add("Rock");
            objectsGestures.Add("Paper");
            objectsGestures.Add("Scissors");
            objectsGestures.Add("Lizard");
            objectsGestures.Add("Spock");

            for (int i = 0 < objectGestures.Count; i++)
                Console.WriteLine();




        //Member Methods (CAN DO)
        public abstract void chooseGesture();



    }