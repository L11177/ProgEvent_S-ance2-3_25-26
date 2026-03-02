using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgEvent_Séance2_25_26
{
    public partial class EcranEditeur : Form
    {
        private string sFichier = "";
        private bool bModifier = false;
        public EcranEditeur()
        {
            InitializeComponent();
        }
        private void FichierEnregistrer()
        {
            if (string.IsNullOrEmpty(sFichier))
            {
                if (sfdEnregistrer.ShowDialog() == DialogResult.OK)
                {
                    sFichier = sfdEnregistrer.FileName;
                }
                else return;
            }

            rtbTexte.SaveFile(sFichier);
            bModifier = false;
        }
        private void VerifierSauver()
        {
            if (bModifier)
            {
                DialogResult result = MessageBox.Show("Voulez-vous enregistrer les modifications ?",
                                      "Enregistrement", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    FichierEnregistrer();
                }
            }
        }

        private void nouveauTSMI_Click(object sender, EventArgs e)
        {
            VerifierSauver();
            rtbTexte.Clear();
            sFichier = "";
            bModifier = false;
        }

        private void ouvrirTSMI_Click(object sender, EventArgs e)
        {
            VerifierSauver();
            if (ofdOuvrir.ShowDialog() == DialogResult.OK)
            {
                sFichier = ofdOuvrir.FileName;
                rtbTexte.LoadFile(sFichier);
                bModifier = false;
            }
        }

        private void rtbTexte_TextChanged(object sender, EventArgs e)
        {
            bModifier = true;
        }

        private void enregistrerTSMI_Click(object sender, EventArgs e)
        {
            FichierEnregistrer();
        }

        private void quitterTSMI_Click(object sender, EventArgs e)
        {
            VerifierSauver();
            this.Close();
        }

        private void copierTSMI_Click(object sender, EventArgs e)
        {
            rtbTexte.Copy();
        }
        private void couperTSMI_Click(object sender, EventArgs e)
        {
            rtbTexte.Cut();
        }
        private void collerTSMI_Click(object sender, EventArgs e)
        {
            rtbTexte.Paste();
        }

        private void gaucheTSMI_Click(object sender, EventArgs e)
        {
            rtbTexte.SelectionAlignment = HorizontalAlignment.Left;
        }

        private void centreTSMI_Click(object sender, EventArgs e)
        {
            rtbTexte.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void droiteTSMI_Click(object sender, EventArgs e)
        {
            rtbTexte.SelectionAlignment = HorizontalAlignment.Right;
        }

        private void policeTSMI_Click(object sender, EventArgs e)
        {
            if (fdPolice.ShowDialog() == DialogResult.OK)
            {
                rtbTexte.SelectionFont = fdPolice.Font;
            }
        }

        private void grasTSMI_Click(object sender, EventArgs e)
        {
            if (rtbTexte.SelectionFont != null)
            {
                FontStyle nouveauStyle = rtbTexte.SelectionFont.Style ^ FontStyle.Bold;
                rtbTexte.SelectionFont = new Font(rtbTexte.SelectionFont, nouveauStyle);
            }
        }

        private void italiqueTSMI_Click(object sender, EventArgs e)
        {
            if (rtbTexte.SelectionFont != null)
            {
                FontStyle nouveauStyle = rtbTexte.SelectionFont.Style ^ FontStyle.Italic;
                rtbTexte.SelectionFont = new Font(rtbTexte.SelectionFont, nouveauStyle);
            }
        }

        private void soulignéTSMI_Click(object sender, EventArgs e)
        {
            if (rtbTexte.SelectionFont != null)
            {
                FontStyle nouveauStyle = rtbTexte.SelectionFont.Style ^ FontStyle.Underline;
                rtbTexte.SelectionFont = new Font(rtbTexte.SelectionFont, nouveauStyle);
            }
        }

        private void barréTSMI_Click(object sender, EventArgs e)
        {
            if (rtbTexte.SelectionFont != null)
            {
                FontStyle nouveauStyle = rtbTexte.SelectionFont.Style ^ FontStyle.Strikeout;
                rtbTexte.SelectionFont = new Font(rtbTexte.SelectionFont, nouveauStyle);
            }
        }

        private void EcranEditeur_FormClosing(object sender, FormClosingEventArgs e)
        {
            VerifierSauver();
        }
    }
}
