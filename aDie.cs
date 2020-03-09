/*=====================================================================
   class aDie   Author: Eduardo Nodarse
   -------------------------------------------------------------------
       -This class creates an RNG  that takes in a seed value. This 
        class also contains a singleton patern, as to limit the 
        possibility of multiple RNGs being created with the same seed.
 ===================================================================*/

using System;

namespace Project1
{
    internal class aDie
    {
        //Instance to enable this class to be a singleton, needs to be null here
        //https://www.youtube.com/watch?v=hUE_j6q0LTQ&t=1s
        static aDie instance = null;

        //RNG
        aRNG rng;

        //Seed value

        //Singleton works because of private constructor
        public aDie()
        {
            rng = aRNG.Instance();
        }

        /*-------------------------------------------------------------
            int Roll():
                Returns a random number between 1 and 6
        ------------------------------------------------------------*/
        public int Roll()
        {
            return rng.Random(1, 6);
        }

        //Conversion operator to convert aDie into an int
        public static implicit operator int(aDie a) => a.Roll();

        //Conversion operator to add two dice together
        public static int operator +(aDie left, aDie right) => (int)left + (int)right;

        //Conversion operator to multiply two dice togeter
        public static int operator *(aDie left, aDie right) => (int)left * (int)right;
    }
}