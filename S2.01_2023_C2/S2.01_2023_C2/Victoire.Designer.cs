namespace S2._01_2023_C2
{
    partial class Victoire
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Victoire));
            this.labelJoueurGagnant = new System.Windows.Forms.Label();
            this.pictureBoxVictory = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVictory)).BeginInit();
            this.SuspendLayout();
            // 
            // labelJoueurGagnant
            // 
            this.labelJoueurGagnant.AutoSize = true;
            this.labelJoueurGagnant.Font = new System.Drawing.Font("Cooper Black", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelJoueurGagnant.ForeColor = System.Drawing.Color.White;
            this.labelJoueurGagnant.Location = new System.Drawing.Point(111, 289);
            this.labelJoueurGagnant.Name = "labelJoueurGagnant";
            this.labelJoueurGagnant.Size = new System.Drawing.Size(101, 34);
            this.labelJoueurGagnant.TabIndex = 0;
            this.labelJoueurGagnant.Text = "label1";
            // 
            // pictureBoxVictory
            // 
            this.pictureBoxVictory.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxVictory.BackgroundImage")));
            this.pictureBoxVictory.Location = new System.Drawing.Point(101, 12);
            this.pictureBoxVictory.Name = "pictureBoxVictory";
            this.pictureBoxVictory.Size = new System.Drawing.Size(564, 258);
            this.pictureBoxVictory.TabIndex = 1;
            this.pictureBoxVictory.TabStop = false;
            // 
            // Victoire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBoxVictory);
            this.Controls.Add(this.labelJoueurGagnant);
            this.ForeColor = System.Drawing.Color.Coral;
            this.Name = "Victoire";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Victoire";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVictory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelJoueurGagnant;
        private System.Windows.Forms.PictureBox pictureBoxVictory;
    }
}