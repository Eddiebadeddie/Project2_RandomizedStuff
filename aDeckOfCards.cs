/**********************************************************************
 *  class aDeckOfCards     Author: Eduardo Nodarse
 *  -------------------------------------------------------------------
 *      -This class creates a collection of Cards to simulate a deck
 *********************************************************************/
using System;
using System.Collections.Generic;

namespace Project1
{
	internal class aDeckOfCards
    {   
        //A list of aCard objects to represent the deck
        List<aCard> deck;
        //Reference to the RNG singleton
        aRNG rng;
        
        //Constructor of a deck of Cards
        public aDeckOfCards()
        {
            //Gets the RNG instance
            rng = aRNG.Instance();
            
            //Creates a deck and shuffles the cards
            ResetDeck();

            //Console.WriteLine("Deck completed and created");
        }

        /*-------------------------------------------------------------
            void ResetDeck():
                Creates a new deck, overwrites the previous deck 
                and shuffles the cards
        ------------------------------------------------------------*/
        public void ResetDeck()
        {
            //Creates a new empty list of cards
            deck = new List<aCard>();

            //Temporary array of chars for the faces of the cards
            char[] faces = {
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

            //Attempts to create the deck based on the faces values
            try
            {
                //For each suit
                for (int i = 0; i < 4; ++i)
                {
                    //And for each face
                    foreach (char face in faces)
                    {
                        //Try and add a new card to the deck
                        deck.Add(new aCard(face, i));
                    }
                }
            }
            //If something goes wrong
            catch (aCard.CardException e)
            {
                //Print the exception message to the console
                Console.WriteLine($"CardException: {e}");
            }

            //Shuffle the cards
            Shuffle();
        }

        /*-------------------------------------------------------------
            void Shuffle():
                Shuffles the cards in the deck
        ------------------------------------------------------------*/
        public void Shuffle(){
            //Empty list to hold the newly shuffled deck
            List<aCard> NewDeck = new List<aCard>();

            //While there are still cards in the old deck
            while(deck.Count > 0){
                //Get a random index between 0 and deck.Count-1
                int index = rng.Excluding_Random(0, deck.Count);
                //Add the card from the old deck @ index to the new deck
                NewDeck.Add(deck[index]);
                //Remove the card from the old deck @ index
                deck.RemoveAt(index);
            }

            //Overwrite the old deck to the new deck
            deck = NewDeck;
            //Console.WriteLine("Deck Shuffled");
        }

        /*-------------------------------------------------------------
            aCard Remove():
                returns the card at the top of the deck
        ------------------------------------------------------------*/
        public aCard Remove(){
            //If the deck has cards in it,
            if(deck.Count > 0){
                //Temporarily store the card
                aCard card = deck[0];
                //Remove the card from the deck
                deck.RemoveAt(0);
                //Return the temporary card
                return card;
            }
            //Else, throw an exception
            else
                throw new aCard.CardException("No cards in the deck");
        }
        /*-------------------------------------------------------------
            List<aCard> Draw(num):
                returns a collection of cards with num number of
                cards
        ------------------------------------------------------------*/
        public List<aCard> Draw(int num)
        {
            //New list to be returned
            List<aCard> hand = new List<aCard>();
            //Attempt to remove the cards from the top of the deck
            try
            {
                //For num number of cards
                for (int i = 0; i < num; ++i)
                {
                    //Add the top card of the deck to the hand
                    hand.Add(Remove());
                }
            }
            //If something goes wrong, throw an exception
            catch (aCard.CardException e)
            {
                Console.WriteLine($"CardException: {e}");
            }

            //Return the list
            return hand;
        }

        //Public getter to read the number of cards in the deck
        public int Count
        {
            //Returns the number of cards in the deck
            get => deck.Count;
        }
    }
}