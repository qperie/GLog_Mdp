namespace form
{
    partial class modifierCompte
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
            this.modif = new System.Windows.Forms.Label();
            this.annulerBtn = new System.Windows.Forms.Button();
            this.modifierBtn = new System.Windows.Forms.Button();
            this.forceMdp = new System.Windows.Forms.ProgressBar();
            this.mdpBox = new System.Windows.Forms.TextBox();
            this.loginBox = new System.Windows.Forms.TextBox();
            this.nomBox = new System.Windows.Forms.TextBox();
            this.mdpCompte = new System.Windows.Forms.Label();
            this.loginCompte = new System.Windows.Forms.Label();
            this.nomCompte = new System.Windows.Forms.Label();
            this.genererBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // modif
            // 
            this.modif.AutoSize = true;
            this.modif.Location = new System.Drawing.Point(139, 24);
            this.modif.Name = "modif";
            this.modif.Size = new System.Drawing.Size(93, 13);
            this.modif.TabIndex = 6;
            this.modif.Text = "Modifier le compte";
            // 
            // annulerBtn
            // 
            this.annulerBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.annulerBtn.Location = new System.Drawing.Point(210, 212);
            this.annulerBtn.Name = "annulerBtn";
            this.annulerBtn.Size = new System.Drawing.Size(76, 23);
            this.annulerBtn.TabIndex = 5;
            this.annulerBtn.Text = "Annuler";
            this.annulerBtn.UseVisualStyleBackColor = false;
            // 
            // modifierBtn
            // 
            this.modifierBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.modifierBtn.Location = new System.Drawing.Point(119, 212);
            this.modifierBtn.Name = "modifierBtn";
            this.modifierBtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.modifierBtn.Size = new System.Drawing.Size(76, 23);
            this.modifierBtn.TabIndex = 4;
            this.modifierBtn.Text = "Modifier";
            this.modifierBtn.UseVisualStyleBackColor = true;
            this.modifierBtn.Click += new System.EventHandler(this.modifierBtn_Click);
            // 
            // forceMdp
            // 
            this.forceMdp.Location = new System.Drawing.Point(119, 143);
            this.forceMdp.Maximum = 3;
            this.forceMdp.Name = "forceMdp";
            this.forceMdp.Size = new System.Drawing.Size(167, 13);
            this.forceMdp.Step = 1;
            this.forceMdp.TabIndex = 10;
            // 
            // mdpBox
            // 
            this.mdpBox.Location = new System.Drawing.Point(119, 117);
            this.mdpBox.Name = "mdpBox";
            this.mdpBox.Size = new System.Drawing.Size(167, 20);
            this.mdpBox.TabIndex = 2;
            this.mdpBox.TextChanged += new System.EventHandler(this.mdpBox_TextChanged);
            // 
            // loginBox
            // 
            this.loginBox.Location = new System.Drawing.Point(119, 91);
            this.loginBox.Name = "loginBox";
            this.loginBox.Size = new System.Drawing.Size(167, 20);
            this.loginBox.TabIndex = 1;
            // 
            // nomBox
            // 
            this.nomBox.Location = new System.Drawing.Point(119, 65);
            this.nomBox.Name = "nomBox";
            this.nomBox.Size = new System.Drawing.Size(167, 20);
            this.nomBox.TabIndex = 0;
            // 
            // mdpCompte
            // 
            this.mdpCompte.AutoSize = true;
            this.mdpCompte.Location = new System.Drawing.Point(36, 117);
            this.mdpCompte.Name = "mdpCompte";
            this.mdpCompte.Size = new System.Drawing.Size(77, 13);
            this.mdpCompte.TabIndex = 9;
            this.mdpCompte.Text = "Mot de passe :";
            // 
            // loginCompte
            // 
            this.loginCompte.AutoSize = true;
            this.loginCompte.Location = new System.Drawing.Point(74, 91);
            this.loginCompte.Name = "loginCompte";
            this.loginCompte.Size = new System.Drawing.Size(39, 13);
            this.loginCompte.TabIndex = 8;
            this.loginCompte.Text = "Login :";
            // 
            // nomCompte
            // 
            this.nomCompte.AutoSize = true;
            this.nomCompte.Location = new System.Drawing.Point(74, 65);
            this.nomCompte.Name = "nomCompte";
            this.nomCompte.Size = new System.Drawing.Size(35, 13);
            this.nomCompte.TabIndex = 7;
            this.nomCompte.Text = "Nom :";
            // 
            // genererBtn
            // 
            this.genererBtn.Location = new System.Drawing.Point(119, 162);
            this.genererBtn.Name = "genererBtn";
            this.genererBtn.Size = new System.Drawing.Size(167, 27);
            this.genererBtn.TabIndex = 3;
            this.genererBtn.Text = "Générer un mot de passe";
            this.genererBtn.UseVisualStyleBackColor = true;
            this.genererBtn.Click += new System.EventHandler(this.genererBtn_Click);
            // 
            // modifierCompte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 262);
            this.Controls.Add(this.genererBtn);
            this.Controls.Add(this.modif);
            this.Controls.Add(this.annulerBtn);
            this.Controls.Add(this.modifierBtn);
            this.Controls.Add(this.forceMdp);
            this.Controls.Add(this.mdpBox);
            this.Controls.Add(this.loginBox);
            this.Controls.Add(this.nomBox);
            this.Controls.Add(this.mdpCompte);
            this.Controls.Add(this.loginCompte);
            this.Controls.Add(this.nomCompte);
            this.Name = "modifierCompte";
            this.Text = "Modification du compte";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label modif;
        private System.Windows.Forms.Button annulerBtn;
        private System.Windows.Forms.Button modifierBtn;
        private System.Windows.Forms.ProgressBar forceMdp;
        private System.Windows.Forms.TextBox mdpBox;
        private System.Windows.Forms.TextBox loginBox;
        private System.Windows.Forms.TextBox nomBox;
        private System.Windows.Forms.Label mdpCompte;
        private System.Windows.Forms.Label loginCompte;
        private System.Windows.Forms.Label nomCompte;
        private System.Windows.Forms.Button genererBtn;
    }
}