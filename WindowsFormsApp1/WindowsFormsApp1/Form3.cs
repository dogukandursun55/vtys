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
    
    public partial class Form3 : Form
    {
        DateTime dt = DateTime.Now;
        public string Kullanici = "";
        int sayac = 0;
        
        public NpgsqlConnection conn;
        string connstring = String.Format
            ("Server={0};Port={1};" +
            "User Id ={2};Password={3};Database={4};",
            "localhost", "5432", "postgres",
            "antikelek55", "postgres");
        public NpgsqlCommand cmd;

        public string sql = null;
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            conn = new NpgsqlConnection(connstring);
            label35.Text = Form1.a;
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
                label33.Text = da.GetValue(0).ToString();

            }
            conn.Close();
            sayac = 0;

            /////////////////////// pc fiyat 
            ///
            conn = new NpgsqlConnection(connstring);
            if (sayac == 0)
                conn.Open();
            sayac++;
            {
                NpgsqlCommand cmd3 = conn.CreateCommand();
                cmd3.CommandType = CommandType.Text;
                cmd3.CommandText = "select fiyat FROM urun where isim='bilgisayar'";

                NpgsqlDataReader da2 = cmd3.ExecuteReader();
                while (da2.Read())
                {
                    label10.Text = da2.GetValue(0).ToString();

                }
                conn.Close();
                sayac = 0;
                ///////////////pc stok
                ///
                conn = new NpgsqlConnection(connstring);
                if (sayac == 0)
                    conn.Open();
                sayac++;

                NpgsqlCommand cmd4 = conn.CreateCommand();
                cmd4.CommandType = CommandType.Text;
                cmd4.CommandText = "select stok FROM urun where isim='bilgisayar'";

                NpgsqlDataReader da3 = cmd4.ExecuteReader();
                while (da3.Read())
                {
                    label11.Text = da3.GetValue(0).ToString();

                }
                conn.Close();
                sayac = 0;
            }
            {
                /////////////////////// kulaklık fiyat 
                ///
                conn = new NpgsqlConnection(connstring);
                if (sayac == 0)
                    conn.Open();
                sayac++;

                NpgsqlCommand cmd3 = conn.CreateCommand();
                cmd3.CommandType = CommandType.Text;
                cmd3.CommandText = "select fiyat FROM urun where isim='kulaklık'";

                NpgsqlDataReader da2 = cmd3.ExecuteReader();
                while (da2.Read())
                {
                    label13.Text = da2.GetValue(0).ToString();

                }
                conn.Close();
                sayac = 0;
                //////////////kulaklık stok
                ///
                conn = new NpgsqlConnection(connstring);
                if (sayac == 0)
                    conn.Open();
                sayac++;

                NpgsqlCommand cmd4 = conn.CreateCommand();
                cmd4.CommandType = CommandType.Text;
                cmd4.CommandText = "select stok FROM urun where isim='kulaklık'";

                NpgsqlDataReader da3 = cmd4.ExecuteReader();
                while (da3.Read())
                {
                    label12.Text = da3.GetValue(0).ToString();

                }
                conn.Close();
                sayac = 0;

            }

            {
                /////////////////////// klavye fiyat 
                ///
                conn = new NpgsqlConnection(connstring);
                if (sayac == 0)
                    conn.Open();
                sayac++;

                NpgsqlCommand cmd3 = conn.CreateCommand();
                cmd3.CommandType = CommandType.Text;
                cmd3.CommandText = "select fiyat FROM urun where isim='klavye'";

                NpgsqlDataReader da2 = cmd3.ExecuteReader();
                while (da2.Read())
                {
                    label17.Text = da2.GetValue(0).ToString();

                }
                conn.Close();
                sayac = 0;
                //////////////klavye stok
                ///
                conn = new NpgsqlConnection(connstring);
                if (sayac == 0)
                    conn.Open();
                sayac++;

                NpgsqlCommand cmd4 = conn.CreateCommand();
                cmd4.CommandType = CommandType.Text;
                cmd4.CommandText = "select stok FROM urun where isim='klavye'";

                NpgsqlDataReader da3 = cmd4.ExecuteReader();
                while (da3.Read())
                {
                    label16.Text = da3.GetValue(0).ToString();

                }
                conn.Close();
                sayac = 0;

            }

            {
                /////////////////////// mouse fiyat 
                ///
                conn = new NpgsqlConnection(connstring);
                if (sayac == 0)
                    conn.Open();
                sayac++;

                NpgsqlCommand cmd3 = conn.CreateCommand();
                cmd3.CommandType = CommandType.Text;
                cmd3.CommandText = "select fiyat FROM urun where isim='fare'";

                NpgsqlDataReader da2 = cmd3.ExecuteReader();
                while (da2.Read())
                {
                    label21.Text = da2.GetValue(0).ToString();

                }
                conn.Close();
                sayac = 0;
                //////////////mouse stok
                ///
                conn = new NpgsqlConnection(connstring);
                if (sayac == 0)
                    conn.Open();
                sayac++;

                NpgsqlCommand cmd4 = conn.CreateCommand();
                cmd4.CommandType = CommandType.Text;
                cmd4.CommandText = "select stok FROM urun where isim='fare'";

                NpgsqlDataReader da3 = cmd4.ExecuteReader();
                while (da3.Read())
                {
                    label20.Text = da3.GetValue(0).ToString();

                }
                conn.Close();
                sayac = 0;

            }

            {
                /////////////////////// monitor fiyat 
                ///
                conn = new NpgsqlConnection(connstring);
                if (sayac == 0)
                    conn.Open();
                sayac++;

                NpgsqlCommand cmd3 = conn.CreateCommand();
                cmd3.CommandType = CommandType.Text;
                cmd3.CommandText = "select fiyat FROM urun where isim='monitor'";

                NpgsqlDataReader da2 = cmd3.ExecuteReader();
                while (da2.Read())
                {
                    label25.Text = da2.GetValue(0).ToString();

                }
                conn.Close();
                sayac = 0;
                //////////////monitor stok
                ///
                conn = new NpgsqlConnection(connstring);
                if (sayac == 0)
                    conn.Open();
                sayac++;

                NpgsqlCommand cmd4 = conn.CreateCommand();
                cmd4.CommandType = CommandType.Text;
                cmd4.CommandText = "select stok FROM urun where isim='monitor'";

                NpgsqlDataReader da3 = cmd4.ExecuteReader();
                while (da3.Read())
                {
                    label24.Text = da3.GetValue(0).ToString();

                }
                conn.Close();
                sayac = 0;

            }
            {
                /////////////////////// yazici fiyat 
                ///
                conn = new NpgsqlConnection(connstring);
                if (sayac == 0)
                    conn.Open();
                sayac++;

                NpgsqlCommand cmd3 = conn.CreateCommand();
                cmd3.CommandType = CommandType.Text;
                cmd3.CommandText = "select fiyat FROM urun where isim='yazıcı'";

                NpgsqlDataReader da2 = cmd3.ExecuteReader();
                while (da2.Read())
                {
                    label29.Text = da2.GetValue(0).ToString();

                }
                conn.Close();
                sayac = 0;
                //////////////yazici stok
                ///
                conn = new NpgsqlConnection(connstring);
                if (sayac == 0)
                    conn.Open();
                sayac++;

                NpgsqlCommand cmd4 = conn.CreateCommand();
                cmd4.CommandType = CommandType.Text;
                cmd4.CommandText = "select stok FROM urun where isim='yazıcı'";

                NpgsqlDataReader da3 = cmd4.ExecuteReader();
                while (da3.Read())
                {
                    label28.Text = da3.GetValue(0).ToString();

                }
                conn.Close();
                sayac = 0;

            }

        }

        private void label35_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form5 fm = new Form5();
            fm.Show();
            this.Hide();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int guncelbakiye = Int32.Parse(label33.Text);
            int urunfiyat = Int32.Parse(label10.Text);
            int urunstok = Int32.Parse(label11.Text);
            if (guncelbakiye >= urunfiyat&&urunstok>0)
            {
                {
                    if (sayac == 0)
                    {
                        conn.Open();
                        sayac++;
                    }
                    cmd = conn.CreateCommand();


                    //int sayi = Int32.Parse(textBox1.Text);
                    int stok = Int32.Parse(label11.Text) - 1;
                    string abc = stok.ToString();
                    cmd.CommandText = "update urun set stok='" + abc + "' Where isim='bilgisayar'";
                    cmd.ExecuteNonQuery();
                }
                {
                    if (sayac == 0)
                    {
                        conn.Open();
                        sayac++;
                    }
                    cmd = conn.CreateCommand();
                    cmd.CommandType = CommandType.Text;

                    cmd.CommandText = "insert into satinalimlar values('" + label1.Text + "','" + label35.Text + "','" + label10.Text + "','"+dt+"')";
                    cmd.ExecuteNonQuery();
                }
                {
                    if (sayac == 0)
                    {
                        conn.Open();
                        sayac++;
                    }
                    cmd = conn.CreateCommand();



                    int sonbakiye = Int32.Parse(label33.Text) - Int32.Parse(label10.Text);
                    string abc = sonbakiye.ToString();
                    cmd.CommandText = "update giris set bakiye='" + abc + "' Where kullaniciad='" + label35.Text + "'";
                    cmd.ExecuteNonQuery();
                }
                conn.Close();
                sayac = 0;


                MessageBox.Show("basariyla satın alindi");
                this.Hide();
                Form3 form3 = new Form3();
                form3.Show();
                form3.Refresh();
            }
            else
                MessageBox.Show("Yetersiz Bakiye veya Urun Stokta Yok");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int guncelbakiye = Int32.Parse(label33.Text);
            int urunfiyat = Int32.Parse(label13.Text);
            int urunstok = Int32.Parse(label12.Text);
            if (guncelbakiye >= urunfiyat && urunstok > 0)
            {
                {
                    if (sayac == 0)
                    {
                        conn.Open();
                        sayac++;
                    }
                    cmd = conn.CreateCommand();


                    //int sayi = Int32.Parse(textBox1.Text);
                    int stok = urunstok - 1;
                    string abc = stok.ToString();
                    cmd.CommandText = "update urun set stok='" + abc + "' Where isim='kulaklık'";
                    cmd.ExecuteNonQuery();
                }
                {
                    if (sayac == 0)
                    {
                        conn.Open();
                        sayac++;
                    }
                    cmd = conn.CreateCommand();
                    cmd.CommandType = CommandType.Text;

                    cmd.CommandText = "insert into satinalimlar values('" + label2.Text + "','" + label35.Text + "','" + urunfiyat + "','" + dt + "')";
                    cmd.ExecuteNonQuery();
                }
                {
                    if (sayac == 0)
                    {
                        conn.Open();
                        sayac++;
                    }
                    cmd = conn.CreateCommand();



                    int sonbakiye = Int32.Parse(label33.Text) - urunfiyat;
                    string abc = sonbakiye.ToString();
                    cmd.CommandText = "update giris set bakiye='" + abc + "' Where kullaniciad='" + label35.Text + "'";
                    cmd.ExecuteNonQuery();
                }
                conn.Close();
                sayac = 0;


                MessageBox.Show("basariyla satın alindi");
                this.Hide();
                Form3 form3 = new Form3();
                form3.Show();
                form3.Refresh();
            }
            else
                MessageBox.Show("Yetersiz Bakiye veya Urun Stokta Yok");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int guncelbakiye = Int32.Parse(label33.Text);
            int urunfiyat = Int32.Parse(label17.Text);
            int urunstok = Int32.Parse(label16.Text);
            if (guncelbakiye >= urunfiyat && urunstok > 0)
            {
                {
                    if (sayac == 0)
                    {
                        conn.Open();
                        sayac++;
                    }
                    cmd = conn.CreateCommand();


                    //int sayi = Int32.Parse(textBox1.Text);
                    int stok = urunstok - 1;
                    string abc = stok.ToString();
                    cmd.CommandText = "update urun set stok='" + abc + "' Where isim='klavye'";
                    cmd.ExecuteNonQuery();
                }
                {
                    if (sayac == 0)
                    {
                        conn.Open();
                        sayac++;
                    }
                    cmd = conn.CreateCommand();
                    cmd.CommandType = CommandType.Text;

                    cmd.CommandText = "insert into satinalimlar values('" + label3.Text + "','" + label35.Text + "','" + urunfiyat + "','" + dt + "')";
                    cmd.ExecuteNonQuery();
                }
                {
                    if (sayac == 0)
                    {
                        conn.Open();
                        sayac++;
                    }
                    cmd = conn.CreateCommand();



                    int sonbakiye = Int32.Parse(label33.Text) - urunfiyat;
                    string abc = sonbakiye.ToString();
                    cmd.CommandText = "update giris set bakiye='" + abc + "' Where kullaniciad='" + label35.Text + "'";
                    cmd.ExecuteNonQuery();
                }
                conn.Close();
                sayac = 0;


                MessageBox.Show("basariyla satın alindi");
                this.Hide();
                Form3 form3 = new Form3();
                form3.Show();
                form3.Refresh();
            }
            else
                MessageBox.Show("Yetersiz Bakiye veya Urun Stokta Yok");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int guncelbakiye = Int32.Parse(label33.Text);
            int urunfiyat = Int32.Parse(label21.Text);
            int urunstok = Int32.Parse(label20.Text);
            if (guncelbakiye >= urunfiyat && urunstok > 0)
            {
                {
                    if (sayac == 0)
                    {
                        conn.Open();
                        sayac++;
                    }
                    cmd = conn.CreateCommand();


                    //int sayi = Int32.Parse(textBox1.Text);
                    int stok = urunstok - 1;
                    string abc = stok.ToString();
                    cmd.CommandText = "update urun set stok='" + abc + "' Where isim='fare'";
                    cmd.ExecuteNonQuery();
                }
                {
                    if (sayac == 0)
                    {
                        conn.Open();
                        sayac++;
                    }
                    cmd = conn.CreateCommand();
                    cmd.CommandType = CommandType.Text;

                    cmd.CommandText = "insert into satinalimlar values('" + label4.Text + "','" + label35.Text + "','" + urunfiyat + "','" + dt + "')";
                    cmd.ExecuteNonQuery();
                }
                {
                    if (sayac == 0)
                    {
                        conn.Open();
                        sayac++;
                    }
                    cmd = conn.CreateCommand();



                    int sonbakiye = Int32.Parse(label33.Text) - urunfiyat;
                    string abc = sonbakiye.ToString();
                    cmd.CommandText = "update giris set bakiye='" + abc + "' Where kullaniciad='" + label35.Text + "'";
                    cmd.ExecuteNonQuery();
                }
                conn.Close();
                sayac = 0;


                MessageBox.Show("basariyla satın alindi");
                this.Hide();
                Form3 form3 = new Form3();
                form3.Show();
                form3.Refresh();
            }
            else
                MessageBox.Show("Yetersiz Bakiye veya Urun Stokta Yok");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int guncelbakiye = Int32.Parse(label33.Text);
            int urunfiyat = Int32.Parse(label25.Text);
            int urunstok = Int32.Parse(label24.Text);
            if (guncelbakiye >= urunfiyat && urunstok > 0)
            {
                {
                    if (sayac == 0)
                    {
                        conn.Open();
                        sayac++;
                    }
                    cmd = conn.CreateCommand();


                    int stok = urunstok - 1;
                    string abc = stok.ToString();
                    cmd.CommandText = "update urun set stok='" + abc + "' Where isim='monitor'";
                    cmd.ExecuteNonQuery();
                }
                {
                    if (sayac == 0)
                    {
                        conn.Open();
                        sayac++;
                    }
                    cmd = conn.CreateCommand();
                    cmd.CommandType = CommandType.Text;

                    cmd.CommandText = "insert into satinalimlar values('" + label5.Text + "','" + label35.Text + "','" + urunfiyat + "','" + dt + "')";
                    cmd.ExecuteNonQuery();
                }
                {
                    if (sayac == 0)
                    {
                        conn.Open();
                        sayac++;
                    }
                    cmd = conn.CreateCommand();



                    int sonbakiye = Int32.Parse(label33.Text) - urunfiyat;
                    string abc = sonbakiye.ToString();
                    cmd.CommandText = "update giris set bakiye='" + abc + "' Where kullaniciad='" + label35.Text + "'";
                    cmd.ExecuteNonQuery();
                }
                conn.Close();
                sayac = 0;


                MessageBox.Show("basariyla satın alindi");
                this.Hide();
                Form3 form3 = new Form3();
                form3.Show();
                form3.Refresh();
            }
            else
                MessageBox.Show("Yetersiz Bakiye veya Urun Stokta Yok");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int guncelbakiye = Int32.Parse(label33.Text);
            int urunfiyat = Int32.Parse(label29.Text);
            int urunstok = Int32.Parse(label28.Text);
            if (guncelbakiye >= urunfiyat && urunstok > 0)
            {
                {
                    if (sayac == 0)
                    {
                        conn.Open();
                        sayac++;
                    }
                    cmd = conn.CreateCommand();


                    int stok = urunstok - 1;
                    string abc = stok.ToString();
                    cmd.CommandText = "update urun set stok='" + abc + "' Where isim='yazıcı'";
                    cmd.ExecuteNonQuery();
                }
                {
                    if (sayac == 0)
                    {
                        conn.Open();
                        sayac++;
                    }
                    cmd = conn.CreateCommand();
                    cmd.CommandType = CommandType.Text;

                    cmd.CommandText = "insert into satinalimlar values('" + label6.Text + "','" + label35.Text + "','" + urunfiyat + "','" + dt + "')";
                    cmd.ExecuteNonQuery();
                }
                {
                    if (sayac == 0)
                    {
                        conn.Open();
                        sayac++;
                    }
                    cmd = conn.CreateCommand();



                    int sonbakiye = Int32.Parse(label33.Text) - urunfiyat;
                    string abc = sonbakiye.ToString();
                    cmd.CommandText = "update giris set bakiye='" + abc + "' Where kullaniciad='" + label35.Text + "'";
                    cmd.ExecuteNonQuery();
                }
                conn.Close();
                sayac = 0;


                MessageBox.Show("basariyla satın alindi");
                this.Hide();
                Form3 form3 = new Form3();
                form3.Show();
                form3.Refresh();
            }
            else
                MessageBox.Show("Yetersiz Bakiye veya Urun Stokta Yok");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form6 fm = new Form6();
            fm.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form7 fm = new Form7();
            fm.Show();
        }
    }
}
    

