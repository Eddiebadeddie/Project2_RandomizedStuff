/*=====================================================================
   class aCoin   Author: Eduardo Nodarse
   -------------------------------------------------------------------
       -This class creates an RNG that will simulate a coin flip and
        will return a 'H' for heads, or a 'T' for tails.
 ===================================================================*/
using System;

namespace Project1
{
	internal class aCoin
    {
        //RNG that will return a 0 or a 1
        aRNG rng;

        //Private constructor that accepts a seed
        public aCoin(){
            rng = aRNG.Instance();    
        }

        /*-------------------------------------------------------------
            int Flip():
                Returns a random number between 0 and 1
        ------------------------------------------------------------*/
        public int Flip(){
            return rng.Random(0,1);
        }

        //Conversion operator that converts a coin to an int
        public static implicit operator int(aCoin c) => c.Flip();

        //Conversion operator that converts a coin to a string
        public static implicit operator string(aCoin c)=> (int)c == 1 ? "H" : "T";
    }
}