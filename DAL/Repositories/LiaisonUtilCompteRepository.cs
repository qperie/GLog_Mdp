using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace DAL
{
    public class LiaisonUtilCompteRepository : Repository, ILiaisonUtilCompte
    {
        /// <summary>
        /// Récupère la liste des liaisons utilisateur/compte dans la BDD
        /// </summary>
        /// <returns type='IList<LiaisonUtilCompte>'> Liste d'objets de type LiaisonUtilCompte </returns>
        public IList<LiaisonUtilCompte> GetAll()
        {
            return Session.Query<LiaisonUtilCompte>().ToList();
        }
    }
}
