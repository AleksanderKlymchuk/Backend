using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Lesson02_Startup;
namespace Lesson02_Startup.Models
{
    public class Dice
    {

        
        private int eyes, numRoll,outcome,totalSum;
        private int[] distribution;
        public int[] Distribution 
        {
            get { return distribution; }
        
        }
        
 
        public int Eyes
        {

            get { return eyes; }
            set { eyes = value; }
    
        } 
        public int NumRoll
        {
            get { return numRoll; }

        }
        public int Outcome
        {
            get { return outcome; }
        }
        public int TotalSum
        {
            get { return totalSum; }
        }



        public Dice()
        {
            eyes = 6;
            numRoll = 0;
            totalSum = 0;
            outcome=0;
            this.distribution = new int[6] { 0,0,0,0,0,0};

           
        
        }
        public void Roll(int eyes )
       {
          
           this.numRoll++;
           this.outcome = eyes;
           this.totalSum = this.totalSum + eyes;
           this.eyes = eyes;
           switch (eyes) 
           { 
               case 1:
                   this.distribution[eyes-1] += 1;
             
               break;
               case 2:
               this.distribution[eyes - 1] += 1;
               break;
               case 3:
               this.distribution[eyes - 1]+= 1;
              
               break;
               case 4:
               this.distribution[eyes - 1] += 1;
             
               break;
               case 5:
               this.distribution[eyes - 1] += 1;
            
               break;
               case 6:
               this.distribution[eyes - 1] += 1;
               
               break;
           
           }
      
            
          
       }


    }
}