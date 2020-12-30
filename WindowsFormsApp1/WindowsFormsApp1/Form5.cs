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
    public partial class Form5 : Form
    {
        public int sayac = 0;
        public NpgsqlConnection conn;
        string connstring = String.Format
            ("Server={0};Port={1};" +
            "User Id ={2};Password={3};Database={4};",
            "localhost", "5432", "postgres",
            "antikelek55", "postgres");
        public NpgsqlCommand cmd;

        public string sql = null;
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox1.Text != "" && comboBox1.Text != "")
            {
                {
                    if (sayac == 0)
                        conn.Open();
                    sayac++;
                    cmd = conn.CreateCommand();


                    int sayi = Int32.Parse(textBox1.Text);
                    int toplam = sayi + Int32.Parse(label6.Text);
                    string abc = toplam.ToString();
                    cmd.CommandText = "update giris set bakiye='" + abc + "' Where kullaniciad='" + Form1.a + "'";
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("bakiyeniz güncellendi");
                    this.Hide();
                    Form3 form3 = new Form3();
                    form3.Show();
                    form3.Refresh();
                }
                {
                    if (sayac == 0)
                    {
                        conn.Open();
                        sayac++;
                    }
                    cmd = conn.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    DateTime dt;
                    dt = DateTime.Now;
                    cmd.CommandText = "insert into bakiyeyuklemeler values('" + Form1.a + "','" + textBox1.Text + "','" + comboBox1.Text + "','" + dt + "')";
                    cmd.ExecuteNonQuery();
                }
            }
            else
                MessageBox.Show("kutucukları boş bırakmayınız");
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            conn = new NpgsqlConnection(connstring);
            if (sayac == 0)
                conn.Open();
            sayac++;
            
            NpgsqlCommand cmd2 = conn.CreateCommand();
            cmd2.CommandType = CommandType.Text;
            cmd2.CommandText = "select bakiye FROM giris where kullaniciad='" + Form1.a + "'";
          
            NpgsqlDataReader da = cmd2.ExecuteReader();
            while (da.Read())
            {
                label6.Text = da.GetValue(0).ToString();

            }
            conn.Close();
            sayac = 0;
        }
        
    }
}
