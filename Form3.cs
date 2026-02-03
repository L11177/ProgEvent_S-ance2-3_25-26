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

            // Associer les événements
            this.Load += FormProgression_Load;
            timer1.Tick += timer1_Tick;
        }

        private void FormProgression_Load(object sender, EventArgs e)
        {
            // Initialiser les barres
            progressBarPrincipale.Value = 0;
            progressBarSecondaire.Value = 0;

            // Démarrer le Timer
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Avancer la barre secondaire
            valeurSecondaire += 5;

            if (valeurSecondaire >= progressBarSecondaire.Maximum)
            {
                valeurSecondaire = 0;               // reset secondaire
                valeurPrincipale += 10;             // avancer principale
                if (valeurPrincipale > progressBarPrincipale.Maximum)
                    valeurPrincipale = progressBarPrincipale.Maximum;
            }

            progressBarSecondaire.Value = valeurSecondaire;
            progressBarPrincipale.Value = valeurPrincipale;

            // Si barre principale remplie
            if (valeurPrincipale >= progressBarPrincipale.Maximum)
            {
                timer1.Stop();
                MessageBox.Show("Chargement terminé !");
            }
        }
    }
}
