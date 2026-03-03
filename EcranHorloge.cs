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
    public partial class EcranHorloge : Form
    {
        public EcranHorloge()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Text = "Horloge - " + DateTime.Now.ToLongTimeString();

            Invalidate();
        }

        private void EcranHorloge_Paint(object sender, PaintEventArgs e)
        {
            int xc = ClientSize.Width / 2;
            int yc = ClientSize.Height / 2;
            int rayon = Math.Min(xc, yc) - 30;

            DateTime maintenant = DateTime.Now;
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;


            double sAngle = (maintenant.Second * 6) * Math.PI / 180 - Math.PI / 2;

            double mAngle = ((maintenant.Minute + maintenant.Second / 60.0) * 6) * Math.PI / 180 - Math.PI / 2;

            double hAngle = ((maintenant.Hour % 12 + maintenant.Minute / 60.0) * 30) * Math.PI / 180 - Math.PI / 2;

            DessinerAiguille(e.Graphics, xc, yc, hAngle, rayon * 0.5, Color.Black, 6);

            DessinerAiguille(e.Graphics, xc, yc, mAngle, rayon * 0.8, Color.Blue, 4);

            DessinerAiguille(e.Graphics, xc, yc, sAngle, rayon * 0.9, Color.Red, 2);

            using (Pen styloCadran = new Pen(Color.Black, 3))
            {
                e.Graphics.DrawEllipse(styloCadran, xc - rayon, yc - rayon, rayon * 2, rayon * 2);
            }
        }
        private void DessinerAiguille(Graphics g, int xc, int yc, double angle, double r, Color couleur, int epaisseur)
        {
            int xEnd = (int)(xc + r * Math.Cos(angle));
            int yEnd = (int)(yc + r * Math.Sin(angle));

            using (Pen p = new Pen(couleur, epaisseur))
            {
                g.DrawLine(p, xc, yc, xEnd, yEnd);
            }
        }
    }
}
