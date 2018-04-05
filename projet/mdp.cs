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
    public partial class mdp : Form
    {
        // Constructeurs

        public mdp()
        {
            InitializeComponent();
        }

        //Accesseur

            //Permet de récupérer le mot de passe généré dans un autre formulaire
        public string Input
        {
            get { return mdpBox.Text; }
        }

        // Méthodes
        
            //Permet de générer un mdp suivant les conditions imposées par l'utilisateur
        private void genererBtn_Click(object sender, EventArgs e)
        {
            //Listes des caractères pouvant figurer dans un mdp
            List<Char> listeSymboles = new List<char> { '&', '~', '#', '(', '-', '_', ')', '@', '\\', '/', '[', ']', '°', '$', '£', '*', '<', '>', '?', ';', ':', ',', '!', '+', '.', '^' };
            List<Char> listeLettres = new List<char> { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            List<Char> listeChiffres = new List<char> { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };

            //Initialisation des caractères
            int longueur = 0;
            int nbrChiffres = 0; 
            int nbrSymboles = 0;

            //Verifie qu'on entre des nombres dans les textbox
            try
            {
                //Récupération des éléments dans les textBox
                if (nbrChiffresBox.Text == "") { } 
                else { nbrChiffres = Convert.ToInt32(nbrChiffresBox.Text); }

                if (NbrSymbolesBox.Text == "") { }
                else { nbrSymboles = Convert.ToInt32(NbrSymbolesBox.Text); }

                if (longueurBox.Text == "") { } 
                else { longueur = Convert.ToInt32(longueurBox.Text); }

                //Verif positive
                if (nbrChiffres < 0) nbrChiffres = -nbrChiffres;
                if (nbrSymboles < 0) nbrSymboles = -nbrSymboles;
                if (longueur < 0) longueur = -longueur;

                // Initialisation des variables suivants les textBox remplies/vides
                Random aleatoire = new Random();
                    //Aucune case n'est remplie
                if (longueurBox.Text == "" && nbrChiffresBox.Text == "" && NbrSymbolesBox.Text == "")
                {
                    longueur = 8; nbrChiffres = 2; nbrSymboles = 2; //Si aucune précision, on initialise un mdp à 8 caractères, 2 symboles et 2 chiffres
                }
                    //Seul la case longueur est remplie
                else if (longueurBox.Text != "" && nbrChiffresBox.Text == "" && NbrSymbolesBox.Text == "")
                {
                    // Nbr aléatoire de chiffres/symboles
                    int nbrC = aleatoire.Next(0, longueur + 1); // Sort un nombre aléatoire entre 0 et le nombre de caractères du mdp
                    nbrChiffres = nbrC;
                    int nbrS = aleatoire.Next(0, longueur + 1 - nbrC); 
                    nbrSymboles=nbrS;
                }
                    //Seul la case chiffres est remplie
                else if (longueurBox.Text == "" && nbrChiffresBox.Text != "" && NbrSymbolesBox.Text == "")
                {
                    longueur = nbrChiffres;
                }
                    //Seul la case symboles est remplie
                else if (longueurBox.Text == "" && nbrChiffresBox.Text == "" && NbrSymbolesBox.Text != "")
                {
                    longueur = nbrSymboles;
                }
                    //Cases longueur et chiffres remplies
                else if (longueurBox.Text != "" && nbrChiffresBox.Text != "" && NbrSymbolesBox.Text == "")
                {
                    // Nbr aléatoire de symboles
                    int nbrS = aleatoire.Next(0, longueur + 1 - nbrChiffres);
                    nbrSymboles = nbrS;
                }
                    //Cases longueur et symboles remplies
                else if (longueurBox.Text != "" && nbrChiffresBox.Text == "" && NbrSymbolesBox.Text != "")
                {
                    // Nbr aléatoire de chiffres
                    int nbrC = aleatoire.Next(0, longueur + 1 - nbrSymboles); 
                    nbrChiffres = nbrC;
                }
                    //Cases chiffres et symboles remplies
                else if (longueurBox.Text == "" && nbrChiffresBox.Text != "" && NbrSymbolesBox.Text != "")
                {
                    longueur = nbrChiffres + nbrSymboles;
                }
                    //Toutes les cases sont remplies --> variables déjà initialisées

            }
            catch
            {
                MessageBox.Show("Merci d'entrer uniquement des nombres positifs!");
            }

            // Verifier que la longueur est supérieur à nbrchiffres + nbr symboles
            if (longueur >= nbrChiffres + nbrSymboles)
            {
                string mdpGenere = "";
                Random alt = new Random();
                while (longueur > 0) // Tant que le mdp n'a pas la bonne longueur 
                {
                    // verifier qu'il reste assez de place pour mettre le bon nombre de symboles/chiffres
                    if (nbrChiffres + nbrSymboles < longueur) // On peut ajouter n'importe quel caractère
                    {
                        if (nbrChiffres == 0 && nbrSymboles == 0)
                        {
                            //On ajoute une lettre 
                            int l = alt.Next(0, listeLettres.Count()); mdpGenere += listeLettres[l];
                        }
                        else if (nbrChiffres == 0)
                        {
                            int type = alt.Next(0, 2);
                            //On ajoute une lettre si on obtient 0
                            if (type == 0) { int l = alt.Next(0, listeLettres.Count()); mdpGenere += listeLettres[l]; }
                            //On ajoute un symbole si on obtient 1
                            else { int s = alt.Next(0, listeSymboles.Count()); mdpGenere += listeSymboles[s]; nbrSymboles--; }
                        }
                        else if (nbrSymboles == 0)
                        {
                            int type = alt.Next(0, 2);
                            //On ajoute une lettre si on obtient 0
                            if (type == 0) { int l = alt.Next(0, listeLettres.Count()); mdpGenere += listeLettres[l]; }
                            //On ajoute un chiffre si on obtient 1
                            else { int c = alt.Next(0, listeChiffres.Count()); mdpGenere += listeChiffres[c]; nbrChiffres--; }

                        }
                        else 
                        {
                            int type = alt.Next(0, 3);
                            //On ajoute une lettre si on obtient 0
                            if (type == 0) { int l = alt.Next(0, listeLettres.Count()); mdpGenere += listeLettres[l];}
                            //On ajoute un chiffre si on obtient 1
                            else if (type == 1) { int c = alt.Next(0, listeChiffres.Count()); mdpGenere += listeChiffres[c]; nbrChiffres--; }
                            //On ajoute un symbole si on obtient 2
                            else { int s = alt.Next(0, listeSymboles.Count()); mdpGenere += listeSymboles[s]; nbrSymboles--; }
                        }

                    }
                    else // On doit forcement ajouter un chiffre ou  un symbole pour avoir le bon compte
                    {
                        if (nbrChiffres == 0)
                        {
                            //On ajoute un symbole
                            int s = alt.Next(0, listeSymboles.Count()); mdpGenere += listeSymboles[s]; nbrSymboles--; 
                        }
                        else if (nbrSymboles == 0)
                        {
                            //On ajoute un chiffre
                            int c = alt.Next(0, listeChiffres.Count()); mdpGenere += listeChiffres[c]; nbrChiffres--;
                        }
                        else if (nbrChiffres != 0 && nbrSymboles != 0)
                        {
                            int type = alt.Next(0, 2);
                            //On ajoute un chiffre si on obtient 0
                            if (type == 1) { int c = alt.Next(0, listeChiffres.Count()); mdpGenere += listeChiffres[c]; nbrChiffres--; }
                            //On ajoute un symbole si on obtient 1
                            else { int s = alt.Next(0, listeSymboles.Count()); mdpGenere += listeSymboles[s]; nbrSymboles--; }
                        }
                    }
                    longueur--;
                }
                mdpBox.Text = mdpGenere;
            }
            else
            {
                MessageBox.Show("Vous ne pouvez pas demander un mot de passe " + longueur + " caractères avec plus de symboles et de chiffres");
            }
                    
        }

    }
}
