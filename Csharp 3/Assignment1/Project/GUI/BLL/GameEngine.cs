using BLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL {
   public class GameEngine {
      private Player dealer;
      private Deck deck;
      private List<Player> players;
      private Player turn;
      public Player Dealer {
         get { return dealer; }
      }

      public Player Turn {
         get { return turn; }
         set { turn = value; }
      }
      /// <summary>
      /// Constructor
      /// </summary>
      /// <param name="aPlayerNameList"></param>
      /// <param name="nbrOfDecks"></param>
      public GameEngine(IEnumerable<String> aPlayerNameList, Int32 nbrOfDecks) {
         // create a dealer
         dealer = new Player("Dealer", id: 0);
         // create players
         players = new List<Player>();
         Int32 i = 1;
         foreach(String name in aPlayerNameList) {
            players.Add(new Player(name, id: i));
            i++;
         }

         deck = new Deck(nbrOfDecks);

         getNextPlayer();
      }
      /// <summary>
      /// Get next player
      /// </summary>
      public void getNextPlayer() {
         Turn = players.FirstOrDefault(x => !x.IsFinished);
      }
      /// <summary>
      /// Get players score
      /// </summary>
      /// <param name="aPlayerId"></param>
      /// <returns></returns>
      public String getPlayersScore(Int32 aPlayerId) {
         return aPlayerId == 0 ? dealer.Hand.Score.ToString() : players.FirstOrDefault(x => x.PlayerId.Equals(aPlayerId)).Hand.Score.ToString();
      }
      /// <summary>
      /// Draw next card
      /// </summary>
      /// <returns></returns>
      public Card drawNextCard() {
         return deck.drawNextCard();
      }
      /// <summary>
      /// Check if deck needs to be shuffled
      /// </summary>
      /// <returns></returns>
      public Boolean needsToBeShuffled() {
         Int32 nbrOfCards = deck.Count * 52;
         Decimal percent = Decimal.Divide(deck.Cards.Count(), nbrOfCards);
         return (percent <= new Decimal(0.25));
      }
      /// <summary>
      /// Get players
      /// </summary>
      /// <returns> Player </returns>
      public IEnumerable<Player> getPlayers() {
         return players;
      }
      /// <summary>
      /// Shuffle and return deck
      /// </summary>
      /// <returns>Deck</returns>
      public Deck shuffleDeck() {
         deck.shuffleDeck();
         return deck;
      }

      /// <summary>
      /// Check if dealers turn
      /// </summary>
      /// <returns></returns>
      public Boolean isDealersTurn() {
         return (turn == null);
      }

      /// <summary>
      /// Check if dealer has lower score than 17
      /// </summary>
      /// <returns></returns>
      public Boolean dealerHasLowerThanSeventeen() {
         return Convert.ToInt32(getPlayersScore(dealer.PlayerId)) < 17; 
      }
      /// <summary>
      /// Create new round
      /// </summary>
      public void newRound() {
         foreach(Player player in players) {
            player.newRound();
         }

         dealer.newRound();
      }

      

      

      
   }
}
