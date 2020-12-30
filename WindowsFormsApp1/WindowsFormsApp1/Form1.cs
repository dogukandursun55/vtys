using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Devart.Data.PostgreSql;
using Devart.Data;
using Devart.Common;
using Npgsql;


namespace WindowsFormsApp1
{
    
    public partial class Form1 : Form
    {
        
        
       
        
        public static string a;
        public NpgsqlConnection conn;
        string connstring = String.Format
            ("Server={0};Port={1};" +
            "User Id ={2};Password={3};Database={4};",
            "localhost", "5432", "postgres",
            "antikelek55", "postgres");
        public NpgsqlCommand cmd;
        public NpgsqlCommand cmd2;
        public string sql = null;
        public string sql2 = null;



        public Form1()
        {
            InitializeComponent();
        }
      
        private void button1_Click(object sender, EventArgs e)
        {

            try
            {


                if (textBox2.Text != "" && textBox1.Text != ""&&comboBox1.Text!="")
                {
                    conn.Open();
                    sql = @"select * from u_login3(:_kullaniciad,:_sifre,:_yetki)";
                    sql2 = @"select * from u_login4(:_kullaniciad,:_sifre,:_yetki)";
                    cmd = new NpgsqlCommand(sql, conn);
                    cmd2 = new NpgsqlCommand(sql2, conn);
                    cmd.Parameters.AddWithValue("_kullaniciad", textBox1.Text);
                    cmd.Parameters.AddWithValue("_sifre", textBox2.Text);
                    cmd.Parameters.AddWithValue("_yetki", comboBox1.Text);
                    cmd2.Parameters.AddWithValue("_kullaniciad", textBox1.Text);
                    cmd2.Parameters.AddWithValue("_sifre", textBox2.Text);
                    cmd2.Parameters.AddWithValue("_yetki", comboBox1.Text);
                    int result = (int)cmd.ExecuteScalar();
                    int result2 = (int)cmd2.ExecuteScalar();
                    conn.Close();



                    if (result == 1)
                    {
                        a = textBox1.Text;
                        Form4 fm2 = new Form4();
                        fm2.Show();
                        this.Hide();
                    }

                    else if (result2 == 2)
                    {
                        a = textBox1.Text;
                        Form3 fm = new Form3();
                        fm.Show();
                        this.Hide();


                    }


                    else
                    {
                        MessageBox.Show("kullanici adi veya sifre yanlis");

                    }
                }
                else
                    MessageBox.Show("Kullanici adi ,sifre veya giris tipi alanı boş bırakılamaz");
            }
            catch(Exception ex)
            {

                MessageBox.Show("hata");
                conn.Close();
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            conn = new NpgsqlConnection(connstring);
        }

        private void label34_Click(object sender, EventArgs e)
        {

        }
    }
}
