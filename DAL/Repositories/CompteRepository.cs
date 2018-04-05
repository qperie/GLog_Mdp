using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using NHibernate.Linq;

namespace DAL
{
    public class CompteRepository : Repository, ICompteRepository
    {
        // Méthodes

        /// <summary>
        /// Récupère la liste des comptes dans la BDD
        /// </summary>
        /// <returns type='IList<Compte>'> Liste d'objets de type Compte </returns>
        public IList<Compte> GetAll()
        {
            return Session.Query<Compte>().ToList();
        }

        /// <summary>
        /// Modifie un compte après avoir vérifié que l'on pouvait
        /// </summary>
        /// <param name="compte"> Compte à modifier </param>
        /// <returns type="bool"> Booléen signalant si la mofication a été effectuée ou non </returns>
        public bool MAJCompte(Compte compte)
        {
            bool test = false;
            string requete = "select c from Compte c where (c.Titre='" + compte.Titre + "' and c.Login='" + compte.Login + "' and c.Mdp='" + compte.Mdp + "' and c.LastModif='" + compte.LastModif + "' and c.LastModifMdp='" + compte.LastModifMdp + "')";
            IList<Compte> resultats = Session.CreateQuery(requete).List<Compte>();
            if (resultats.Count() == 0) // Si on n'a trouvé aucun résultat exactement identique aux modifications demandées
            {
                Session.Update(compte); // Alors la modifcation est bien effectuée
                test = true;
            }
            Session.Flush(); // On actualise la BDD
            return (test); 
        }

        /// <summary>
        /// Ajoute un compte après avoir vérifié que l'on pouvait
        /// </summary>
        /// <param name="compte"> Compte à ajouter </param>
        /// <param name="Id"> Identifiant de l'utilisateur qui ajoute un compte </param>
        public void AjoutCompte(Compte compte, int Id)
        {
            string requete = "select c from Compte c where (c.Titre='" + compte.Titre + "' and c.Login='" + compte.Login + "' and c.Mdp='" + compte.Mdp + "' and c.LastModif='" + compte.LastModif + "' and c.LastModifMdp='" + compte.LastModifMdp + "')";
            IList<Compte> resultats = Session.CreateQuery(requete).List<Compte>();
            if (resultats.Count() == 0) // Si on n'a trouvé aucun résultat exactement identique au compte que l'on veut ajouter
            {
                Session.Save(compte); // Alors le nouveau compte est enregistré
            }
            else
            {
                compte = resultats[0]; // Sinon on récupère ce compte déjà existant
            }
            Utilisateur utilisateur = new UtilisateurRepository().utilGraceAId(Id)[0];
            // Même si le compte existe déjà, peut être qu'un nouvel utilisateur se met à l'utiliser (donc création de lien nécessaire quand même)
            LiaisonUtilCompte newLiaison = new LiaisonUtilCompte(utilisateur, compte);
            Session.SaveOrUpdate(newLiaison); // On enregistre/modifie la nouvelle liaison
            Session.Flush(); // On actualise la BDD
        }

        /// <summary>
        /// Supprime un compte après avoir vérifié que l'on pouvait
        /// </summary>
        /// <param name="compte"> Compte à supprimer </param>
        /// <param name="Id"> Identifiant de l'utilisateur qui supprime un compte </param>
        public void SupprCompte(Compte compte, int Id)
        {
            Utilisateur utilisateur = new UtilisateurRepository().utilGraceAId(Id)[0];
            string requete = "select l from LiaisonUtilCompte l where (l.Utilisateur.Id=" + utilisateur.Id + " and l.Compte.Id=" + compte.Id + ")";
            IList<LiaisonUtilCompte> resultats = Session.CreateQuery(requete).List<LiaisonUtilCompte>();
            foreach (LiaisonUtilCompte resultat in resultats) // Pour toutes les liaisons correspondates trouvées
            {
                Session.Delete(resultat); // On les supprime de la BDD
            }
            Session.Flush(); // On actualise la BDD
            requete = "select l from LiaisonUtilCompte l where l.Compte.Id=" + compte.Id;
            resultats = Session.CreateQuery(requete).List<LiaisonUtilCompte>();
            if (resultats.Count() == 0) // Si on plus aucune liaison ne mentionne ce point wifi
            {
                Session.Delete(compte); // Alors on supprime le compte car ça veut dier que personne ne l'utilise
            }
            Session.Flush(); // On actualise la BDD
        }
    }
}
