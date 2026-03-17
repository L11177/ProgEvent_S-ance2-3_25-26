using System;
using System.Windows.Forms;

namespace ProgEvent_Séance2_25_26
{
    public partial class FenetrePrincipal : Form
    {
        public FenetrePrincipal()
        {
            InitializeComponent();
            listeMenu.Click += listeMenu_Click;
            barreDeProgressionMenu.Click += barreDeProgressionMenu_Click;
            editeurMenu.Click += editeurMenu_Click;

        }
        private void NonImplantee(object sender, EventArgs e)
        {
            MessageBox.Show("Cette fonctionnalite n'est pas encore implémentee", "information");
        }

        private void quitterMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void aProposMenu_Click(object sender, EventArgs e)
        {
            aProposForm f = new aProposForm();
            f.ShowDialog();
        }
        private void barreDeProgressionMenu_Click(object sender, EventArgs e)
        {
            FormProgression f = new FormProgression();
            f.ShowDialog();
        }

        private void listeMenu_Click(object sender, EventArgs e)
        {
            EcranListe f = new EcranListe();
            f.ShowDialog();
        }

        private void bMalware_Click(object sender, EventArgs e)
        {
            ficMalware f = new ficMalware();
            f.Show();
        }

        private void editeurMenu_Click(object sender, EventArgs e)
        {
            EcranEditeur f = new EcranEditeur();

            f.Show();
        }

        private void spirographeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EcranSpirographie f = new EcranSpirographie();

            f.Show();
        }

        private void horlogeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EcranHorloge f = new EcranHorloge();

            f.Show();
        }

        private void clavierSourisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EcranClavierSouris f = new EcranClavierSouris();

            f.Show();
        }

        private void FicExplorateur_Click(object sender, EventArgs e)
        {
            EcranExplorateur f = new EcranExplorateur();

            f.Show();
        }
    }
}
