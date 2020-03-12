using System;

namespace Project1{
    internal class aCard{
        class CardException:Exception{
            public CardException(string message) : base (message);
        }
        
        enum Card_suits{
            Spades,
            Hearts,
            Diamonds,
            Clubs
        }

        Card_suits Suit;
        char Face;

        public aCard(char face, int suit){
            switch(face){
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
                case 'T':
                case 't':
                    Face = 'T';
                    break;
                case 'J':
                case 'j':
                    Face = 'J';
                    break;
                case 'Q':
                case 'q':
                    Face = 'Q';
                    break;
                case 'K':
                case 'k':
                    Face = 'K';
                    break;
                default:
                    throw CardException("Face does not exist");
            }
            
            if(suit >= 0 && suit < 4)
                Suit = (Card_suits) suit;
            else{
                throw CardException("Suit does not exist");
            }
        }
    }
}