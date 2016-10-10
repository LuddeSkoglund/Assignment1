using BLL;
using BLL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI {
   public partial class BlackJack: Form {
      private GameEngine game;
      private Boolean newTurn = false;
      public BlackJack(IEnumerable<String> aPlayerNameList, Int32 aDecks) {
         game = initializeGame(aPlayerNameList, aDecks);
         InitializeComponent();
         CreateStartLayout(game);
         
      }
      /// <summary>
      /// Initzialize game
      /// </summary>
      /// <param name="aPlayerNameList"></param>
      /// <param name="aNbrOfDecks"></param>
      /// <returns></returns>
      private GameEngine initializeGame(IEnumerable<String> aPlayerNameList, Int32 aNbrOfDecks) {
         return new GameEngine(aPlayerNameList, aNbrOfDecks);
         
      }
      private Int32 imgPositionX = 1233;
      private Int32 imgPositionY = 420;
      /// <summary>
      /// Add card to player
      /// </summary>
      /// <param name="sender"></param>
      /// <param name="e"></param>
      private void btnHit_Click(object sender, EventArgs e) {
         Player player = game.Turn;
         if(game.isDealersTurn()) {
            if(game.isDealersTurn()) {
               //Dealers turn;
               flipDealersCard();
               return;
            }
         }
         if(player.IsFinished) {
            return;
         }
         if(newTurn) {
            imgPositionX = imgPositionX - 200;
            newTurn = false;
         }
         
         Card card = game.drawNextCard();
         Int32 newPositionX = player.calculate(imgPositionX);
         PictureBox pb = getImgBox(newPositionX, imgPositionY, new Guid().ToString());
         addCardToPlayer(pb, card);
         player.Hand.addCardToHand(card);
         this.Controls.Add(pb);
         if(player.isThick()) {
            player.IsFinished = true;
            Label lblBusted = getLabel(imgPositionX, imgPositionY + 120, "lblBusted" + player.Name, "BUSTED");
            this.Controls.Add(lblBusted);
            game.getNextPlayer();
            if(game.isDealersTurn()) {
               //Dealers turn;
               flipDealersCard();
               dealersTurn();
               return;
            }
            newTurn = true;
            
         }

         if(player.hasBlackJack()) {
            player.IsFinished = true;
            Label lblBlackJack = getLabel(imgPositionX, imgPositionY + 120, "lblBlackJack" + player.Name, "BLACK JACK");
            this.Controls.Add(lblBlackJack);
            game.getNextPlayer();
            if(game.isDealersTurn()) {
               flipDealersCard();
               dealersTurn();
               return;
            }
            newTurn = true;
            
         }



      }
      /// <summary>
      /// Stay and get next player in line
      /// </summary>
      /// <param name="sender"></param>
      /// <param name="e"></param>
      private void btnStay_Click(object sender, EventArgs e) {
         
         if(newTurn) {
            imgPositionX = imgPositionX - 200;
            newTurn = false;
         }
         
         Player player = game.Turn;
         
         player.IsFinished = true;
         String score = game.getPlayersScore(player.PlayerId);
         Label lblBusted = getLabel(imgPositionX, imgPositionY + 120, "lblFinished" + player.Name, score);
         this.Controls.Add(lblBusted);
         game.getNextPlayer();
         if(game.isDealersTurn()) {
            //Dealers turn;
            flipDealersCard();
            dealersTurn();
            return;
         } else {
            
         }
         newTurn = true;
      }
      /// <summary>
      /// Dealers turn, get card until dealer has atleast 17 or is busted
      /// </summary>
      private void dealersTurn() {
         
         Int32 imgPositionX = 576 - 25;
         Int32 imgPositionY = 33;
         if(game.dealerHasLowerThanSeventeen()) {
            Card card = game.drawNextCard();
            Int32 newPositionX = game.Dealer.calculate(imgPositionX);
            PictureBox pb = getImgBox(newPositionX, imgPositionY, new Guid().ToString());
            addCardToPlayer(pb, card);
            game.Dealer.Hand.addCardToHand(card);
            this.Controls.Add(pb);
            dealersTurn();
         } else {
            String score = game.getPlayersScore(game.Dealer.PlayerId);
            if(Convert.ToInt32(score) > 21) {
               Label lblBusted = getLabel(imgPositionX, imgPositionY + 120, "lblFinished" + game.Dealer.Name, "BUSTED");
               this.Controls.Add(lblBusted);
            } else {
               if(game.Dealer.hasBlackJack()) {
                  score = "BLACK JACK";
               }
               Label lblscore = getLabel(imgPositionX, imgPositionY + 120, "lblscore" + game.Dealer.Name, score);
               this.Controls.Add(lblscore);
            }
            if(game.needsToBeShuffled()) {
               DialogResult dialogResult = MessageBox.Show("Deck has less than 25% of cards left. Do you want to shuffle", "Shuffle?", MessageBoxButtons.YesNo);
               if(dialogResult == DialogResult.Yes) {
                  game.shuffleDeck();
               } else if(dialogResult == DialogResult.No) {
                  return;
               }

            }
            enableDisableButtons(false);
            btnDeal.Enabled = true;

         }


      }

      private void enableDisableButtons(Boolean aEnable) {
         btnHit.Enabled = aEnable;
         btnStay.Enabled = aEnable;
      }

      private void ShowDialogBox(String aMsg) {
         Modal modal = new Modal();

         modal.lblModalMsg.Text = aMsg;
         modal.ShowDialog();
      }
      /// <summary>
      /// New Round clear table and start over.
      /// </summary>
      private void newRound() {
         //Clear table
         //remove cards;

         List<PictureBox> tmpPb = new List<PictureBox>();
         tmpPb.AddRange(Controls.OfType<PictureBox>());
         foreach(Control card in tmpPb) {
            this.Controls.Remove(card);
         }
         List<Label> tmpLbl = new List<Label>();
         tmpLbl.AddRange(Controls.OfType<Label>());
         foreach(Control lbl in tmpLbl) {
            this.Controls.Remove(lbl);
         }
         enableDisableButtons(true);
         game.newRound();
         game.getNextPlayer();
         imgPositionX = 1233;
         imgPositionY = 420;
         newTurn = false;
      }
      /// <summary>
      /// Shuffle deck
      /// </summary>
      /// <param name="sender"></param>
      /// <param name="e"></param>
      private void btnSuhffle_Click(object sender, EventArgs e) {
         game.shuffleDeck();
         ShowDialogBox("Deck has been shuffled.");

      }
      /// <summary>
      /// Deal to start a new round
      /// </summary>
      /// <param name="sender"></param>
      /// <param name="e"></param>
      private void btnDeal_Click(object sender, EventArgs e) {
         newRound();
         CreateStartLayout(game);
         
      }
   }
}
