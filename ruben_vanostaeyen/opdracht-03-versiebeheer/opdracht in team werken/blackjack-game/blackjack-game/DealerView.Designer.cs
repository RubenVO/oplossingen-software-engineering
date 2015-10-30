namespace blackjack_game
{
    partial class DealerView
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
            this.lblDealerCards = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblDealerCards
            // 
            this.lblDealerCards.AutoSize = true;
            this.lblDealerCards.Location = new System.Drawing.Point(14, 13);
            this.lblDealerCards.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDealerCards.Name = "lblDealerCards";
            this.lblDealerCards.Size = new System.Drawing.Size(80, 13);
            this.lblDealerCards.TabIndex = 0;
            this.lblDealerCards.Text = "Dealer kaarten:";
            this.lblDealerCards.Click += new System.EventHandler(this.lblDealerCards_Click);
            // 
            // DealerView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblDealerCards);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "DealerView";
            this.Size = new System.Drawing.Size(281, 59);
            this.Load += new System.EventHandler(this.DealerView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDealerCards;
    }
}
