namespace blackjack_game
{
    partial class PlayerView
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblMoney = new System.Windows.Forms.Label();
            this.lblKaarten = new System.Windows.Forms.Label();
            this.btnDrawCard = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.lblWinLose = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblMoney
            // 
            this.lblMoney.AutoSize = true;
            this.lblMoney.Location = new System.Drawing.Point(9, 13);
            this.lblMoney.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMoney.Name = "lblMoney";
            this.lblMoney.Size = new System.Drawing.Size(45, 13);
            this.lblMoney.TabIndex = 0;
            this.lblMoney.Text = "Money: ";
            // 
            // lblKaarten
            // 
            this.lblKaarten.AutoSize = true;
            this.lblKaarten.Location = new System.Drawing.Point(129, 13);
            this.lblKaarten.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblKaarten.Name = "lblKaarten";
            this.lblKaarten.Size = new System.Drawing.Size(50, 13);
            this.lblKaarten.TabIndex = 1;
            this.lblKaarten.Text = "Kaarten: ";
            // 
            // btnDrawCard
            // 
            this.btnDrawCard.Location = new System.Drawing.Point(12, 62);
            this.btnDrawCard.Name = "btnDrawCard";
            this.btnDrawCard.Size = new System.Drawing.Size(83, 32);
            this.btnDrawCard.TabIndex = 2;
            this.btnDrawCard.Text = "Draw card";
            this.btnDrawCard.UseVisualStyleBackColor = true;
            this.btnDrawCard.Click += new System.EventHandler(this.btnDrawCard_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(132, 62);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(83, 32);
            this.btnStop.TabIndex = 3;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // lblWinLose
            // 
            this.lblWinLose.AutoSize = true;
            this.lblWinLose.Location = new System.Drawing.Point(12, 122);
            this.lblWinLose.Name = "lblWinLose";
            this.lblWinLose.Size = new System.Drawing.Size(0, 13);
            this.lblWinLose.TabIndex = 4;
            // 
            // PlayerView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblWinLose);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnDrawCard);
            this.Controls.Add(this.lblKaarten);
            this.Controls.Add(this.lblMoney);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "PlayerView";
            this.Size = new System.Drawing.Size(391, 156);
            this.Load += new System.EventHandler(this.PlayerView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMoney;
        private System.Windows.Forms.Label lblKaarten;
        private System.Windows.Forms.Button btnDrawCard;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Label lblWinLose;
    }
}
