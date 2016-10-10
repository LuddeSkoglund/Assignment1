namespace GUI {
   partial class Modal {
      /// <summary>
      /// Required designer variable.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

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
         this.lblModalMsg = new System.Windows.Forms.Label();
         this.SuspendLayout();
         // 
         // lblModalMsg
         // 
         this.lblModalMsg.AutoSize = true;
         this.lblModalMsg.Location = new System.Drawing.Point(13, 13);
         this.lblModalMsg.Name = "lblModalMsg";
         this.lblModalMsg.Size = new System.Drawing.Size(46, 17);
         this.lblModalMsg.TabIndex = 0;
         this.lblModalMsg.Text = "label1";
         // 
         // Modal
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(282, 253);
         this.Controls.Add(this.lblModalMsg);
         this.Name = "Modal";
         this.Text = "Modal";
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      public System.Windows.Forms.Label lblModalMsg;


   }
}