namespace form
{
    partial class supprimerCompte
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
            this.confirmation = new System.Windows.Forms.Label();
            this.oui = new System.Windows.Forms.Button();
            this.non = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // confirmation
            // 
            this.confirmation.AutoSize = true;
            this.confirmation.Location = new System.Drawing.Point(28, 53);
            this.confirmation.Name = "confirmation";
            this.confirmation.Size = new System.Drawing.Size(230, 13);
            this.confirmation.TabIndex = 0;
            this.confirmation.Text = "Etes-vous sûr de vouloir supprimer ce compte ?";
            // 
            // oui
            // 
            this.oui.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.oui.Location = new System.Drawing.Point(51, 102);
            this.oui.Name = "oui";
            this.oui.Size = new System.Drawing.Size(75, 23);
            this.oui.TabIndex = 1;
            this.oui.Text = "Oui";
            this.oui.UseVisualStyleBackColor = true;
            this.oui.Click += new System.EventHandler(this.oui_Click);
            // 
            // non
            // 
            this.non.DialogResult = System.Windows.Forms.DialogResult.No;
            this.non.Location = new System.Drawing.Point(153, 102);
            this.non.Name = "non";
            this.non.Size = new System.Drawing.Size(75, 23);
            this.non.TabIndex = 2;
            this.non.Text = "Non";
            this.non.UseVisualStyleBackColor = true;
            // 
            // supprimerCompte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 162);
            this.Controls.Add(this.non);
            this.Controls.Add(this.oui);
            this.Controls.Add(this.confirmation);
            this.Name = "supprimerCompte";
            this.Text = "Confirmation de suppression";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label confirmation;
        private System.Windows.Forms.Button oui;
        private System.Windows.Forms.Button non;
    }
}