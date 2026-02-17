namespace ProgEvent_Séance2_25_26
{
    partial class EcranListe
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
            IFichier = new Label();
            INom = new Label();
            IQualite = new Label();
            bAnnuler = new Button();
            bConfirmer = new Button();
            bOuvrir = new Button();
            bEnregistrer = new Button();
            bSupprimer = new Button();
            bAjouter = new Button();
            lbPersonne = new ListBox();
            cbQualite = new ComboBox();
            gbDetail = new GroupBox();
            tbNom = new TextBox();
            ofdOuvrirFichier = new OpenFileDialog();
            sfdEnregistrer = new SaveFileDialog();
            bModifier = new Button();
            gbDetail.SuspendLayout();
            SuspendLayout();
            // 
            // IFichier
            // 
            IFichier.AutoSize = true;
            IFichier.Location = new Point(10, 5);
            IFichier.Name = "IFichier";
            IFichier.Size = new Size(108, 20);
            IFichier.TabIndex = 0;
            IFichier.Text = "Nom de fichier";
            // 
            // INom
            // 
            INom.AutoSize = true;
            INom.Location = new Point(6, 74);
            INom.Name = "INom";
            INom.Size = new Size(42, 20);
            INom.TabIndex = 1;
            INom.Text = "Nom";
            // 
            // IQualite
            // 
            IQualite.AutoSize = true;
            IQualite.Location = new Point(6, 22);
            IQualite.Name = "IQualite";
            IQualite.Size = new Size(57, 20);
            IQualite.TabIndex = 2;
            IQualite.Text = "Qualité";
            // 
            // bAnnuler
            // 
            bAnnuler.Location = new Point(102, 136);
            bAnnuler.Name = "bAnnuler";
            bAnnuler.Size = new Size(90, 29);
            bAnnuler.TabIndex = 3;
            bAnnuler.Text = "Annuler";
            bAnnuler.UseVisualStyleBackColor = true;
            bAnnuler.Click += bAnnuler_Click;
            // 
            // bConfirmer
            // 
            bConfirmer.Location = new Point(6, 136);
            bConfirmer.Name = "bConfirmer";
            bConfirmer.Size = new Size(90, 29);
            bConfirmer.TabIndex = 4;
            bConfirmer.Text = "Confirmer";
            bConfirmer.UseVisualStyleBackColor = true;
            bConfirmer.Click += bConfirmer_Click;
            // 
            // bOuvrir
            // 
            bOuvrir.Location = new Point(12, 151);
            bOuvrir.Name = "bOuvrir";
            bOuvrir.Size = new Size(94, 29);
            bOuvrir.TabIndex = 5;
            bOuvrir.Text = "Ouvrir";
            bOuvrir.UseVisualStyleBackColor = true;
            bOuvrir.Click += bOuvrir_Click;
            // 
            // bEnregistrer
            // 
            bEnregistrer.Location = new Point(12, 186);
            bEnregistrer.Name = "bEnregistrer";
            bEnregistrer.Size = new Size(94, 29);
            bEnregistrer.TabIndex = 6;
            bEnregistrer.Text = "Enregistrer";
            bEnregistrer.UseVisualStyleBackColor = true;
            bEnregistrer.Click += bEnregistrer_Click;
            // 
            // bSupprimer
            // 
            bSupprimer.Location = new Point(10, 269);
            bSupprimer.Name = "bSupprimer";
            bSupprimer.Size = new Size(94, 29);
            bSupprimer.TabIndex = 7;
            bSupprimer.Text = "Supprimer";
            bSupprimer.UseVisualStyleBackColor = true;
            bSupprimer.Click += bSupprimer_Click;
            // 
            // bAjouter
            // 
            bAjouter.Location = new Point(10, 234);
            bAjouter.Name = "bAjouter";
            bAjouter.Size = new Size(94, 29);
            bAjouter.TabIndex = 8;
            bAjouter.Text = "Ajouter";
            bAjouter.UseVisualStyleBackColor = true;
            bAjouter.Click += bAjouter_Click;
            // 
            // lbPersonne
            // 
            lbPersonne.FormattingEnabled = true;
            lbPersonne.Location = new Point(10, 28);
            lbPersonne.Name = "lbPersonne";
            lbPersonne.Size = new Size(328, 104);
            lbPersonne.TabIndex = 9;
            lbPersonne.DoubleClick += lbPersonne_DoubleClick;
            // 
            // cbQualite
            // 
            cbQualite.FormattingEnabled = true;
            cbQualite.Items.AddRange(new object[] { "Madame", "Mademoiselle", "Monsieur", "Mondamoiseau", "Indéfini" });
            cbQualite.Location = new Point(6, 45);
            cbQualite.Name = "cbQualite";
            cbQualite.Size = new Size(190, 28);
            cbQualite.TabIndex = 10;
            // 
            // gbDetail
            // 
            gbDetail.Controls.Add(tbNom);
            gbDetail.Controls.Add(IQualite);
            gbDetail.Controls.Add(cbQualite);
            gbDetail.Controls.Add(INom);
            gbDetail.Controls.Add(bConfirmer);
            gbDetail.Controls.Add(bAnnuler);
            gbDetail.Location = new Point(136, 138);
            gbDetail.Name = "gbDetail";
            gbDetail.Size = new Size(202, 172);
            gbDetail.TabIndex = 11;
            gbDetail.TabStop = false;
            gbDetail.Text = "Détail personne";
            // 
            // tbNom
            // 
            tbNom.Location = new Point(6, 98);
            tbNom.Name = "tbNom";
            tbNom.Size = new Size(190, 27);
            tbNom.TabIndex = 0;
            // 
            // bModifier
            // 
            bModifier.Location = new Point(10, 304);
            bModifier.Name = "bModifier";
            bModifier.Size = new Size(94, 29);
            bModifier.TabIndex = 12;
            bModifier.Text = "Modifier";
            bModifier.UseVisualStyleBackColor = true;
            bModifier.Click += bModifier_Click;
            // 
            // EcranListe
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(349, 340);
            Controls.Add(bModifier);
            Controls.Add(gbDetail);
            Controls.Add(lbPersonne);
            Controls.Add(bAjouter);
            Controls.Add(bSupprimer);
            Controls.Add(bEnregistrer);
            Controls.Add(bOuvrir);
            Controls.Add(IFichier);
            Name = "EcranListe";
            Text = "EcranListe";
            Load += EcranListe_Load;
            gbDetail.ResumeLayout(false);
            gbDetail.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label IFichier;
        private Label INom;
        private Label IQualite;
        private Button bAnnuler;
        private Button bConfirmer;
        private Button bOuvrir;
        private Button bEnregistrer;
        private Button bSupprimer;
        private Button bAjouter;
        private ListBox lbPersonne;
        private ComboBox cbQualite;
        private GroupBox gbDetail;
        private TextBox tbNom;
        private OpenFileDialog ofdOuvrirFichier;
        private SaveFileDialog sfdEnregistrer;
        private Button bModifier;
    }
}