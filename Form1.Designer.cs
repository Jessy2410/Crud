namespace Crud
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnConnex = new System.Windows.Forms.Button();
            this.TBMdp = new System.Windows.Forms.TextBox();
            this.btnDisconn = new System.Windows.Forms.Button();
            this.btnPointInterr = new System.Windows.Forms.Button();
            this.RTBClients = new System.Windows.Forms.RichTextBox();
            this.btnRemplissage = new System.Windows.Forms.Button();
            this.LBCompteur = new System.Windows.Forms.Label();
            this.btnOpen = new System.Windows.Forms.Button();
            this.DGV1 = new System.Windows.Forms.DataGridView();
            this.TBMail = new System.Windows.Forms.TextBox();
            this.LB_Mail = new System.Windows.Forms.Label();
            this.LB_Mdp = new System.Windows.Forms.Label();
            this.mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            this.mySqlCommand2 = new MySql.Data.MySqlClient.MySqlCommand();
            ((System.ComponentModel.ISupportInitialize)(this.DGV1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConnex
            // 
            this.btnConnex.BackColor = System.Drawing.Color.DarkGreen;
            this.btnConnex.Location = new System.Drawing.Point(83, 101);
            this.btnConnex.Margin = new System.Windows.Forms.Padding(2);
            this.btnConnex.Name = "btnConnex";
            this.btnConnex.Size = new System.Drawing.Size(112, 28);
            this.btnConnex.TabIndex = 0;
            this.btnConnex.Text = "Connexion";
            this.btnConnex.UseVisualStyleBackColor = false;
            this.btnConnex.Click += new System.EventHandler(this.btnConnex_Click);
            // 
            // TBMdp
            // 
            this.TBMdp.Location = new System.Drawing.Point(83, 57);
            this.TBMdp.Margin = new System.Windows.Forms.Padding(2);
            this.TBMdp.Multiline = true;
            this.TBMdp.Name = "TBMdp";
            this.TBMdp.Size = new System.Drawing.Size(355, 25);
            this.TBMdp.TabIndex = 1;
            // 
            // btnDisconn
            // 
            this.btnDisconn.BackColor = System.Drawing.Color.Crimson;
            this.btnDisconn.Location = new System.Drawing.Point(212, 100);
            this.btnDisconn.Margin = new System.Windows.Forms.Padding(2);
            this.btnDisconn.Name = "btnDisconn";
            this.btnDisconn.Size = new System.Drawing.Size(114, 29);
            this.btnDisconn.TabIndex = 2;
            this.btnDisconn.Text = "Déconnexion";
            this.btnDisconn.UseVisualStyleBackColor = false;
            this.btnDisconn.Click += new System.EventHandler(this.btnDisconn_Click);
            // 
            // btnPointInterr
            // 
            this.btnPointInterr.Location = new System.Drawing.Point(567, 8);
            this.btnPointInterr.Margin = new System.Windows.Forms.Padding(2);
            this.btnPointInterr.Name = "btnPointInterr";
            this.btnPointInterr.Size = new System.Drawing.Size(43, 43);
            this.btnPointInterr.TabIndex = 3;
            this.btnPointInterr.Text = "?";
            this.btnPointInterr.UseVisualStyleBackColor = true;
            this.btnPointInterr.Click += new System.EventHandler(this.btnPointInterr_Click);
            // 
            // RTBClients
            // 
            this.RTBClients.Location = new System.Drawing.Point(89, 437);
            this.RTBClients.Margin = new System.Windows.Forms.Padding(2);
            this.RTBClients.Name = "RTBClients";
            this.RTBClients.Size = new System.Drawing.Size(484, 141);
            this.RTBClients.TabIndex = 4;
            this.RTBClients.Text = "";
            // 
            // btnRemplissage
            // 
            this.btnRemplissage.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnRemplissage.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnRemplissage.Location = new System.Drawing.Point(353, 508);
            this.btnRemplissage.Margin = new System.Windows.Forms.Padding(2);
            this.btnRemplissage.Name = "btnRemplissage";
            this.btnRemplissage.Size = new System.Drawing.Size(112, 33);
            this.btnRemplissage.TabIndex = 5;
            this.btnRemplissage.Text = "Remplir";
            this.btnRemplissage.UseVisualStyleBackColor = false;
            this.btnRemplissage.Click += new System.EventHandler(this.btnRemplissage_Click);
            // 
            // LBCompteur
            // 
            this.LBCompteur.AutoSize = true;
            this.LBCompteur.Location = new System.Drawing.Point(86, 156);
            this.LBCompteur.Name = "LBCompteur";
            this.LBCompteur.Size = new System.Drawing.Size(0, 16);
            this.LBCompteur.TabIndex = 6;
            // 
            // btnOpen
            // 
            this.btnOpen.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnOpen.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnOpen.Location = new System.Drawing.Point(114, 485);
            this.btnOpen.Margin = new System.Windows.Forms.Padding(2);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(112, 33);
            this.btnOpen.TabIndex = 8;
            this.btnOpen.Text = "Ouvrir";
            this.btnOpen.UseVisualStyleBackColor = false;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // DGV1
            // 
            this.DGV1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV1.Location = new System.Drawing.Point(89, 437);
            this.DGV1.Name = "DGV1";
            this.DGV1.RowHeadersWidth = 51;
            this.DGV1.RowTemplate.Height = 24;
            this.DGV1.Size = new System.Drawing.Size(484, 150);
            this.DGV1.TabIndex = 9;
            // 
            // TBMail
            // 
            this.TBMail.Location = new System.Drawing.Point(83, 11);
            this.TBMail.Margin = new System.Windows.Forms.Padding(2);
            this.TBMail.Multiline = true;
            this.TBMail.Name = "TBMail";
            this.TBMail.Size = new System.Drawing.Size(355, 31);
            this.TBMail.TabIndex = 10;
            // 
            // LB_Mail
            // 
            this.LB_Mail.AutoSize = true;
            this.LB_Mail.Location = new System.Drawing.Point(38, 26);
            this.LB_Mail.Name = "LB_Mail";
            this.LB_Mail.Size = new System.Drawing.Size(38, 16);
            this.LB_Mail.TabIndex = 11;
            this.LB_Mail.Text = "Mail :";
            // 
            // LB_Mdp
            // 
            this.LB_Mdp.AutoSize = true;
            this.LB_Mdp.Location = new System.Drawing.Point(38, 66);
            this.LB_Mdp.Name = "LB_Mdp";
            this.LB_Mdp.Size = new System.Drawing.Size(40, 16);
            this.LB_Mdp.TabIndex = 12;
            this.LB_Mdp.Text = "Mdp :";
            // 
            // mySqlCommand1
            // 
            this.mySqlCommand1.CacheAge = 0;
            this.mySqlCommand1.Connection = null;
            this.mySqlCommand1.EnableCaching = false;
            this.mySqlCommand1.Transaction = null;
            // 
            // mySqlCommand2
            // 
            this.mySqlCommand2.CacheAge = 0;
            this.mySqlCommand2.Connection = null;
            this.mySqlCommand2.EnableCaching = false;
            this.mySqlCommand2.Transaction = null;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 196);
            this.Controls.Add(this.LB_Mdp);
            this.Controls.Add(this.LB_Mail);
            this.Controls.Add(this.TBMail);
            this.Controls.Add(this.DGV1);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.LBCompteur);
            this.Controls.Add(this.btnRemplissage);
            this.Controls.Add(this.RTBClients);
            this.Controls.Add(this.btnPointInterr);
            this.Controls.Add(this.btnDisconn);
            this.Controls.Add(this.TBMdp);
            this.Controls.Add(this.btnConnex);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Page de connexion";
            ((System.ComponentModel.ISupportInitialize)(this.DGV1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConnex;
        private System.Windows.Forms.TextBox TBMdp;
        private System.Windows.Forms.Button btnDisconn;
        private System.Windows.Forms.Button btnPointInterr;
        private System.Windows.Forms.RichTextBox RTBClients;
        private System.Windows.Forms.Button btnRemplissage;
        private System.Windows.Forms.Label LBCompteur;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.DataGridView DGV1;
        private System.Windows.Forms.TextBox TBMail;
        private System.Windows.Forms.Label LB_Mail;
        private System.Windows.Forms.Label LB_Mdp;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand2;
    }
}

