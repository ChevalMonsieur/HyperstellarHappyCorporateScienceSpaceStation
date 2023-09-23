namespace S2._01_2023_C2
{
    partial class ChoixCarte
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChoixCarte));
            this.Text = new System.Windows.Forms.Label();
            this.CarteJaune = new System.Windows.Forms.Button();
            this.CarteBleue = new System.Windows.Forms.Button();
            this.CarteRouge = new System.Windows.Forms.Button();
            this.CarteVerte = new System.Windows.Forms.Button();
            this.CarteViolette = new System.Windows.Forms.Button();
            this.CarteNoire = new System.Windows.Forms.Button();
            this.CarteBlanche = new System.Windows.Forms.Button();
            this.CarteGrisee = new System.Windows.Forms.Button();
            this.Echanger = new System.Windows.Forms.Button();
            this.QuitButton = new System.Windows.Forms.Button();
            this.NBJaune = new System.Windows.Forms.Label();
            this.NBBleu = new System.Windows.Forms.Label();
            this.NBRouge = new System.Windows.Forms.Label();
            this.NBVert = new System.Windows.Forms.Label();
            this.NBViolet = new System.Windows.Forms.Label();
            this.NBNoir = new System.Windows.Forms.Label();
            this.NBBlanc = new System.Windows.Forms.Label();
            this.SelectionJaune = new System.Windows.Forms.Label();
            this.SelectionBleu = new System.Windows.Forms.Label();
            this.SelectionRouge = new System.Windows.Forms.Label();
            this.SelectionVert = new System.Windows.Forms.Label();
            this.SelectionBlanc = new System.Windows.Forms.Label();
            this.SelectionViolet = new System.Windows.Forms.Label();
            this.SelectionNoir = new System.Windows.Forms.Label();
            this.ResetButton = new System.Windows.Forms.Button();
            this.PointsVictoire = new System.Windows.Forms.Label();
            this.jetonsEnergie = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Text
            // 
            this.Text.AutoSize = true;
            this.Text.BackColor = System.Drawing.Color.White;
            this.Text.Font = new System.Drawing.Font("Cooper Black", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Text.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Text.Location = new System.Drawing.Point(32, 102);
            this.Text.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Text.MaximumSize = new System.Drawing.Size(3750, 81);
            this.Text.Name = "Text";
            this.Text.Size = new System.Drawing.Size(754, 36);
            this.Text.TabIndex = 7;
            this.Text.Text = "Cliquez sur les cartes pour réaliser les combos";
            // 
            // CarteJaune
            // 
            this.CarteJaune.BackColor = System.Drawing.SystemColors.Control;
            this.CarteJaune.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CarteJaune.Image = ((System.Drawing.Image)(resources.GetObject("CarteJaune.Image")));
            this.CarteJaune.Location = new System.Drawing.Point(38, 186);
            this.CarteJaune.Margin = new System.Windows.Forms.Padding(2);
            this.CarteJaune.Name = "CarteJaune";
            this.CarteJaune.Size = new System.Drawing.Size(104, 158);
            this.CarteJaune.TabIndex = 8;
            this.CarteJaune.UseVisualStyleBackColor = false;
            this.CarteJaune.Click += new System.EventHandler(this.CarteJaune_Click);
            // 
            // CarteBleue
            // 
            this.CarteBleue.Image = ((System.Drawing.Image)(resources.GetObject("CarteBleue.Image")));
            this.CarteBleue.Location = new System.Drawing.Point(169, 186);
            this.CarteBleue.Margin = new System.Windows.Forms.Padding(2);
            this.CarteBleue.Name = "CarteBleue";
            this.CarteBleue.Size = new System.Drawing.Size(101, 158);
            this.CarteBleue.TabIndex = 9;
            this.CarteBleue.UseVisualStyleBackColor = true;
            this.CarteBleue.Click += new System.EventHandler(this.CarteBleue_Click);
            // 
            // CarteRouge
            // 
            this.CarteRouge.Image = ((System.Drawing.Image)(resources.GetObject("CarteRouge.Image")));
            this.CarteRouge.Location = new System.Drawing.Point(300, 186);
            this.CarteRouge.Margin = new System.Windows.Forms.Padding(2);
            this.CarteRouge.Name = "CarteRouge";
            this.CarteRouge.Size = new System.Drawing.Size(101, 158);
            this.CarteRouge.TabIndex = 10;
            this.CarteRouge.UseVisualStyleBackColor = true;
            this.CarteRouge.Click += new System.EventHandler(this.CarteRouge_Click);
            // 
            // CarteVerte
            // 
            this.CarteVerte.Image = ((System.Drawing.Image)(resources.GetObject("CarteVerte.Image")));
            this.CarteVerte.Location = new System.Drawing.Point(436, 186);
            this.CarteVerte.Margin = new System.Windows.Forms.Padding(2);
            this.CarteVerte.Name = "CarteVerte";
            this.CarteVerte.Size = new System.Drawing.Size(104, 158);
            this.CarteVerte.TabIndex = 11;
            this.CarteVerte.UseVisualStyleBackColor = true;
            this.CarteVerte.Click += new System.EventHandler(this.CarteVerte_Click);
            // 
            // CarteViolette
            // 
            this.CarteViolette.Image = ((System.Drawing.Image)(resources.GetObject("CarteViolette.Image")));
            this.CarteViolette.Location = new System.Drawing.Point(574, 186);
            this.CarteViolette.Margin = new System.Windows.Forms.Padding(2);
            this.CarteViolette.Name = "CarteViolette";
            this.CarteViolette.Size = new System.Drawing.Size(100, 158);
            this.CarteViolette.TabIndex = 12;
            this.CarteViolette.UseVisualStyleBackColor = true;
            this.CarteViolette.Click += new System.EventHandler(this.CarteViolette_Click);
            // 
            // CarteNoire
            // 
            this.CarteNoire.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CarteNoire.Image = ((System.Drawing.Image)(resources.GetObject("CarteNoire.Image")));
            this.CarteNoire.Location = new System.Drawing.Point(710, 186);
            this.CarteNoire.Margin = new System.Windows.Forms.Padding(2);
            this.CarteNoire.Name = "CarteNoire";
            this.CarteNoire.Size = new System.Drawing.Size(100, 158);
            this.CarteNoire.TabIndex = 13;
            this.CarteNoire.UseVisualStyleBackColor = true;
            this.CarteNoire.Click += new System.EventHandler(this.CarteNoire_Click);
            // 
            // CarteBlanche
            // 
            this.CarteBlanche.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.CarteBlanche.Image = ((System.Drawing.Image)(resources.GetObject("CarteBlanche.Image")));
            this.CarteBlanche.Location = new System.Drawing.Point(844, 186);
            this.CarteBlanche.Margin = new System.Windows.Forms.Padding(2);
            this.CarteBlanche.Name = "CarteBlanche";
            this.CarteBlanche.Size = new System.Drawing.Size(99, 158);
            this.CarteBlanche.TabIndex = 14;
            this.CarteBlanche.UseVisualStyleBackColor = true;
            this.CarteBlanche.Click += new System.EventHandler(this.CarteBlanche_Click);
            // 
            // CarteGrisee
            // 
            this.CarteGrisee.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.CarteGrisee.Image = ((System.Drawing.Image)(resources.GetObject("CarteGrisee.Image")));
            this.CarteGrisee.Location = new System.Drawing.Point(742, -131);
            this.CarteGrisee.Margin = new System.Windows.Forms.Padding(2);
            this.CarteGrisee.Name = "CarteGrisee";
            this.CarteGrisee.Size = new System.Drawing.Size(99, 158);
            this.CarteGrisee.TabIndex = 15;
            this.CarteGrisee.UseVisualStyleBackColor = true;
            // 
            // Echanger
            // 
            this.Echanger.Font = new System.Drawing.Font("Cooper Black", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Echanger.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Echanger.Location = new System.Drawing.Point(38, 426);
            this.Echanger.Margin = new System.Windows.Forms.Padding(2);
            this.Echanger.Name = "Echanger";
            this.Echanger.Size = new System.Drawing.Size(122, 58);
            this.Echanger.TabIndex = 16;
            this.Echanger.Text = "Echanger";
            this.Echanger.UseVisualStyleBackColor = true;
            this.Echanger.Click += new System.EventHandler(this.Echanger_Click);
            // 
            // QuitButton
            // 
            this.QuitButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.QuitButton.Font = new System.Drawing.Font("Cooper Black", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuitButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.QuitButton.Location = new System.Drawing.Point(844, 426);
            this.QuitButton.Margin = new System.Windows.Forms.Padding(2);
            this.QuitButton.Name = "QuitButton";
            this.QuitButton.Size = new System.Drawing.Size(99, 58);
            this.QuitButton.TabIndex = 17;
            this.QuitButton.Text = "Quitter";
            this.QuitButton.UseVisualStyleBackColor = true;
            // 
            // NBJaune
            // 
            this.NBJaune.AutoSize = true;
            this.NBJaune.Font = new System.Drawing.Font("Cooper Black", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NBJaune.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.NBJaune.Location = new System.Drawing.Point(84, 168);
            this.NBJaune.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.NBJaune.Name = "NBJaune";
            this.NBJaune.Size = new System.Drawing.Size(17, 17);
            this.NBJaune.TabIndex = 18;
            this.NBJaune.Text = "0";
            // 
            // NBBleu
            // 
            this.NBBleu.AutoSize = true;
            this.NBBleu.Font = new System.Drawing.Font("Cooper Black", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NBBleu.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.NBBleu.Location = new System.Drawing.Point(213, 168);
            this.NBBleu.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.NBBleu.Name = "NBBleu";
            this.NBBleu.Size = new System.Drawing.Size(17, 17);
            this.NBBleu.TabIndex = 19;
            this.NBBleu.Text = "0";
            // 
            // NBRouge
            // 
            this.NBRouge.AutoSize = true;
            this.NBRouge.Font = new System.Drawing.Font("Cooper Black", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NBRouge.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.NBRouge.Location = new System.Drawing.Point(344, 168);
            this.NBRouge.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.NBRouge.Name = "NBRouge";
            this.NBRouge.Size = new System.Drawing.Size(17, 17);
            this.NBRouge.TabIndex = 20;
            this.NBRouge.Text = "0";
            // 
            // NBVert
            // 
            this.NBVert.AutoSize = true;
            this.NBVert.Font = new System.Drawing.Font("Cooper Black", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NBVert.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.NBVert.Location = new System.Drawing.Point(481, 168);
            this.NBVert.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.NBVert.Name = "NBVert";
            this.NBVert.Size = new System.Drawing.Size(17, 17);
            this.NBVert.TabIndex = 21;
            this.NBVert.Text = "0";
            // 
            // NBViolet
            // 
            this.NBViolet.AutoSize = true;
            this.NBViolet.Font = new System.Drawing.Font("Cooper Black", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NBViolet.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.NBViolet.Location = new System.Drawing.Point(616, 168);
            this.NBViolet.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.NBViolet.Name = "NBViolet";
            this.NBViolet.Size = new System.Drawing.Size(17, 17);
            this.NBViolet.TabIndex = 22;
            this.NBViolet.Text = "0";
            // 
            // NBNoir
            // 
            this.NBNoir.AutoSize = true;
            this.NBNoir.Font = new System.Drawing.Font("Cooper Black", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NBNoir.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.NBNoir.Location = new System.Drawing.Point(752, 168);
            this.NBNoir.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.NBNoir.Name = "NBNoir";
            this.NBNoir.Size = new System.Drawing.Size(17, 17);
            this.NBNoir.TabIndex = 23;
            this.NBNoir.Text = "0";
            // 
            // NBBlanc
            // 
            this.NBBlanc.AutoSize = true;
            this.NBBlanc.Font = new System.Drawing.Font("Cooper Black", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NBBlanc.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.NBBlanc.Location = new System.Drawing.Point(886, 168);
            this.NBBlanc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.NBBlanc.Name = "NBBlanc";
            this.NBBlanc.Size = new System.Drawing.Size(17, 17);
            this.NBBlanc.TabIndex = 24;
            this.NBBlanc.Text = "0";
            // 
            // SelectionJaune
            // 
            this.SelectionJaune.AutoSize = true;
            this.SelectionJaune.Font = new System.Drawing.Font("Cooper Black", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectionJaune.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.SelectionJaune.Location = new System.Drawing.Point(31, 347);
            this.SelectionJaune.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SelectionJaune.Name = "SelectionJaune";
            this.SelectionJaune.Size = new System.Drawing.Size(76, 14);
            this.SelectionJaune.TabIndex = 25;
            this.SelectionJaune.Text = "Séléctionné";
            // 
            // SelectionBleu
            // 
            this.SelectionBleu.AutoSize = true;
            this.SelectionBleu.Font = new System.Drawing.Font("Cooper Black", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectionBleu.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.SelectionBleu.Location = new System.Drawing.Point(160, 347);
            this.SelectionBleu.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SelectionBleu.Name = "SelectionBleu";
            this.SelectionBleu.Size = new System.Drawing.Size(76, 14);
            this.SelectionBleu.TabIndex = 26;
            this.SelectionBleu.Text = "Séléctionné";
            // 
            // SelectionRouge
            // 
            this.SelectionRouge.AutoSize = true;
            this.SelectionRouge.Font = new System.Drawing.Font("Cooper Black", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectionRouge.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.SelectionRouge.Location = new System.Drawing.Point(290, 347);
            this.SelectionRouge.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SelectionRouge.Name = "SelectionRouge";
            this.SelectionRouge.Size = new System.Drawing.Size(76, 14);
            this.SelectionRouge.TabIndex = 27;
            this.SelectionRouge.Text = "Séléctionné";
            // 
            // SelectionVert
            // 
            this.SelectionVert.AutoSize = true;
            this.SelectionVert.Font = new System.Drawing.Font("Cooper Black", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectionVert.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.SelectionVert.Location = new System.Drawing.Point(428, 347);
            this.SelectionVert.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SelectionVert.Name = "SelectionVert";
            this.SelectionVert.Size = new System.Drawing.Size(76, 14);
            this.SelectionVert.TabIndex = 28;
            this.SelectionVert.Text = "Séléctionné";
            // 
            // SelectionBlanc
            // 
            this.SelectionBlanc.AutoSize = true;
            this.SelectionBlanc.Font = new System.Drawing.Font("Cooper Black", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectionBlanc.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.SelectionBlanc.Location = new System.Drawing.Point(838, 347);
            this.SelectionBlanc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SelectionBlanc.Name = "SelectionBlanc";
            this.SelectionBlanc.Size = new System.Drawing.Size(76, 14);
            this.SelectionBlanc.TabIndex = 29;
            this.SelectionBlanc.Text = "Séléctionné";
            // 
            // SelectionViolet
            // 
            this.SelectionViolet.AutoSize = true;
            this.SelectionViolet.Font = new System.Drawing.Font("Cooper Black", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectionViolet.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.SelectionViolet.Location = new System.Drawing.Point(566, 347);
            this.SelectionViolet.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SelectionViolet.Name = "SelectionViolet";
            this.SelectionViolet.Size = new System.Drawing.Size(76, 14);
            this.SelectionViolet.TabIndex = 29;
            this.SelectionViolet.Text = "Séléctionné";
            // 
            // SelectionNoir
            // 
            this.SelectionNoir.AutoSize = true;
            this.SelectionNoir.Font = new System.Drawing.Font("Cooper Black", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectionNoir.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.SelectionNoir.Location = new System.Drawing.Point(703, 347);
            this.SelectionNoir.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SelectionNoir.Name = "SelectionNoir";
            this.SelectionNoir.Size = new System.Drawing.Size(76, 14);
            this.SelectionNoir.TabIndex = 30;
            this.SelectionNoir.Text = "Séléctionné";
            // 
            // ResetButton
            // 
            this.ResetButton.Font = new System.Drawing.Font("Cooper Black", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResetButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ResetButton.Location = new System.Drawing.Point(172, 426);
            this.ResetButton.Margin = new System.Windows.Forms.Padding(2);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(104, 58);
            this.ResetButton.TabIndex = 31;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // PointsVictoire
            // 
            this.PointsVictoire.AutoSize = true;
            this.PointsVictoire.Font = new System.Drawing.Font("Cooper Black", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PointsVictoire.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.PointsVictoire.Location = new System.Drawing.Point(31, 36);
            this.PointsVictoire.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PointsVictoire.Name = "PointsVictoire";
            this.PointsVictoire.Size = new System.Drawing.Size(141, 17);
            this.PointsVictoire.TabIndex = 32;
            this.PointsVictoire.Text = "points victoire : x";
            // 
            // jetonsEnergie
            // 
            this.jetonsEnergie.AutoSize = true;
            this.jetonsEnergie.Font = new System.Drawing.Font("Cooper Black", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jetonsEnergie.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.jetonsEnergie.Location = new System.Drawing.Point(31, 67);
            this.jetonsEnergie.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.jetonsEnergie.Name = "jetonsEnergie";
            this.jetonsEnergie.Size = new System.Drawing.Size(143, 17);
            this.jetonsEnergie.TabIndex = 33;
            this.jetonsEnergie.Text = "jetons energies : x";
            // 
            // ChoixCarte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(984, 527);
            this.Controls.Add(this.jetonsEnergie);
            this.Controls.Add(this.PointsVictoire);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.SelectionNoir);
            this.Controls.Add(this.SelectionViolet);
            this.Controls.Add(this.SelectionBlanc);
            this.Controls.Add(this.SelectionVert);
            this.Controls.Add(this.SelectionRouge);
            this.Controls.Add(this.SelectionBleu);
            this.Controls.Add(this.SelectionJaune);
            this.Controls.Add(this.NBBlanc);
            this.Controls.Add(this.NBNoir);
            this.Controls.Add(this.NBViolet);
            this.Controls.Add(this.NBVert);
            this.Controls.Add(this.NBRouge);
            this.Controls.Add(this.NBBleu);
            this.Controls.Add(this.NBJaune);
            this.Controls.Add(this.QuitButton);
            this.Controls.Add(this.Echanger);
            this.Controls.Add(this.CarteGrisee);
            this.Controls.Add(this.CarteBlanche);
            this.Controls.Add(this.CarteNoire);
            this.Controls.Add(this.CarteViolette);
            this.Controls.Add(this.CarteVerte);
            this.Controls.Add(this.CarteRouge);
            this.Controls.Add(this.CarteBleue);
            this.Controls.Add(this.CarteJaune);
            this.Controls.Add(this.Text);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ChoixCarte";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Text;
        private System.Windows.Forms.Button CarteJaune;
        private System.Windows.Forms.Button CarteBleue;
        private System.Windows.Forms.Button CarteRouge;
        private System.Windows.Forms.Button CarteVerte;
        private System.Windows.Forms.Button CarteViolette;
        private System.Windows.Forms.Button CarteNoire;
        private System.Windows.Forms.Button CarteBlanche;
        private System.Windows.Forms.Button CarteGrisee;
        private System.Windows.Forms.Button Echanger;
        private System.Windows.Forms.Button QuitButton;
        private System.Windows.Forms.Label NBJaune;
        private System.Windows.Forms.Label NBBleu;
        private System.Windows.Forms.Label NBRouge;
        private System.Windows.Forms.Label NBVert;
        private System.Windows.Forms.Label NBViolet;
        private System.Windows.Forms.Label NBNoir;
        private System.Windows.Forms.Label NBBlanc;
        private System.Windows.Forms.Label SelectionJaune;
        private System.Windows.Forms.Label SelectionBleu;
        private System.Windows.Forms.Label SelectionRouge;
        private System.Windows.Forms.Label SelectionVert;
        private System.Windows.Forms.Label SelectionBlanc;
        private System.Windows.Forms.Label SelectionViolet;
        private System.Windows.Forms.Label SelectionNoir;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.Label PointsVictoire;
        private System.Windows.Forms.Label jetonsEnergie;
    }
}