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

namespace VeritabaniOdev1
{
    public partial class biletSat : Form
    {

        public biletSat()
        {
            InitializeComponent();
        }
        NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost; port=5432; Database=SinemaDatabase; user ID=postgres ; password=1234");

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked == true)
            {
                checkBox2.Enabled = false;
                button13.Enabled = true;
            }

            else
            {
                checkBox2.Enabled = true;
                button13.Enabled = false;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                checkBox1.Enabled = false;
                button13.Enabled = true;
            }

            else
            {
                checkBox1.Enabled = true;
                button13.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox3.Text = label1.Text + button1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox3.Text = label1.Text + button2.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox3.Text = label1.Text + button3.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox3.Text = label1.Text + button4.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox3.Text = label1.Text + button5.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox3.Text = label1.Text + button6.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox3.Text = label2.Text + button7.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox3.Text = label2.Text + button8.Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox3.Text = label2.Text + button9.Text;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox3.Text = label2.Text + button10.Text;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox3.Text = label2.Text + button11.Text;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox3.Text = label2.Text + button12.Text;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            int dolu=0;
            int bos = 12;

            try
            {
                //Aşağıdaki Kodlarda İse Satışı Yapılan Koltukların Dolu Gözükmesi için gerekli kodları yazdık.


                // ------------- A SIRASINDAKI KOLTUKLAR ICIN --------------
                if (textBox3.Text == "A1")
                {
                    button1.BackColor = Color.Red; button1.Enabled = false;
                    dolu ++;
                    bos--;
                    label7.Text = "DOLU: " + dolu.ToString();
                    label6.Text = "BOŞ: " + bos.ToString();
                }
                if (textBox3.Text == "A2")
                {
                    button2.BackColor = Color.Red; button2.Enabled = false;
                    dolu++;
                    bos--;
                    label7.Text = "DOLU: " + dolu.ToString();
                    label6.Text = "BOŞ: " + bos.ToString();
                }
                if (textBox3.Text == "A3")
                {
                    button3.BackColor = Color.Red; button3.Enabled = false;
                    dolu++;
                    bos--;
                    label7.Text = "DOLU: " + dolu.ToString();
                    label6.Text = "BOŞ: " + bos.ToString();
                }
                if (textBox3.Text == "A4")
                {
                    button4.BackColor = Color.Red; button4.Enabled = false;
                    dolu++;
                    bos--;
                    label7.Text = "DOLU: " + dolu.ToString();
                    label6.Text = "BOŞ: " + bos.ToString();
                }
                if (textBox3.Text == "A5")
                {
                    button5.BackColor = Color.Red; button5.Enabled = false;
                    dolu++;
                    bos--;
                    label7.Text = "DOLU: " + dolu.ToString();
                    label6.Text = "BOŞ: " + bos.ToString();
                }
                if (textBox3.Text == "A6")
                {
                    button6.BackColor = Color.Red; button6.Enabled = false;
                    dolu++;
                    bos--;
                    label7.Text = "DOLU: " + dolu.ToString();
                    label6.Text = "BOŞ: " + bos.ToString();
                }

                // ---------------- B SATIRINDAKI KOLTUKLAR ICIN---------------

                if (textBox3.Text == "B1")
                { 
                    button7.BackColor = Color.Red; button7.Enabled = false;
                    dolu++;
                    bos--;
                    label7.Text = "DOLU: " + dolu.ToString();
                    label6.Text = "BOŞ: " + bos.ToString();
                }
                if (textBox3.Text == "B2")
                {
                    button8.BackColor = Color.Red; button8.Enabled = false;
                    dolu++;
                    bos--;
                    label7.Text = "DOLU: " + dolu.ToString();
                    label6.Text = "BOŞ: " + bos.ToString();
                }
                if (textBox3.Text == "B3")
                {
                    button9.BackColor = Color.Red; button9.Enabled = false;
                    dolu++;
                    bos--;
                    label7.Text = "DOLU: " + dolu.ToString();
                    label6.Text = "BOŞ: " + bos.ToString();
                }
                if (textBox3.Text == "B4")
                {
                    button10.BackColor = Color.Red; button10.Enabled = false;
                    dolu++;
                    bos--;
                    label7.Text = "DOLU: " + dolu.ToString();
                    label6.Text = "BOŞ: " + bos.ToString();
                }
                if (textBox3.Text == "B5")
                {
                    button11.BackColor = Color.Red; button11.Enabled = false;
                    dolu++;
                    bos--;
                    label7.Text = "DOLU: " + dolu.ToString();
                    label6.Text = "BOŞ: " + bos.ToString();
                }
                if (textBox3.Text == "B6")
                {
                    button12.BackColor = Color.Red; button12.Enabled = false;
                    dolu++;
                    bos--;
                    label7.Text = "DOLU: " + dolu.ToString();
                    label6.Text = "BOŞ: " + bos.ToString();
                }

            }

            catch
            {

            }

            if (checkBox1.Checked == true)
            {
                baglanti.Open();
                NpgsqlCommand komut1 = new NpgsqlCommand("insert into bilet (bilet_tarih,bilet_fiyat,bilet_id,koltuk_no) values (@bt,@bf,@bi,@kn)", baglanti);
                komut1.Parameters.AddWithValue("@bt", Convert.ToDateTime(textBox1.Text));
                komut1.Parameters.AddWithValue("@bf", int.Parse(label10.Text));
                komut1.Parameters.AddWithValue("@bi", int.Parse(textBox4.Text));
                komut1.Parameters.AddWithValue("@kn", (textBox3.Text));
                komut1.ExecuteNonQuery();
                MessageBox.Show("Bilet Satışı Gerçekleşti.", "Bilet satildi.", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                baglanti.Close();
                
            }
            else if (checkBox2.Checked == true)
            {
                baglanti.Open();
                NpgsqlCommand komut2 = new NpgsqlCommand("insert into bilet (bilet_tarih,bilet_fiyat,bilet_id,koltuk_no) values (@bt,@bf,@bi,@kn)", baglanti);
                komut2.Parameters.AddWithValue("@bt", Convert.ToDateTime(textBox1.Text));
                komut2.Parameters.AddWithValue("@bf", int.Parse(label11.Text));
                komut2.Parameters.AddWithValue("@bi", int.Parse(textBox4.Text));
                komut2.Parameters.AddWithValue("@kn", (textBox3.Text));
                komut2.ExecuteNonQuery();
                MessageBox.Show("Bilet Satışı Gerçekleşti.", "Bilet satildi.", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                baglanti.Close();
                
            }

        }

        private void biletSat_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            comboBox1.Items.Clear();
            NpgsqlCommand combo = new NpgsqlCommand();
            combo.CommandText = "select film.film_adi from film";
            combo.Connection = baglanti;
            combo.CommandType = CommandType.Text;
            NpgsqlDataReader dr = combo.ExecuteReader();

            while (dr.Read())
            {
                if (true)
                {
                    comboBox1.Items.Add(dr["film_adi"]);
                }
            }

            baglanti.Close();

        }
    }
}

