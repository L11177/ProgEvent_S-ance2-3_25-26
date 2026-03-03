using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgEvent_Séance2_25_26
{
    public partial class EcranSpirographie : Form
    {
        private Color cFond = Color.DarkBlue;
        private Color cTrait = Color.Cyan;
        private GraphicsPath gpSauvegarde = null;

        public EcranSpirographie()
        {
            InitializeComponent();
            gpSauvegarde = null;
        }

        private void bTrait_Click(object sender, EventArgs e)
        {
            if (cdCouleur.ShowDialog() == DialogResult.OK)
            {
                cTrait = cdCouleur.Color;
                Invalidate();
            }
        }

        private void bFond_Click(object sender, EventArgs e)
        {
            if (cdCouleur.ShowDialog() == DialogResult.OK)
            {
                cFond = cdCouleur.Color;
                Invalidate();
            }
        }

        private void bGo_Click(object sender, EventArgs e)
        {
            int iSommets = tbSommets.Value;
            int iDensite = tbDensite.Value;
            double iProfondeur = tbProfondeur.Value;

            int xZone = gbParametrage.Width + 10;
            int largeurZone = ClientSize.Width - xZone;
            int hauteurZone = ClientSize.Height;

            int xc = xZone + largeurZone / 2;
            int yc = hauteurZone / 2;
            int rayon = Math.Min(largeurZone, hauteurZone) / 2 - 20;

            gpSauvegarde = new GraphicsPath();

            double[] sx = new double[iSommets + 1];
            double[] sy = new double[iSommets + 1];

            for (int i = 0; i <= iSommets; i++)
            {
                sx[i] = xc + rayon * Math.Cos(2 * Math.PI * i / iSommets);
                sy[i] = yc + rayon * Math.Sin(2 * Math.PI * i / iSommets);
            }

            double limite = rayon * iProfondeur / 100.0;

            while (Math.Sqrt(Math.Pow(sx[0] - xc, 2) + Math.Pow(sy[0] - yc, 2)) > limite)
            {
                for (int i = 0; i < iSommets; i++)
                {
                    gpSauvegarde.AddLine((float)sx[i], (float)sy[i], (float)sx[i + 1], (float)sy[i + 1]);
                }

                for (int i = 0; i < iSommets; i++)
                {
                    sx[i] = sx[i] + (sx[i + 1] - sx[i]) / iDensite;
                    sy[i] = sy[i] + (sy[i + 1] - sy[i]) / iDensite;
                }

                sx[iSommets] = sx[0];
                sy[iSommets] = sy[0];
            }
            Invalidate();
        }

        private void EcranSpirographie_Paint(object sender, PaintEventArgs e)
        {
            if (gpSauvegarde != null)
            {
                int xOffset = gbParametrage.Width + 8;
                Rectangle zoneDessin = new Rectangle(xOffset, 0, ClientSize.Width - xOffset, ClientSize.Height);

                e.Graphics.FillRectangle(new SolidBrush(cFond), zoneDessin);
                e.Graphics.DrawPath(new Pen(cTrait), gpSauvegarde);
            }
        }
    }
}
