namespace ProgEvent_Séance2_25_26
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            listeMenu.Click += NonImplantee;
            barreDeProgressionMenu.Click += barreDeProgressionMenu_Click;
            editeurMenu.Click += NonImplantee;

        }
        private void NonImplantee(object sender, EventArgs e)
        {
            MessageBox.Show("Cette fonctionnalité n'est pas encore implémentée", "Information");
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
            f.ShowDialog(); // ouvre la fenêtre de progression
        }

    }
}
