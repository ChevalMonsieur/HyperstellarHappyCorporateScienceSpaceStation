namespace S2._01_2023_C2
{
    partial class ChoixNombreJoueur
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChoixNombreJoueur));
            this.texteJoueur = new System.Windows.Forms.Label();
            this.ChoixJoueur2 = new System.Windows.Forms.Button();
            this.choixJoueur3 = new System.Windows.Forms.Button();
            this.choixJoueur4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // texteJoueur
            // 
            this.texteJoueur.AutoSize = true;
            this.texteJoueur.Font = new System.Drawing.Font("Cooper Black", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.texteJoueur.Location = new System.Drawing.Point(40, 27);
            this.texteJoueur.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.texteJoueur.Name = "texteJoueur";
            this.texteJoueur.Size = new System.Drawing.Size(629, 42);
            this.texteJoueur.TabIndex = 0;
            this.texteJoueur.Text = "Choisissez le nombre de joueurs :";
            // 
            // ChoixJoueur2
            // 
            this.ChoixJoueur2.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.ChoixJoueur2.Font = new System.Drawing.Font("Cooper Black", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChoixJoueur2.Location = new System.Drawing.Point(48, 242);
            this.ChoixJoueur2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ChoixJoueur2.Name = "ChoixJoueur2";
            this.ChoixJoueur2.Size = new System.Drawing.Size(159, 66);
            this.ChoixJoueur2.TabIndex = 1;
            this.ChoixJoueur2.Text = "2";
            this.ChoixJoueur2.UseVisualStyleBackColor = true;
            this.ChoixJoueur2.Click += new System.EventHandler(this.ChoixJoueur2_Click);
            // 
            // choixJoueur3
            // 
            this.choixJoueur3.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.choixJoueur3.Font = new System.Drawing.Font("Cooper Black", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.choixJoueur3.Location = new System.Drawing.Point(296, 242);
            this.choixJoueur3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.choixJoueur3.Name = "choixJoueur3";
            this.choixJoueur3.Size = new System.Drawing.Size(156, 66);
            this.choixJoueur3.TabIndex = 2;
            this.choixJoueur3.Text = "3";
            this.choixJoueur3.UseVisualStyleBackColor = true;
            this.choixJoueur3.Click += new System.EventHandler(this.choixJoueur3_Click);
            // 
            // choixJoueur4
            // 
            this.choixJoueur4.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.choixJoueur4.Font = new System.Drawing.Font("Cooper Black", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.choixJoueur4.Location = new System.Drawing.Point(547, 242);
            this.choixJoueur4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.choixJoueur4.Name = "choixJoueur4";
            this.choixJoueur4.Size = new System.Drawing.Size(139, 66);
            this.choixJoueur4.TabIndex = 3;
            this.choixJoueur4.Text = "4";
            this.choixJoueur4.UseVisualStyleBackColor = true;
            this.choixJoueur4.Click += new System.EventHandler(this.choixJoueur4_Click);
            // 
            // ChoixNombreJoueur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(748, 436);
            this.Controls.Add(this.choixJoueur4);
            this.Controls.Add(this.choixJoueur3);
            this.Controls.Add(this.ChoixJoueur2);
            this.Controls.Add(this.texteJoueur);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ChoixNombreJoueur";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChoixNombreJoueur";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label texteJoueur;
        private System.Windows.Forms.Button ChoixJoueur2;
        private System.Windows.Forms.Button choixJoueur3;
        private System.Windows.Forms.Button choixJoueur4;
    }
}