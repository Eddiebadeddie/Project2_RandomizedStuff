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
        Random rand;

        //Seed value
        int SEED;

        //Singleton works because of private constructor
        private aDie(int seedValue)
        {
            //Sets the seed for the RNG
            SEED = seedValue;
            //Creates the RNG
            rand = new Random(SEED);
        }

        /*Public static getter for the instantiation of the singleton
         *  +Checks to see if there is an instance already: if not,
         *   one is created
         */
        public static aDie Instance(int seedValue)
        {
            //If there is no instance, create a new instance with the seed value 
            if (instance == null)
            {
                instance = new aDie(seedValue);
            }

            //If there us an instance, but a new seed is needed
            else if (seedValue != instance.SEED)
            {
                //Creates a new die with the new seed value
                instance = new aDie(seedValue);
            }

            //Returns the instance
            return instance;
        }

        /*-------------------------------------------------------------
            int Roll():
                Returns a random number between 1 and 6
        ------------------------------------------------------------*/
        public int Roll()
        {
            return rand.Next(1, 7);
        }

        //Conversion operator to convert aDie into an int
        public static implicit operator int(aDie a) => a.Roll();

        //Conversion operator to add two dice together
        public static int operator +(aDie left, aDie right) => (int)left + (int)right;

        //Conversion operator to multiply two dice togeter
        public static int operator *(aDie left, aDie right) => (int)left * (int)right;
    }
}