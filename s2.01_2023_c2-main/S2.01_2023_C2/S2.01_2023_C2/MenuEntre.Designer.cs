namespace S2._01_2023_C2
{
    partial class MenuEntre
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuEntre));
            this.jouerButton = new System.Windows.Forms.Button();
            this.QuitterButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // jouerButton
            // 
            this.jouerButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.jouerButton.Font = new System.Drawing.Font("Cooper Black", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jouerButton.Location = new System.Drawing.Point(160, 267);
            this.jouerButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.jouerButton.Name = "jouerButton";
            this.jouerButton.Size = new System.Drawing.Size(407, 71);
            this.jouerButton.TabIndex = 0;
            this.jouerButton.Text = "Jouer";
            this.jouerButton.UseVisualStyleBackColor = true;
            // 
            // QuitterButton
            // 
            this.QuitterButton.DialogResult = System.Windows.Forms.DialogResult.Abort;
            this.QuitterButton.Font = new System.Drawing.Font("Cooper Black", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuitterButton.Location = new System.Drawing.Point(160, 389);
            this.QuitterButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.QuitterButton.Name = "QuitterButton";
            this.QuitterButton.Size = new System.Drawing.Size(407, 71);
            this.QuitterButton.TabIndex = 1;
            this.QuitterButton.Text = "Quitter";
            this.QuitterButton.UseVisualStyleBackColor = true;
            // 
            // MenuEntre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(741, 514);
            this.Controls.Add(this.QuitterButton);
            this.Controls.Add(this.jouerButton);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MenuEntre";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuEntre";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button jouerButton;
        private System.Windows.Forms.Button QuitterButton;
    }
}