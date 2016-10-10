using BLL;
using BLL.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
namespace GUI {
   partial class BlackJack {
      /// <summary>
      /// Required designer variable.
      /// </summary>
      private System.ComponentModel.IContainer components = null;
      private Card dealersFaceDown;
      private PictureBox delersFaceDownPic;
      private String[] players = new String[] { "", "", "", "" };
      /// <summary>
      /// Clean up any resources being used.
      /// </summary>
      /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
      protected override void Dispose(bool disposing) {
         if(disposing && (components != null)) {
            components.Dispose();
         }
         base.Dispose(disposing);
      }

      #region Windows Form Designer generated code

      /// <summary>
      /// Required method for Designer support - do not modify
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent() {
         this.btnHit = new System.Windows.Forms.Button();
         this.btnStay = new System.Windows.Forms.Button();
         this.btnSuhffle = new System.Windows.Forms.Button();
         this.btnDeal = new System.Windows.Forms.Button();
         this.SuspendLayout();
         // 
         // btnHit
         // 
         this.btnHit.Location = new System.Drawing.Point(485, 571);
         this.btnHit.Name = "btnHit";
         this.btnHit.Size = new System.Drawing.Size(88, 33);
         this.btnHit.TabIndex = 0;
         this.btnHit.Text = "Hit";
         this.btnHit.UseVisualStyleBackColor = true;
         this.btnHit.Click += new System.EventHandler(this.btnHit_Click);
         // 
         // btnStay
         // 
         this.btnStay.Location = new System.Drawing.Point(602, 571);
         this.btnStay.Name = "btnStay";
         this.btnStay.Size = new System.Drawing.Size(88, 33);
         this.btnStay.TabIndex = 1;
         this.btnStay.Text = "Stay";
         this.btnStay.UseVisualStyleBackColor = true;
         this.btnStay.Click += new System.EventHandler(this.btnStay_Click);
         // 
         // btnSuhffle
         // 
         this.btnSuhffle.Location = new System.Drawing.Point(718, 571);
         this.btnSuhffle.Name = "btnSuhffle";
         this.btnSuhffle.Size = new System.Drawing.Size(92, 33);
         this.btnSuhffle.TabIndex = 2;
         this.btnSuhffle.Text = "Shuffle";
         this.btnSuhffle.UseVisualStyleBackColor = true;
         this.btnSuhffle.Click += new System.EventHandler(this.btnSuhffle_Click);
         // 
         // btnDeal
         // 
         this.btnDeal.Enabled = false;
         this.btnDeal.Location = new System.Drawing.Point(537, 268);
         this.btnDeal.Name = "btnDeal";
         this.btnDeal.Size = new System.Drawing.Size(131, 45);
         this.btnDeal.TabIndex = 3;
         this.btnDeal.Text = "Deal";
         this.btnDeal.UseVisualStyleBackColor = true;
         this.btnDeal.Click += new System.EventHandler(this.btnDeal_Click);
         // 
         // BlackJack
         // 
         this.ClientSize = new System.Drawing.Size(1378, 660);
         this.Controls.Add(this.btnDeal);
         this.Controls.Add(this.btnSuhffle);
         this.Controls.Add(this.btnStay);
         this.Controls.Add(this.btnHit);
         this.Name = "BlackJack";
         this.ResumeLayout(false);

      }

      #endregion

 
     
