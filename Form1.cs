using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Crud
{
    public partial class Form1 : Form
    {
        DBConnection laConnexion = new DBConnection();

        public int userID { get; set; }

        public Form1()
        {
            InitializeComponent();
            TBMdp.KeyPress += new KeyPressEventHandler(TBMdp_KeyPress);

        }


        private void TBMdp_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Display '*' for each character typed
            TBMdp.PasswordChar = '*';
        }

        public void btnConnex_Click(object sender, EventArgs e)
        {
            laConnexion.Server = "localhost";
            laConnexion.DatabaseName = "crud2";
            laConnexion.UserName = "root";
            laConnexion.Password = Crypto.Decrypt("8QMF/XZEGWSWu1ZY4F3wtg==");


            string motDePasse = TBMdp.Text;
            string email = TBMail.Text;

            try
            {
                if (!laConnexion.IsConnect())
                {
                    laConnexion.Connection.Open();
                }

                // Hasher le mot de passe saisi par l'utilisateur
                string motDePasseHash = SHA.mdpHasheAvecSel(motDePasse);

                string query = "SELECT * FROM user WHERE mail = @Email AND mdp = @MotDePasse";
                using (MySqlCommand cmd = new MySqlCommand(query, laConnexion.Connection))
                {
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@MotDePasse", motDePasseHash); // Utiliser le mot de passe hashé

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            userID = reader.GetInt32("idUser");
                            string prenomUtilisateur = reader.GetString("prenom");
                            string niveauUtilisateur = reader.GetString("niveau");
                            reader.Close();
                            HistoriqueConnexion(userID);
                            if (niveauUtilisateur == "2")
                            {             
                                MessageBox.Show("Connexion réussie !");
                                Gestionnaire formGest = new Gestionnaire(prenomUtilisateur, userID);
                                formGest.btnAfficherListe_Click(sender, e);
                                formGest.Show();
                                this.Hide();
                            }
                            else if (niveauUtilisateur != "2")
                            {
                                MessageBox.Show("Connexion réussie !");
                                Gestionnaire formGest = new Gestionnaire(prenomUtilisateur, userID);
                                formGest.Show();
                                this.Hide();
                            }
                        }
                        else
                        {
                            MessageBox.Show("E-mail ou mot de passe incorrect !");
                            reader.Close();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de la tentative de connexion : " + ex.Message);
            }
        }

        private void HistoriqueConnexion(int userID)
        {
            string insertQuery = "INSERT INTO historique_connexions (DateConnexion, IDUtilisateur) VALUES (CURRENT_TIMESTAMP, @IDUtilisateur);";
            using (MySqlCommand insertCmd = new MySqlCommand(insertQuery, laConnexion.Connection))
            {
                insertCmd.Parameters.AddWithValue("@IDUtilisateur", userID);
                insertCmd.ExecuteNonQuery();
            }
        }

        private void btnDisconn_Click(object sender, EventArgs e)
        {
            laConnexion.Close();
            TBMdp.Text = "Deconnecté avec succès";
        }

        private void btnPointInterr_Click(object sender, EventArgs e)
        {
            FormUtilitaire formUtil = new FormUtilitaire();
            formUtil.Show();
        }

        private void btnRemplissage_Click(object sender, EventArgs e)
        {
            if (laConnexion.IsConnect())
            {
                string query = "select code_c, nom, adresse from client";
                var cmd = new MySqlCommand(query, laConnexion.Connection);
                var reader = cmd.ExecuteReader();
                List<Client> contacts = new List<Client>();

                while (reader.Read())
                {
                    string someStringFromColumnOne = reader.GetString(1);
                    string someStringFromColumnThree = reader.GetString(2);
                    RTBClients.AppendText(someStringFromColumnOne + "," + someStringFromColumnThree);
                    Client contact = new Client()
                    {
                        IDUser = (int)reader["code_c"],
                        ContactNom = (string)reader["nom"],
                        ContactPrenom = (string)reader["adresse"],
                    };
                    contacts.Add(contact);

                }

                DGV1.DataSource = contacts; // Configurer le DataGridView
                DGV1.Columns["IDUser"].Visible = false;

                reader.Close();
                LBCompteur.Text = contacts.Count.ToString();

                Client monclient = contacts.Find(x => x.IDUser == 64);
            }
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            if (DGV1.SelectedRows.Count > 0)
            {
                DataGridViewRow row = DGV1.SelectedRows[0];
                Client selectedClient = (Client)row.DataBoundItem; // Obtenir l'objet Client de la ligne sélectionnée
                FormClients formClient = new FormClients(selectedClient, laConnexion); // Passer DataBaseConnection à FormClients
                formClient.Show();
            }
        }
    }
}
