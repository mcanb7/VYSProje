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
    public partial class filmAra : Form
    {
        public filmAra()
        {
            InitializeComponent();
        }

        NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost; port=5432; Database=SinemaDatabase; user ID=postgres ; password=1234");
        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            DataTable tablo = new DataTable();
            NpgsqlDataAdapter adtr = new NpgsqlDataAdapter("select * from film where film_adi like'%" + textBox1.Text + "%'", baglanti);
            adtr.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }
    }
}
