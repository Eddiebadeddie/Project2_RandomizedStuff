using System;

namespace Project1
{
	internal class aDeckOfCards
    {
        Random rand = new Random();
        List<aCard> deck;

        aRNG rng;
        
        public aDeckOfCards(bool empty){
            rng = aRNG.Instance();
            deck = new List<aCard>();

            List<char> faces = {
                '1',
                '2',
                '3',
                '4',
                '5',
                '6',
                '7',
                '8',
                '9',
                'T',
                'J',
                'Q',
                'K'
            };

            try{
                for(int  i = 0; i < 4; ++i){
                    foreach(char face in faces){
                        deck.Add(new aCard(face, i));
                    }
                }
            }
            catch(aCard.CardException e){
                Console.WriteLine($"CardException: {e}");
            }

            Console.WriteLine("Deck completed and created");
        }

        void Shuffle(){
            List<aCard> NewDeck = new List<aCard>();

            while(deck.Count > 0){
                int index = rng.Random(0, Count);
                NewDeck.Add(deck[index]);
                deck.RemoveAt(index);
            }

            deck = NewDeck;
        }

        public aCard Remove(){
            if(deck.Count > 0){
                aCard card = deck[0];
                deck.RemoveAt(0);
                return card;
            }
            else
                throw aCard.CardException("No cards in the deck");
        }

        public void Replace(aCard card){

        }
    }
}