using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Utilisateur
    {
        // Constructeurs

        public Utilisateur() { }

        public Utilisateur(string login, string mdp)
        {
            this.Login = login;
            this.Mdp = mdp;
        }


        // Méthodes

        public override string ToString()
        {
            return (this.Login);
        }


        // Propriétés

        public virtual int Id { get; set; }

        public virtual string Login { get; set; }

        public virtual string Mdp { get; set; }
    }
}
