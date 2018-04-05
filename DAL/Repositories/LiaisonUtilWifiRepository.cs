using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace DAL
{
    public class LiaisonUtilWifiRepository : Repository, ILiaisonUtilWifi
    {
        /// <summary>
        /// Récupère la liste des liaisons utilisateur/wifi dans la BDD
        /// </summary>
        /// <returns type='IList<LiaisonUtilWifi>'> Liste d'objets de type LiaisonUtilWifi </returns>
        public IList<LiaisonUtilWifi> GetAll()
        {
            return Session.Query<LiaisonUtilWifi>().ToList();
        }
    }
}
