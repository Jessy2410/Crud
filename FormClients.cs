using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Crud
{
    public partial class FormClients : Form
    {
        DBConnection DataBaseConnection;
        Client LeClientCourant;
        Client monClient = new Client();
        DBConnection estConnecter = new DBConnection();
        public FormClients(Client monClient, DBConnection dbConnection)
        {
            InitializeComponent();
            LeClientCourant = monClient;
            DataBaseConnection = dbConnection;
            TBNom.Text = monClient.ContactNom;
            TBMail.Text = monClient.ContactMail;
            TBMdp.Text = monClient.ContactMdp;
            TBNiveau.Text = monClient.ContactNiveau;
            this.Text = "Créer un nouvel utilisateur";
        }

        private void btn_Enregistrer_Click(object sender, EventArgs e)
        {
            string newNom = TBNom.Text;
            string newPrenom = TBPrenom.Text;
            string newMail = TBMail.Text;
            string newMdp = TBMdp.Text;
            string newNiveau = TBNiveau.Text;

            Client NVClient = new Client();

            NVClient.SaveHashe(newNom, newPrenom, newMail, newMdp, newNiveau);
        }

        private void TBNom_TextChanged(object sender, EventArgs e)
        {
            LeClientCourant.ContactNom = TBNom.Text;
        }

        private void TBPrenom_Click(object sender, EventArgs e)
        {
            LeClientCourant.ContactPrenom = TBPrenom.Text;

        }
        

    }
}
