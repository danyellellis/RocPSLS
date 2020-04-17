using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Computer : Player
    {

        //Member Variables (HAS A)
        public int comp;
        

        //Constructor
        public Computer()
        {
            comp = 5;
        }



        //Member Methods (CAN DO)

        public override void ChooseGesture()

        {
            Random random = new Random();
            






          for (int i = 0; i < 5; i--)
          {
               Console.WriteLine(random.Next());
               chosenGesture = Console.ReadLine();

          }
             

            
                
          

          
            

          
            
           
            
            //needs to set chosenGesture member variable to a string of "rock" or etc.
            //use a random to randomly grab something from the objectsGesture list
            //use random number as the index of objectsGestures to get back a string from that list
        }
    }
}
