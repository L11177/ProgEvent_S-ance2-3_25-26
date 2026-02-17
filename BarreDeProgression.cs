using System;
using System.Windows.Forms;

namespace ProgEvent_Séance2_25_26
{
    public partial class FormProgression : Form
    {
        private int valeurPrincipale = 0;
        private int valeurSecondaire = 0;

        public FormProgression()
        {
            InitializeComponent();

            this.Load += FormProgression_Load;
            timer1.Tick += timer1_Tick;
        }

        private void FormProgression_Load(object sender, EventArgs e)
        {
            progressBarPrincipale.Value = 0;
            progressBarSecondaire.Value = 0;

            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            valeurSecondaire += 5;

            if (valeurSecondaire >= progressBarSecondaire.Maximum)
            {
                valeurSecondaire = 0;
                valeurPrincipale += 10; //barre principale
                if (valeurPrincipale > progressBarPrincipale.Maximum)
                    valeurPrincipale = progressBarPrincipale.Maximum;
            }

            progressBarSecondaire.Value = valeurSecondaire;
            progressBarPrincipale.Value = valeurPrincipale;

            // Si la barre principale est remplie
            if (valeurPrincipale >= progressBarPrincipale.Maximum)
            {
                timer1.Stop();
                MessageBox.Show("Chargement terminé !");
            }
        }
    }
}
