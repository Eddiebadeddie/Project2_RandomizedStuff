using System;

namespace Project1
{
	internal class aDeckOfCards
    {
        Random rand = new Random();
        List<aCard> deck;
        
        public aDeckOfCards(){
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
                        present.Add(true);
                    }
                }
            }
            catch(aCard.CardException e){
                Console.WriteLine($"CardException: {e}");
            }

            Console.WriteLine("Deck completed and created");
        }

        public aCard draw()
        {
            aCard card = deck[rand.Next(0, deck.Count + 1)];
            deck.Remove(card);

        }
    }
}