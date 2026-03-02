namespace ProgEvent_Séance2_25_26
{
    partial class EcranEditeur
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EcranEditeur));
            menuStrip1 = new MenuStrip();
            fichierTSMI = new ToolStripMenuItem();
            nouveauTSMI = new ToolStripMenuItem();
            ouvrirTSMI = new ToolStripMenuItem();
            enregistrerTSMI = new ToolStripMenuItem();
            quitterTSMI = new ToolStripMenuItem();
            editerTSMI = new ToolStripMenuItem();
            copierTSMI = new ToolStripMenuItem();
            couperTSMI = new ToolStripMenuItem();
            collerTSMI = new ToolStripMenuItem();
            formatTSMI = new ToolStripMenuItem();
            justifierTSMI = new ToolStripMenuItem();
            gaucheTSMI = new ToolStripMenuItem();
            centreTSMI = new ToolStripMenuItem();
            droiteTSMI = new ToolStripMenuItem();
            policeTSMI = new ToolStripMenuItem();
            caractèreTSMI = new ToolStripMenuItem();
            grasTSMI = new ToolStripMenuItem();
            italiqueTSMI = new ToolStripMenuItem();
            soulignéTSMI = new ToolStripMenuItem();
            barréTSMI = new ToolStripMenuItem();
            pMenu = new Panel();
            pbQuitter = new PictureBox();
            pbEnregistrer = new PictureBox();
            pbOuvrir = new PictureBox();
            pbNouveau = new PictureBox();
            rtbTexte = new RichTextBox();
            ofdOuvrir = new OpenFileDialog();
            sfdEnregistrer = new SaveFileDialog();
            fdPolice = new FontDialog();
            menuStrip1.SuspendLayout();
            pMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbQuitter).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbEnregistrer).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbOuvrir).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbNouveau).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fichierTSMI, editerTSMI, formatTSMI });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(622, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fichierTSMI
            // 
            fichierTSMI.DropDownItems.AddRange(new ToolStripItem[] { nouveauTSMI, ouvrirTSMI, enregistrerTSMI, quitterTSMI });
            fichierTSMI.Name = "fichierTSMI";
            fichierTSMI.Size = new Size(66, 24);
            fichierTSMI.Text = "Fichier";
            // 
            // nouveauTSMI
            // 
            nouveauTSMI.Name = "nouveauTSMI";
            nouveauTSMI.Size = new Size(163, 26);
            nouveauTSMI.Text = "Nouveau";
            nouveauTSMI.Click += nouveauTSMI_Click;
            // 
            // ouvrirTSMI
            // 
            ouvrirTSMI.Name = "ouvrirTSMI";
            ouvrirTSMI.Size = new Size(163, 26);
            ouvrirTSMI.Text = "Ouvrir";
            ouvrirTSMI.Click += ouvrirTSMI_Click;
            // 
            // enregistrerTSMI
            // 
            enregistrerTSMI.Name = "enregistrerTSMI";
            enregistrerTSMI.Size = new Size(163, 26);
            enregistrerTSMI.Text = "Enregistrer";
            enregistrerTSMI.Click += enregistrerTSMI_Click;
            // 
            // quitterTSMI
            // 
            quitterTSMI.Name = "quitterTSMI";
            quitterTSMI.Size = new Size(163, 26);
            quitterTSMI.Text = "Quitter";
            quitterTSMI.Click += quitterTSMI_Click;
            // 
            // editerTSMI
            // 
            editerTSMI.DropDownItems.AddRange(new ToolStripItem[] { copierTSMI, couperTSMI, collerTSMI });
            editerTSMI.Name = "editerTSMI";
            editerTSMI.Size = new Size(62, 24);
            editerTSMI.Text = "Editer";
            // 
            // copierTSMI
            // 
            copierTSMI.Name = "copierTSMI";
            copierTSMI.Size = new Size(140, 26);
            copierTSMI.Text = "Copier";
            copierTSMI.Click += copierTSMI_Click;
            // 
            // couperTSMI
            // 
            couperTSMI.Name = "couperTSMI";
            couperTSMI.Size = new Size(140, 26);
            couperTSMI.Text = "Couper";
            couperTSMI.Click += couperTSMI_Click;
            // 
            // collerTSMI
            // 
            collerTSMI.Name = "collerTSMI";
            collerTSMI.Size = new Size(140, 26);
            collerTSMI.Text = "Coller";
            collerTSMI.Click += collerTSMI_Click;
            // 
            // formatTSMI
            // 
            formatTSMI.DropDownItems.AddRange(new ToolStripItem[] { justifierTSMI, policeTSMI, caractèreTSMI });
            formatTSMI.Name = "formatTSMI";
            formatTSMI.Size = new Size(70, 24);
            formatTSMI.Text = "Format";
            // 
            // justifierTSMI
            // 
            justifierTSMI.DropDownItems.AddRange(new ToolStripItem[] { gaucheTSMI, centreTSMI, droiteTSMI });
            justifierTSMI.Name = "justifierTSMI";
            justifierTSMI.Size = new Size(155, 26);
            justifierTSMI.Text = "Justifier";
            // 
            // gaucheTSMI
            // 
            gaucheTSMI.Name = "gaucheTSMI";
            gaucheTSMI.Size = new Size(141, 26);
            gaucheTSMI.Text = "Gauche";
            gaucheTSMI.Click += gaucheTSMI_Click;
            // 
            // centreTSMI
            // 
            centreTSMI.Name = "centreTSMI";
            centreTSMI.Size = new Size(141, 26);
            centreTSMI.Text = "Centre";
            centreTSMI.Click += centreTSMI_Click;
            // 
            // droiteTSMI
            // 
            droiteTSMI.Name = "droiteTSMI";
            droiteTSMI.Size = new Size(141, 26);
            droiteTSMI.Text = "Droite";
            droiteTSMI.Click += droiteTSMI_Click;
            // 
            // policeTSMI
            // 
            policeTSMI.Name = "policeTSMI";
            policeTSMI.Size = new Size(155, 26);
            policeTSMI.Text = "Police";
            policeTSMI.Click += policeTSMI_Click;
            // 
            // caractèreTSMI
            // 
            caractèreTSMI.DropDownItems.AddRange(new ToolStripItem[] { grasTSMI, italiqueTSMI, soulignéTSMI, barréTSMI });
            caractèreTSMI.Name = "caractèreTSMI";
            caractèreTSMI.Size = new Size(155, 26);
            caractèreTSMI.Text = "Caractère";
            // 
            // grasTSMI
            // 
            grasTSMI.Name = "grasTSMI";
            grasTSMI.Size = new Size(150, 26);
            grasTSMI.Text = "Gras";
            grasTSMI.Click += grasTSMI_Click;
            // 
            // italiqueTSMI
            // 
            italiqueTSMI.Name = "italiqueTSMI";
            italiqueTSMI.Size = new Size(150, 26);
            italiqueTSMI.Text = "Italique";
            italiqueTSMI.Click += italiqueTSMI_Click;
            // 
            // soulignéTSMI
            // 
            soulignéTSMI.Name = "soulignéTSMI";
            soulignéTSMI.Size = new Size(150, 26);
            soulignéTSMI.Text = "Souligné";
            soulignéTSMI.Click += soulignéTSMI_Click;
            // 
            // barréTSMI
            // 
            barréTSMI.Name = "barréTSMI";
            barréTSMI.Size = new Size(150, 26);
            barréTSMI.Text = "Barré";
            barréTSMI.Click += barréTSMI_Click;
            // 
            // pMenu
            // 
            pMenu.Controls.Add(pbQuitter);
            pMenu.Controls.Add(pbEnregistrer);
            pMenu.Controls.Add(pbOuvrir);
            pMenu.Controls.Add(pbNouveau);
            pMenu.Dock = DockStyle.Top;
            pMenu.Location = new Point(0, 28);
            pMenu.Name = "pMenu";
            pMenu.Size = new Size(622, 45);
            pMenu.TabIndex = 1;
            // 
            // pbQuitter
            // 
            pbQuitter.BackColor = Color.Transparent;
            pbQuitter.BackgroundImage = Properties.Resources.Quitter;
            pbQuitter.BackgroundImageLayout = ImageLayout.Zoom;
            pbQuitter.Location = new Point(123, 6);
            pbQuitter.Name = "pbQuitter";
            pbQuitter.Size = new Size(31, 33);
            pbQuitter.TabIndex = 5;
            pbQuitter.TabStop = false;
            pbQuitter.Click += quitterTSMI_Click;
            // 
            // pbEnregistrer
            // 
            pbEnregistrer.BackColor = Color.Transparent;
            pbEnregistrer.BackgroundImage = Properties.Resources.EnregistrerFichier;
            pbEnregistrer.BackgroundImageLayout = ImageLayout.Zoom;
            pbEnregistrer.Location = new Point(86, 6);
            pbEnregistrer.Name = "pbEnregistrer";
            pbEnregistrer.Size = new Size(31, 33);
            pbEnregistrer.TabIndex = 4;
            pbEnregistrer.TabStop = false;
            pbEnregistrer.Click += enregistrerTSMI_Click;
            // 
            // pbOuvrir
            // 
            pbOuvrir.BackColor = Color.Transparent;
            pbOuvrir.BackgroundImage = Properties.Resources.OuvrirFichier;
            pbOuvrir.BackgroundImageLayout = ImageLayout.Zoom;
            pbOuvrir.Location = new Point(49, 6);
            pbOuvrir.Name = "pbOuvrir";
            pbOuvrir.Size = new Size(36, 33);
            pbOuvrir.TabIndex = 3;
            pbOuvrir.TabStop = false;
            pbOuvrir.Click += ouvrirTSMI_Click;
            // 
            // pbNouveau
            // 
            pbNouveau.BackColor = Color.Transparent;
            pbNouveau.BackgroundImage = (Image)resources.GetObject("pbNouveau.BackgroundImage");
            pbNouveau.BackgroundImageLayout = ImageLayout.Zoom;
            pbNouveau.Location = new Point(12, 6);
            pbNouveau.Name = "pbNouveau";
            pbNouveau.Size = new Size(31, 33);
            pbNouveau.TabIndex = 2;
            pbNouveau.TabStop = false;
            pbNouveau.Click += nouveauTSMI_Click;
            // 
            // rtbTexte
            // 
            rtbTexte.Dock = DockStyle.Fill;
            rtbTexte.Location = new Point(0, 73);
            rtbTexte.Name = "rtbTexte";
            rtbTexte.Size = new Size(622, 377);
            rtbTexte.TabIndex = 0;
            rtbTexte.Text = "";
            rtbTexte.TextChanged += rtbTexte_TextChanged;
            // 
            // ofdOuvrir
            // 
            ofdOuvrir.FileName = "openFileDialog1";
            // 
            // EcranEditeur
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(622, 450);
            Controls.Add(rtbTexte);
            Controls.Add(pMenu);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "EcranEditeur";
            Text = "Editeur";
            FormClosing += EcranEditeur_FormClosing;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            pMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbQuitter).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbEnregistrer).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbOuvrir).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbNouveau).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fichierTSMI;
        private ToolStripMenuItem nouveauTSMI;
        private ToolStripMenuItem ouvrirTSMI;
        private ToolStripMenuItem enregistrerTSMI;
        private ToolStripMenuItem quitterTSMI;
        private ToolStripMenuItem editerTSMI;
        private ToolStripMenuItem copierTSMI;
        private ToolStripMenuItem couperTSMI;
        private ToolStripMenuItem collerTSMI;
        private ToolStripMenuItem formatTSMI;
        private ToolStripMenuItem justifierTSMI;
        private ToolStripMenuItem gaucheTSMI;
        private ToolStripMenuItem centreTSMI;
        private ToolStripMenuItem droiteTSMI;
        private ToolStripMenuItem policeTSMI;
        private ToolStripMenuItem caractèreTSMI;
        private ToolStripMenuItem grasTSMI;
        private ToolStripMenuItem italiqueTSMI;
        private ToolStripMenuItem soulignéTSMI;
        private ToolStripMenuItem barréTSMI;
        private Panel pMenu;
        private PictureBox pbNouveau;
        private RichTextBox rtbTexte;
        private PictureBox pbQuitter;
        private PictureBox pbEnregistrer;
        private PictureBox pbOuvrir;
        private OpenFileDialog ofdOuvrir;
        private SaveFileDialog sfdEnregistrer;
        private FontDialog fdPolice;
    }
}