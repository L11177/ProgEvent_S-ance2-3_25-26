using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace ProgEvent_Séance2_25_26
{
    public partial class BaseDeDonnee : Form
    {
        string cnStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\BaseDeDonnee.mdf;Initial Catalog=GarageV2;Integrated Security=True;Connect Timeout=30";
        public BaseDeDonnee()
        {
            InitializeComponent();
        }

        // --- BOUTON CONSULTER ---
        private void bConsulter_Click(object sender, EventArgs e)
        {
            using (SqlConnection cn = new SqlConnection(cnStr))
            {
                try
                {
                    cn.Open();
                    string sql = "SELECT ID_CLIENT, Nom, Prénom FROM Clients ORDER BY Nom";
                    SqlCommand cmd = new SqlCommand(sql, cn);
                    SqlDataReader dr = cmd.ExecuteReader();

                    lbConsole.Items.Clear();
                    lbConsole.Items.Add("--- Liste des Clients ---");

                    while (dr.Read())
                    {
                        string ligne = $"{dr["Prénom"]} {dr["Nom"]} ({dr["ID_CLIENT"]})";
                        lbConsole.Items.Add(ligne);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur de lecture : " + ex.Message);
                }
            }
        }

        // --- BOUTON DÉNOMBRER ---
        private void bDenombrer_Click(object sender, EventArgs e)
        {
            using (SqlConnection cn = new SqlConnection(cnStr))
            {
                try
                {
                    cn.Open();
                    SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Clients", cn);

                    int total = (int)cmd.ExecuteScalar();

                    lbConsole.Items.Add($"Nombre total d'enregistrements : {total}");
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }
        }

        // --- BOUTON AJOUTER ---
        private void bAjouter_Click(object sender, EventArgs e)
        {
            using (SqlConnection cn = new SqlConnection(cnStr))
            {
                try
                {
                    cn.Open();
                    string sql = "INSERT INTO Clients (Nom, Prénom) VALUES (@nom, @prenom)";
                    SqlCommand cmd = new SqlCommand(sql, cn);

                    cmd.Parameters.AddWithValue("@nom", tbNom.Text);
                    cmd.Parameters.AddWithValue("@prenom", tbPrenom.Text);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Client ajouté au garage !");

                    tbNom.Clear();
                    tbPrenom.Clear();
                }
                catch (Exception ex) { MessageBox.Show("Erreur d'ajout : " + ex.Message); }
            }
        }
    }
}