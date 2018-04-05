using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class LiaisonUtilWifi
    {
        // Constructeurs

        public LiaisonUtilWifi() { }

        public LiaisonUtilWifi(Utilisateur utilisateur, Wifi wifi)
        {
            this.Utilisateur = utilisateur;
            this.Wifi = wifi;
        }


        // Méthodes

        public override string ToString()
        {
            return (this.Utilisateur + " - " + this.Wifi);
        }


        // Propriétés

        public virtual int Id { get; set; }

        public virtual Utilisateur Utilisateur { get; set; }

        public virtual Wifi Wifi { get; set; }
    }
}
