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
    public partial class modifierCompte : Form
    {
        // Attributs

        private ICompteRepository compteRepository = new CompteRepository();
        Compte compte = new Compte();
        string mdpActuel = "";
        private ILiaisonUtilCompte liaisonUtilCompte = new LiaisonUtilCompteRepository();


        // Constructeurs

        //Récupère toutes les données du compte à modifier
        public modifierCompte(Compte compte)
        {
            InitializeComponent();
            this.compte = compte;
            nomBox.Text = compte.Titre;
            loginBox.Text = compte.Login;
            mdpBox.Text = compte.Mdp;
            mdpActuel = compte.Mdp;

        }


        // Méthodes

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

        //Modifie un compte si les informations sont correctes
        private void modifierBtn_Click(object sender, EventArgs e)
        {
            if ((nomBox.Text != "") && (loginBox.Text != "") && (mdpBox.Text != ""))
            {
                //Verifier qu'aucun compte n'a le même titre
                IList<LiaisonUtilCompte> comptesUtil = liaisonUtilCompte.GetAll();
                bool valideTitreCompte = true;
                foreach (LiaisonUtilCompte lienCompteUtil in comptesUtil)
                {
                    if (lienCompteUtil.Utilisateur.Id == Program.session && lienCompteUtil.Compte.Titre == nomBox.Text)
                    {
                        if (lienCompteUtil.Compte.Titre == compte.Titre) { }
                        else valideTitreCompte = false;
                    }
                }
                if (valideTitreCompte)
                {
                    //Modification un Compte
                    compte.Login = loginBox.Text;
                    compte.Titre = nomBox.Text;    
                    if (mdpBox.Text != mdpActuel) //Si le mdp de passe a changé
                    {
                        compte.Mdp = mdpBox.Text;
                        compte.LastModifMdp = DateTime.Today;
                    }
                    compteRepository.MAJCompte(compte);
                }
                else
                {
                    MessageBox.Show("Le titre du compte est déjà utilisé. Modification impossible.");
                }

                
            }
            else
            {
                MessageBox.Show("Vous n'avez pas rempli tous les champs.");
            }

        }
    }
}
