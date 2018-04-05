using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class LiaisonUtilCompte
    {
        // Constructeurs

        public LiaisonUtilCompte() { }

        public LiaisonUtilCompte(Utilisateur utilisateur, Compte compte)
        {
            this.Utilisateur = utilisateur;
            this.Compte = compte;
        }


        // Méthodes

        public override string ToString()
        {
            return (this.Utilisateur + " - " + this.Compte);
        }


        // Propriétés

        public virtual int Id { get; set; }
        
        public virtual Utilisateur Utilisateur { get; set; }

        public virtual Compte Compte { get; set; }
    }
}
