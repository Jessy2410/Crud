namespace Crud
{
    partial class FormClients
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
            this.label_Nom = new System.Windows.Forms.Label();
            this.label_Prénom = new System.Windows.Forms.Label();
            this.TBNom = new System.Windows.Forms.TextBox();
            this.TBPrenom = new System.Windows.Forms.TextBox();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Enregistrer = new System.Windows.Forms.Button();
            this.TBMail = new System.Windows.Forms.TextBox();
            this.TBMdp = new System.Windows.Forms.TextBox();
            this.LBMail = new System.Windows.Forms.Label();
            this.LBMdp = new System.Windows.Forms.Label();
            this.TBNiveau = new System.Windows.Forms.TextBox();
            this.LBNiveau = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_Nom
            // 
            this.label_Nom.AutoSize = true;
            this.label_Nom.Location = new System.Drawing.Point(101, 51);
            this.label_Nom.Name = "label_Nom";
            this.label_Nom.Size = new System.Drawing.Size(42, 16);
            this.label_Nom.TabIndex = 0;
            this.label_Nom.Text = "Nom :";
            // 
            // label_Prénom
            // 
            this.label_Prénom.AutoSize = true;
            this.label_Prénom.Location = new System.Drawing.Point(101, 103);
            this.label_Prénom.Name = "label_Prénom";
            this.label_Prénom.Size = new System.Drawing.Size(60, 16);
            this.label_Prénom.TabIndex = 1;
            this.label_Prénom.Text = "Prénom :";
            // 
            // TBNom
            // 
            this.TBNom.Location = new System.Drawing.Point(171, 45);
            this.TBNom.Name = "TBNom";
            this.TBNom.Size = new System.Drawing.Size(344, 22);
            this.TBNom.TabIndex = 3;
            // 
            // TBPrenom
            // 
            this.TBPrenom.Location = new System.Drawing.Point(171, 97);
            this.TBPrenom.Name = "TBPrenom";
            this.TBPrenom.Size = new System.Drawing.Size(344, 22);
            this.TBPrenom.TabIndex = 4;
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(104, 281);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(92, 31);
            this.btn_Delete.TabIndex = 6;
            this.btn_Delete.Text = "Supprimer";
            this.btn_Delete.UseVisualStyleBackColor = true;
            // 
            // btn_Enregistrer
            // 
            this.btn_Enregistrer.Location = new System.Drawing.Point(223, 281);
            this.btn_Enregistrer.Name = "btn_Enregistrer";
            this.btn_Enregistrer.Size = new System.Drawing.Size(92, 31);
            this.btn_Enregistrer.TabIndex = 7;
            this.btn_Enregistrer.Text = "Enregistrer";
            this.btn_Enregistrer.UseVisualStyleBackColor = true;
            this.btn_Enregistrer.Click += new System.EventHandler(this.btn_Enregistrer_Click);
            // 
            // TBMail
            // 
            this.TBMail.Location = new System.Drawing.Point(171, 151);
            this.TBMail.Name = "TBMail";
            this.TBMail.Size = new System.Drawing.Size(344, 22);
            this.TBMail.TabIndex = 8;
            // 
            // TBMdp
            // 
            this.TBMdp.Location = new System.Drawing.Point(171, 201);
            this.TBMdp.Name = "TBMdp";
            this.TBMdp.Size = new System.Drawing.Size(344, 22);
            this.TBMdp.TabIndex = 9;
            // 
            // LBMail
            // 
            this.LBMail.AutoSize = true;
            this.LBMail.Location = new System.Drawing.Point(104, 156);
            this.LBMail.Name = "LBMail";
            this.LBMail.Size = new System.Drawing.Size(38, 16);
            this.LBMail.TabIndex = 10;
            this.LBMail.Text = "Mail :";
            // 
            // LBMdp
            // 
            this.LBMdp.AutoSize = true;
            this.LBMdp.Location = new System.Drawing.Point(104, 207);
            this.LBMdp.Name = "LBMdp";
            this.LBMdp.Size = new System.Drawing.Size(40, 16);
            this.LBMdp.TabIndex = 11;
            this.LBMdp.Text = "Mdp :";
            // 
            // TBNiveau
            // 
            this.TBNiveau.Location = new System.Drawing.Point(171, 242);
            this.TBNiveau.Name = "TBNiveau";
            this.TBNiveau.Size = new System.Drawing.Size(344, 22);
            this.TBNiveau.TabIndex = 12;
            // 
            // LBNiveau
            // 
            this.LBNiveau.AutoSize = true;
            this.LBNiveau.Location = new System.Drawing.Point(104, 248);
            this.LBNiveau.Name = "LBNiveau";
            this.LBNiveau.Size = new System.Drawing.Size(56, 16);
            this.LBNiveau.TabIndex = 13;
            this.LBNiveau.Text = "Niveau :";
            // 
            // FormClients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 334);
            this.Controls.Add(this.LBNiveau);
            this.Controls.Add(this.TBNiveau);
            this.Controls.Add(this.LBMdp);
            this.Controls.Add(this.LBMail);
            this.Controls.Add(this.TBMdp);
            this.Controls.Add(this.TBMail);
            this.Controls.Add(this.btn_Enregistrer);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.TBPrenom);
            this.Controls.Add(this.TBNom);
            this.Controls.Add(this.label_Prénom);
            this.Controls.Add(this.label_Nom);
            this.Name = "FormClients";
            this.Text = "FormClients";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Nom;
        private System.Windows.Forms.Label label_Prénom;
        private System.Windows.Forms.TextBox TBNom;
        private System.Windows.Forms.TextBox TBPrenom;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Enregistrer;
        private System.Windows.Forms.TextBox TBMail;
        private System.Windows.Forms.TextBox TBMdp;
        private System.Windows.Forms.Label LBMail;
        private System.Windows.Forms.Label LBMdp;
        private System.Windows.Forms.TextBox TBNiveau;
        private System.Windows.Forms.Label LBNiveau;
    }
}