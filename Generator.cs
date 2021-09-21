using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleGrupparbete6
{
    class Generator
    {
        
        public static Random Rnd { get; set; }

        public Generator() 
        {
            
            Rnd = new Random();
            
        }

        public static int RandomNumber(int lowNum, int highNum) 
        {
            return Rnd.Next(lowNum, highNum + 1);
            
        }

        public int OneToHundred()
        {
            return Rnd.Next(1, 101);
            
        }


    }
}
