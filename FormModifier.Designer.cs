namespace Crud
{
    partial class FormModifier
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
            this.BTNSave = new System.Windows.Forms.Button();
            this.TBNom = new System.Windows.Forms.TextBox();
            this.TBPrenom = new System.Windows.Forms.TextBox();
            this.TBMail = new System.Windows.Forms.TextBox();
            this.TBMdp = new System.Windows.Forms.TextBox();
            this.LBNom = new System.Windows.Forms.Label();
            this.LBPrenom = new System.Windows.Forms.Label();
            this.LBMail = new System.Windows.Forms.Label();
            this.LBMdp = new System.Windows.Forms.Label();
            this.TBNiveau = new System.Windows.Forms.TextBox();
            this.LBNiveau = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BTNSave
            // 
            this.BTNSave.Location = new System.Drawing.Point(100, 253);
            this.BTNSave.Name = "BTNSave";
            this.BTNSave.Size = new System.Drawing.Size(90, 23);
            this.BTNSave.TabIndex = 0;
            this.BTNSave.Text = "Enregistrer";
            this.BTNSave.UseVisualStyleBackColor = true;
            this.BTNSave.Click += new System.EventHandler(this.BTNSave_Click);
            // 
            // TBNom
            // 
            this.TBNom.Location = new System.Drawing.Point(100, 67);
            this.TBNom.Name = "TBNom";
            this.TBNom.Size = new System.Drawing.Size(276, 22);
            this.TBNom.TabIndex = 1;
            // 
            // TBPrenom
            // 
            this.TBPrenom.Location = new System.Drawing.Point(100, 106);
            this.TBPrenom.Name = "TBPrenom";
            this.TBPrenom.Size = new System.Drawing.Size(276, 22);
            this.TBPrenom.TabIndex = 2;
            // 
            // TBMail
            // 
            this.TBMail.Location = new System.Drawing.Point(100, 141);
            this.TBMail.Name = "TBMail";
            this.TBMail.Size = new System.Drawing.Size(276, 22);
            this.TBMail.TabIndex = 3;
            // 
            // TBMdp
            // 
            this.TBMdp.Location = new System.Drawing.Point(100, 176);
            this.TBMdp.Name = "TBMdp";
            this.TBMdp.Size = new System.Drawing.Size(276, 22);
            this.TBMdp.TabIndex = 4;
            // 
            // LBNom
            // 
            this.LBNom.AutoSize = true;
            this.LBNom.Location = new System.Drawing.Point(52, 73);
            this.LBNom.Name = "LBNom";
            this.LBNom.Size = new System.Drawing.Size(42, 16);
            this.LBNom.TabIndex = 5;
            this.LBNom.Text = "Nom :";
            // 
            // LBPrenom
            // 
            this.LBPrenom.AutoSize = true;
            this.LBPrenom.Location = new System.Drawing.Point(34, 112);
            this.LBPrenom.Name = "LBPrenom";
            this.LBPrenom.Size = new System.Drawing.Size(60, 16);
            this.LBPrenom.TabIndex = 6;
            this.LBPrenom.Text = "Prénom :";
            // 
            // LBMail
            // 
            this.LBMail.AutoSize = true;
            this.LBMail.Location = new System.Drawing.Point(56, 147);
            this.LBMail.Name = "LBMail";
            this.LBMail.Size = new System.Drawing.Size(38, 16);
            this.LBMail.TabIndex = 7;
            this.LBMail.Text = "Mail :";
            // 
            // LBMdp
            // 
            this.LBMdp.AutoSize = true;
            this.LBMdp.Location = new System.Drawing.Point(54, 182);
            this.LBMdp.Name = "LBMdp";
            this.LBMdp.Size = new System.Drawing.Size(40, 16);
            this.LBMdp.TabIndex = 8;
            this.LBMdp.Text = "Mdp :";
            // 
            // TBNiveau
            // 
            this.TBNiveau.Location = new System.Drawing.Point(100, 215);
            this.TBNiveau.Name = "TBNiveau";
            this.TBNiveau.Size = new System.Drawing.Size(276, 22);
            this.TBNiveau.TabIndex = 9;
            // 
            // LBNiveau
            // 
            this.LBNiveau.AutoSize = true;
            this.LBNiveau.Location = new System.Drawing.Point(38, 221);
            this.LBNiveau.Name = "LBNiveau";
            this.LBNiveau.Size = new System.Drawing.Size(56, 16);
            this.LBNiveau.TabIndex = 10;
            this.LBNiveau.Text = "Niveau :";
            // 
            // FormModifier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 288);
            this.Controls.Add(this.LBNiveau);
            this.Controls.Add(this.TBNiveau);
            this.Controls.Add(this.LBMdp);
            this.Controls.Add(this.LBMail);
            this.Controls.Add(this.LBPrenom);
            this.Controls.Add(this.LBNom);
            this.Controls.Add(this.TBMdp);
            this.Controls.Add(this.TBMail);
            this.Controls.Add(this.TBPrenom);
            this.Controls.Add(this.TBNom);
            this.Controls.Add(this.BTNSave);
            this.Name = "FormModifier";
            this.Text = "FormModifier";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTNSave;
        private System.Windows.Forms.TextBox TBNom;
        private System.Windows.Forms.TextBox TBPrenom;
        private System.Windows.Forms.TextBox TBMail;
        private System.Windows.Forms.TextBox TBMdp;
        private System.Windows.Forms.Label LBNom;
        private System.Windows.Forms.Label LBPrenom;
        private System.Windows.Forms.Label LBMail;
        private System.Windows.Forms.Label LBMdp;
        private System.Windows.Forms.TextBox TBNiveau;
        private System.Windows.Forms.Label LBNiveau;
    }
}