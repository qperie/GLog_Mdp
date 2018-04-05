using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using NHibernate.Linq;

namespace DAL
{
    public class WifiRepository : Repository, IWifiRepository
    {
        // Méthodes

        /// <summary>
        /// Récupère la liste des wifi dans la BDD
        /// </summary>
        /// <returns type='IList<Wifi>'> Liste d'objets de type Wifi </returns>
        public IList<Wifi> GetAll()
        {
            return Session.Query<Wifi>().ToList();
        }

        /// <summary>
        /// Modifie un wifi après avoir vérifié que l'on pouvait
        /// </summary>
        /// <param name="wifi"> Wifi à modifier </param>
        /// <returns type="bool"> Booléen signalant si la mofication a été effectuée ou non </returns>
        public bool MAJWifi(Wifi wifi)
        {
            bool test = false;
            string requete = "select w from Wifi w where (w.SSID='" + wifi.SSID + "' and w.Mdp='" + wifi.Mdp + "')";
            IList<Wifi> resultats = Session.CreateQuery(requete).List<Wifi>();
            if (resultats.Count() == 0) // Si on n'a trouvé aucun résultat exactement identique aux modifications demandées
            {
                Session.Update(wifi); // Alors la modifcation est bien effectuée
                test = true;
            }
            Session.Flush(); // On actualise la BDD
            return (test);
        }

        /// <summary>
        /// Ajoute un wifi après avoir vérifié que l'on pouvait
        /// </summary>
        /// <param name="wifi"> Wifi à ajouter </param>
        /// <param name="Id"> Identifiant de l'utilisateur qui ajoute un compte </param>
        public void AjoutWifi(Wifi wifi, int Id)
        {
            string requete = "select w from Wifi w where (w.SSID='" + wifi.SSID + "' and w.Mdp='" + wifi.Mdp + "')";
            IList<Wifi> resultats = Session.CreateQuery(requete).List<Wifi>();
            if (resultats.Count() == 0) // Si on n'a trouvé aucun résultat exactement identique au wifi que l'on veut ajouter
            {
                Session.Save(wifi); // Alors le nouveau wifi est enregistré
            }
            else
            {
                wifi = resultats[0]; // Sinon on récupère ce wifi déjà existant
            }
            Utilisateur utilisateur = new UtilisateurRepository().utilGraceAId(Id)[0];
            // Même si le wifi existe déjà, peut être qu'un nouvel utilisateur se met à l'utiliser (donc création de lien nécessaire quand même)
            LiaisonUtilWifi newLiaison = new LiaisonUtilWifi(utilisateur, wifi);
            Session.SaveOrUpdate(newLiaison); // On enregistre/modifie la nouvelle liaison
            Session.Flush(); // On actualise la BDD
        }

        /// <summary>
        /// Supprime un wifi après avoir vérifié que l'on pouvait
        /// </summary>
        /// <param name="wifi"> Wifi à supprimer </param>
        /// <param name="Id"> Identifiant de l'utilisateur qui ajoute un compte </param>
        public void SupprWifi(Wifi wifi, int Id)
        {
            Utilisateur utilisateur = new UtilisateurRepository().utilGraceAId(Id)[0];
            string requete = "select l from LiaisonUtilWifi l where (l.Utilisateur.Id='" + utilisateur.Id + "' and l.Wifi.Id='" + wifi.Id + "')";
            IList<LiaisonUtilWifi> resultats = Session.CreateQuery(requete).List<LiaisonUtilWifi>();
            foreach (LiaisonUtilWifi resultat in resultats) // Pour toutes les liaisons correspondates trouvées
            {
                Session.Delete(resultat); // On les supprime de la BDD
            }
            Session.Flush(); // On actualise la BDD
            requete = "select l from LiaisonUtilWifi l where l.Wifi.Id=" + wifi.Id;
            resultats = Session.CreateQuery(requete).List<LiaisonUtilWifi>();
            if (resultats.Count() == 0) // Si on plus aucune liaison ne mentionne ce point wifi
            {
                Session.Delete(wifi); // Alors on supprime le wifi car ça veut dier que personne ne l'utilise
            }
            Session.Flush(); // On actualise la BDD
        }
    }
}
