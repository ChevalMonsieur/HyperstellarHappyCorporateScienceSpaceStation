namespace S2._01_2023_C2
{
    partial class defaite
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(defaite));
            this.labelDefaite = new System.Windows.Forms.Label();
            this.pictureBoxDefaite = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDefaite)).BeginInit();
            this.SuspendLayout();
            // 
            // labelDefaite
            // 
            this.labelDefaite.AutoSize = true;
            this.labelDefaite.Font = new System.Drawing.Font("Cooper Black", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDefaite.Location = new System.Drawing.Point(22, 370);
            this.labelDefaite.Name = "labelDefaite";
            this.labelDefaite.Size = new System.Drawing.Size(73, 24);
            this.labelDefaite.TabIndex = 0;
            this.labelDefaite.Text = "label1";
            // 
            // pictureBoxDefaite
            // 
            this.pictureBoxDefaite.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxDefaite.BackgroundImage")));
            this.pictureBoxDefaite.Location = new System.Drawing.Point(103, 31);
            this.pictureBoxDefaite.Name = "pictureBoxDefaite";
            this.pictureBoxDefaite.Size = new System.Drawing.Size(548, 254);
            this.pictureBoxDefaite.TabIndex = 1;
            this.pictureBoxDefaite.TabStop = false;
            // 
            // defaite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBoxDefaite);
            this.Controls.Add(this.labelDefaite);
            this.Name = "defaite";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "defaite";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDefaite)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelDefaite;
        private System.Windows.Forms.PictureBox pictureBoxDefaite;
    }
}