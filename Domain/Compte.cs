using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Compte
    {
        // Constructeurs

        public Compte() { }

        public Compte(string titre, string login, string mdp, DateTime lastModif, DateTime lastModifMdp)
        {
            this.Titre = titre;
            this.Login = login;
            this.Mdp = mdp;
            this.LastModif = lastModif;
            this.LastModifMdp = lastModifMdp;
        }


        // Méthodes

        public override string ToString()
        {
            return (this.Titre);
        }


        // Propriétés

        public virtual int Id { get; set; }

        public virtual string Titre { get; set; }

        public virtual string Login { get; set; }

        public virtual string Mdp { get; set; }

        public virtual DateTime LastModif { get; set; }

        public virtual DateTime LastModifMdp { get; set; }
    }
}
