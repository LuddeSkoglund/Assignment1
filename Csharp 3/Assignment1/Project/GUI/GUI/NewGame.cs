
using BLL;
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
   public partial class NewGame: Form {
      private Common common;
      public NewGame() {
         InitializeComponent();
         common = new Common();

      }

      private void btnNewGame_Click(object sender, EventArgs e) {

      }

      private void NewGame_Load(object sender, EventArgs e) {

      }

      private void txtDecks_KeyPress(object sender, KeyPressEventArgs e) {
         //Check if number
         e.Handled = common.isNumber(e.KeyChar);
      }
      /// <summary>
      /// Starts game
      /// </summary>
      /// <param name="sender"></param>
      /// <param name="e"></param>
      private void btnStartGame_Click(object sender, EventArgs e) {
         List<String> playersNameList = new List<String>();
         getNbrOfPlayers(playersNameList);
         if(playersNameList.Count() == 0) {
            Modal modal = new GUI.Modal();
            modal.lblModalMsg.Text = "Add atleast one player";
            modal.Show();
            return;
         }

         if(String.IsNullOrEmpty(txtDecks.Text)) {
            Modal modal = new GUI.Modal();
            modal.lblModalMsg.Text = "Add atleast one deck";
            modal.Show();
            return;
         }
         Int32 decks = Convert.ToInt32(txtDecks.Text);
         if(decks < 1) {
            Modal modal = new GUI.Modal();
            modal.lblModalMsg.Text = "Add atleast one deck";
            modal.Show();
            return;
         }
         this.Hide();
         BlackJack blackJack = new BlackJack(playersNameList, decks);
         blackJack.Show();
         
      }
      /// <summary>
      /// Gets nbr of players
      /// </summary>
      /// <param name="aPlayersNameList"></param>
      private void getNbrOfPlayers(List<String> aPlayersNameList) {

         if(!common.isEmpty(txtPlayer1.Text)) {
            aPlayersNameList.Add(txtPlayer1.Text);
         }
         if(!common.isEmpty(txtPlayer2.Text)) {
            aPlayersNameList.Add(txtPlayer2.Text);
         }
         if(!common.isEmpty(txtPlayer3.Text)) {
            aPlayersNameList.Add(txtPlayer3.Text);
         }
         if(!common.isEmpty(txtPlayer4.Text)) {
            aPlayersNameList.Add(txtPlayer4.Text);
         }

      }


   }
}
