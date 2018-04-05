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
    public partial class supprimerCompte : Form
    {

        private ICompteRepository compteRepository = new CompteRepository();
        Compte compte = new Compte();

        // Constructeurs
        public supprimerCompte(Compte compte)
        {
            InitializeComponent();
            this.compte = compte;

        }

        // Méthodes

        //Suppression d'un compte après confirmation
        private void oui_Click(object sender, EventArgs e)
        {
            compteRepository.SupprCompte(compte, Program.session);
        }
    }
}
