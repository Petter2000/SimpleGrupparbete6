using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleGrupparbete6
{
    interface IGenerator1
    {

        public static Random RndStatic { get; set; }
        public Random Rnd { get; set; }

        /*
        public Generator(Random rnd)
        {
            RndStatic = rnd;
            Rnd = rnd;
        }
        */
        public static int RandomNumber(int lowNum, int highNum)
        {
            return RndStatic.Next(lowNum, highNum + 1);
        }

        public int OneToHundred()
        {
            return Rnd.Next(1, 101);
        }
    }
}
