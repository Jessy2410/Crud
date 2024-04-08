using System.Security.Cryptography;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Org.BouncyCastle.Asn1.Cmp.Challenge;

namespace Crud
{
    public class Client
    {
        public int IDUser { get; set; }
        public string ContactNom { get; set; }
        public string ContactPrenom { get; set; }
        public string ContactMail { get; set; }
        public string ContactMdp { get; set; }
        public string ContactNiveau { get; set; }
        public DateTime LastLogin { get; set; }

        Random random = new Random();
        public void Delete(DBConnection DataBaseConnection, MySqlDataReader TheReader)
        {
            if (DataBaseConnection.IsConnect())
            {
                try
                {
                    String sqlString = "DELETE FROM user WHERE idUser = ?idUser";
                    //sqlString = Tools.PrepareLigne(sqlString, "?code_c", ContactID.ToString());

                    sqlString = Tools.PrepareLigne(sqlString, "?idUser", Tools.PrepareChamp(IDUser.ToString(), "Nombre"));
                    var cmd = new MySqlCommand(sqlString, DataBaseConnection.Connection);
                    cmd.ExecuteNonQuery();
                }
                catch (MySql.Data.MySqlClient.MySqlException ex)
                {
                    Console.Write("Erreur N° " + ex.Number + " : " + ex.Message);

                }
            }
        }

        public void Modifier(DBConnection DataBaseConnection, string nom, string prenom, string mail, string mdp, string niveau)
        {
            if (DataBaseConnection.IsConnect())
            {
                try
                {
                    string sqlUpdate = "UPDATE user SET nom = @nom, prenom = @prenom, mail = @mail, mdp = @mdp, niveau = @niveau     WHERE idUser = @idUser";

                    using (MySqlCommand cmd = new MySqlCommand(sqlUpdate, DataBaseConnection.Connection))
                    {
                        cmd.Parameters.AddWithValue("@nom", nom);
                        cmd.Parameters.AddWithValue("@prenom", prenom);
                        cmd.Parameters.AddWithValue("@mail", mail);
                        cmd.Parameters.AddWithValue("@mdp", mdp);
                        cmd.Parameters.AddWithValue("@niveau", niveau);
                        cmd.Parameters.AddWithValue("@idUser", IDUser);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            Console.WriteLine("Les données de l'utilisateur ont été modifiées avec succès !");
                        }
                        else
                        {
                            Console.WriteLine("Aucune donnée d'utilisateur n'a été modifiée.");
                        }
                    }
                }
                catch (MySql.Data.MySqlClient.MySqlException ex)
                {
                    Console.WriteLine("Erreur N° : " + ex.Number + ", Message : " + ex.Message);
                }
            }
            else
            {
                Console.WriteLine("Connexion à la base de données échouée.");
            }
        }


        public void Save(string newNom, string newPrenom, string newMail, string newMdp, string newNiveau)
        {
            DBConnection estConnecter = new DBConnection();

            estConnecter.Server = "localhost";
            estConnecter.DatabaseName = "crud2";
            estConnecter.UserName = "root";
            estConnecter.Password = Crypto.Decrypt("8QMF/XZEGWSWu1ZY4F3wtg==");
            estConnecter.IsConnect();

            string query = "INSERT INTO user (Nom, Prenom, Mail, Mdp, Niveau) VALUES (@Nom, @Prenom, @Mail, @Mdp, @Niveau)";

            using (MySqlCommand commande = new MySqlCommand(query, estConnecter.Connection))
            {
                commande.Parameters.AddWithValue("@Nom", newNom);
                commande.Parameters.AddWithValue("@Prenom", newPrenom);
                commande.Parameters.AddWithValue("@Mail", newMail);
                commande.Parameters.AddWithValue("@Mdp", newMdp);
                commande.Parameters.AddWithValue("@Niveau", newNiveau);

                int lignesAffectees = commande.ExecuteNonQuery();

                if (lignesAffectees > 0)
                {
                    MessageBox.Show("Les données ont été insérées avec succès dans la base de données.");
                }
                else
                {
                    MessageBox.Show("Aucune donnée n'a été insérée dans la base de données.");
                }
            }
        }

        public void SaveHashe(string newNom, string newPrenom, string newMail, string newMdp, string newNiveau)
        {
            string hashedPassword = SHA.mdpHasheAvecSel(newMdp);
            Save(newNom, newPrenom, newMail, hashedPassword, newNiveau);

        }



    }
    
}
