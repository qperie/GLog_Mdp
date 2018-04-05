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
    public partial class supprimerWifi : Form
    {
        private IWifiRepository wifiRepository = new WifiRepository();
        Wifi wifi = new Wifi();
        // Constructeurs

        public supprimerWifi(Wifi pointWifi)
        {
            InitializeComponent();
            wifi = pointWifi;
        }

        
        // Méthodes

            //Suppression d'un point Wifi après confirmation
        private void oui_Click(object sender, EventArgs e)
        {
            wifiRepository.SupprWifi(wifi, Program.session);
        }
    }
}
