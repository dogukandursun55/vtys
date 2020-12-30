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


    public partial class Form2 : Form
    {
        public NpgsqlConnection conn;
        string connstring = String.Format
            ("Server={0};Port={1};" +
            "User Id ={2};Password={3};Database={4};",
            "localhost", "5432", "postgres",
            "antikelek55", "postgres");
        public NpgsqlCommand cmd;
       
        public string sql = null;
        
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox2.Text == textBox3.Text)
                {
                    conn.Open();
                    cmd = conn.CreateCommand();
                    cmd.CommandType = CommandType.Text;

                    cmd.CommandText = "insert into giris values('" + textBox1.Text + "','" + textBox2.Text + "','kullanici','0')";
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Basariyla kaydoldunuz");
                    this.Hide();
                    Form1 fm = new Form1();
                    fm.Show();
                }
                else
                    MessageBox.Show("sifreler uyusmuyor");
            }
            catch (Exception ex)
            {
                MessageBox.Show("hata");

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            conn = new NpgsqlConnection(connstring);
        }
    }
}
