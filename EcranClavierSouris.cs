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
    public partial class EcranClavierSouris : Form
    {
        private int nbGauche = 0;
        private int nbDroit = 0;
        public EcranClavierSouris()
        {
            InitializeComponent();
        }

        private void AfficherClic()
        {
            tbxClicGauche.Text = nbGauche.ToString();
            tbxClicDroit.Text = nbDroit.ToString();
        }
        private void lsbClavier_KeyDown(object sender, KeyEventArgs e)
        {
            lsbClavier.Items.Insert(0, "Touche enfoncée : " + e.KeyCode);
        }

        private void lsbClavier_KeyPress(object sender, KeyPressEventArgs e)
        {
            lsbClavier.Items.Insert(0, "Caractère tapé : " + e.KeyChar);
        }

        private void lsbClavier_KeyUp(object sender, KeyEventArgs e)
        {
            lsbClavier.Items.Insert(0, "Touche relâchée : " + e.KeyCode);
        }

        private void pnlSouris_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                nbGauche = nbGauche + 1;
            }

            if (e.Button == MouseButtons.Right)
            {
                nbDroit = nbDroit + 1;
            }

            AfficherClic(); 
            
            int colonne = (e.X / (pnlSouris.Width / 3)) + 1;
            int ligne = (e.Y / (pnlSouris.Height / 3)) + 1;

            if (colonne > 3) colonne = 3;
            if (ligne > 3) ligne = 3;

            lsbClavier.Items.Insert(0, "Clic case : Ligne " + ligne + ", Col " + colonne);
        }

        private void pnlSouris_MouseMove(object sender, MouseEventArgs e)
        {
            tbxPositionX.Text = e.X.ToString();
            tbxPositionY.Text = e.Y.ToString();
        }

        private void butRAZ_Click(object sender, EventArgs e)
        {
            nbGauche = 0;
            nbDroit = 0;
            AfficherClic();

            tbxPositionX.Text = "";
            tbxPositionY.Text = "";

            lsbClavier.Items.Clear();
        }

        private void pnlSouris_Paint(object sender, PaintEventArgs e)
        {
            int w = pnlSouris.Width / 3;
            int h = pnlSouris.Height / 3;

            e.Graphics.DrawLine(Pens.Black, w, 0, w, pnlSouris.Height);
            e.Graphics.DrawLine(Pens.Black, 2 * w, 0, 2 * w, pnlSouris.Height);

            e.Graphics.DrawLine(Pens.Black, 0, h, pnlSouris.Width, h);
            e.Graphics.DrawLine(Pens.Black, 0, 2 * h, pnlSouris.Width, 2 * h);
        }
    }
}
