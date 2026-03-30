using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections; // Pour pouvoir utiliser l'ArrayList
using System.Drawing;     // Pour le dessin (Graphics, Pen, etc.)
using Mes_Controles; // À ajouter tout en haut

namespace ProgEvent_Séance2_25_26
{
    public partial class EcranHistogramme : Form
    {
        private ArrayList alData = new ArrayList();

        // --- LA SALLE D'ATTENTE ---
        // On crée une liste globale qui va stocker les points en attendant 
        // que l'utilisateur appuie sur "Dessiner".
        private List<HistoPoint> pointsEnAttente = new List<HistoPoint>();
        private int maxXGenere = 100; // Pour mémoriser la largeur max

        public EcranHistogramme()
        {
            InitializeComponent();
        }

        private void bCreer_Click(object sender, EventArgs e)
        {
            // 1. On vide tout (ListBox et notre liste d'attente)
            alData.Clear();
            lbMonPoint.Items.Clear();
            pointsEnAttente.Clear();

            // On vide aussi le graphique actuel pour qu'il redevienne blanc
            controleHistogramme1.ChargerPoints(new List<HistoPoint>());

            Random rd = new Random();
            int nbPoints = rd.Next(5, 16);
            int xCumule = 0;

            for (int i = 0; i < nbPoints; i++)
            {
                xCumule += rd.Next(10, 50);
                int yVal = rd.Next(-100, 101);

                // Pour la ListBox
                MonPoint p = new MonPoint(xCumule, yVal);
                alData.Add(p);
                lbMonPoint.Items.Add(p);

                // On stocke dans la salle d'attente, MAIS ON NE DESSINE PAS
                pointsEnAttente.Add(new HistoPoint(xCumule, yVal));
            }

            maxXGenere = xCumule; // On retient la valeur pour le dessin plus tard
        }

        private void bDessiner_Click(object sender, EventArgs e)
        {
            // C'EST ICI qu'on donne enfin les points au contrôle !
            if (pointsEnAttente.Count > 0)
            {
                controleHistogramme1.MinX = 0;
                controleHistogramme1.MaxX = maxXGenere;

                // Cette ligne va déclencher le dessin
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