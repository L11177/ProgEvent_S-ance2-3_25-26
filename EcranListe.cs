using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace ProgEvent_Séance2_25_26
{
    public partial class EcranListe : Form
    {
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        // Constantes pour la donnée cachée
        private const int smLire = 0x0199;
        private const int smEcrire = 0x019A;

        private string NomFichier = "";
        private int indexAModifier = -1; // -1 pour dire qu'il n'ya aucun élément séléctionné
        private int prochainNumero = 1; // Commence à 1 et s’incrémente à chaque ajout

        public EcranListe()
        {
            InitializeComponent();
        }

        private void Activer(bool etat)
        {
            lbPersonne.Enabled = etat;
            bAjouter.Enabled = etat;
            bSupprimer.Enabled = etat;
            bOuvrir.Enabled = etat;
            bEnregistrer.Enabled = etat;

            gbDetail.Enabled = !etat;
        }

        private void EcranListe_Load(object sender, EventArgs e)
        {
            Activer(true);
            cbQualite.SelectedIndex = 0;
        }

        private void bAjouter_Click(object sender, EventArgs e)
        {
            tbNom.Clear();
            cbQualite.SelectedIndex = 0;
            Activer(false);
        }

        private void bAnnuler_Click(object sender, EventArgs e)
        {
            Activer(true);
        }

        private void bConfirmer_Click(object sender, EventArgs e)
        {
            if (tbNom.Text.Trim() == "")
        return;

         string texte = tbNom.Text + " (" + cbQualite.Text + ")";

         if (indexAModifier != -1) // Modification
          {
                lbPersonne.Items[indexAModifier] = texte;
                indexAModifier = -1;
         }
         else // Ajout
         {
             int index = lbPersonne.Items.Add(texte);
             SendMessage(lbPersonne.Handle, smEcrire, index, prochainNumero); // stocke le numéro caché
             prochainNumero++;
             }

             // --- Tri alphabétique en conservant des numéros cachés ---
             List<(string texte, int numero)> temp = new List<(string, int)>();

                for (int i = 0; i < lbPersonne.Items.Count; i++)
             {
                    string t = lbPersonne.Items[i].ToString();
                    int n = SendMessage(lbPersonne.Handle, smLire, i, 0);
                    temp.Add((t, n));
             }
            
             temp = temp.OrderBy(x => x.texte).ToList(); // tri alphabétique
    
             lbPersonne.Items.Clear();

             foreach (var x in temp)
             {
                 int idx = lbPersonne.Items.Add(x.texte);
                 SendMessage(lbPersonne.Handle, smEcrire, idx, x.numero);
             }
             // --------------------------------------

             Activer(true);
            }

        private void bSupprimer_Click(object sender, EventArgs e)
        {
            if (lbPersonne.SelectedIndex != -1)
            {
                int numeroSupprime = SendMessage(lbPersonne.Handle, smLire, lbPersonne.SelectedIndex, 0);

                lbPersonne.Items.RemoveAt(lbPersonne.SelectedIndex);

                for (int i = 0; i < lbPersonne.Items.Count; i++)
                {
                    int numero = SendMessage(lbPersonne.Handle, smLire, i, 0);
                    if (numero > numeroSupprime)
                        SendMessage(lbPersonne.Handle, smEcrire, i, numero - 1);
                }

                prochainNumero--;
            }
        }

        private void lbPersonne_DoubleClick(object sender, EventArgs e)
        {
            int idx = lbPersonne.SelectedIndex;
            if (idx != -1)
            {
                string texte = lbPersonne.Items[idx].ToString();
                int numero = SendMessage(lbPersonne.Handle, smLire, idx, 0); // lit le numéro caché
                MessageBox.Show(
                    "Contenu : " + texte +
                    "\nIndex : " + idx +
                    "\nNuméro d'encodage : " + numero
                );
            }
        }

        private void bOuvrir_Click(object sender, EventArgs e)
        {
            if (ofdOuvrirFichier.ShowDialog() == DialogResult.OK)
            {
                NomFichier = ofdOuvrirFichier.FileName;
                lbPersonne.Items.Clear();
                prochainNumero = 1;

                foreach (string ligne in System.IO.File.ReadAllLines(NomFichier))
                {
                    int pos = ligne.LastIndexOf('#'); // cherche le #
                    string texte;
                    int numero;

                    if (pos != -1) // fichier avec #numéro
                    {
                        texte = ligne.Substring(0, pos); // tout avant #
                        numero = int.Parse(ligne.Substring(pos + 1)); // tout après #
                    }
                    else // ancien fichier sans #
                    {
                        texte = ligne;               // tout le texte
                        numero = prochainNumero;     // on crée un numéro
                        prochainNumero++;            // incrémente pour le suivant
                    }

                    int index = lbPersonne.Items.Add(texte);
                    SendMessage(lbPersonne.Handle, smEcrire, index, numero);

                    // S'assurer que prochainNumero est toujours supérieur au plus grand numéro existant
                    if (numero >= prochainNumero)
                        prochainNumero = numero + 1;
                }
            }
        }

        private void bEnregistrer_Click(object sender, EventArgs e)
        {
            if (sfdEnregistrer.ShowDialog() == DialogResult.OK)
            {
                NomFichier = sfdEnregistrer.FileName;

                using (System.IO.StreamWriter sw = new System.IO.StreamWriter(NomFichier))
                {
                    foreach (var item in lbPersonne.Items)
                    {
                        int index = lbPersonne.Items.IndexOf(item);
                        int numero = SendMessage(lbPersonne.Handle, smLire, index, 0);
                        sw.WriteLine(item.ToString() + "#" + numero);
                    }
                }
            }
        }

        private void bModifier_Click(object sender, EventArgs e)
        {
            if (lbPersonne.SelectedIndex != -1)
            {
                indexAModifier = lbPersonne.SelectedIndex;

                string item = lbPersonne.Items[indexAModifier].ToString();
                int pos = item.LastIndexOf(" (");
                if (pos != -1)
                {
                    tbNom.Text = item.Substring(0, pos);
                    cbQualite.Text = item.Substring(pos + 2, item.Length - pos - 3);
                }

                Activer(false);
            }
        }
    }
}