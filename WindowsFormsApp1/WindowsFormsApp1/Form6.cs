using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
namespace WindowsFormsApp1
{
    public partial class Form6 : Form
    {
      
        int sayac = 0;

        public NpgsqlConnection conn;
        string connstring = String.Format
            ("Server={0};Port={1};" +
            "User Id ={2};Password={3};Database={4};",
            "localhost", "5432", "postgres",
            "antikelek55", "postgres");
        public NpgsqlCommand cmd;

        public string sql = null;
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            label2.Text = Form1.a;
            DataTable dt2 = new DataTable();
            conn = new NpgsqlConnection(connstring);
            NpgsqlCommand cm=new NpgsqlCommand("select urunad, fiyat, tarih from satinalimlar where alankullanici = '" + Form1.a + "'",conn);
            conn.Open();
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(cm);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            conn.Close();
            da.Dispose();

            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.ReadOnly = true;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
