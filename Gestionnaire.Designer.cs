namespace Crud
{
    partial class Gestionnaire
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAfficherListe = new System.Windows.Forms.Button();
            this.DGVListeUtilisateurs = new System.Windows.Forms.DataGridView();
            this.RTBUser = new System.Windows.Forms.RichTextBox();
            this.LB_CPT = new System.Windows.Forms.Label();
            this.btn_Actualiser = new System.Windows.Forms.Button();
            this.btn_Modifier = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnHistoriqueConnexions = new System.Windows.Forms.Button();
            this.DVGHistoriqueConnexion = new System.Windows.Forms.DataGridView();
            this.btnDéconnexion = new System.Windows.Forms.Button();
            this.CBUser = new System.Windows.Forms.ComboBox();
            this.btnFiltrer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGVListeUtilisateurs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DVGHistoriqueConnexion)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAfficherListe
            // 
            this.btnAfficherListe.BackColor = System.Drawing.Color.Orange;
            this.btnAfficherListe.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAfficherListe.Location = new System.Drawing.Point(24, 101);
            this.btnAfficherListe.Name = "btnAfficherListe";
            this.btnAfficherListe.Size = new System.Drawing.Size(100, 42);
            this.btnAfficherListe.TabIndex = 1;
            this.btnAfficherListe.Text = "Liste Utilisateur";
            this.btnAfficherListe.UseVisualStyleBackColor = false;
            this.btnAfficherListe.Click += new System.EventHandler(this.btnAfficherListe_Click);
            // 
            // DGVListeUtilisateurs
            // 
            this.DGVListeUtilisateurs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVListeUtilisateurs.Location = new System.Drawing.Point(24, 170);
            this.DGVListeUtilisateurs.Name = "DGVListeUtilisateurs";
            this.DGVListeUtilisateurs.RowHeadersWidth = 51;
            this.DGVListeUtilisateurs.RowTemplate.Height = 24;
            this.DGVListeUtilisateurs.Size = new System.Drawing.Size(726, 268);
            this.DGVListeUtilisateurs.TabIndex = 2;
            // 
            // RTBUser
            // 
            this.RTBUser.Location = new System.Drawing.Point(859, 308);
            this.RTBUser.Name = "RTBUser";
            this.RTBUser.Size = new System.Drawing.Size(52, 32);
            this.RTBUser.TabIndex = 3;
            this.RTBUser.Text = "";
            // 
            // LB_CPT
            // 
            this.LB_CPT.AutoSize = true;
            this.LB_CPT.BackColor = System.Drawing.Color.Transparent;
            this.LB_CPT.Location = new System.Drawing.Point(256, 151);
            this.LB_CPT.Name = "LB_CPT";
            this.LB_CPT.Size = new System.Drawing.Size(0, 16);
            this.LB_CPT.TabIndex = 4;
            // 
            // btn_Actualiser
            // 
            this.btn_Actualiser.BackColor = System.Drawing.Color.Orange;
            this.btn_Actualiser.Image = global::Crud.Properties.Resources.actualiser3;
            this.btn_Actualiser.Location = new System.Drawing.Point(446, 101);
            this.btn_Actualiser.Name = "btn_Actualiser";
            this.btn_Actualiser.Size = new System.Drawing.Size(83, 42);
            this.btn_Actualiser.TabIndex = 7;
            this.btn_Actualiser.UseVisualStyleBackColor = false;
            this.btn_Actualiser.Click += new System.EventHandler(this.btn_Actualiser_Click);
            // 
            // btn_Modifier
            // 
            this.btn_Modifier.BackColor = System.Drawing.Color.Black;
            this.btn_Modifier.Image = global::Crud.Properties.Resources.edit2;
            this.btn_Modifier.Location = new System.Drawing.Point(344, 101);
            this.btn_Modifier.Name = "btn_Modifier";
            this.btn_Modifier.Size = new System.Drawing.Size(78, 42);
            this.btn_Modifier.TabIndex = 6;
            this.btn_Modifier.UseVisualStyleBackColor = false;
            this.btn_Modifier.Click += new System.EventHandler(this.btn_Modifier_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.BackColor = System.Drawing.Color.Orange;
            this.btn_Delete.Image = global::Crud.Properties.Resources.supp1;
            this.btn_Delete.Location = new System.Drawing.Point(229, 101);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(94, 42);
            this.btn_Delete.TabIndex = 5;
            this.btn_Delete.UseVisualStyleBackColor = false;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btnAjouter
            // 
            this.btnAjouter.BackColor = System.Drawing.Color.Black;
            this.btnAjouter.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnAjouter.Image = global::Crud.Properties.Resources.plus2;
            this.btnAjouter.Location = new System.Drawing.Point(130, 101);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(76, 42);
            this.btnAjouter.TabIndex = 0;
            this.btnAjouter.UseVisualStyleBackColor = false;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // btnHistoriqueConnexions
            // 
            this.btnHistoriqueConnexions.BackColor = System.Drawing.Color.Orange;
            this.btnHistoriqueConnexions.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHistoriqueConnexions.Location = new System.Drawing.Point(547, 101);
            this.btnHistoriqueConnexions.Name = "btnHistoriqueConnexions";
            this.btnHistoriqueConnexions.Size = new System.Drawing.Size(134, 42);
            this.btnHistoriqueConnexions.TabIndex = 8;
            this.btnHistoriqueConnexions.Text = "Historique de connexions";
            this.btnHistoriqueConnexions.UseVisualStyleBackColor = false;
            this.btnHistoriqueConnexions.Click += new System.EventHandler(this.btnHistoriqueConnexions_Click);
            // 
            // DVGHistoriqueConnexion
            // 
            this.DVGHistoriqueConnexion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DVGHistoriqueConnexion.Location = new System.Drawing.Point(24, 170);
            this.DVGHistoriqueConnexion.Name = "DVGHistoriqueConnexion";
            this.DVGHistoriqueConnexion.RowHeadersWidth = 51;
            this.DVGHistoriqueConnexion.RowTemplate.Height = 24;
            this.DVGHistoriqueConnexion.Size = new System.Drawing.Size(505, 268);
            this.DVGHistoriqueConnexion.TabIndex = 9;
            // 
            // btnDéconnexion
            // 
            this.btnDéconnexion.BackColor = System.Drawing.Color.Orange;
            this.btnDéconnexion.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDéconnexion.Location = new System.Drawing.Point(590, 12);
            this.btnDéconnexion.Name = "btnDéconnexion";
            this.btnDéconnexion.Size = new System.Drawing.Size(169, 27);
            this.btnDéconnexion.TabIndex = 10;
            this.btnDéconnexion.Text = "Se déconnecter";
            this.btnDéconnexion.UseVisualStyleBackColor = false;
            this.btnDéconnexion.Click += new System.EventHandler(this.btnDéconnexion_Click);
            // 
            // CBUser
            // 
            this.CBUser.FormattingEnabled = true;
            this.CBUser.Location = new System.Drawing.Point(541, 227);
            this.CBUser.Name = "CBUser";
            this.CBUser.Size = new System.Drawing.Size(218, 24);
            this.CBUser.TabIndex = 11;
            this.CBUser.Text = "Tous";
            this.CBUser.Visible = false;
            // 
            // btnFiltrer
            // 
            this.btnFiltrer.BackColor = System.Drawing.Color.Orange;
            this.btnFiltrer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltrer.Location = new System.Drawing.Point(590, 336);
            this.btnFiltrer.Name = "btnFiltrer";
            this.btnFiltrer.Size = new System.Drawing.Size(118, 41);
            this.btnFiltrer.TabIndex = 12;
            this.btnFiltrer.Text = "Filtrer";
            this.btnFiltrer.UseVisualStyleBackColor = false;
            this.btnFiltrer.Visible = false;
            // 
            // Gestionnaire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.BackgroundImage = global::Crud.Properties.Resources.fondOrange2;
            this.ClientSize = new System.Drawing.Size(771, 450);
            this.Controls.Add(this.btnFiltrer);
            this.Controls.Add(this.CBUser);
            this.Controls.Add(this.btnDéconnexion);
            this.Controls.Add(this.DVGHistoriqueConnexion);
            this.Controls.Add(this.btnHistoriqueConnexions);
            this.Controls.Add(this.btn_Actualiser);
            this.Controls.Add(this.btn_Modifier);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.LB_CPT);
            this.Controls.Add(this.RTBUser);
            this.Controls.Add(this.DGVListeUtilisateurs);
            this.Controls.Add(this.btnAfficherListe);
            this.Controls.Add(this.btnAjouter);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Gestionnaire";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestionnaire";
            ((System.ComponentModel.ISupportInitialize)(this.DGVListeUtilisateurs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DVGHistoriqueConnexion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnAfficherListe;
        private System.Windows.Forms.DataGridView DGVListeUtilisateurs;
        private System.Windows.Forms.RichTextBox RTBUser;
        private System.Windows.Forms.Label LB_CPT;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Modifier;
        private System.Windows.Forms.Button btn_Actualiser;
        private System.Windows.Forms.Button btnHistoriqueConnexions;
        private System.Windows.Forms.DataGridView DVGHistoriqueConnexion;
        private System.Windows.Forms.Button btnDéconnexion;
        private System.Windows.Forms.ComboBox CBUser;
        private System.Windows.Forms.Button btnFiltrer;
    }
}