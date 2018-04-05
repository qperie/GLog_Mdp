using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Domain;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n==================== Test utilisateurs ====================");


            IUtilisateurRepository utilRepo = new UtilisateurRepository();
            Utilisateur utilisateurtest = utilRepo.GetAll()[0];
            Utilisateur utilisateurtest2 = utilRepo.GetAll()[1];


            Console.WriteLine("\nListe des utilisateurs :");
            foreach (Utilisateur util in utilRepo.GetAll())
            {
                Console.WriteLine(util);
            }

            Console.WriteLine("\nTest utilGraceAId :");
            Console.Write("L'utilisateur ayant pour Id le numéro {0} est l'utilisateur définie par : ", utilisateurtest.Id);
            foreach (Utilisateur util in utilRepo.utilGraceAId(utilisateurtest.Id))
            {
                Console.WriteLine(util);
            }


            Console.WriteLine("\n==================== Test comptes ====================");


            ICompteRepository compteRepo = new CompteRepository();
            ILiaisonUtilCompte liaisonUtilCompteRepo = new LiaisonUtilCompteRepository();
            Compte nouvCompte = new Compte("titretest", "logintest", "mdptest", DateTime.Today, DateTime.Today);
            bool test = false;


            Console.WriteLine("\nListe des comptes :");
            foreach (Compte compte in compteRepo.GetAll())
            {
                Console.WriteLine(compte);
            }

            Console.WriteLine("\nListe des liaisonUtilCompte :");
            foreach (LiaisonUtilCompte liaisonUtilCompte in liaisonUtilCompteRepo.GetAll())
            {
                Console.WriteLine(liaisonUtilCompte);
            }

            Console.WriteLine("\nTest création compte :");
            compteRepo.AjoutCompte(nouvCompte, utilisateurtest.Id);
            foreach (Compte compte in compteRepo.GetAll())
            {
                Console.WriteLine(compte);
            }
            Console.WriteLine("-----");
            foreach (LiaisonUtilCompte liaisonUtilCompte in liaisonUtilCompteRepo.GetAll())
            {
                Console.WriteLine(liaisonUtilCompte);
            }

            Console.WriteLine("\nTest création compte 2 :");
            compteRepo.AjoutCompte(nouvCompte, utilisateurtest2.Id);
            foreach (Compte compte in compteRepo.GetAll())
            {
                Console.WriteLine(compte);
            }
            Console.WriteLine("-----");
            foreach (LiaisonUtilCompte liaisonUtilCompte in liaisonUtilCompteRepo.GetAll())
            {
                Console.WriteLine(liaisonUtilCompte);
            }

            Console.WriteLine("\nTest modification compte :");
            nouvCompte.Titre = "newTitretest";
            test = compteRepo.MAJCompte(nouvCompte);
            Console.WriteLine(test);
            foreach (Compte compte in compteRepo.GetAll())
            {
                Console.WriteLine(compte);
            }
            Console.WriteLine("-----");
            foreach (LiaisonUtilCompte liaisonUtilCompte in liaisonUtilCompteRepo.GetAll())
            {
                Console.WriteLine(liaisonUtilCompte);
            }

            Console.WriteLine("\nTest suppression compte pour une personne :");
            compteRepo.SupprCompte(nouvCompte, utilisateurtest.Id);
            foreach (Compte compte in compteRepo.GetAll())
            {
                Console.WriteLine(compte);
            }
            Console.WriteLine("-----");
            foreach (LiaisonUtilCompte liaisonUtilCompte in liaisonUtilCompteRepo.GetAll())
            {
                Console.WriteLine(liaisonUtilCompte);
            }

            Console.WriteLine("\nTest suppression compte si personne n'y est plus relié :");
            compteRepo.SupprCompte(nouvCompte, utilisateurtest2.Id);
            foreach (Compte compte in compteRepo.GetAll())
            {
                Console.WriteLine(compte);
            }
            Console.WriteLine("-----");
            foreach (LiaisonUtilCompte liaisonUtilCompte in liaisonUtilCompteRepo.GetAll())
            {
                Console.WriteLine(liaisonUtilCompte);
            }


            Console.WriteLine("\n==================== Test wifis ====================");

            
            IWifiRepository wifiRepo = new WifiRepository();
            ILiaisonUtilWifi liaisonUtilWifiRepo = new LiaisonUtilWifiRepository();
            Wifi nouvWifi = new Wifi("SSIDtest", "mdptest");


            Console.WriteLine("\nListe des wifi :");
            foreach (Wifi wifi in wifiRepo.GetAll())
            {
                Console.WriteLine(wifi);
            }
            
            Console.WriteLine("\nListe des liaisonUtilWifi :");
            foreach (LiaisonUtilWifi liaisonUtilWifi in liaisonUtilWifiRepo.GetAll())
            {
                Console.WriteLine(liaisonUtilWifi);
            }

            Console.WriteLine("\nTest création wifi :");
            wifiRepo.AjoutWifi(nouvWifi, utilisateurtest.Id);
            foreach (Wifi wifi in wifiRepo.GetAll())
            {
                Console.WriteLine(wifi);
            }
            Console.WriteLine("-----");
            foreach (LiaisonUtilWifi liaisonUtilWifi in liaisonUtilWifiRepo.GetAll())
            {
                Console.WriteLine(liaisonUtilWifi);
            }

            Console.WriteLine("\nTest création wifi 2 :");
            wifiRepo.AjoutWifi(nouvWifi, utilisateurtest2.Id);
            foreach (Wifi wifi in wifiRepo.GetAll())
            {
                Console.WriteLine(wifi);
            }
            Console.WriteLine("-----");
            foreach (LiaisonUtilWifi liaisonUtilWifi in liaisonUtilWifiRepo.GetAll())
            {
                Console.WriteLine(liaisonUtilWifi);
            }

            Console.WriteLine("\nTest modification wifi :");
            nouvWifi.SSID = "newSSIDtest";
            test = wifiRepo.MAJWifi(nouvWifi);
            Console.WriteLine(test);
            foreach (Wifi wifi in wifiRepo.GetAll())
            {
                Console.WriteLine(wifi);
            }
            Console.WriteLine("-----");
            foreach (LiaisonUtilWifi liaisonUtilWifi in liaisonUtilWifiRepo.GetAll())
            {
                Console.WriteLine(liaisonUtilWifi);
            }

            Console.WriteLine("\nTest suppression wifi pour une personne :");
            wifiRepo.SupprWifi(nouvWifi, utilisateurtest.Id);
            foreach (Wifi wifi in wifiRepo.GetAll())
            {
                Console.WriteLine(wifi);
            }
            Console.WriteLine("-----");
            foreach (LiaisonUtilWifi liaisonUtilWifi in liaisonUtilWifiRepo.GetAll())
            {
                Console.WriteLine(liaisonUtilWifi);
            }

            Console.WriteLine("\nTest suppression wifi si personne n'y est plus relié :");
            wifiRepo.SupprWifi(nouvWifi, utilisateurtest2.Id);
            foreach (Wifi wifi in wifiRepo.GetAll())
            {
                Console.WriteLine(wifi);
            }
            Console.WriteLine("-----");
            foreach (LiaisonUtilWifi liaisonUtilWifi in liaisonUtilWifiRepo.GetAll())
            {
                Console.WriteLine(liaisonUtilWifi);
            }


            Console.WriteLine("\n==================== Fin des tests ====================");


            Console.WriteLine("\nTests ok !");
            
            Console.ReadKey();

        }
    }
}
