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
    public partial class Connexion : Form
    {
        // Attributs
        
        private IUtilisateurRepository utilisateurRepository = new UtilisateurRepository();


        // Constructeurs

        public Connexion()
        {
            InitializeComponent();
        }


        // Méthodes
        
       // Vérification du login et du mot de passe
       private int verificationMdp(string login, string mdp)
       {
            int valideConnexion = 0;
            IList<Utilisateur> utils = this.utilisateurRepository.GetAll();
            foreach (Utilisateur utilisateur in utils)
            {
                if (login == utilisateur.Login)
                {
                    if (mdp == utilisateur.Mdp)
                    {
                        valideConnexion = utilisateur.Id;
                        return valideConnexion;
                    }
                }
            }
            return valideConnexion;
        }

        //Connexion au gestionnaire si la combinaison Login/mdp est valide
        private void connexionBtn_Click(object sender, EventArgs e)
        {
            string login = identifiantBox.Text;
            string mdp = passwordBox.Text;
            int valideConnexion=verificationMdp(login, mdp);
            if (valideConnexion != 0)
            {
                Program.session = valideConnexion;
                Gestion gestion = new Gestion();
                gestion.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Login ou Mot de Passe incorrect");
            }
        }

        //Sortie de l'application si l'utilisateur n'est pas connecté
        private void Connexion_FormClosed(object sender, FormClosedEventArgs e)
        {
                if (Program.session == 0)
            {
                Application.Exit();
            }
        }
    }
}
