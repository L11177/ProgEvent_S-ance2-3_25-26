using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ProgEvent_Séance2_25_26
{
    public partial class EcranExplorateur : Form
    {
        public EcranExplorateur()
        {
            InitializeComponent();
        }

        private void EcranExplorateur_Load(object sender, EventArgs e)
        {
            RemplirTreeView();
        }

        private void RemplirTreeView()
        {
            tvRepertoire.Nodes.Clear();
            TreeNode racine = new TreeNode("Poste de Travail");
            tvRepertoire.Nodes.Add(racine);

            LireDisques(racine);
            racine.Expand();
        }

        private void LireDisques(TreeNode noeudParent)
        {
            string[] disques = Environment.GetLogicalDrives();
            foreach (string d in disques)
            {
                TreeNode nDisque = new TreeNode(d);
                noeudParent.Nodes.Add(nDisque);
                LireRepertoires(d, nDisque);
            }
        }

        private void LireRepertoires(string chemin, TreeNode noeudParent)
        {
            try
            {
                if (Directory.Exists(chemin))
                {
                    string[] dossiers = Directory.GetDirectories(chemin);
                    foreach (string d in dossiers)
                    {
                        TreeNode nDossier = new TreeNode(Path.GetFileName(d));
                        noeudParent.Nodes.Add(nDossier);

                    }
                }
            }
            catch { }
        }

        private void tvRepertoire_AfterSelect(object sender, TreeViewEventArgs e)
        {
            string chemin = e.Node.FullPath.Replace("Poste de Travail\\", "");

            if (Directory.Exists(chemin))
            {
                LireFichiers(chemin);
                slMessage.Text = chemin;
            }
        }

        private void LireFichiers(string chemin)
        {
            lvFichiers.Items.Clear();

            try
            {
                string[] fichiers = Directory.GetFiles(chemin);

                foreach (string f in fichiers)
                {
                    FileInfo info = new FileInfo(f);

                    ListViewItem ligne = new ListViewItem(NomFichier(f), 0);

                    ligne.SubItems.Add((info.Length / 1024).ToString() + " Ko");
                    ligne.SubItems.Add(info.CreationTime.ToShortDateString());
                    ligne.SubItems.Add(info.LastWriteTime.ToShortDateString());

                    lvFichiers.Items.Add(ligne);
                }
            }
            catch
            {
            }
        }
        private void tsaGrandesIcones_Click(object sender, EventArgs e)
        {
            // on change le mode d'affichage pour voir des grosses icônes
            lvFichiers.View = View.LargeIcon;
        }

        private void tsaPetitesIcones_Click(object sender, EventArgs e)
        {
            // on change pour des petites icônes
            lvFichiers.View = View.SmallIcon;
        }

        private void tsaListe_Click(object sender, EventArgs e)
        {
            // on affiche une liste simple
            lvFichiers.View = View.List;
        }

        private void tsaDetail_Click(object sender, EventArgs e)
        {
            // on affiche le mode avec les colonnes (NOM, TAILLE...)
            lvFichiers.View = View.Details;
        }

        // Bouton pour fermer l'explorateur
        private void tsbQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private string NomFichier(string cheminComplet)
        {
            return Path.GetFileName(cheminComplet);
        }
    }
}