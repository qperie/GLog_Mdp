using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace DAL
{
    // Interface d'accès aux Utilisateurs du gestionnaire de mot de passe
    public interface IUtilisateurRepository
    {
        // Récupère la liste des Utilisateurs
        IList<Utilisateur> GetAll();

        // Récupère l'Utilisateur dont on connait l'identifiant
        IList<Utilisateur> utilGraceAId(int Id);
    }
}
