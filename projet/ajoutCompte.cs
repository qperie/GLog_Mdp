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
    public partial class ajoutCompte : Form
    {
        // Attributs

        private ILiaisonUtilCompte liaisonUtilCompte = new LiaisonUtilCompteRepository();

        // Constructeurs

        public ajoutCompte()
        {
            InitializeComponent();
        }


        // Méthodes
        
        //Affichage de la force du mdp suivant le mot de passe entré dans la textbox
        private void mdpBox_TextChanged(object sender, EventArgs e)
        {
            Gestion gestion = new Gestion();
            string motDePasse = mdpBox.Text;
            forceMdp.Value = gestion.valeurForceMdp(gestion.mdpCaracDiff(motDePasse));

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

        // Ajoute à la BDD d'un nouveau Compte
        private void validerBtn_Click(object sender, EventArgs e)
        {

            if ((nomBox.Text != "") && (loginBox.Text != "") && (mdpBox.Text != ""))
            {
                ICompteRepository compteRepo = new CompteRepository();

                //Verifier qu'aucun compte n'a le même titre
                IList<LiaisonUtilCompte> comptesUtil = liaisonUtilCompte.GetAll();
                bool valideTitreCompte = true;
                foreach (LiaisonUtilCompte lienCompteUtil in comptesUtil)
                {
                    if (lienCompteUtil.Utilisateur.Id == Program.session && lienCompteUtil.Compte.Titre== nomBox.Text)
                    {
                        valideTitreCompte = false;
                    }
                }
                if (valideTitreCompte)
                {
                    //Ajout du Compte
                    Compte nouvCompte = new Compte(nomBox.Text, loginBox.Text, mdpBox.Text, DateTime.Today, DateTime.Today);
                    compteRepo.AjoutCompte(nouvCompte, Program.session);
                }
                else
                {
                    MessageBox.Show("Le titre du compte est déjà utilisé. Ajout impossible.");
                }


            }
            else
            {
                MessageBox.Show("Vous n'avez pas rempli tous les champs.");
            }

        }
    }
}
