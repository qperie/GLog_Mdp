using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace DAL
{
    // Interface d'accès aux Comptes du gestionnaire de mot de passe
    public interface ICompteRepository
    {
        // Récupère la liste des Comptes
        IList<Compte> GetAll();

        // Met à jour un Compte puis renvoie un booléen indiquant si la mise à jour s'est bien effectuée
        bool MAJCompte(Compte compte);

        // Ajoute un nouveau Compte puie renvoie un booléen indiquant si l'ajout s'est bien effectué
        void AjoutCompte(Compte compte, int Id);

        // Supprime un Compte existant
        void SupprCompte(Compte compte, int Id);
    }
}
