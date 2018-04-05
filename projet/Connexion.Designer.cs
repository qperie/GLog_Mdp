namespace form
{
    partial class Connexion
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
            this.mdp = new System.Windows.Forms.Label();
            this.identifiant = new System.Windows.Forms.Label();
            this.identifiantBox = new System.Windows.Forms.TextBox();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.connexionBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mdp
            // 
            this.mdp.AutoSize = true;
            this.mdp.Location = new System.Drawing.Point(357, 294);
            this.mdp.Name = "mdp";
            this.mdp.Size = new System.Drawing.Size(71, 13);
            this.mdp.TabIndex = 4;
            this.mdp.Text = "Mot de passe";
            // 
            // identifiant
            // 
            this.identifiant.AutoSize = true;
            this.identifiant.Location = new System.Drawing.Point(366, 202);
            this.identifiant.Name = "identifiant";
            this.identifiant.Size = new System.Drawing.Size(53, 13);
            this.identifiant.TabIndex = 3;
            this.identifiant.Text = "Identifiant";
            // 
            // identifiantBox
            // 
            this.identifiantBox.Location = new System.Drawing.Point(269, 236);
            this.identifiantBox.Multiline = true;
            this.identifiantBox.Name = "identifiantBox";
            this.identifiantBox.Size = new System.Drawing.Size(252, 20);
            this.identifiantBox.TabIndex = 0;
            // 
            // passwordBox
            // 
            this.passwordBox.Location = new System.Drawing.Point(269, 324);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.PasswordChar = '•';
            this.passwordBox.Size = new System.Drawing.Size(252, 20);
            this.passwordBox.TabIndex = 1;
            // 
            // connexionBtn
            // 
            this.connexionBtn.Location = new System.Drawing.Point(353, 383);
            this.connexionBtn.Name = "connexionBtn";
            this.connexionBtn.Size = new System.Drawing.Size(75, 23);
            this.connexionBtn.TabIndex = 2;
            this.connexionBtn.Text = "Connexion";
            this.connexionBtn.UseVisualStyleBackColor = true;
            this.connexionBtn.Click += new System.EventHandler(this.connexionBtn_Click);
            // 
            // Connexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 642);
            this.Controls.Add(this.mdp);
            this.Controls.Add(this.identifiant);
            this.Controls.Add(this.identifiantBox);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.connexionBtn);
            this.Name = "Connexion";
            this.Text = "Connexion";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Connexion_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label mdp;
        private System.Windows.Forms.Label identifiant;
        private System.Windows.Forms.TextBox identifiantBox;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.Button connexionBtn;
    }
}