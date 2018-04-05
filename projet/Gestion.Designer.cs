namespace form
{
    partial class Gestion
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
            this.nomCompte = new System.Windows.Forms.Label();
            this.loginCompte = new System.Windows.Forms.Label();
            this.mdpCompte = new System.Windows.Forms.Label();
            this.modifCompte = new System.Windows.Forms.Label();
            this.nomBox = new System.Windows.Forms.TextBox();
            this.loginBox = new System.Windows.Forms.TextBox();
            this.mdpBox = new System.Windows.Forms.TextBox();
            this.modifBox = new System.Windows.Forms.TextBox();
            this.forceMdp = new System.Windows.Forms.ProgressBar();
            this.ajoutBtn = new System.Windows.Forms.Button();
            this.modifierBtn = new System.Windows.Forms.Button();
            this.supprimerBtn = new System.Windows.Forms.Button();
            this.navTab = new System.Windows.Forms.TabControl();
            this.ComptesList = new System.Windows.Forms.TabPage();
            this.comptesTab = new System.Windows.Forms.DataGridView();
            this.Nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MotDePasse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AncienMdp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Wifi = new System.Windows.Forms.TabPage();
            this.wifiBox = new System.Windows.Forms.ListBox();
            this.mdpWifiBox = new System.Windows.Forms.TextBox();
            this.ssidBox = new System.Windows.Forms.TextBox();
            this.mdpWifi = new System.Windows.Forms.Label();
            this.ssid = new System.Windows.Forms.Label();
            this.supprimerWifiBtn = new System.Windows.Forms.Button();
            this.modifierWifiBtn = new System.Windows.Forms.Button();
            this.ajoutWifiBtn = new System.Windows.Forms.Button();
            this.informationsCompte = new System.Windows.Forms.Label();
            this.informationWifi = new System.Windows.Forms.Label();
            this.navTab.SuspendLayout();
            this.ComptesList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comptesTab)).BeginInit();
            this.Wifi.SuspendLayout();
            this.SuspendLayout();
            // 
            // nomCompte
            // 
            this.nomCompte.AutoSize = true;
            this.nomCompte.Location = new System.Drawing.Point(508, 200);
            this.nomCompte.Name = "nomCompte";
            this.nomCompte.Size = new System.Drawing.Size(35, 13);
            this.nomCompte.TabIndex = 15;
            this.nomCompte.Text = "Nom :";
            // 
            // loginCompte
            // 
            this.loginCompte.AutoSize = true;
            this.loginCompte.Location = new System.Drawing.Point(508, 226);
            this.loginCompte.Name = "loginCompte";
            this.loginCompte.Size = new System.Drawing.Size(39, 13);
            this.loginCompte.TabIndex = 16;
            this.loginCompte.Text = "Login :";
            // 
            // mdpCompte
            // 
            this.mdpCompte.AutoSize = true;
            this.mdpCompte.Location = new System.Drawing.Point(470, 252);
            this.mdpCompte.Name = "mdpCompte";
            this.mdpCompte.Size = new System.Drawing.Size(77, 13);
            this.mdpCompte.TabIndex = 17;
            this.mdpCompte.Text = "Mot de passe :";
            // 
            // modifCompte
            // 
            this.modifCompte.AutoSize = true;
            this.modifCompte.Location = new System.Drawing.Point(474, 297);
            this.modifCompte.Name = "modifCompte";
            this.modifCompte.Size = new System.Drawing.Size(69, 26);
            this.modifCompte.TabIndex = 19;
            this.modifCompte.Text = "Dernière \r\nmodification :";
            // 
            // nomBox
            // 
            this.nomBox.Location = new System.Drawing.Point(553, 200);
            this.nomBox.Name = "nomBox";
            this.nomBox.ReadOnly = true;
            this.nomBox.Size = new System.Drawing.Size(167, 20);
            this.nomBox.TabIndex = 6;
            // 
            // loginBox
            // 
            this.loginBox.Location = new System.Drawing.Point(553, 226);
            this.loginBox.Name = "loginBox";
            this.loginBox.ReadOnly = true;
            this.loginBox.Size = new System.Drawing.Size(167, 20);
            this.loginBox.TabIndex = 7;
            // 
            // mdpBox
            // 
            this.mdpBox.Location = new System.Drawing.Point(553, 252);
            this.mdpBox.Name = "mdpBox";
            this.mdpBox.ReadOnly = true;
            this.mdpBox.Size = new System.Drawing.Size(167, 20);
            this.mdpBox.TabIndex = 8;
            // 
            // modifBox
            // 
            this.modifBox.Location = new System.Drawing.Point(553, 297);
            this.modifBox.Name = "modifBox";
            this.modifBox.ReadOnly = true;
            this.modifBox.Size = new System.Drawing.Size(167, 20);
            this.modifBox.TabIndex = 9;
            // 
            // forceMdp
            // 
            this.forceMdp.Location = new System.Drawing.Point(553, 278);
            this.forceMdp.Maximum = 3;
            this.forceMdp.Name = "forceMdp";
            this.forceMdp.Size = new System.Drawing.Size(167, 13);
            this.forceMdp.Step = 1;
            this.forceMdp.TabIndex = 18;
            // 
            // ajoutBtn
            // 
            this.ajoutBtn.Location = new System.Drawing.Point(425, 25);
            this.ajoutBtn.Name = "ajoutBtn";
            this.ajoutBtn.Size = new System.Drawing.Size(165, 62);
            this.ajoutBtn.TabIndex = 0;
            this.ajoutBtn.Text = "Ajouter un nouveau compte";
            this.ajoutBtn.UseVisualStyleBackColor = true;
            this.ajoutBtn.Click += new System.EventHandler(this.ajoutBtn_Click);
            // 
            // modifierBtn
            // 
            this.modifierBtn.Location = new System.Drawing.Point(553, 328);
            this.modifierBtn.Name = "modifierBtn";
            this.modifierBtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.modifierBtn.Size = new System.Drawing.Size(76, 23);
            this.modifierBtn.TabIndex = 10;
            this.modifierBtn.Text = "Modifier";
            this.modifierBtn.UseVisualStyleBackColor = true;
            this.modifierBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // supprimerBtn
            // 
            this.supprimerBtn.Location = new System.Drawing.Point(644, 328);
            this.supprimerBtn.Name = "supprimerBtn";
            this.supprimerBtn.Size = new System.Drawing.Size(76, 23);
            this.supprimerBtn.TabIndex = 11;
            this.supprimerBtn.Text = "Supprimer";
            this.supprimerBtn.UseVisualStyleBackColor = false;
            this.supprimerBtn.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // navTab
            // 
            this.navTab.Controls.Add(this.ComptesList);
            this.navTab.Controls.Add(this.Wifi);
            this.navTab.Location = new System.Drawing.Point(12, 12);
            this.navTab.Name = "navTab";
            this.navTab.SelectedIndex = 0;
            this.navTab.Size = new System.Drawing.Size(400, 618);
            this.navTab.TabIndex = 12;
            // 
            // ComptesList
            // 
            this.ComptesList.Controls.Add(this.comptesTab);
            this.ComptesList.Location = new System.Drawing.Point(4, 22);
            this.ComptesList.Name = "ComptesList";
            this.ComptesList.Padding = new System.Windows.Forms.Padding(3);
            this.ComptesList.Size = new System.Drawing.Size(392, 592);
            this.ComptesList.TabIndex = 0;
            this.ComptesList.Text = "Comptes";
            this.ComptesList.UseVisualStyleBackColor = true;
            // 
            // comptesTab
            // 
            this.comptesTab.AllowUserToAddRows = false;
            this.comptesTab.AllowUserToDeleteRows = false;
            this.comptesTab.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.comptesTab.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nom,
            this.MotDePasse,
            this.AncienMdp});
            this.comptesTab.EnableHeadersVisualStyles = false;
            this.comptesTab.Location = new System.Drawing.Point(1, 2);
            this.comptesTab.MultiSelect = false;
            this.comptesTab.Name = "comptesTab";
            this.comptesTab.ReadOnly = true;
            this.comptesTab.RowHeadersVisible = false;
            this.comptesTab.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.comptesTab.Size = new System.Drawing.Size(395, 587);
            this.comptesTab.TabIndex = 0;
            this.comptesTab.SelectionChanged += new System.EventHandler(this.comptesTab_SelectionChanged);
            // 
            // Nom
            // 
            this.Nom.HeaderText = "Nom";
            this.Nom.Name = "Nom";
            this.Nom.ReadOnly = true;
            this.Nom.Width = 190;
            // 
            // MotDePasse
            // 
            this.MotDePasse.HeaderText = "Faible Mdp";
            this.MotDePasse.MaxInputLength = 1;
            this.MotDePasse.Name = "MotDePasse";
            this.MotDePasse.ReadOnly = true;
            // 
            // AncienMdp
            // 
            this.AncienMdp.HeaderText = "Ancien Mdp";
            this.AncienMdp.MaxInputLength = 1;
            this.AncienMdp.Name = "AncienMdp";
            this.AncienMdp.ReadOnly = true;
            // 
            // Wifi
            // 
            this.Wifi.Controls.Add(this.wifiBox);
            this.Wifi.Location = new System.Drawing.Point(4, 22);
            this.Wifi.Name = "Wifi";
            this.Wifi.Padding = new System.Windows.Forms.Padding(3);
            this.Wifi.Size = new System.Drawing.Size(392, 592);
            this.Wifi.TabIndex = 1;
            this.Wifi.Text = "Points Wifi";
            this.Wifi.UseVisualStyleBackColor = true;
            // 
            // wifiBox
            // 
            this.wifiBox.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.wifiBox.ForeColor = System.Drawing.SystemColors.Window;
            this.wifiBox.FormattingEnabled = true;
            this.wifiBox.Location = new System.Drawing.Point(0, 3);
            this.wifiBox.Name = "wifiBox";
            this.wifiBox.Size = new System.Drawing.Size(399, 589);
            this.wifiBox.TabIndex = 14;
            this.wifiBox.SelectedValueChanged += new System.EventHandler(this.wifiBox_SelectedValueChanged);
            // 
            // mdpWifiBox
            // 
            this.mdpWifiBox.Location = new System.Drawing.Point(553, 517);
            this.mdpWifiBox.Name = "mdpWifiBox";
            this.mdpWifiBox.ReadOnly = true;
            this.mdpWifiBox.Size = new System.Drawing.Size(167, 20);
            this.mdpWifiBox.TabIndex = 3;
            // 
            // ssidBox
            // 
            this.ssidBox.Location = new System.Drawing.Point(553, 491);
            this.ssidBox.Name = "ssidBox";
            this.ssidBox.ReadOnly = true;
            this.ssidBox.Size = new System.Drawing.Size(167, 20);
            this.ssidBox.TabIndex = 2;
            // 
            // mdpWifi
            // 
            this.mdpWifi.AutoSize = true;
            this.mdpWifi.Location = new System.Drawing.Point(466, 517);
            this.mdpWifi.Name = "mdpWifi";
            this.mdpWifi.Size = new System.Drawing.Size(77, 13);
            this.mdpWifi.TabIndex = 14;
            this.mdpWifi.Text = "Mot de passe :";
            // 
            // ssid
            // 
            this.ssid.AutoSize = true;
            this.ssid.Location = new System.Drawing.Point(508, 491);
            this.ssid.Name = "ssid";
            this.ssid.Size = new System.Drawing.Size(38, 13);
            this.ssid.TabIndex = 13;
            this.ssid.Text = "SSID :";
            // 
            // supprimerWifiBtn
            // 
            this.supprimerWifiBtn.Location = new System.Drawing.Point(644, 545);
            this.supprimerWifiBtn.Name = "supprimerWifiBtn";
            this.supprimerWifiBtn.Size = new System.Drawing.Size(76, 23);
            this.supprimerWifiBtn.TabIndex = 5;
            this.supprimerWifiBtn.Text = "Supprimer";
            this.supprimerWifiBtn.UseVisualStyleBackColor = false;
            this.supprimerWifiBtn.Click += new System.EventHandler(this.SupprimerWifiBtn_Click);
            // 
            // modifierWifiBtn
            // 
            this.modifierWifiBtn.Location = new System.Drawing.Point(553, 545);
            this.modifierWifiBtn.Name = "modifierWifiBtn";
            this.modifierWifiBtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.modifierWifiBtn.Size = new System.Drawing.Size(76, 23);
            this.modifierWifiBtn.TabIndex = 4;
            this.modifierWifiBtn.Text = "Modifier";
            this.modifierWifiBtn.UseVisualStyleBackColor = true;
            this.modifierWifiBtn.Click += new System.EventHandler(this.ModifierWifiBtn_Click);
            // 
            // ajoutWifiBtn
            // 
            this.ajoutWifiBtn.Location = new System.Drawing.Point(606, 25);
            this.ajoutWifiBtn.Name = "ajoutWifiBtn";
            this.ajoutWifiBtn.Size = new System.Drawing.Size(165, 62);
            this.ajoutWifiBtn.TabIndex = 1;
            this.ajoutWifiBtn.Text = "Ajouter un nouveau point Wifi";
            this.ajoutWifiBtn.UseVisualStyleBackColor = true;
            this.ajoutWifiBtn.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // informationsCompte
            // 
            this.informationsCompte.AutoSize = true;
            this.informationsCompte.Location = new System.Drawing.Point(526, 156);
            this.informationsCompte.Name = "informationsCompte";
            this.informationsCompte.Size = new System.Drawing.Size(180, 13);
            this.informationsCompte.TabIndex = 20;
            this.informationsCompte.Text = "INFORMATIONS SUR CE COMPTE";
            // 
            // informationWifi
            // 
            this.informationWifi.AutoSize = true;
            this.informationWifi.Location = new System.Drawing.Point(538, 444);
            this.informationWifi.Name = "informationWifi";
            this.informationWifi.Size = new System.Drawing.Size(158, 13);
            this.informationWifi.TabIndex = 21;
            this.informationWifi.Text = "INFORMATIONS SUR CE WIFI";
            // 
            // Gestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 642);
            this.Controls.Add(this.informationWifi);
            this.Controls.Add(this.informationsCompte);
            this.Controls.Add(this.ajoutWifiBtn);
            this.Controls.Add(this.supprimerWifiBtn);
            this.Controls.Add(this.modifierWifiBtn);
            this.Controls.Add(this.mdpWifiBox);
            this.Controls.Add(this.ssidBox);
            this.Controls.Add(this.mdpWifi);
            this.Controls.Add(this.ssid);
            this.Controls.Add(this.navTab);
            this.Controls.Add(this.supprimerBtn);
            this.Controls.Add(this.modifierBtn);
            this.Controls.Add(this.ajoutBtn);
            this.Controls.Add(this.forceMdp);
            this.Controls.Add(this.modifBox);
            this.Controls.Add(this.mdpBox);
            this.Controls.Add(this.loginBox);
            this.Controls.Add(this.nomBox);
            this.Controls.Add(this.modifCompte);
            this.Controls.Add(this.mdpCompte);
            this.Controls.Add(this.loginCompte);
            this.Controls.Add(this.nomCompte);
            this.Name = "Gestion";
            this.Text = "Gestion";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Gestion_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Gestion_FormClosed);
            this.navTab.ResumeLayout(false);
            this.ComptesList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.comptesTab)).EndInit();
            this.Wifi.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label nomCompte;
        private System.Windows.Forms.Label loginCompte;
        private System.Windows.Forms.Label mdpCompte;
        private System.Windows.Forms.Label modifCompte;
        private System.Windows.Forms.TextBox nomBox;
        private System.Windows.Forms.TextBox loginBox;
        private System.Windows.Forms.TextBox mdpBox;
        private System.Windows.Forms.TextBox modifBox;
        private System.Windows.Forms.ProgressBar forceMdp;
        private System.Windows.Forms.Button ajoutBtn;
        private System.Windows.Forms.Button modifierBtn;
        private System.Windows.Forms.Button supprimerBtn;
        private System.Windows.Forms.TabControl navTab;
        private System.Windows.Forms.TabPage ComptesList;
        private System.Windows.Forms.TabPage Wifi;
        private System.Windows.Forms.ListBox wifiBox;
        private System.Windows.Forms.TextBox mdpWifiBox;
        private System.Windows.Forms.TextBox ssidBox;
        private System.Windows.Forms.Label mdpWifi;
        private System.Windows.Forms.Label ssid;
        private System.Windows.Forms.Button supprimerWifiBtn;
        private System.Windows.Forms.Button modifierWifiBtn;
        private System.Windows.Forms.Button ajoutWifiBtn;
        private System.Windows.Forms.DataGridView comptesTab;
        private System.Windows.Forms.Label informationsCompte;
        private System.Windows.Forms.Label informationWifi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn MotDePasse;
        private System.Windows.Forms.DataGridViewTextBoxColumn AncienMdp;
    }
}