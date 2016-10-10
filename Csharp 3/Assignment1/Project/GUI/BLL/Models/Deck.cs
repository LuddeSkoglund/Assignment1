using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL {
   public class Deck {
      public Int32 Count { get; set; }
      public Card[] Cards {get;set;}
      public List<Card> DrawnCards { get; set; }
      /// <summary>
      /// Constructor
      /// </summary>
      /// <param name="aNbrOfDecks"></param>
      public Deck(Int32 aNbrOfDecks) {
         Count = aNbrOfDecks;
         Cards = new Card[52*aNbrOfDecks];
         initalizeDeck(aNbrOfDecks);
         shuffleDeck();
         DrawnCards = new List<Card>();
      }

      /// <summary>
      /// Initialize a new deck. aNbrOfDecks = how many decks there should be.
      /// </summary>
      /// <param name="aNbrOfDecks"></param>
      private void initalizeDeck(Int32 aNbrOfDecks) {
         DrawnCards = new List<Card>();
         Int32 idx = 0;
         for(Int32 nbrOfDecks = 0; nbrOfDecks < aNbrOfDecks; nbrOfDecks++) {
            
            for(Int32 suit = 1; suit <= 4; suit++) {
               for(Int32 val = 1; val <= 13; val++) {
                  if(suit == (int) Suits.Hearts) {
                     Cards[idx] = new Card(Suits.Hearts, "Hears", (Value) val, false);
                  }

                  if(suit == (int) Suits.Diamonds) {
                     Cards[idx] = new Card(Suits.Diamonds, "Diamonds", (Value) val, false);
                  }

                  if(suit == (int) Suits.Clubs) {
                     Cards[idx] = new Card(Suits.Clubs, "Clubs", (Value) val, false);
                  }

                  if(suit == (int) Suits.Spades) {
                     Cards[idx] = new Card(Suits.Spades, "Spades", (Value) val, false);
                  }
                  idx++;
               }
            }
         }
      }

      /// <summary>
      /// Shuffle deck
      /// </summary>
      public void shuffleDeck() {
         Random shuffle = new Random();
         Cards = Cards.OrderBy(x => shuffle.Next()).ToArray();
      }

      /// <summary>
      /// Draw next card in line
      /// </summary>
      /// <returns></returns>
      public Card drawNextCard() {
         if(Cards.Count() == 0) {
            Cards = new Card[52 * Count];
            initalizeDeck(Count);
            shuffleDeck();
         }
         Card card = Cards[0];
         if(card != null) {
            
            Cards = Cards.Where(x => x != card).ToArray();
            if(cardHasBeenDrawn(card)) {
               card = drawNextCard();
            }
            DrawnCards.Add(card);
         }
         
         

         return card;


      }

      /// <summary>
      /// Check if card has been drawn
      /// </summary>
      /// <param name="card"></param>
      /// <returns></returns>
      private Boolean cardHasBeenDrawn(Card card) {
         return DrawnCards.Any(x => x.Suits.Equals(card.Suits) && x.Value.Equals(card.Value));
      }


   }
}
