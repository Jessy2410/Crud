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
    public partial class FormModifier : Form
    {
        private Client userUpdate;
        private DBConnection laconnexion;
        MySqlDataReader Reader;
        public FormModifier(Client leClient, DBConnection estConnecte)
        {
            InitializeComponent();

            userUpdate = leClient;

            // Initialisez la connexion avec la connexion passée en paramètre
            laconnexion = estConnecte;

            TBNom.Text = userUpdate.ContactNom;
            TBPrenom.Text = userUpdate.ContactPrenom;
            TBMail.Text = userUpdate.ContactMail;
            TBMdp.Text = userUpdate.ContactMdp;
            TBNiveau.Text = userUpdate.ContactNiveau;

            this.Text = "Modifier l'utilisateur " + userUpdate.ContactPrenom;
        }

        private void BTNSave_Click(object sender, EventArgs e)
        {

            string nom = TBNom.Text;
            string prenom = TBPrenom.Text;
            string mail = TBMail.Text;
            string mdp = TBMdp.Text;
            string niveau = TBNiveau.Text;

            userUpdate.Modifier(laconnexion, nom, prenom, mail, mdp, niveau);
        }
    }
}
