/*=====================================================================
   class aCard   Author: Eduardo Nodarse
   -------------------------------------------------------------------
       -This class creates an object that is to be used in a deck.
 ===================================================================*/
using System;

namespace Project1{
    internal class aCard{
        //Card exceptions to be thrown if there is a problem
        public class CardException:Exception{
            //Sets up the card exception based on it's inheretence
            public CardException(string message) : base(message) { }
        }
        
        //enumeration to hold the card suits
        enum Card_suits{
            S,
            H,
            D,
            C
        }

        //Private variable to hold this card's suit
        Card_suits Suit;
        //Private char to represent the face of the card
        char Face;

        //Constructor that sets face and suit for a card
        public aCard(char face, int suit){
            //Based on face, will set the face
            switch(face){
                //If the char is 1-9, then the char will be the face
                case '1':
                case '2':
                case '3':
                case '4':
                case '5':
                case '6':
                case '7':
                case '8':
                case '9':
                    Face = face;
                    break;
                //If the char is T or t, then the face will be T
                case 'T':
                case 't':
                    Face = 'T';
                    break;
                //If the char is J or j, then the face will be J
                case 'J':
                case 'j':
                    Face = 'J';
                    break;
                //If the char is Q or q, then the face will be Q
                case 'Q':
                case 'q':
                    Face = 'Q';
                    break;
                //If the char is K or k, then the face will be K
                case 'K':
                case 'k':
                    Face = 'K';
                    break;
                //If the char does not line up with any of the cases
                default:
                    //Throw an Exception
                    throw new CardException("Face does not exist");
            }
            
            //If the suit is between [0,4]
            if(suit >= 0 && suit < 4)
                //Then assign it as a suit
                Suit = (Card_suits) suit;
            else{
                //Else, throw an exception
                throw new CardException("Suit does not exist");
            }
        }

        //Converts a card into a string implicitly
        public static implicit operator string(aCard card) => ""+ card.Face + card.Suit; 
    }
}