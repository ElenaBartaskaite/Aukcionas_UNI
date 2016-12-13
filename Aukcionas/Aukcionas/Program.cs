using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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
            string connString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=C:\USERS\ELENA\DESKTOP\EB\AUKCIONAS\AUKCIONAS\BIN\DEBUG\AUKCIONAS.MDF;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            
            // var dbDS = new DataSet();

            /*AukcionasEntities db = new AukcionasEntities();
            db.Dailininkas.Add(new Dailininkas { Vardas = "Petras", Pavarde = "Petrauskas", GimimoMetai = new DateTime(1995, 04, 04) });
            db.SaveChanges();
            IQueryable<string> dbInfo = db.Dailininkas.Select(x => x.Vardas + x.Pavarde);

            foreach (string vardas in dbInfo)
            {
                Console.WriteLine(vardas);
            }
            */
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
        
    }
}
