using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace DAL
{
    // Interface d'accès aux Liaisons entre Utilisateurs et Wifis du gestionnaire de mot de passe
    public interface ILiaisonUtilWifi
    {
        // Récupère la liste des Liaisons entre Utilisateurs et Wifis
        IList<LiaisonUtilWifi> GetAll();
    }
}
