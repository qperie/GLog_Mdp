using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace DAL
{
    // Interface d'accès aux Wifis du gestionnaire de mot de passe
    public interface IWifiRepository
    {
        // Récupère la liste des Wifis
        IList<Wifi> GetAll();

        // Met à jour un point Wifi puis renvoie un booléen indiquant si la mise à jour s'est bien effectuée
        bool MAJWifi(Wifi wifi);

        // Ajoute un nouveau point Wifi puie renvoie un booléen indiquant si l'ajout s'est bien effectué
        void AjoutWifi(Wifi wifi, int Id);

        // Supprime un point Wifi existant
        void SupprWifi(Wifi wifi, int Id);
    }
}
