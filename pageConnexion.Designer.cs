namespace Crud
{
    partial class pageConnexion
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
            this.LBIdentifiant = new System.Windows.Forms.Label();
            this.LBMdp = new System.Windows.Forms.Label();
            this.TBMail = new System.Windows.Forms.TextBox();
            this.TBMdp = new System.Windows.Forms.TextBox();
            this.btnConnexion = new System.Windows.Forms.Button();
            this.btnCrypt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LBIdentifiant
            // 
            this.LBIdentifiant.AutoSize = true;
            this.LBIdentifiant.Location = new System.Drawing.Point(133, 94);
            this.LBIdentifiant.Name = "LBIdentifiant";
            this.LBIdentifiant.Size = new System.Drawing.Size(38, 16);
            this.LBIdentifiant.TabIndex = 0;
            this.LBIdentifiant.Text = "mail :";
            // 
            // LBMdp
            // 
            this.LBMdp.AutoSize = true;
            this.LBMdp.Location = new System.Drawing.Point(76, 140);
            this.LBMdp.Name = "LBMdp";
            this.LBMdp.Size = new System.Drawing.Size(95, 16);
            this.LBMdp.TabIndex = 1;
            this.LBMdp.Text = "Mot de passe :";
            // 
            // TBMail
            // 
            this.TBMail.Location = new System.Drawing.Point(177, 88);
            this.TBMail.Name = "TBMail";
            this.TBMail.Size = new System.Drawing.Size(194, 22);
            this.TBMail.TabIndex = 2;
            // 
            // TBMdp
            // 
            this.TBMdp.Location = new System.Drawing.Point(177, 134);
            this.TBMdp.Name = "TBMdp";
            this.TBMdp.Size = new System.Drawing.Size(194, 22);
            this.TBMdp.TabIndex = 3;
            // 
            // btnConnexion
            // 
            this.btnConnexion.BackColor = System.Drawing.Color.LimeGreen;
            this.btnConnexion.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnConnexion.Location = new System.Drawing.Point(177, 184);
            this.btnConnexion.Name = "btnConnexion";
            this.btnConnexion.Size = new System.Drawing.Size(113, 34);
            this.btnConnexion.TabIndex = 4;
            this.btnConnexion.Text = "se connecter";
            this.btnConnexion.UseVisualStyleBackColor = false;
            this.btnConnexion.Click += new System.EventHandler(this.btnConnexion_Click);
            // 
            // btnCrypt
            // 
            this.btnCrypt.Location = new System.Drawing.Point(415, 75);
            this.btnCrypt.Name = "btnCrypt";
            this.btnCrypt.Size = new System.Drawing.Size(36, 35);
            this.btnCrypt.TabIndex = 5;
            this.btnCrypt.Text = "?";
            this.btnCrypt.UseVisualStyleBackColor = true;
            this.btnCrypt.Click += new System.EventHandler(this.btnCrypt_Click);
            // 
            // pageConnexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCrypt);
            this.Controls.Add(this.btnConnexion);
            this.Controls.Add(this.TBMdp);
            this.Controls.Add(this.TBMail);
            this.Controls.Add(this.LBMdp);
            this.Controls.Add(this.LBIdentifiant);
            this.Name = "pageConnexion";
            this.Text = "pageConnexion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBIdentifiant;
        private System.Windows.Forms.Label LBMdp;
        private System.Windows.Forms.TextBox TBMail;
        private System.Windows.Forms.TextBox TBMdp;
        private System.Windows.Forms.Button btnConnexion;
        private System.Windows.Forms.Button btnCrypt;
    }
}