namespace blackjack_game
{
    partial class PlayerBetView
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
            this.btnBet = new System.Windows.Forms.Button();
            this.txtBetMoney = new System.Windows.Forms.TextBox();
            this.lblBetMoney = new System.Windows.Forms.Label();
            this.lblMoneyPot = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnBet
            // 
            this.btnBet.Location = new System.Drawing.Point(34, 120);
            this.btnBet.Name = "btnBet";
            this.btnBet.Size = new System.Drawing.Size(247, 63);
            this.btnBet.TabIndex = 0;
            this.btnBet.Text = "Bet!";
            this.btnBet.UseVisualStyleBackColor = true;
            this.btnBet.Click += new System.EventHandler(this.btnBet_Click);
            // 
            // txtBetMoney
            // 
            this.txtBetMoney.Location = new System.Drawing.Point(34, 59);
            this.txtBetMoney.Name = "txtBetMoney";
            this.txtBetMoney.Size = new System.Drawing.Size(247, 31);
            this.txtBetMoney.TabIndex = 1;
            this.txtBetMoney.Click += new System.EventHandler(this.txtBetMoney_Click);
            // 
            // lblBetMoney
            // 
            this.lblBetMoney.AutoSize = true;
            this.lblBetMoney.Location = new System.Drawing.Point(29, 31);
            this.lblBetMoney.Name = "lblBetMoney";
            this.lblBetMoney.Size = new System.Drawing.Size(120, 25);
            this.lblBetMoney.TabIndex = 2;
            this.lblBetMoney.Text = "Bet money:";
            // 
            // lblMoneyPot
            // 
            this.lblMoneyPot.AutoSize = true;
            this.lblMoneyPot.Location = new System.Drawing.Point(364, 65);
            this.lblMoneyPot.Name = "lblMoneyPot";
            this.lblMoneyPot.Size = new System.Drawing.Size(148, 25);
            this.lblMoneyPot.TabIndex = 3;
            this.lblMoneyPot.Text = "Money in pot: ";
            // 
            // PlayerBetView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblMoneyPot);
            this.Controls.Add(this.lblBetMoney);
            this.Controls.Add(this.txtBetMoney);
            this.Controls.Add(this.btnBet);
            this.Name = "PlayerBetView";
            this.Size = new System.Drawing.Size(656, 240);
            this.Load += new System.EventHandler(this.PlayerBetView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBet;
        private System.Windows.Forms.TextBox txtBetMoney;
        private System.Windows.Forms.Label lblBetMoney;
        private System.Windows.Forms.Label lblMoneyPot;
    }
}
