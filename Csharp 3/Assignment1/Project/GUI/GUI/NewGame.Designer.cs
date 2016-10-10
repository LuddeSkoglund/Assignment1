namespace GUI
{
    partial class NewGame
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
         this.blackJackTitle = new System.Windows.Forms.Label();
         this.lblPlayer1 = new System.Windows.Forms.Label();
         this.lblDecks = new System.Windows.Forms.Label();
         this.txtPlayer1 = new System.Windows.Forms.TextBox();
         this.txtDecks = new System.Windows.Forms.TextBox();
         this.btnStartGame = new System.Windows.Forms.Button();
         this.txtPlayer2 = new System.Windows.Forms.TextBox();
         this.lblPlayer2 = new System.Windows.Forms.Label();
         this.txtPlayer3 = new System.Windows.Forms.TextBox();
         this.lblPlayer3 = new System.Windows.Forms.Label();
         this.txtPlayer4 = new System.Windows.Forms.TextBox();
         this.lblPlayer4 = new System.Windows.Forms.Label();
         this.SuspendLayout();
         // 
         // blackJackTitle
         // 
         this.blackJackTitle.AccessibleRole = System.Windows.Forms.AccessibleRole.Clock;
         this.blackJackTitle.AutoSize = true;
         this.blackJackTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.blackJackTitle.Location = new System.Drawing.Point(55, 9);
         this.blackJackTitle.Name = "blackJackTitle";
         this.blackJackTitle.Size = new System.Drawing.Size(413, 58);
         this.blackJackTitle.TabIndex = 0;
         this.blackJackTitle.Text = "Black Jack Game";
         // 
         // lblPlayer1
         // 
         this.lblPlayer1.AutoSize = true;
         this.lblPlayer1.Location = new System.Drawing.Point(34, 99);
         this.lblPlayer1.Name = "lblPlayer1";
         this.lblPlayer1.Size = new System.Drawing.Size(60, 17);
         this.lblPlayer1.TabIndex = 1;
         this.lblPlayer1.Text = "Player 1";
         // 
         // lblDecks
         // 
         this.lblDecks.AutoSize = true;
         this.lblDecks.Location = new System.Drawing.Point(34, 271);
         this.lblDecks.Name = "lblDecks";
         this.lblDecks.Size = new System.Drawing.Size(47, 17);
         this.lblDecks.TabIndex = 2;
         this.lblDecks.Text = "Decks";
         // 
         // txtPlayer1
         // 
         this.txtPlayer1.Location = new System.Drawing.Point(107, 99);
         this.txtPlayer1.Name = "txtPlayer1";
         this.txtPlayer1.Size = new System.Drawing.Size(144, 22);
         this.txtPlayer1.TabIndex = 3;
         // 
         // txtDecks
         // 
         this.txtDecks.Location = new System.Drawing.Point(100, 271);
         this.txtDecks.Name = "txtDecks";
         this.txtDecks.Size = new System.Drawing.Size(34, 22);
         this.txtDecks.TabIndex = 4;
         this.txtDecks.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDecks_KeyPress);
         // 
         // btnStartGame
         // 
         this.btnStartGame.Location = new System.Drawing.Point(37, 309);
         this.btnStartGame.Name = "btnStartGame";
         this.btnStartGame.Size = new System.Drawing.Size(97, 33);
         this.btnStartGame.TabIndex = 5;
         this.btnStartGame.Text = "Start game";
         this.btnStartGame.UseVisualStyleBackColor = true;
         this.btnStartGame.Click += new System.EventHandler(this.btnStartGame_Click);
         // 
         // txtPlayer2
         // 
         this.txtPlayer2.Location = new System.Drawing.Point(107, 127);
         this.txtPlayer2.Name = "txtPlayer2";
         this.txtPlayer2.Size = new System.Drawing.Size(144, 22);
         this.txtPlayer2.TabIndex = 7;
         // 
         // lblPlayer2
         // 
         this.lblPlayer2.AutoSize = true;
         this.lblPlayer2.Location = new System.Drawing.Point(34, 127);
         this.lblPlayer2.Name = "lblPlayer2";
         this.lblPlayer2.Size = new System.Drawing.Size(60, 17);
         this.lblPlayer2.TabIndex = 6;
         this.lblPlayer2.Text = "Player 2";
         // 
         // txtPlayer3
         // 
         this.txtPlayer3.Location = new System.Drawing.Point(107, 155);
         this.txtPlayer3.Name = "txtPlayer3";
         this.txtPlayer3.Size = new System.Drawing.Size(144, 22);
         this.txtPlayer3.TabIndex = 9;
         // 
         // lblPlayer3
         // 
         this.lblPlayer3.AutoSize = true;
         this.lblPlayer3.Location = new System.Drawing.Point(34, 155);
         this.lblPlayer3.Name = "lblPlayer3";
         this.lblPlayer3.Size = new System.Drawing.Size(60, 17);
         this.lblPlayer3.TabIndex = 8;
         this.lblPlayer3.Text = "Player 3";
         // 
         // txtPlayer4
         // 
         this.txtPlayer4.Location = new System.Drawing.Point(107, 183);
         this.txtPlayer4.Name = "txtPlayer4";
         this.txtPlayer4.Size = new System.Drawing.Size(144, 22);
         this.txtPlayer4.TabIndex = 11;
         // 
         // lblPlayer4
         // 
         this.lblPlayer4.AutoSize = true;
         this.lblPlayer4.Location = new System.Drawing.Point(34, 183);
         this.lblPlayer4.Name = "lblPlayer4";
         this.lblPlayer4.Size = new System.Drawing.Size(60, 17);
         this.lblPlayer4.TabIndex = 10;
         this.lblPlayer4.Text = "Player 4";
         // 
         // NewGame
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(518, 441);
         this.Controls.Add(this.txtPlayer4);
         this.Controls.Add(this.lblPlayer4);
         this.Controls.Add(this.txtPlayer3);
         this.Controls.Add(this.lblPlayer3);
         this.Controls.Add(this.txtPlayer2);
         this.Controls.Add(this.lblPlayer2);
         this.Controls.Add(this.btnStartGame);
         this.Controls.Add(this.txtDecks);
         this.Controls.Add(this.txtPlayer1);
         this.Controls.Add(this.lblDecks);
         this.Controls.Add(this.lblPlayer1);
         this.Controls.Add(this.blackJackTitle);
         this.Name = "NewGame";
         this.Text = "New Game";
         this.Load += new System.EventHandler(this.NewGame_Load);
         this.ResumeLayout(false);
         this.PerformLayout();

        }

      #endregion

      private System.Windows.Forms.Label blackJackTitle;
      private System.Windows.Forms.Label lblPlayer1;
      private System.Windows.Forms.Label lblDecks;
      private System.Windows.Forms.TextBox txtPlayer1;
      private System.Windows.Forms.TextBox txtDecks;
      private System.Windows.Forms.Button btnStartGame;
      private System.Windows.Forms.TextBox txtPlayer2;
      private System.Windows.Forms.Label lblPlayer2;
      private System.Windows.Forms.TextBox txtPlayer3;
      private System.Windows.Forms.Label lblPlayer3;
      private System.Windows.Forms.TextBox txtPlayer4;
      private System.Windows.Forms.Label lblPlayer4;
   }
}

