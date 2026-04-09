namespace ProgEvent_Séance2_25_26
{
    partial class EcranIntegration
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
            lGauche = new Label();
            lDroite = new Label();
            lNbInt = new Label();
            tbGauche = new TextBox();
            tbDroite = new TextBox();
            tbNbInt = new TextBox();
            lbResultats = new ListBox();
            bPolynome = new Button();
            bTrigonometrique = new Button();
            bPointeurPolynome = new Button();
            bPointeurTrigonometrique = new Button();
            SuspendLayout();
            // 
            // lGauche
            // 
            lGauche.AutoSize = true;
            lGauche.Location = new Point(27, 19);
            lGauche.Name = "lGauche";
            lGauche.Size = new Size(58, 20);
            lGauche.TabIndex = 0;
            lGauche.Text = "Gauche";
            // 
            // lDroite
            // 
            lDroite.AutoSize = true;
            lDroite.Location = new Point(180, 19);
            lDroite.Name = "lDroite";
            lDroite.Size = new Size(51, 20);
            lDroite.TabIndex = 1;
            lDroite.Text = "Droite";
            // 
            // lNbInt
            // 
            lNbInt.AutoSize = true;
            lNbInt.Location = new Point(338, 19);
            lNbInt.Name = "lNbInt";
            lNbInt.Size = new Size(100, 20);
            lNbInt.TabIndex = 2;
            lNbInt.Text = "Nb intervalles";
            // 
            // tbGauche
            // 
            tbGauche.Location = new Point(27, 49);
            tbGauche.Name = "tbGauche";
            tbGauche.Size = new Size(125, 27);
            tbGauche.TabIndex = 3;
            // 
            // tbDroite
            // 
            tbDroite.Location = new Point(180, 49);
            tbDroite.Name = "tbDroite";
            tbDroite.Size = new Size(125, 27);
            tbDroite.TabIndex = 4;
            // 
            // tbNbInt
            // 
            tbNbInt.Location = new Point(338, 49);
            tbNbInt.Name = "tbNbInt";
            tbNbInt.Size = new Size(125, 27);
            tbNbInt.TabIndex = 5;
            // 
            // lbResultats
            // 
            lbResultats.FormattingEnabled = true;
            lbResultats.Location = new Point(27, 94);
            lbResultats.Name = "lbResultats";
            lbResultats.Size = new Size(436, 184);
            lbResultats.TabIndex = 6;
            // 
            // bPolynome
            // 
            bPolynome.Location = new Point(27, 298);
            bPolynome.Name = "bPolynome";
            bPolynome.Size = new Size(278, 60);
            bPolynome.TabIndex = 7;
            bPolynome.Text = " Polynôme : X * X + 2";
            bPolynome.UseVisualStyleBackColor = true;
            bPolynome.Click += bPolynome_Click;
            // 
            // bTrigonometrique
            // 
            bTrigonometrique.Location = new Point(27, 366);
            bTrigonometrique.Name = "bTrigonometrique";
            bTrigonometrique.Size = new Size(278, 60);
            bTrigonometrique.TabIndex = 8;
            bTrigonometrique.Text = "Trigonométrique : sin(x)";
            bTrigonometrique.UseVisualStyleBackColor = true;
            bTrigonometrique.Click += bTrigonometrique_Click;
            // 
            // bPointeurPolynome
            // 
            bPointeurPolynome.Location = new Point(311, 298);
            bPointeurPolynome.Name = "bPointeurPolynome";
            bPointeurPolynome.Size = new Size(152, 60);
            bPointeurPolynome.TabIndex = 9;
            bPointeurPolynome.Text = "Idem Pointeur";
            bPointeurPolynome.UseVisualStyleBackColor = true;
            bPointeurPolynome.Click += bPointeurPolynome_Click;
            // 
            // bPointeurTrigonometrique
            // 
            bPointeurTrigonometrique.Location = new Point(311, 364);
            bPointeurTrigonometrique.Name = "bPointeurTrigonometrique";
            bPointeurTrigonometrique.Size = new Size(152, 60);
            bPointeurTrigonometrique.TabIndex = 10;
            bPointeurTrigonometrique.Text = "Idem Pointeur";
            bPointeurTrigonometrique.UseVisualStyleBackColor = true;
            bPointeurTrigonometrique.Click += bPointeurTrigonometrique_Click;
            // 
            // EcranIntegration
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(503, 438);
            Controls.Add(bPointeurTrigonometrique);
            Controls.Add(bPointeurPolynome);
            Controls.Add(bTrigonometrique);
            Controls.Add(bPolynome);
            Controls.Add(lbResultats);
            Controls.Add(tbNbInt);
            Controls.Add(tbDroite);
            Controls.Add(tbGauche);
            Controls.Add(lNbInt);
            Controls.Add(lDroite);
            Controls.Add(lGauche);
            Name = "EcranIntegration";
            Text = "EcranIntegration";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lGauche;
        private Label lDroite;
        private Label lNbInt;
        private TextBox tbGauche;
        private TextBox tbDroite;
        private TextBox tbNbInt;
        private ListBox lbResultats;
        private Button bPolynome;
        private Button bTrigonometrique;
        private Button bPointeurPolynome;
        private Button bPointeurTrigonometrique;
    }
}