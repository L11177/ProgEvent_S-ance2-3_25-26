namespace ProgEvent_Séance2_25_26
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            listeMenu.Click += listeMenu_Click;
            barreDeProgressionMenu.Click += barreDeProgressionMenu_Click;
            editeurMenu.Click += NonImplantee;

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
    }
}
