namespace form
{
    partial class ajoutCompte
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
            this.annulerBtn = new System.Windows.Forms.Button();
            this.validerBtn = new System.Windows.Forms.Button();
            this.forceMdp = new System.Windows.Forms.ProgressBar();
            this.mdpBox = new System.Windows.Forms.TextBox();
            this.loginBox = new System.Windows.Forms.TextBox();
            this.nomBox = new System.Windows.Forms.TextBox();
            this.mdpCompte = new System.Windows.Forms.Label();
            this.loginCompte = new System.Windows.Forms.Label();
            this.nomCompte = new System.Windows.Forms.Label();
            this.ajout = new System.Windows.Forms.Label();
            this.genererBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // annulerBtn
            // 
            this.annulerBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.annulerBtn.Location = new System.Drawing.Point(184, 244);
            this.annulerBtn.Name = "annulerBtn";
            this.annulerBtn.Size = new System.Drawing.Size(76, 23);
            this.annulerBtn.TabIndex = 5;
            this.annulerBtn.Text = "Annuler";
            this.annulerBtn.UseVisualStyleBackColor = false;
            // 
            // validerBtn
            // 
            this.validerBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.validerBtn.Location = new System.Drawing.Point(93, 244);
            this.validerBtn.Name = "validerBtn";
            this.validerBtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.validerBtn.Size = new System.Drawing.Size(76, 23);
            this.validerBtn.TabIndex = 4;
            this.validerBtn.Text = "Valider";
            this.validerBtn.UseVisualStyleBackColor = true;
            this.validerBtn.Click += new System.EventHandler(this.validerBtn_Click);
            // 
            // forceMdp
            // 
            this.forceMdp.Location = new System.Drawing.Point(93, 177);
            this.forceMdp.Maximum = 3;
            this.forceMdp.Name = "forceMdp";
            this.forceMdp.Size = new System.Drawing.Size(167, 13);
            this.forceMdp.Step = 1;
            this.forceMdp.TabIndex = 10;
            // 
            // mdpBox
            // 
            this.mdpBox.Location = new System.Drawing.Point(93, 151);
            this.mdpBox.Name = "mdpBox";
            this.mdpBox.Size = new System.Drawing.Size(167, 20);
            this.mdpBox.TabIndex = 2;
            this.mdpBox.TextChanged += new System.EventHandler(this.mdpBox_TextChanged);
            // 
            // loginBox
            // 
            this.loginBox.Location = new System.Drawing.Point(93, 125);
            this.loginBox.Name = "loginBox";
            this.loginBox.Size = new System.Drawing.Size(167, 20);
            this.loginBox.TabIndex = 1;
            // 
            // nomBox
            // 
            this.nomBox.Location = new System.Drawing.Point(93, 99);
            this.nomBox.Name = "nomBox";
            this.nomBox.Size = new System.Drawing.Size(167, 20);
            this.nomBox.TabIndex = 0;
            // 
            // mdpCompte
            // 
            this.mdpCompte.AutoSize = true;
            this.mdpCompte.Location = new System.Drawing.Point(10, 151);
            this.mdpCompte.Name = "mdpCompte";
            this.mdpCompte.Size = new System.Drawing.Size(77, 13);
            this.mdpCompte.TabIndex = 9;
            this.mdpCompte.Text = "Mot de passe :";
            // 
            // loginCompte
            // 
            this.loginCompte.AutoSize = true;
            this.loginCompte.Location = new System.Drawing.Point(48, 125);
            this.loginCompte.Name = "loginCompte";
            this.loginCompte.Size = new System.Drawing.Size(39, 13);
            this.loginCompte.TabIndex = 8;
            this.loginCompte.Text = "Login :";
            // 
            // nomCompte
            // 
            this.nomCompte.AutoSize = true;
            this.nomCompte.Location = new System.Drawing.Point(48, 99);
            this.nomCompte.Name = "nomCompte";
            this.nomCompte.Size = new System.Drawing.Size(35, 13);
            this.nomCompte.TabIndex = 7;
            this.nomCompte.Text = "Nom :";
            // 
            // ajout
            // 
            this.ajout.AutoSize = true;
            this.ajout.Location = new System.Drawing.Point(133, 58);
            this.ajout.Name = "ajout";
            this.ajout.Size = new System.Drawing.Size(93, 13);
            this.ajout.TabIndex = 6;
            this.ajout.Text = "Ajouter un compte";
            // 
            // genererBtn
            // 
            this.genererBtn.Location = new System.Drawing.Point(93, 196);
            this.genererBtn.Name = "genererBtn";
            this.genererBtn.Size = new System.Drawing.Size(167, 25);
            this.genererBtn.TabIndex = 3;
            this.genererBtn.Text = "Générer un mot de passe";
            this.genererBtn.UseVisualStyleBackColor = true;
            this.genererBtn.Click += new System.EventHandler(this.genererBtn_Click);
            // 
            // ajoutCompte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 334);
            this.Controls.Add(this.genererBtn);
            this.Controls.Add(this.ajout);
            this.Controls.Add(this.annulerBtn);
            this.Controls.Add(this.validerBtn);
            this.Controls.Add(this.forceMdp);
            this.Controls.Add(this.mdpBox);
            this.Controls.Add(this.loginBox);
            this.Controls.Add(this.nomBox);
            this.Controls.Add(this.mdpCompte);
            this.Controls.Add(this.loginCompte);
            this.Controls.Add(this.nomCompte);
            this.Name = "ajoutCompte";
            this.Text = "ajoutCompte";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button annulerBtn;
        private System.Windows.Forms.Button validerBtn;
        private System.Windows.Forms.ProgressBar forceMdp;
        private System.Windows.Forms.TextBox mdpBox;
        private System.Windows.Forms.TextBox loginBox;
        private System.Windows.Forms.TextBox nomBox;
        private System.Windows.Forms.Label mdpCompte;
        private System.Windows.Forms.Label loginCompte;
        private System.Windows.Forms.Label nomCompte;
        private System.Windows.Forms.Label ajout;
        private System.Windows.Forms.Button genererBtn;
    }
}