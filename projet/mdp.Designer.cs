namespace form
{
    partial class mdp
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
            this.NbrSymbolesBox = new System.Windows.Forms.TextBox();
            this.nbrSymboles = new System.Windows.Forms.Label();
            this.genererMdp = new System.Windows.Forms.Label();
            this.nbrChiffresBox = new System.Windows.Forms.TextBox();
            this.nbrChiffres = new System.Windows.Forms.Label();
            this.longueur = new System.Windows.Forms.Label();
            this.longueurBox = new System.Windows.Forms.TextBox();
            this.genererBtn = new System.Windows.Forms.Button();
            this.mdpBox = new System.Windows.Forms.TextBox();
            this.ok = new System.Windows.Forms.Button();
            this.Annuler = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NbrSymbolesBox
            // 
            this.NbrSymbolesBox.Location = new System.Drawing.Point(187, 123);
            this.NbrSymbolesBox.Name = "NbrSymbolesBox";
            this.NbrSymbolesBox.Size = new System.Drawing.Size(45, 20);
            this.NbrSymbolesBox.TabIndex = 2;
            // 
            // nbrSymboles
            // 
            this.nbrSymboles.AutoSize = true;
            this.nbrSymboles.Location = new System.Drawing.Point(72, 126);
            this.nbrSymboles.Name = "nbrSymboles";
            this.nbrSymboles.Size = new System.Drawing.Size(111, 13);
            this.nbrSymboles.TabIndex = 8;
            this.nbrSymboles.Text = "Nombre de symboles :";
            // 
            // genererMdp
            // 
            this.genererMdp.AutoSize = true;
            this.genererMdp.Location = new System.Drawing.Point(81, 25);
            this.genererMdp.Name = "genererMdp";
            this.genererMdp.Size = new System.Drawing.Size(126, 13);
            this.genererMdp.TabIndex = 5;
            this.genererMdp.Text = "Générer un mot de passe";
            // 
            // nbrChiffresBox
            // 
            this.nbrChiffresBox.Location = new System.Drawing.Point(187, 88);
            this.nbrChiffresBox.Name = "nbrChiffresBox";
            this.nbrChiffresBox.Size = new System.Drawing.Size(45, 20);
            this.nbrChiffresBox.TabIndex = 1;
            // 
            // nbrChiffres
            // 
            this.nbrChiffres.AutoSize = true;
            this.nbrChiffres.Location = new System.Drawing.Point(81, 93);
            this.nbrChiffres.Name = "nbrChiffres";
            this.nbrChiffres.Size = new System.Drawing.Size(102, 13);
            this.nbrChiffres.TabIndex = 7;
            this.nbrChiffres.Text = "Nombre de chiffres :";
            // 
            // longueur
            // 
            this.longueur.AutoSize = true;
            this.longueur.Location = new System.Drawing.Point(29, 58);
            this.longueur.Name = "longueur";
            this.longueur.Size = new System.Drawing.Size(154, 13);
            this.longueur.TabIndex = 6;
            this.longueur.Text = "Longueur du mot de de passe :";
            // 
            // longueurBox
            // 
            this.longueurBox.Location = new System.Drawing.Point(187, 55);
            this.longueurBox.Name = "longueurBox";
            this.longueurBox.Size = new System.Drawing.Size(45, 20);
            this.longueurBox.TabIndex = 0;
            // 
            // genererBtn
            // 
            this.genererBtn.Location = new System.Drawing.Point(63, 165);
            this.genererBtn.Name = "genererBtn";
            this.genererBtn.Size = new System.Drawing.Size(154, 36);
            this.genererBtn.TabIndex = 3;
            this.genererBtn.Text = "Générer un mot de passe";
            this.genererBtn.UseVisualStyleBackColor = true;
            this.genererBtn.Click += new System.EventHandler(this.genererBtn_Click);
            // 
            // mdpBox
            // 
            this.mdpBox.Location = new System.Drawing.Point(321, 73);
            this.mdpBox.Name = "mdpBox";
            this.mdpBox.Size = new System.Drawing.Size(154, 20);
            this.mdpBox.TabIndex = 9;
            // 
            // ok
            // 
            this.ok.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.ok.Location = new System.Drawing.Point(321, 116);
            this.ok.Name = "ok";
            this.ok.Size = new System.Drawing.Size(68, 27);
            this.ok.TabIndex = 4;
            this.ok.Text = "ok";
            this.ok.UseVisualStyleBackColor = true;
            // 
            // Annuler
            // 
            this.Annuler.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Annuler.Location = new System.Drawing.Point(406, 116);
            this.Annuler.Name = "Annuler";
            this.Annuler.Size = new System.Drawing.Size(69, 27);
            this.Annuler.TabIndex = 10;
            this.Annuler.Text = "Annuler";
            this.Annuler.UseVisualStyleBackColor = true;
            // 
            // mdp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 222);
            this.Controls.Add(this.Annuler);
            this.Controls.Add(this.ok);
            this.Controls.Add(this.mdpBox);
            this.Controls.Add(this.NbrSymbolesBox);
            this.Controls.Add(this.nbrSymboles);
            this.Controls.Add(this.genererMdp);
            this.Controls.Add(this.nbrChiffresBox);
            this.Controls.Add(this.nbrChiffres);
            this.Controls.Add(this.longueur);
            this.Controls.Add(this.longueurBox);
            this.Controls.Add(this.genererBtn);
            this.Name = "mdp";
            this.Text = "mdp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NbrSymbolesBox;
        private System.Windows.Forms.Label nbrSymboles;
        private System.Windows.Forms.Label genererMdp;
        private System.Windows.Forms.TextBox nbrChiffresBox;
        private System.Windows.Forms.Label nbrChiffres;
        private System.Windows.Forms.Label longueur;
        private System.Windows.Forms.TextBox longueurBox;
        private System.Windows.Forms.Button genererBtn;
        private System.Windows.Forms.TextBox mdpBox;
        private System.Windows.Forms.Button ok;
        private System.Windows.Forms.Button Annuler;
    }
}