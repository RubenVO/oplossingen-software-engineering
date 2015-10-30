namespace YahtzeeTeerling
{
    partial class allemaalView
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
            this.allemaalButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // allemaalButton
            // 
            this.allemaalButton.Location = new System.Drawing.Point(3, 3);
            this.allemaalButton.Name = "allemaalButton";
            this.allemaalButton.Size = new System.Drawing.Size(131, 31);
            this.allemaalButton.TabIndex = 0;
            this.allemaalButton.Text = "Allemaal werpen!";
            this.allemaalButton.UseVisualStyleBackColor = true;
            this.allemaalButton.Click += new System.EventHandler(this.allemaalButton_Click);
            // 
            // allemaalView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.allemaalButton);
            this.Name = "allemaalView";
            this.Size = new System.Drawing.Size(138, 40);
            this.Load += new System.EventHandler(this.allemaalView_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button allemaalButton;
    }
}
