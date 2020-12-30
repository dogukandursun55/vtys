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
  

    public partial class Form4 : Form
    {
        public string Kullanici = "";
        public int sayac = 0;
        public NpgsqlConnection conn;
        string connstring = String.Format
            ("Server={0};Port={1};" +
            "User Id ={2};Password={3};Database={4};",
            "localhost", "5432", "postgres",
            "antikelek55", "postgres");
        public NpgsqlCommand cmd;

        public string sql = null;
        
        public Form4()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                if (sayac == 0)
                    conn.Open();
                sayac++;
                cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "update urun set fiyat='" + textBox1.Text + "',stok='" + textBox2.Text + "'Where isim='bilgisayar'";
                cmd.ExecuteNonQuery();
                MessageBox.Show("fiyat ve stok Güncellendi");
            }
            else
                MessageBox.Show("Hem Stok Hemde Fiyat Bilgisi Giriniz");
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            conn = new NpgsqlConnection(connstring);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox3.Text != "" && textBox4.Text != "")
            {
                if (sayac == 0)
                    conn.Open();
                sayac++;
                cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "update urun set fiyat='" + textBox4.Text + "',stok='" + textBox3.Text + "'Where isim='kulaklık'";
                cmd.ExecuteNonQuery();
                MessageBox.Show("fiyat ve stok Güncellendi");
            }
            else
                MessageBox.Show("Hem Stok Hemde Fiyat Bilgisi Giriniz");

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox5.Text != "" && textBox6.Text != "")
            {
                if (sayac == 0)
                    conn.Open();
                sayac++;
                cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "update urun set fiyat='" + textBox6.Text + "',stok='" + textBox5.Text + "'Where isim='klavye'";
                cmd.ExecuteNonQuery();
                MessageBox.Show("fiyat ve stok Güncellendi");
            }
            MessageBox.Show("Hem Stok Hemde Fiyat Bilgisi Giriniz");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox11.Text !="" && textBox12.Text != "")
            {
                if (sayac == 0)
                    conn.Open();
                sayac++;
                cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "update urun set fiyat='" + textBox8.Text + "',stok='" + textBox7.Text + "'Where isim='fare'";
                cmd.ExecuteNonQuery();
                MessageBox.Show("fiyat ve stok Güncellendi");
            }
            else
            MessageBox.Show("Hem Stok Hemde Fiyat Bilgisi Giriniz");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox9.Text != "" && textBox10.Text != "")
            {
                if (sayac == 0)
                    conn.Open();
                sayac++;
                cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "update urun set fiyat='" + textBox10.Text + "',stok='" + textBox9.Text + "'Where isim='monitor'";
                cmd.ExecuteNonQuery();
                MessageBox.Show("fiyat ve stok Güncellendi");
            }
            else
                MessageBox.Show("Hem Stok Hemde Fiyat Bilgisi Giriniz");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox7.Text != "" && textBox8.Text !="")
            {
                if (sayac == 0)
                    conn.Open();
                sayac++;
                cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "update urun set fiyat='" + textBox12.Text + "',stok='" + textBox11.Text + "'Where isim='yazıcı'";
                cmd.ExecuteNonQuery();
                MessageBox.Show("fiyat ve stok Güncellendi");
            }
            else
                MessageBox.Show("Hem Stok Hemde Fiyat Bilgisi Giriniz");

        }
    }
}
