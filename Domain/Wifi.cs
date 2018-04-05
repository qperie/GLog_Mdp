using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Wifi
    {
        // Constructeurs

        public Wifi() { }

        public Wifi(string SSID, string mdp)
        {
            this.SSID = SSID;
            this.Mdp = mdp;
        }


        // Méthodes

        public override string ToString()
        {
            return (this.SSID);
        }


        // Propriétés

        public virtual int Id { get; set; }

        public virtual string SSID { get; set; }

        public virtual string Mdp { get; set; }

    }
}
