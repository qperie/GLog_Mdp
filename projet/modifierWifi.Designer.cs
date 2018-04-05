namespace form
{
    partial class modifierWifi
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
            this.genererBtn = new System.Windows.Forms.Button();
            this.modifierPointWifi = new System.Windows.Forms.Label();
            this.annulerBtn = new System.Windows.Forms.Button();
            this.modifierBtn = new System.Windows.Forms.Button();
            this.forceMdp = new System.Windows.Forms.ProgressBar();
            this.mdpBox = new System.Windows.Forms.TextBox();
            this.ssidBox = new System.Windows.Forms.TextBox();
            this.mdpWifi = new System.Windows.Forms.Label();
            this.SSID = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // genererBtn
            // 
            this.genererBtn.Location = new System.Drawing.Point(115, 147);
            this.genererBtn.Name = "genererBtn";
            this.genererBtn.Size = new System.Drawing.Size(167, 25);
            this.genererBtn.TabIndex = 2;
            this.genererBtn.Text = "Générer un mot de passe";
            this.genererBtn.UseVisualStyleBackColor = true;
            this.genererBtn.Click += new System.EventHandler(this.genererBtn_Click);
            // 
            // modifierPointWifi
            // 
            this.modifierPointWifi.AutoSize = true;
            this.modifierPointWifi.Cursor = System.Windows.Forms.Cursors.Default;
            this.modifierPointWifi.Location = new System.Drawing.Point(127, 31);
            this.modifierPointWifi.Name = "modifierPointWifi";
            this.modifierPointWifi.Size = new System.Drawing.Size(111, 13);
            this.modifierPointWifi.TabIndex = 5;
            this.modifierPointWifi.Text = "Modifier ce point WIFI";
            // 
            // annulerBtn
            // 
            this.annulerBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.annulerBtn.Location = new System.Drawing.Point(206, 191);
            this.annulerBtn.Name = "annulerBtn";
            this.annulerBtn.Size = new System.Drawing.Size(76, 23);
            this.annulerBtn.TabIndex = 4;
            this.annulerBtn.Text = "Annuler";
            this.annulerBtn.UseVisualStyleBackColor = false;
            // 
            // modifierBtn
            // 
            this.modifierBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.modifierBtn.Location = new System.Drawing.Point(115, 191);
            this.modifierBtn.Name = "modifierBtn";
            this.modifierBtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.modifierBtn.Size = new System.Drawing.Size(76, 23);
            this.modifierBtn.TabIndex = 3;
            this.modifierBtn.Text = "Modifier";
            this.modifierBtn.UseVisualStyleBackColor = true;
            this.modifierBtn.Click += new System.EventHandler(this.validerBtn_Click);
            // 
            // forceMdp
            // 
            this.forceMdp.Location = new System.Drawing.Point(115, 128);
            this.forceMdp.Maximum = 3;
            this.forceMdp.Name = "forceMdp";
            this.forceMdp.Size = new System.Drawing.Size(167, 13);
            this.forceMdp.Step = 1;
            this.forceMdp.TabIndex = 8;
            // 
            // mdpBox
            // 
            this.mdpBox.Location = new System.Drawing.Point(115, 102);
            this.mdpBox.Name = "mdpBox";
            this.mdpBox.Size = new System.Drawing.Size(167, 20);
            this.mdpBox.TabIndex = 1;
            this.mdpBox.TextChanged += new System.EventHandler(this.mdpBox_TextChanged);
            // 
            // ssidBox
            // 
            this.ssidBox.Location = new System.Drawing.Point(115, 76);
            this.ssidBox.Name = "ssidBox";
            this.ssidBox.Size = new System.Drawing.Size(167, 20);
            this.ssidBox.TabIndex = 0;
            // 
            // mdpWifi
            // 
            this.mdpWifi.AutoSize = true;
            this.mdpWifi.Location = new System.Drawing.Point(32, 102);
            this.mdpWifi.Name = "mdpWifi";
            this.mdpWifi.Size = new System.Drawing.Size(77, 13);
            this.mdpWifi.TabIndex = 7;
            this.mdpWifi.Text = "Mot de passe :";
            // 
            // SSID
            // 
            this.SSID.AutoSize = true;
            this.SSID.Location = new System.Drawing.Point(70, 76);
            this.SSID.Name = "SSID";
            this.SSID.Size = new System.Drawing.Size(38, 13);
            this.SSID.TabIndex = 6;
            this.SSID.Text = "SSID :";
            // 
            // modifierWifi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 262);
            this.Controls.Add(this.genererBtn);
            this.Controls.Add(this.modifierPointWifi);
            this.Controls.Add(this.annulerBtn);
            this.Controls.Add(this.modifierBtn);
            this.Controls.Add(this.forceMdp);
            this.Controls.Add(this.mdpBox);
            this.Controls.Add(this.ssidBox);
            this.Controls.Add(this.mdpWifi);
            this.Controls.Add(this.SSID);
            this.Name = "modifierWifi";
            this.Text = "Modification du point wifi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button genererBtn;
        private System.Windows.Forms.Label modifierPointWifi;
        private System.Windows.Forms.Button annulerBtn;
        private System.Windows.Forms.Button modifierBtn;
        private System.Windows.Forms.ProgressBar forceMdp;
        private System.Windows.Forms.TextBox mdpBox;
        private System.Windows.Forms.TextBox ssidBox;
        private System.Windows.Forms.Label mdpWifi;
        private System.Windows.Forms.Label SSID;
    }
}