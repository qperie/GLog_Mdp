using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domain;


namespace form
{
    static class Program
    {
        public static int session = 0; // Variable globale de session, 0 si pas de connexion sinon = id de l'utilisateur
        
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Connexion connexion = new Connexion();
            connexion.Show();
            Application.Run();
        }

    }
}
