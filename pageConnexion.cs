using MySqlX.XDevAPI.Common;
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
    public partial class pageConnexion : Form
    {

        DBConnection seConnecter = new DBConnection();
        public pageConnexion()
        {
            InitializeComponent();
        }

        private void btnConnexion_Click(object sender, EventArgs e)
        {
            seConnecter.Server = "localhost";
            seConnecter.DatabaseName = "CRUD";
            seConnecter.UserName = "UserCrud";
            seConnecter.Password = Crypto.Decrypt("FpTbmsqYJzCUxooUrLYCew==");

            if (seConnecter.IsConnect())
            {
                TBMdp.Text = "est connecté";
            }
            else
            {
                TBMdp.Text = "Problème de connexion";
            }
        }

        private void btnCrypt_Click(object sender, EventArgs e)
        {
             FormUtilitaire formUtil = new FormUtilitaire();
             formUtil.Show();
        }
    }
}
