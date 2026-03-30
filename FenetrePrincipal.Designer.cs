namespace ProgEvent_Séance2_25_26
{
    partial class FenetrePrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            contrôlesToolStripMenuItem = new ToolStripMenuItem();
            listeMenu = new ToolStripMenuItem();
            barreDeProgressionMenu = new ToolStripMenuItem();
            quitterMenu = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            applicationsToolStripMenuItem = new ToolStripMenuItem();
            editeurMenu = new ToolStripMenuItem();
            aideToolStripMenuItem = new ToolStripMenuItem();
            aProposMenu = new ToolStripMenuItem();
            bMalware = new ToolStripMenuItem();
            spirographeToolStripMenuItem = new ToolStripMenuItem();
            horlogeToolStripMenuItem = new ToolStripMenuItem();
            clavierSourisToolStripMenuItem = new ToolStripMenuItem();
            FicExplorateur = new ToolStripMenuItem();
            baseDeDonnéeToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.AppWorkspace;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { contrôlesToolStripMenuItem, applicationsToolStripMenuItem, aideToolStripMenuItem, bMalware, spirographeToolStripMenuItem, horlogeToolStripMenuItem, clavierSourisToolStripMenuItem, FicExplorateur, baseDeDonnéeToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(882, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // contrôlesToolStripMenuItem
            // 
            contrôlesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { listeMenu, barreDeProgressionMenu, quitterMenu, toolStripSeparator1 });
            contrôlesToolStripMenuItem.Name = "contrôlesToolStripMenuItem";
            contrôlesToolStripMenuItem.Size = new Size(86, 24);
            contrôlesToolStripMenuItem.Text = "Contrôles";
            // 
            // listeMenu
            // 
            listeMenu.Name = "listeMenu";
            listeMenu.Size = new Size(230, 26);
            listeMenu.Text = "Liste";
            listeMenu.Click += listeMenu_Click;
            // 
            // barreDeProgressionMenu
            // 
            barreDeProgressionMenu.Name = "barreDeProgressionMenu";
            barreDeProgressionMenu.Size = new Size(230, 26);
            barreDeProgressionMenu.Text = "Barre de progression";
            // 
            // quitterMenu
            // 
            quitterMenu.Name = "quitterMenu";
            quitterMenu.Size = new Size(230, 26);
            quitterMenu.Text = "Quitter";
            quitterMenu.Click += quitterMenu_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(227, 6);
            // 
            // applicationsToolStripMenuItem
            // 
            applicationsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { editeurMenu });
            applicationsToolStripMenuItem.Name = "applicationsToolStripMenuItem";
            applicationsToolStripMenuItem.Size = new Size(106, 24);
            applicationsToolStripMenuItem.Text = "Applications";
            // 
            // editeurMenu
            // 
            editeurMenu.Name = "editeurMenu";
            editeurMenu.Size = new Size(139, 26);
            editeurMenu.Text = "Editeur";
            // 
            // aideToolStripMenuItem
            // 
            aideToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aProposMenu });
            aideToolStripMenuItem.Name = "aideToolStripMenuItem";
            aideToolStripMenuItem.Size = new Size(54, 24);
            aideToolStripMenuItem.Text = "Aide";
            // 
            // aProposMenu
            // 
            aProposMenu.Name = "aProposMenu";
            aProposMenu.Size = new Size(153, 26);
            aProposMenu.Text = "A propos";
            aProposMenu.Click += aProposMenu_Click;
            // 
            // bMalware
            // 
            bMalware.Name = "bMalware";
            bMalware.Size = new Size(80, 24);
            bMalware.Text = "Malware";
            bMalware.Click += bMalware_Click;
            // 
            // spirographeToolStripMenuItem
            // 
            spirographeToolStripMenuItem.Name = "spirographeToolStripMenuItem";
            spirographeToolStripMenuItem.Size = new Size(105, 24);
            spirographeToolStripMenuItem.Text = "Spirographe";
            spirographeToolStripMenuItem.Click += spirographeToolStripMenuItem_Click;
            // 
            // horlogeToolStripMenuItem
            // 
            horlogeToolStripMenuItem.Name = "horlogeToolStripMenuItem";
            horlogeToolStripMenuItem.Size = new Size(78, 24);
            horlogeToolStripMenuItem.Text = "Horloge";
            horlogeToolStripMenuItem.Click += horlogeToolStripMenuItem_Click;
            // 
            // clavierSourisToolStripMenuItem
            // 
            clavierSourisToolStripMenuItem.Name = "clavierSourisToolStripMenuItem";
            clavierSourisToolStripMenuItem.Size = new Size(114, 24);
            clavierSourisToolStripMenuItem.Text = "Clavier/Souris";
            clavierSourisToolStripMenuItem.Click += clavierSourisToolStripMenuItem_Click;
            // 
            // FicExplorateur
            // 
            FicExplorateur.Name = "FicExplorateur";
            FicExplorateur.Size = new Size(99, 24);
            FicExplorateur.Text = "Explorateur";
            FicExplorateur.Click += FicExplorateur_Click;
            // 
            // baseDeDonnéeToolStripMenuItem
            // 
            baseDeDonnéeToolStripMenuItem.Name = "baseDeDonnéeToolStripMenuItem";
            baseDeDonnéeToolStripMenuItem.Size = new Size(129, 24);
            baseDeDonnéeToolStripMenuItem.Text = "Base de donnée";
            baseDeDonnéeToolStripMenuItem.Click += baseDeDonnéeToolStripMenuItem_Click;
            // 
            // FenetrePrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(882, 450);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "FenetrePrincipal";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem contrôlesToolStripMenuItem;
        private ToolStripMenuItem listeMenu;
        private ToolStripMenuItem barreDeProgressionMenu;
        private ToolStripMenuItem applicationsToolStripMenuItem;
        private ToolStripMenuItem aideToolStripMenuItem;
        private ToolStripMenuItem editeurMenu;
        private ToolStripMenuItem aProposMenu;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem quitterMenu;
        private ToolStripMenuItem bMalware;
        private ToolStripMenuItem spirographeToolStripMenuItem;
        private ToolStripMenuItem horlogeToolStripMenuItem;
        private ToolStripMenuItem clavierSourisToolStripMenuItem;
        private ToolStripMenuItem FicExplorateur;
        private ToolStripMenuItem baseDeDonnéeToolStripMenuItem;
    }
}