      /// <summary>
      /// create a start layour
      /// </summary>
      /// <param name="aGame"></param>
     private void CreateStartLayout(GameEngine aGame) {
        createStartPlayers(aGame);
        createStartDealer(aGame);
         btnDeal.Enabled = false;
     }
      /// <summary>
      /// Createa start delar with one card faced down.
      /// </summary>
      /// <param name="aGame"></param>
     private void createStartDealer(GameEngine aGame) {
        Int32 imgPositionX = 576;
        Int32 imgPositionY = 33;
        Int32 tempPosX = imgPositionX;
        for(Int32 i = 0; i < 2; i++) {
           Card card = aGame.drawNextCard();
            
           PictureBox pb = getImgBox(tempPosX, imgPositionY, new Guid().ToString());
            if(i % 2 != 0) {
               dealersFaceDown = card;
               delersFaceDownPic = pb;
            }
            addCardToPlayer(pb, card, (i % 2 == 0));
           aGame.Dealer.Hand.addCardToHand(card);
           tempPosX = tempPosX - 25;
           this.Controls.Add(pb);
        }
     }
      /// <summary>
      /// Flips the faced down card.
      /// </summary>
      /// <returns></returns>
      private Card flipDealersCard() {
         Int32 imgPositionX = 576 -25;
         Int32 imgPositionY = 33;
         PictureBox pb = getImgBox(imgPositionX, imgPositionY, new Guid().ToString());
         addCardToPlayer(pb, dealersFaceDown);
         this.Controls.Remove(delersFaceDownPic);
         this.Controls.Add(pb);

         return dealersFaceDown;
      }
      /// <summary>
      /// Hand out two card to each player faced up
      /// </summary>
      /// <param name="aGame"></param>
     private void createStartPlayers(GameEngine aGame) {
        Int32 lblPositionX = 1243;
        Int32 lblPositionY = 400;

        Int32 imgPositionX = 1233;
        Int32 imgPositionY = 420;


        foreach(Player player in aGame.getPlayers()) {
           Label lbl = getLabel(lblPositionX, lblPositionY, "lbl" + player.Name, player.Name);
           this.Controls.Add(lbl);
           Int32 tempPosX = imgPositionX;
           for(Int32 i = 0; i < 2; i++) {
              Card card = aGame.drawNextCard();
              PictureBox pb = getImgBox(tempPosX, imgPositionY, new Guid().ToString());
              addCardToPlayer(pb, card);
              player.Hand.addCardToHand(card);
              tempPosX = tempPosX - 15;
              this.Controls.Add(pb);
           }
           //Label lblScore = getLabel(lblPositionX, lblPositionY + 120, "lblScore" + player.Name, player.Hand.Score.ToString());
           //this.Controls.Add(lblScore);
           lblPositionX = lblPositionX - 200;

           imgPositionX = imgPositionX - 200;


        }
     }
     /// <summary>
     /// Add a card to player to picture box
     /// </summary>
     /// <param name="aPictureBox"></param>
     /// <param name="aCard"></param>
     /// <param name="faceUp"></param>
      private void addCardToPlayer(PictureBox aPictureBox, Card aCard, Boolean faceUp = true) {
         String card = "";
         if(faceUp) {
            Int32 value = (Int32)aCard.Value;
            card = aCard.Suits.ToString().ToLower() + value.ToString() + ".png";
         } else {
            card = "facedown.png";
         }
         aPictureBox.ImageLocation = Path.Combine(Application.StartupPath, "\\img\\" + card);
         aPictureBox.Load(Application.StartupPath + "\\img\\" + card);
      }
      /// <summary>
      /// Gets and creates picturebox
      /// </summary>
      /// <param name="aImgPositionX"></param>
      /// <param name="aImgPositionY"></param>
      /// <param name="aName"></param>
      /// <returns></returns>
      private PictureBox getImgBox(Int32 aImgPositionX, Int32 aImgPositionY, String aName) {
         System.Windows.Forms.PictureBox img = new System.Windows.Forms.PictureBox();
         img.Location = new System.Drawing.Point(aImgPositionX, aImgPositionY);
         img.Name = aName;
         img.Size = new System.Drawing.Size(100, 100);
         img.TabIndex = 1;
         img.TabStop = false;
         return img;
      }
      /// <summary>
      /// Gets and creates label
      /// </summary>
      /// <param name="aLblPositionX"></param>
      /// <param name="aLblPositionY"></param>
      /// <param name="aName"></param>
      /// <param name="aText"></param>
      /// <returns></returns>
      private Label getLabel(Int32 aLblPositionX, Int32 aLblPositionY, String aName, String aText) {
         System.Windows.Forms.Label lbl = new System.Windows.Forms.Label();

         lbl.AutoSize = true;
         lbl.Location = new System.Drawing.Point(aLblPositionX, aLblPositionY);
         lbl.Name = aName;
         lbl.Size = new System.Drawing.Size(50, 17);
         lbl.TabIndex = 0;
         lbl.Text = aText;
         return lbl;
      }

      private Button btnHit;
      private Button btnStay;
      private Button btnSuhffle;
      private Button btnDeal;
   }
}