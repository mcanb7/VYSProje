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
    public partial class filmEkle : Form
    {
        public filmEkle()
        {
            InitializeComponent();
        }
        NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost; port=5432; Database=SinemaDatabase; user ID=postgres ; password=1234");
       
        public int otomatikGuncelle()
        {
            string sorgu = "select * from film ";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];

            return 0;
        }
        private void button1_Click(object sender, EventArgs e)
        {

            baglanti.Open();
            NpgsqlCommand ekle = new NpgsqlCommand("insert into film (film_adi,film_cikis_tarihi,film_id) values (@fa,@fct,@fi)", baglanti);
            ekle.Parameters.AddWithValue("@fa", (textBox3.Text));
            ekle.Parameters.AddWithValue("@fct", Convert.ToDateTime(textBox2.Text));
            ekle.Parameters.AddWithValue("@fi", int.Parse(textBox1.Text));
            ekle.ExecuteNonQuery();
            MessageBox.Show("Film ekleme işlemi başarıyla gerçekleşti.", "Film Eklendi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            baglanti.Close();
            otomatikGuncelle();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            otomatikGuncelle();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            baglanti.Open();


            NpgsqlCommand guncelle = new NpgsqlCommand("update film set film_adi=@fa,film_cikis_tarihi=@fct where film_id=@fi", baglanti);

            guncelle.Parameters.AddWithValue("@fa", (textBox3.Text));
            guncelle.Parameters.AddWithValue("@fct", Convert.ToDateTime(textBox2.Text));
            guncelle.Parameters.AddWithValue("@fi", int.Parse(textBox1.Text));
            guncelle.ExecuteNonQuery();
            MessageBox.Show("Film güncelleme işlemi başarıyla gerçekleşti.", "Film Güncellendi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            baglanti.Close();
            otomatikGuncelle();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand silme = new NpgsqlCommand("Delete from film where film_id=@fi", baglanti);
            silme.Parameters.AddWithValue("@fi", int.Parse(textBox1.Text));
            silme.ExecuteNonQuery();
            MessageBox.Show("Film silme işlemi başarıyla gerçekleşti.", "Film Silindi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            baglanti.Close();
            otomatikGuncelle();
        }
    }
}
