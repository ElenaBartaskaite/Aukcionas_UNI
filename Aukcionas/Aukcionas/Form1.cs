using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aukcionas
{
    public partial class Form1 : Form
    {
        public Aukcionas prisijungta = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=C:\USERS\ELENA\DESKTOP\EB\AUKCIONAS\AUKCIONAS\BIN\DEBUG\AUKCIONAS.MDF;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            string query = textBox1.Text;

            SqlConnection conn = new SqlConnection(connString);
            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();

            // create data adapter
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            // this will query your database and return the result to your datatable
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
            da.Dispose();
        }
        static DataTable Select(string what, string from, string db)
        {
            SqlConnection conn = new SqlConnection(db);
            SqlCommand cmd = new SqlCommand("Select " + what + " from " + from + ";", conn);
            conn.Open();

            // create data adapter
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            // this will query your database and return the result to your datatable
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            da.Dispose();
            return dt;
        }

        /*private void Selectinimas cia(object sender, EventArgs e)
        {
            string connString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=C:\USERS\ELENA\DESKTOP\EB\AUKCIONAS\AUKCIONAS\BIN\DEBUG\AUKCIONAS.MDF;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            string what = textBox2.Text;
            string from = textBox3.Text;
            dataGridView2.DataSource = Select(what, from, connString);
        }*/

        /*private void button3_Click(object sender, EventArgs e)
        {
            string connString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=C:\USERS\ELENA\DESKTOP\EB\AUKCIONAS\AUKCIONAS\BIN\DEBUG\AUKCIONAS.MDF;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            string to = textBox4.Text;
            string valueTypes = textBox5.Text;
            string values = textBox6.Text;
            SqlConnection conn = new SqlConnection(connString);
            SqlCommand cmd = new SqlCommand("INSERT INTO " + to + "(" + valueTypes + ")VALUES(" + values + ");");
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            da.Dispose();
            dataGridView3.DataSource = Select("*", to, connString);
        }*/


        private void button3_Click(object sender, EventArgs e)
        {
            //paveikslaas ikelt
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //dailininkas update
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //kolekcionieriai
        }

        }
    }
}
