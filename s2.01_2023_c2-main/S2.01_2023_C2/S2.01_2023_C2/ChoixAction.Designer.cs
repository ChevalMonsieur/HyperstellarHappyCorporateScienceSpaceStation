namespace S2._01_2023_C2
{
    partial class ChoixAction
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChoixAction));
            this.buttonRefuser = new System.Windows.Forms.Button();
            this.buttonAccepter1 = new System.Windows.Forms.Button();
            this.LabelChoix1 = new System.Windows.Forms.Label();
            this.buttonAccepter2 = new System.Windows.Forms.Button();
            this.LabelChoix2 = new System.Windows.Forms.Label();
            this.Titre = new System.Windows.Forms.Label();
            this.labelTypeSecteur = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonRefuser
            // 
            this.buttonRefuser.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonRefuser.Font = new System.Drawing.Font("Cooper Black", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRefuser.Location = new System.Drawing.Point(12, 334);
            this.buttonRefuser.Name = "buttonRefuser";
            this.buttonRefuser.Size = new System.Drawing.Size(222, 41);
            this.buttonRefuser.TabIndex = 0;
            this.buttonRefuser.Text = "N\'accepter aucun bonus";
            this.buttonRefuser.UseVisualStyleBackColor = true;
            // 
            // buttonAccepter1
            // 
            this.buttonAccepter1.Font = new System.Drawing.Font("Cooper Black", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAccepter1.Location = new System.Drawing.Point(328, 186);
            this.buttonAccepter1.Name = "buttonAccepter1";
            this.buttonAccepter1.Size = new System.Drawing.Size(75, 41);
            this.buttonAccepter1.TabIndex = 1;
            this.buttonAccepter1.Text = "Accepter Bonus 1";
            this.buttonAccepter1.UseVisualStyleBackColor = true;
            this.buttonAccepter1.Click += new System.EventHandler(this.ButtonAccepter1_Click);
            // 
            // LabelChoix1
            // 
            this.LabelChoix1.AutoSize = true;
            this.LabelChoix1.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelChoix1.Location = new System.Drawing.Point(46, 143);
            this.LabelChoix1.Name = "LabelChoix1";
            this.LabelChoix1.Size = new System.Drawing.Size(58, 19);
            this.LabelChoix1.TabIndex = 2;
            this.LabelChoix1.Text = "label1";
            // 
            // buttonAccepter2
            // 
            this.buttonAccepter2.Font = new System.Drawing.Font("Cooper Black", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAccepter2.Location = new System.Drawing.Point(328, 294);
            this.buttonAccepter2.Name = "buttonAccepter2";
            this.buttonAccepter2.Size = new System.Drawing.Size(75, 41);
            this.buttonAccepter2.TabIndex = 3;
            this.buttonAccepter2.Text = "Accepter Bonus 2";
            this.buttonAccepter2.UseVisualStyleBackColor = true;
            this.buttonAccepter2.Click += new System.EventHandler(this.ButtonAccepter2_Click);
            // 
            // LabelChoix2
            // 
            this.LabelChoix2.AutoSize = true;
            this.LabelChoix2.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelChoix2.Location = new System.Drawing.Point(46, 255);
            this.LabelChoix2.Name = "LabelChoix2";
            this.LabelChoix2.Size = new System.Drawing.Size(58, 19);
            this.LabelChoix2.TabIndex = 4;
            this.LabelChoix2.Text = "label2";
            // 
            // Titre
            // 
            this.Titre.AutoSize = true;
            this.Titre.Font = new System.Drawing.Font("Cooper Black", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titre.ForeColor = System.Drawing.Color.White;
            this.Titre.Location = new System.Drawing.Point(110, 23);
            this.Titre.Name = "Titre";
            this.Titre.Size = new System.Drawing.Size(502, 31);
            this.Titre.TabIndex = 5;
            this.Titre.Text = "Joueur 1 veuillez faire un choix sur \r\n";
            // 
            // labelTypeSecteur
            // 
            this.labelTypeSecteur.AutoSize = true;
            this.labelTypeSecteur.Font = new System.Drawing.Font("Cooper Black", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTypeSecteur.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.labelTypeSecteur.Location = new System.Drawing.Point(218, 54);
            this.labelTypeSecteur.Name = "labelTypeSecteur";
            this.labelTypeSecteur.Size = new System.Drawing.Size(128, 34);
            this.labelTypeSecteur.TabIndex = 6;
            this.labelTypeSecteur.Text = "Secteur";
            // 
            // ChoixAction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(727, 400);
            this.Controls.Add(this.labelTypeSecteur);
            this.Controls.Add(this.Titre);
            this.Controls.Add(this.LabelChoix2);
            this.Controls.Add(this.buttonAccepter2);
            this.Controls.Add(this.LabelChoix1);
            this.Controls.Add(this.buttonAccepter1);
            this.Controls.Add(this.buttonRefuser);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ChoixAction";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChoixAction";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonRefuser;
        private System.Windows.Forms.Button buttonAccepter1;
        private System.Windows.Forms.Label LabelChoix1;
        private System.Windows.Forms.Button buttonAccepter2;
        private System.Windows.Forms.Label LabelChoix2;
        private System.Windows.Forms.Label Titre;
        private System.Windows.Forms.Label labelTypeSecteur;
    }
}