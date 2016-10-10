using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Models {
   public class Hand {
      public Int32 NbrOfCards { get; private set; }
      public Int32 Score { get; private set; }
      public List<Card> Cards { get; set; }
      /// <summary>
      /// Constructor
      /// </summary>
      public Hand() {
         NbrOfCards = 0;
         Score = 0;
         Cards = new List<Card>();
      }
      /// <summary>
      /// Add a card
      /// </summary>
      public void addCard() {
         NbrOfCards += 1;
      }
      /// <summary>
      /// Add a card to hand
      /// </summary>
      /// <param name="aCard"></param>
      public void addCardToHand(Card aCard) {
         Cards.Add(aCard);
         addScore(aCard.Value);
         addCard();
      }
      /// <summary>
      /// Add score
      /// </summary>
      /// <param name="aValue"></param>
      private void addScore(Value aValue) {
         Score += (int)aValue;
      }

   }
}
