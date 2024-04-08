    using MySql.Data.MySqlClient;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Data.Common;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

    namespace Crud
    {
        public partial class Gestionnaire : Form
        {
            public int IDUser { get; set; }
            public string ContactNom { get; set; }
            public string ContactPrenom { get; set; }

            DBConnection estConnecter = new DBConnection();

            List<Client> contacts = new List<Client>();

        
            public Gestionnaire(string prenomUtilisateur, int userID)
            {
                InitializeComponent();
                this.Text = "Bienvenue " + prenomUtilisateur + ", voici votre espace Gestionnaire !"; // Utilisez le prénom de l'utilisateur dans le titre du formulaire
                DVGHistoriqueConnexion.Visible= false;
                IDUser= userID;
            }

            private void btnAjouter_Click(object sender, EventArgs e)
            {

                Client NVClient= new Client();
                FormClients nvClientForm = new FormClients(NVClient, estConnecter);

                nvClientForm.Show();
            }

            public void btnAfficherListe_Click(object sender, EventArgs e)
            {
                DGVListeUtilisateurs.Visible = true;
                DVGHistoriqueConnexion.Visible = false;
                CBUser.Visible = false;
                btnFiltrer.Visible = false;
                estConnecter.Server = "localhost";
                estConnecter.DatabaseName = "crud2";
                estConnecter.UserName = "root";
                estConnecter.Password = Crypto.Decrypt("8QMF/XZEGWSWu1ZY4F3wtg==");

                if (estConnecter.IsConnect())
                {
                    string query = "SELECT idUser, nom, prenom, mail, mdp, niveau, last_login FROM user";
                    var cmd = new MySqlCommand(query, estConnecter.Connection);
                    var reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        Client contact = new Client()
                        {
                            IDUser = (int)reader["idUser"],
                            ContactNom = (string)reader["nom"],
                            ContactPrenom = (string)reader["prenom"],
                            ContactMail = (string)reader["mail"],
                            ContactMdp = (string)reader["mdp"],
                            ContactNiveau = (string)reader["niveau"],
                            LastLogin = reader["last_login"] != DBNull.Value ? (DateTime)reader["last_login"] : DateTime.MinValue // Vérifiez si la valeur n'est pas NULL
                        };
                        contacts.Add(contact);

                    }

                    DGVListeUtilisateurs.DataSource = contacts;
                    DGVListeUtilisateurs.Columns["IDUser"].Visible = false;
                    DGVListeUtilisateurs.Columns["LastLogin"].HeaderText = "Dernière Connexion"; 

                    reader.Close();
                

                    Client monclient = contacts.Find(x => x.IDUser == 3);
                }
                ActualiserDataGridView();
            }




            private void btn_Delete_Click(object sender, EventArgs e)
            {
                if (DGVListeUtilisateurs.SelectedRows.Count > 0)
                {
                    DataGridViewRow row = DGVListeUtilisateurs.SelectedRows[0];
                    Client Monclient = (Client)row.DataBoundItem;
                    MySqlDataReader reader = null;

                    Monclient.Delete(estConnecter, reader);

                    btnAfficherListe_Click(sender, e);
                }
            }

            private void btn_Modifier_Click(object sender, EventArgs e)
            {
                DataGridViewRow row = DGVListeUtilisateurs.SelectedRows[0];
                Client Monclient = (Client)row.DataBoundItem;
                FormModifier NVformModifier = new FormModifier(Monclient, estConnecter);

                NVformModifier.Show();
            }

            public void ActualiserDataGridView()
            {
            
                if (estConnecter.IsConnect())
                {
                    string query = "SELECT idUser, nom, prenom, mail, mdp, niveau FROM user";
                    var cmd = new MySqlCommand(query, estConnecter.Connection);
                    var reader = cmd.ExecuteReader();
                    List<Client> contacts = new List<Client>();

                    while (reader.Read())
                    {
                        Client contact = new Client()
                        {
                            IDUser = (int)reader["idUser"],
                            ContactNom = (string)reader["nom"],
                            ContactPrenom = (string)reader["prenom"],
                            ContactMail = (string)reader["mail"],
                            ContactMdp = (string)reader["mdp"],
                            ContactNiveau = (string)reader["niveau"],
                        };
                        contacts.Add(contact);
                    }

                    DGVListeUtilisateurs.DataSource = contacts;
                    DGVListeUtilisateurs.Columns["IDUser"].Visible = false;
                    reader.Close();
                }
            }

            private void btn_Actualiser_Click(object sender, EventArgs e)
            {
                ActualiserDataGridView();
            }

            private void btnHistoriqueConnexions_Click(object sender, EventArgs e)
            {
                DGVListeUtilisateurs.Visible = false;
                DVGHistoriqueConnexion.Visible = true;
                CBUser.Visible = true;
                btnFiltrer.Visible = true;

                estConnecter.Server = "localhost";
                estConnecter.DatabaseName = "crud2";
                estConnecter.UserName = "root";
                estConnecter.Password = Crypto.Decrypt("8QMF/XZEGWSWu1ZY4F3wtg==");

                string query2 = "SELECT prenom FROM user";
                var cmd = new MySqlCommand(query2, estConnecter.Connection);
                var reader = cmd.ExecuteReader();
                string valeur = reader["prenom"].ToString();
                CBUser.Items.Add(valeur);

            if (estConnecter.IsConnect())
                {
                    try
                    {
                        string query = @"
                            SELECT user.prenom, 
                                   historique_connexions.DateConnexion, 
                                   historique_connexions.DateDeconnexion
                            FROM user
                            LEFT JOIN historique_connexions ON user.idUser = historique_connexions.IDUtilisateur
                        ";
                        
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, estConnecter.Connection))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);

                            DVGHistoriqueConnexion.DataSource = dataTable;
                            
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erreur lors de la récupération des données : " + ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Connexion à la base de données échouée.");
                }
            }




        private void btnDéconnexion_Click(object sender, EventArgs e)
        {
            estConnecter.Server = "localhost";
            estConnecter.DatabaseName = "crud2";
            estConnecter.UserName = "root";
            estConnecter.Password = Crypto.Decrypt("8QMF/XZEGWSWu1ZY4F3wtg==");


            if (estConnecter.IsConnect())
            {
                try
                {
                    string getLastLoginQuery = @"
                        SELECT IDConnexion
                        FROM historique_connexions
                        WHERE IDUtilisateur = @IDUtilisateur
                        ORDER BY DateConnexion DESC
                        LIMIT 1
                    ";

                    int lastLoginID;
                    using (MySqlCommand getLastLoginCmd = new MySqlCommand(getLastLoginQuery, estConnecter.Connection))
                    {
                        getLastLoginCmd.Parameters.AddWithValue("@IDUtilisateur", IDUser);
                        object result = getLastLoginCmd.ExecuteScalar();
                        if (result != null)
                        {
                            lastLoginID = Convert.ToInt32(result);
                        }
                        else
                        {
                            MessageBox.Show("Aucune connexion précédente trouvée.");
                            return;
                        }
                    }

                    string updateLastLoginQuery = @"
                        UPDATE historique_connexions
                        SET DateDeconnexion = NOW()
                        WHERE IDUtilisateur = @IDUtilisateur
                        AND IDConnexion = @IDConnexion;
                    ";

                    using (MySqlCommand updateLastLoginCmd = new MySqlCommand(updateLastLoginQuery, estConnecter.Connection))
                    {
                        updateLastLoginCmd.Parameters.AddWithValue("@IDUtilisateur", IDUser);
                        updateLastLoginCmd.Parameters.AddWithValue("@IDConnexion", lastLoginID);
                        int rowsAffected = updateLastLoginCmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            this.Close();
                            MessageBox.Show("Déconnexion réussie !");
                            
                        }
                        else
                        {
                            MessageBox.Show("Erreur : aucune ligne mise à jour. Vérifiez si l'utilisateur est connecté ou non.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur lors de la tentative de déconnexion : " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Connexion à la base de données échouée.");
            }
        }




    }
}
