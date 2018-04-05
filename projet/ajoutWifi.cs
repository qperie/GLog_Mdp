using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using Domain;

namespace form
{
    public partial class ajoutWifi : Form
    {
        // Attributs

        private ILiaisonUtilWifi liaisonUtilWifi = new LiaisonUtilWifiRepository(); 

        // Constructeurs

        public ajoutWifi()
        {
            InitializeComponent();
        }


        // Méthodes

        //Affichage de la force du mdp suivant le mot de passe entré dans la textbox
        private void mdpBox_TextChanged(object sender, EventArgs e)
        {
            Gestion gestion = new Gestion();
            string motDePasse = mdpBox.Text;
            forceMdp.Value= gestion.valeurForceMdp(gestion.mdpCaracDiff(motDePasse));
        }

        //Affiche le mot de passe généré dans la textBox
        private void genererBtn_Click(object sender, EventArgs e)
        {
            mdp mdp = new mdp();
            if (mdp.ShowDialog() == DialogResult.OK)
            {
                mdpBox.Text = mdp.Input;
            }
        }

        // Ajoute à la BDD d'un nouveau point Wifi
        private void validerBtn_Click(object sender, EventArgs e)
        {
            if ((ssidBox.Text != "") && (mdpBox.Text != ""))
            {
                IWifiRepository wifiRepo = new WifiRepository();

                //Verification de la disponibilité du SSID
                IList<LiaisonUtilWifi> wifisUtil = liaisonUtilWifi.GetAll();
                bool valideSSIDWifi = true;
                foreach (LiaisonUtilWifi lienWifisUtil in wifisUtil)
                {
                    if (lienWifisUtil.Utilisateur.Id == Program.session && lienWifisUtil.Wifi.SSID == ssidBox.Text)
                    {
                        valideSSIDWifi = false;
                    }
                }
                if (valideSSIDWifi)
                {
                    //Ajout du Wifi
                    Wifi nouvWifi = new Wifi(ssidBox.Text, mdpBox.Text);
                    wifiRepo.AjoutWifi(nouvWifi, Program.session);
                }
                else
                {
                    MessageBox.Show("Le SSID du Wifi est déjà utilisé. Ajout impossible.");
                }

                
            }
            else
            {
                MessageBox.Show("Vous n'avez pas rempli tous les champs.");
            }
        }
    }
}
