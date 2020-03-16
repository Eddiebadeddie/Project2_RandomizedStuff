/**********************************************************************
 *  class aRNG     Author: Eduardo Nodarse
 *  -------------------------------------------------------------------
 *      -This class creates a singleton which ensures only one random
 *       object is instantiated. All of the other classes use this 
 *       instance for the randomized numbers
 *********************************************************************/
using System;

namespace Project1{
    internal class aRNG{
        //Random class that handles pseudo random numbers
        Random random;
        //Seed for randomization
        int SEED;

        //Private static instance for singleton pattern
        static aRNG instance = null;

        //Private constructor for the singleton pattern
        private aRNG(int seed){
            //Stores the seed, just to compare before changing
            SEED = seed;
            //New random object based on new seed
            random = new Random(SEED);
        }

        /*-------------------------------------------------------------
            aRNG Instance(seed):
                returns the static instance of the rng
        ------------------------------------------------------------*/
        public static aRNG Instance(int seed){
            //If there is no RNG instance
            if(instance == null){
                //Create one with the seed parameter and return it
                instance = new aRNG(seed);
                return instance;
            }
            else{
            //If not, then check the seed
                if(instance.SEED != seed){
                    /*If the current seed is not the same as the
                      new seed, then create a new RNG*/
                    instance = new aRNG(seed);
                    //Return the new instance
                    return instance;
                }
                else{
                    //Return the instance if all fails
                    return instance;
                }
            }
        }

        //Getter for the instance
        public static aRNG Instance() => instance;
        //Gets a random integer that is inclusive of the highest number
        public int Random(int lowest, int highest) => random.Next(lowest, highest + 1);
        //Gets a random integer that is exclusive of the higest number
        public int Excluding_Random(int lowest, int highest) => random.Next(lowest, highest);
    }
}