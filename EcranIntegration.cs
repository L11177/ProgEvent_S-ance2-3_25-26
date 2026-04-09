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
    public delegate double fctAIntegrer(double x);
    public partial class EcranIntegration : Form
    {
        public EcranIntegration()
        {
            InitializeComponent();
        }
        double MonPolynome(double x)
        {
            return (x * x) + 2;
        }

        double MonSinus(double x)
        {
            return Math.Sin(x);
        }
        double IntegrationTrapeze(fctAIntegrer f, double xGauche, double xDroit, int nInterval)
        {
            double h = (xDroit - xGauche) / nInterval;
            double sommeTotale = 0;

            for (int i = 0; i < nInterval; i++)
            {
                double x1 = xGauche + i * h;
                double x2 = x1 + h;

                double aireSlicing = ((f(x1) + f(x2)) * h) / 2;
                sommeTotale += aireSlicing;
            }
            return sommeTotale;
        }

        private void bPolynome_Click(object sender, EventArgs e)
        {
            lbResultats.Items.Clear();
            double a = double.Parse(tbGauche.Text);
            double b = double.Parse(tbDroite.Text);
            int nBase = int.Parse(tbNbInt.Text);

            for (int mult = 1; mult <= 16; mult *= 2)
            {
                int nActuel = nBase * mult;
                double h = (b - a) / nActuel;
                double aireTotale = 0;

                for (int i = 0; i < nActuel; i++)
                {
                    double x1 = a + i * h;
                    double x2 = x1 + h;

                    double y1 = (x1 * x1) + 2;
                    double y2 = (x2 * x2) + 2;

                    aireTotale += ((y1 + y2) * h) / 2;
                }
                lbResultats.Items.Add($"[Trad] n={nActuel} -> Aire = {aireTotale}");
            }
        }

        private void bTrigonometrique_Click(object sender, EventArgs e)
        {
            lbResultats.Items.Clear();
            double a = double.Parse(tbGauche.Text);
            double b = double.Parse(tbDroite.Text);
            int nBase = int.Parse(tbNbInt.Text);

            for (int mult = 1; mult <= 16; mult *= 2)
            {
                int nActuel = nBase * mult;
                double h = (b - a) / nActuel;
                double aireTotale = 0;

                for (int i = 0; i < nActuel; i++)
                {
                    double x1 = a + i * h;
                    double x2 = x1 + h;

                    double y1 = Math.Sin(x1);
                    double y2 = Math.Sin(x2);

                    aireTotale += ((y1 + y2) * h) / 2;
                }
                lbResultats.Items.Add($"[Trad] n={nActuel} -> Aire = {aireTotale}");
            }
        }

        private void bPointeurPolynome_Click(object sender, EventArgs e)
        {
            lbResultats.Items.Clear();

            double a = double.Parse(tbGauche.Text);
            double b = double.Parse(tbDroite.Text);
            int nBase = int.Parse(tbNbInt.Text);

            for (int mult = 1; mult <= 16; mult *= 2)
            {
                int nActuel = nBase * mult;

                double resultat = IntegrationTrapeze(MonPolynome, a, b, nActuel);

                lbResultats.Items.Add($"n={nActuel} -> Aire = {resultat}");
            }
        }

        private void bPointeurTrigonometrique_Click(object sender, EventArgs e)
        {
            lbResultats.Items.Clear();

            double a = double.Parse(tbGauche.Text);
            double b = double.Parse(tbDroite.Text);
            int nBase = int.Parse(tbNbInt.Text);

            for (int mult = 1; mult <= 16; mult *= 2)
            {
                int nActuel = nBase * mult;

                double resultat = IntegrationTrapeze(MonSinus, a, b, nActuel);

                lbResultats.Items.Add($"n={nActuel} -> Aire = {resultat}");
            }
        }
    }
}
