using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aukcionas
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            AukcionasEntities db = new AukcionasEntities();
            //db.Dailininkas.Remove(Dailininkas);
            db.Dailininkas.Add(new Dailininkas { Vardas = "Petras", Pavarde = "Petrauskas", GimimoMetai = new DateTime(1995, 04, 04) });
            db.SaveChanges();
            IQueryable<string> dbInfo = db.Dailininkas.Select(x => x.Vardas + x.Pavarde);

            foreach (string vardas in dbInfo)
            {
                Console.WriteLine(vardas);
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
