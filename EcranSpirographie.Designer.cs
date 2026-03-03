namespace ProgEvent_Séance2_25_26
{
    partial class EcranSpirographie
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
            gbParametrage = new GroupBox();
            bGo = new Button();
            tbProfondeur = new TrackBar();
            tbDensite = new TrackBar();
            tbSommets = new TrackBar();
            lProfondeur = new Label();
            lDensite = new Label();
            lSommets = new Label();
            bTrait = new Button();
            bFond = new Button();
            cdCouleur = new ColorDialog();
            gbParametrage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tbProfondeur).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tbDensite).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tbSommets).BeginInit();
            SuspendLayout();
            // 
            // gbParametrage
            // 
            gbParametrage.Controls.Add(bGo);
            gbParametrage.Controls.Add(tbProfondeur);
            gbParametrage.Controls.Add(tbDensite);
            gbParametrage.Controls.Add(tbSommets);
            gbParametrage.Controls.Add(lProfondeur);
            gbParametrage.Controls.Add(lDensite);
            gbParametrage.Controls.Add(lSommets);
            gbParametrage.Location = new Point(22, 12);
            gbParametrage.Name = "gbParametrage";
            gbParametrage.Size = new Size(236, 349);
            gbParametrage.TabIndex = 0;
            gbParametrage.TabStop = false;
            gbParametrage.Text = "Paramétrages";
            // 
            // bGo
            // 
            bGo.FlatAppearance.BorderColor = Color.Blue;
            bGo.Location = new Point(16, 272);
            bGo.Name = "bGo";
            bGo.Size = new Size(179, 56);
            bGo.TabIndex = 6;
            bGo.Text = "GO!";
            bGo.UseVisualStyleBackColor = true;
            bGo.Click += bGo_Click;
            // 
            // tbProfondeur
            // 
            tbProfondeur.Location = new Point(16, 210);
            tbProfondeur.Maximum = 80;
            tbProfondeur.Minimum = 20;
            tbProfondeur.Name = "tbProfondeur";
            tbProfondeur.Size = new Size(130, 56);
            tbProfondeur.TabIndex = 5;
            tbProfondeur.TickFrequency = 5;
            tbProfondeur.Value = 20;
            // 
            // tbDensite
            // 
            tbDensite.Location = new Point(16, 128);
            tbDensite.Maximum = 20;
            tbDensite.Minimum = 5;
            tbDensite.Name = "tbDensite";
            tbDensite.Size = new Size(130, 56);
            tbDensite.TabIndex = 4;
            tbDensite.Value = 5;
            // 
            // tbSommets
            // 
            tbSommets.Location = new Point(16, 46);
            tbSommets.Maximum = 8;
            tbSommets.Minimum = 3;
            tbSommets.Name = "tbSommets";
            tbSommets.Size = new Size(130, 56);
            tbSommets.TabIndex = 3;
            tbSommets.Value = 3;
            // 
            // lProfondeur
            // 
            lProfondeur.AutoSize = true;
            lProfondeur.Location = new Point(16, 187);
            lProfondeur.Name = "lProfondeur";
            lProfondeur.Size = new Size(212, 20);
            lProfondeur.TabIndex = 2;
            lProfondeur.Text = "Profondeur de dessins 20 à 80)";
            // 
            // lDensite
            // 
            lDensite.AutoSize = true;
            lDensite.Location = new Point(16, 105);
            lDensite.Name = "lDensite";
            lDensite.Size = new Size(185, 20);
            lDensite.TabIndex = 1;
            lDensite.Text = "Densité de dessins (5 à 20)";
            // 
            // lSommets
            // 
            lSommets.AutoSize = true;
            lSommets.Location = new Point(16, 23);
            lSommets.Name = "lSommets";
            lSommets.Size = new Size(195, 20);
            lSommets.TabIndex = 0;
            lSommets.Text = "Nombre de sommets (3 à 8)";
            // 
            // bTrait
            // 
            bTrait.BackColor = SystemColors.ButtonFace;
            bTrait.Location = new Point(12, 367);
            bTrait.Name = "bTrait";
            bTrait.Size = new Size(115, 56);
            bTrait.TabIndex = 7;
            bTrait.Text = "Trait";
            bTrait.UseVisualStyleBackColor = false;
            bTrait.Click += bTrait_Click;
            // 
            // bFond
            // 
            bFond.BackColor = SystemColors.ButtonFace;
            bFond.Location = new Point(133, 367);
            bFond.Name = "bFond";
            bFond.Size = new Size(115, 56);
            bFond.TabIndex = 8;
            bFond.Text = "Fond";
            bFond.UseVisualStyleBackColor = false;
            bFond.Click += bFond_Click;
            // 
            // EcranSpirographie
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(754, 471);
            Controls.Add(bTrait);
            Controls.Add(bFond);
            Controls.Add(gbParametrage);
            Name = "EcranSpirographie";
            Text = "Spirographie";
            Paint += EcranSpirographie_Paint;
            gbParametrage.ResumeLayout(false);
            gbParametrage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tbProfondeur).EndInit();
            ((System.ComponentModel.ISupportInitialize)tbDensite).EndInit();
            ((System.ComponentModel.ISupportInitialize)tbSommets).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbParametrage;
        private Button bGo;
        private TrackBar tbProfondeur;
        private TrackBar tbDensite;
        private TrackBar tbSommets;
        private Label lProfondeur;
        private Label lDensite;
        private Label lSommets;
        private Button bTrait;
        private Button bFond;
        private ColorDialog cdCouleur;
    }
}