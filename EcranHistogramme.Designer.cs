namespace ProgEvent_Séance2_25_26
{
    partial class EcranHistogramme
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
            lbMonPoint = new ListBox();
            bCreer = new Mes_Controles.BoutonColore();
            bDessiner = new Mes_Controles.BoutonColore();
            controleHistogramme1 = new Mes_Controles.ControleHistogramme();
            SuspendLayout();
            // 
            // lbMonPoint
            // 
            lbMonPoint.FormattingEnabled = true;
            lbMonPoint.Location = new Point(383, 75);
            lbMonPoint.Name = "lbMonPoint";
            lbMonPoint.Size = new Size(150, 264);
            lbMonPoint.TabIndex = 0;
            // 
            // bCreer
            // 
            bCreer.CouleurDroite = Color.DarkBlue;
            bCreer.CouleurGauche = Color.LightGreen;
            bCreer.Location = new Point(12, 30);
            bCreer.Name = "bCreer";
            bCreer.Size = new Size(150, 39);
            bCreer.TabIndex = 3;
            bCreer.Text = "Créer";
            bCreer.TransparenceDroite = 64;
            bCreer.TransparenceGauche = 64;
            bCreer.UseVisualStyleBackColor = true;
            bCreer.Click += bCreer_Click;
            // 
            // bDessiner
            // 
            bDessiner.CouleurDroite = Color.MidnightBlue;
            bDessiner.CouleurGauche = Color.Indigo;
            bDessiner.Location = new Point(383, 30);
            bDessiner.Name = "bDessiner";
            bDessiner.Size = new Size(150, 39);
            bDessiner.TabIndex = 4;
            bDessiner.Text = "Dessiner";
            bDessiner.TransparenceDroite = 64;
            bDessiner.TransparenceGauche = 64;
            bDessiner.UseVisualStyleBackColor = true;
            bDessiner.Click += bDessiner_Click;
            // 
            // controleHistogramme1
            // 
            controleHistogramme1.BackColor = Color.White;
            controleHistogramme1.Location = new Point(12, 86);
            controleHistogramme1.MaxX = 100;
            controleHistogramme1.MaxY = 100;
            controleHistogramme1.MinX = 0;
            controleHistogramme1.MinY = -100;
            controleHistogramme1.Name = "controleHistogramme1";
            controleHistogramme1.Size = new Size(365, 253);
            controleHistogramme1.TabIndex = 5;
            controleHistogramme1.Trait = SystemColors.MenuHighlight;
            // 
            // EcranHistogramme
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(566, 367);
            Controls.Add(controleHistogramme1);
            Controls.Add(bDessiner);
            Controls.Add(bCreer);
            Controls.Add(lbMonPoint);
            Name = "EcranHistogramme";
            Text = "EcranHistogramme";
            ResumeLayout(false);
        }

        #endregion

        private ListBox lbMonPoint;
        private Mes_Controles.BoutonColore bCreer;
        private Mes_Controles.BoutonColore bDessiner;
        private Mes_Controles.ControleHistogramme controleHistogramme1;
    }
}