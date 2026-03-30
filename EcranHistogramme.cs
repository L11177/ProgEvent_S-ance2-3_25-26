using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.Drawing;
using Mes_Controles;

namespace ProgEvent_Séance2_25_26
{
    public partial class EcranHistogramme : Form
    {
        private ArrayList alData = new ArrayList();

        private List<HistoPoint> pointsEnAttente = new List<HistoPoint>();
        private int maxXGenere = 100;

        public EcranHistogramme()
        {
            InitializeComponent();
        }

        private void bCreer_Click(object sender, EventArgs e)
        {
            alData.Clear();
            lbMonPoint.Items.Clear();
            pointsEnAttente.Clear();

            controleHistogramme1.ChargerPoints(new List<HistoPoint>());

            Random rd = new Random();
            int nbPoints = rd.Next(5, 16);
            int xCumule = 0;

            for (int i = 0; i < nbPoints; i++)
            {
                xCumule += rd.Next(10, 50);
                int yVal = rd.Next(-100, 101);

                MonPoint p = new MonPoint(xCumule, yVal);
                alData.Add(p);
                lbMonPoint.Items.Add(p);

                pointsEnAttente.Add(new HistoPoint(xCumule, yVal));
            }

            maxXGenere = xCumule;
        }

        private void bDessiner_Click(object sender, EventArgs e)
        {
            if (pointsEnAttente.Count > 0)
            {
                controleHistogramme1.MinX = 0;
                controleHistogramme1.MaxX = maxXGenere;

                controleHistogramme1.ChargerPoints(pointsEnAttente);
            }
            else
            {
                MessageBox.Show("Veuillez d'abord créer des points !");
            }
        }
    }

    public class MonPoint
    {
        public int X { get; set; }
        public int Y { get; set; }
        public MonPoint(int x, int y) { X = x; Y = y; }
        public override string ToString() { return $"X = {X} ; Y = {Y}"; }
    }
}