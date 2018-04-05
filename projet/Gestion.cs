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
    public partial class Gestion : Form
    {
        // Attributs

        private IUtilisateurRepository utilisateurRepository = new UtilisateurRepository();
        private ICompteRepository compteRepository = new CompteRepository();
        private ILiaisonUtilCompte liaisonUtilCompte = new LiaisonUtilCompteRepository();
        private ILiaisonUtilWifi liaisonUtilWifi = new LiaisonUtilWifiRepository();
        private IWifiRepository wifiRepository = new WifiRepository();

        
        // Constructeurs

        public Gestion()
        {
            InitializeComponent();
            AfficherContenuComptes();
            AfficherContenuWifis();
        }


        // Méthodes

        // Retourne le nombre de paramètres différents du mdp (longueur, chiffres, lettres, symboles) pour un mdp Compte
        public int forceMdpCompte (Compte compte)
        {
            //Listes des caractères pouvant figurer dans un mdp
            List<Char> listeSymboles = new List<char> { '&', '~', '#', '(', '-', '_', ')', '@', '\\', '/', '[', ']', '°', '$', '£', '*', '<', '>', '?', ';', ':', ',', '!', '+', '.', '^' };
            List<Char> listeLettres = new List<char> { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            List<Char> listeChiffres = new List<char> { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };

            string mdp = compte.Mdp.ToLower(); // On ne prend pas en compte les majuscules dans notre mot de passe
            int longueurMdp = mdp.Length;
            int nbrLettres = 0;
            int nbrChiffres = 0;
            int nbrSymboles = 0;
            for (int i = 0; i < longueurMdp; i++)
            {
                if (listeSymboles.Contains(mdp[i])) nbrSymboles++;
                else if (listeLettres.Contains(mdp[i])) nbrLettres++;
                else if (listeChiffres.Contains(mdp[i])) nbrChiffres++;
            }
            int caracDiff = 0;
            if (nbrChiffres != 0) { caracDiff++; }
            if (nbrSymboles != 0) { caracDiff++; }
            if (nbrLettres != 0) { caracDiff++; }
            if (longueurMdp >= 8) { caracDiff++; }

            return caracDiff;

        }

        // Retourne le nombre de paramètres différents du mdp (longueur, chiffres, lettres, symboles) pour un mdp étant une chaine de caractère
        public int mdpCaracDiff(String mdp)
        {
            //Listes des caractères pouvant figurer dans un mdp
            List<Char> listeSymboles = new List<char> { '&', '~', '#', '(', '-', '_', ')', '@', '\\', '/', '[', ']', '°', '$', '£', '*', '<', '>', '?', ';', ':', ',', '!', '+', '.', '^' };
            List<Char> listeLettres = new List<char> { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            List<Char> listeChiffres = new List<char> { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };

            mdp = mdp.ToLower(); // On ne prend pas en compte les majuscules dans notre mot de passe
            int longueurMdp = mdp.Length;
            int nbrLettres = 0;
            int nbrChiffres = 0;
            int nbrSymboles = 0;
            for (int i = 0; i < longueurMdp; i++)
            {
                if (listeSymboles.Contains(mdp[i])) nbrSymboles++;
                else if (listeLettres.Contains(mdp[i])) nbrLettres++;
                else if (listeChiffres.Contains(mdp[i])) nbrChiffres++;
            }
            int caracDiff = 0;
            if (nbrChiffres != 0) { caracDiff++; }
            if (nbrSymboles != 0) { caracDiff++; }
            if (nbrLettres != 0) { caracDiff++; }
            if (longueurMdp >= 8) { caracDiff++; }

            return caracDiff;

        }

        //Retourne la valeur que doit prendre la barre de progression
        public int valeurForceMdp(int nbrCaractere)
        {
            if (nbrCaractere == 1) return 1;
            else if (nbrCaractere == 0) return 0;
            else if (nbrCaractere == 4) return 3;
            else return 2;
        }


        // Calcul si le mdp est faible
        private string mdpFaible(Compte compte)
        {
            if (forceMdpCompte(compte) == 1) return "*"; // Si le mdp ne comporte qu'un paramètre
            else return "";
        }
        
        // Calcul si le mdp est ancien 
        private string mdpAncien(Compte compte)
        {
            
            int diffJour = (DateTime.Today - compte.LastModifMdp).Days;
            int diffMois = diffJour / 30; 
            if (diffMois >= 6)
            {
                return "*";
            }
            else return "";
        }

        //Affiche les comptes de l'utilisateur connecté
        private void AfficherContenuComptes()
        {
            IList<LiaisonUtilCompte> comptesUtil = liaisonUtilCompte.GetAll();
            foreach (LiaisonUtilCompte lienCompteUtil in comptesUtil)
            {
                if (lienCompteUtil.Utilisateur.Id == Program.session) // Si le le compte appartient à l'utilisateur connecté
                {
                    string[] ligne = { lienCompteUtil.Compte.Titre, mdpFaible(lienCompteUtil.Compte), mdpAncien(lienCompteUtil.Compte) };
                    comptesTab.Rows.Add(ligne);
                }
            }
        }

        //Affiche les points wifi de l'utilisateur connecté
        private void AfficherContenuWifis()
        {
            IList<LiaisonUtilWifi> wifisUtil = liaisonUtilWifi.GetAll();
            foreach (LiaisonUtilWifi lienWifisUtil in wifisUtil)
            {
                if (lienWifisUtil.Utilisateur.Id == Program.session) // Si le le compte appartient à l'utilisateur connecté
                {
                    wifiBox.Items.Add(lienWifisUtil.Wifi.SSID);
                }
            }
        }

        //Cherche le compte affiché et réaffiche les comptes si une modification est effectuée
        private void button1_Click(object sender, EventArgs e)
        {
            IList<Compte> comptes = compteRepository.GetAll();
            int i = 0;
            while ((comptes[i].Titre != nomBox.Text) && (comptes[i].Login != loginBox.Text) && (comptes[i].Mdp != mdpBox.Text))
            {
                i++;
            }
            modifierCompte modifierCompte = new modifierCompte(comptes[i]);
            if (modifierCompte.ShowDialog() == DialogResult.OK)
            {
                comptesTab.Rows.Clear();
                AfficherContenuComptes();
            }
        }

        //Cherche le compte affiché et réaffiche les comptes si un compte est supprimé
        private void button1_Click_1(object sender, EventArgs e)
        {
            IList<Compte> comptes = compteRepository.GetAll();
            int i = 0;
            while ((comptes[i].Titre != nomBox.Text) && (comptes[i].Login != loginBox.Text) && (comptes[i].Mdp != mdpBox.Text))
            {
                i++;
            }
            supprimerCompte supprimerCompte = new supprimerCompte(comptes[i]);
            if (supprimerCompte.ShowDialog() == DialogResult.Yes)
            {
                comptesTab.Rows.Clear();
                AfficherContenuComptes();
            }
        }

        //Si un compte est ajouté, réaffiche les comptes
        private void ajoutBtn_Click(object sender, EventArgs e)
        {
            ajoutCompte ajoutCompte = new ajoutCompte();
            if (ajoutCompte.ShowDialog() == DialogResult.OK)
            {
                comptesTab.Rows.Clear();
                AfficherContenuComptes();
            }
        }


        //Si un wifi est ajouté, réaffiche les wifis et supprime les éléments dans les textbox d'affichage
        private void button1_Click_2(object sender, EventArgs e)
        {
            ajoutWifi ajoutWifi = new ajoutWifi();
            if (ajoutWifi.ShowDialog() == DialogResult.OK)
            {
                wifiBox.Items.Clear();
                ssidBox.Text = "";
                mdpWifiBox.Text = "";
                AfficherContenuWifis();
            }
        }

        //Si un Wifi est selectionné et modifié, réaffiche les wifis et supprime les éléments dans les textbox d'affichage
        private void ModifierWifiBtn_Click(object sender, EventArgs e)
        {
            //Recherche du compte affiché
            IList<Wifi> wifis = wifiRepository.GetAll();
            int i = 0;
            if (wifiBox.SelectedIndex == -1)
            {
                MessageBox.Show("Veuillez sélectionner un point wifi.");
            }
            else
            {
                while ((wifis[i].SSID != ssidBox.Text) && (wifis[i].Mdp != mdpWifiBox.Text))
                {
                    i++;
                }

                modifierWifi modifierWifi = new modifierWifi(wifis[i]);
                if (modifierWifi.ShowDialog() == DialogResult.OK)
                {
                    wifiBox.Items.Clear();
                    ssidBox.Text = "";
                    mdpWifiBox.Text = "";
                    AfficherContenuWifis();
                }

            }

        }

        //Si un Wifi est selectionné et supprimé, réaffiche les wifis et supprime les éléments dans les textbox d'affichage
        private void SupprimerWifiBtn_Click(object sender, EventArgs e)
        {
            IList<Wifi> wifis = wifiRepository.GetAll();
            int i = 0;
            if (wifiBox.SelectedIndex == -1)
            {
                MessageBox.Show("Veuillez sélectionner un point wifi.");
            }
            else
            {
                while ((wifis[i].SSID != ssidBox.Text) && (wifis[i].Mdp != mdpWifiBox.Text))
                {
                    i++;
                }
                supprimerWifi supprimerWifi = new supprimerWifi(wifis[i]);
                if (supprimerWifi.ShowDialog() == DialogResult.Yes)
                {
                    wifiBox.Items.Clear();
                    ssidBox.Text = "";
                    mdpWifiBox.Text = "";
                    AfficherContenuWifis();
                }
            }
        }


        //Ferme l'application et déconnecte l'utilisateur
        private void Gestion_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.session = 0;
            Application.Exit();
        }

        //Demande confirmation à l'utilisateur avant de pouvoir fermer l'utilisateur
        private void Gestion_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("Etes-vous sûr(e) ?", "Demande de confirmation", 
                MessageBoxButtons.YesNo) ==DialogResult.No) 
            {
                e.Cancel = true;
            }
        }

        //Affiche le détail du compte sélectionné
        private void comptesTab_SelectionChanged(object sender, EventArgs e)
        {

            if (comptesTab.SelectedRows.Count == 0)
            {
            }
            else
            {
                int numLigne = comptesTab.CurrentCell.RowIndex;
                DataGridViewRow ligne = comptesTab.Rows[numLigne];
                String valeur = ligne.Cells[0].Value.ToString();
                //Recherche du compte
                IList<LiaisonUtilCompte> comptesUtil = liaisonUtilCompte.GetAll();

                int i = 0;
                while ((comptesUtil[i].Utilisateur.Id != Program.session) || (comptesUtil[i].Compte.Titre != valeur))
                {
                    i++;
                }
                //Affichage des valeurs
                nomBox.Text = comptesUtil[i].Compte.Titre;
                loginBox.Text = comptesUtil[i].Compte.Login;
                mdpBox.Text = comptesUtil[i].Compte.Mdp;
                modifBox.Text = Convert.ToString(comptesUtil[i].Compte.LastModif);
                //Force du mdp
                string motDePasse = mdpBox.Text;
                forceMdp.Value = valeurForceMdp(mdpCaracDiff(motDePasse));
            }
        }

        //Affiche le détail du wifi sélectionné
        private void wifiBox_SelectedValueChanged(object sender, EventArgs e)
        {
            if (wifiBox.SelectedIndex == -1)
            {
                //Rien n'est selectionné
            }
            else
            {
                ssidBox.Text = wifiBox.SelectedItem.ToString();
                // Wifi
                IList<LiaisonUtilWifi> wifisUtil = liaisonUtilWifi.GetAll();

                int i = 0;
                while ( (wifisUtil[i].Utilisateur.Id != Program.session) || (wifisUtil[i].Wifi.SSID != ssidBox.Text) )
                {
                    i++;
                }
                mdpWifiBox.Text = wifisUtil[i].Wifi.Mdp;
            }
            
        }
    }
}
