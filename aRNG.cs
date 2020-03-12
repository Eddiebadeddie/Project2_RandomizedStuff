using System;

namespace Project1{
    internal class aRNG{
        Random random;
        int SEED;

        static aRNG instance = null;

        private aRNG(int seed){
            SEED = seed;
        }

        public static aRNG Instance(int seed){
            if(instance == null){
                return new aRNG(seed);
            }
            else{
                if(SEED != seed){
                    return new aRNG(seed);
                }
                else{
                    return instance;
                }
            }
        }

        public static aRNG Instance() => instance;

        public int Random() => random.Next();
        public int Random(int lowest, int highest) => random.Next(lowest, highest + 1);
    }
}