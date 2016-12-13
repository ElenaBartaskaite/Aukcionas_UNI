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
           // var dbDS = new DataSet();
            

            /*var adapter = new SqlDataAdapter("select * From Aukcionas;", connection);
            adapter.Fill(dbDS, "Aukcionas");
            //Select/insert/update/delete realizacijos
            var InsertCmd = new SqlCommand();
            InsertCmd.CommandText = "INSERT INTO Aukcionas(Pavadinimas, Vieta, Data, Pradzia, Pabaiga) VALUES (@Kodo, @Ikeltas, @2016/02/02, @11:00, @12:00)";
            //adapter.Fill*/
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
