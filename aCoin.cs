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
        Random random;

        //Seed for the RNG
        int SEED;

        //Static instance for a singleton
        private static aCoin instance = null;

        //Private constructor that accepts a seed
        private aCoin(int seed)
        {
            //Stores the seed value
            SEED = seed;
            //Generates a new Random object with the new seed
            random = new Random(SEED);
        }

        //Public accessor for the instance, ensures a single instance
        public static aCoin Instance(int seed)
        {
            if (instance != null)
            {
                //Create a new coin if the seed is different
                if (seed != instance.SEED)
                    return new aCoin(seed);

                //Return the instance if it's not null
                return instance;
            }
            else
            {
                //Returns a new instance if "instance" is null
                return new aCoin(seed);
            }
        }

        /*-------------------------------------------------------------
            int Flip():
                Returns a random number between 0 and 1
        ------------------------------------------------------------*/
        public int Flip()
        {
            return random.Next(0, 2);
        }

        //Conversion operator that converts a coin to an int
        public static implicit operator int(aCoin c) => c.Flip();

        //Conversion operator that converts a coin to a string
        public static implicit operator string(aCoin c) => (int)c == 1 ? "H" : "T";
    }
}