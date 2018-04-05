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
    public partial class modifierWifi : Form
    {
        //Attributs

        private IWifiRepository wifiRepository = new WifiRepository();
        Wifi wifi = new Wifi();
        private ILiaisonUtilWifi liaisonUtilWifi = new LiaisonUtilWifiRepository();

        // Constructeurs

        //Récupère toutes les données du point wifi à modifier
        public modifierWifi(Wifi pointWifi)
        {
            InitializeComponent();
            wifi = pointWifi;
            ssidBox.Text = pointWifi.SSID;
            mdpBox.Text = pointWifi.Mdp;
        }


        // Méthodes

        //Modifie un point wifi si les informations sont correctes
        private void validerBtn_Click(object sender, EventArgs e)
        {

            if ((ssidBox.Text != "") && (mdpBox.Text != ""))
            {
                //Verification de la disponibilité du SSID
                IList<LiaisonUtilWifi> wifisUtil = liaisonUtilWifi.GetAll();
                bool valideSSIDWifi = true;
                foreach (LiaisonUtilWifi lienWifisUtil in wifisUtil)
                {
                    if (lienWifisUtil.Utilisateur.Id == Program.session && lienWifisUtil.Wifi.SSID == ssidBox.Text)
                    {
                        if (lienWifisUtil.Wifi.SSID == wifi.SSID) { }
                        else valideSSIDWifi = false;

                    }
                }
                if (valideSSIDWifi)
                {
                    //Modification du Wifi
                    wifi.SSID = ssidBox.Text;
                    wifi.Mdp = mdpBox.Text;
                    wifiRepository.MAJWifi(wifi);
                }
                else
                {
                    MessageBox.Show("Le SSID du Wifi est déjà utilisé. Modification impossible. ");
                }

            }
            else
            {
                MessageBox.Show("Vous n'avez pas rempli tous les champs.");
            }
        }

        //Affichage de la force du mdp suivant le mot de passe entré dans la textbox
        private void mdpBox_TextChanged(object sender, EventArgs e)
        {
            Gestion gestion = new Gestion();
            string motDePasse = mdpBox.Text;
            forceMdp.Value = gestion.valeurForceMdp(gestion.mdpCaracDiff(motDePasse));
        }

        //Récupère le mot de passe généré dans la textbox du mdp
        private void genererBtn_Click(object sender, EventArgs e)
        {
            mdp mdp = new mdp();
            if (mdp.ShowDialog() == DialogResult.OK)
            {
                mdpBox.Text = mdp.Input;
            }
        }
    }
}
