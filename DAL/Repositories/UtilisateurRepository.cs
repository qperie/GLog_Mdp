using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using NHibernate.Linq;

namespace DAL
{
    public class UtilisateurRepository : Repository, IUtilisateurRepository
    {
        /// <summary>
        /// Récupère la liste des utilisateurs dans la BDD
        /// </summary>
        /// <returns type='IList<Utilisateur>'> Liste d'objets de type Utilisateur </returns>
        public IList<Utilisateur> GetAll()
        {
            return Session.Query<Utilisateur>().ToList();
        }

        /// <summary>
        /// Renvoie l'utilisateur correspondant à l'identifiant fourni en entrée
        /// </summary>
        /// <param name="Id"> Identifiant de l'utilisateur cherché </param>
        /// <returns type="IList<Utilisateur>"> Liste contenant un objet de type Utilisateur </returns>
        public IList<Utilisateur> utilGraceAId(int Id)
        {
            string requete = "select u from Utilisateur u where u.Id=" + Id;
            return Session.CreateQuery(requete).List<Utilisateur>();
        }
    }
}
