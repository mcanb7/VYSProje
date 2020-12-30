using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VeritabaniOdev1
{

    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost; port=5432; Database=SinemaDatabase; user ID=postgres ; password=1234");

        private void button1_Click(object sender, EventArgs e)
        {         
            filmEkle fe = new filmEkle();
            fe.Show();   
        }

        private void button2_Click(object sender, EventArgs e)
        {
            filmAra fa = new filmAra();
            fa.Show();
        }



        private void button4_Click_1(object sender, EventArgs e)
        {
            biletSat bs = new biletSat();
            bs.Show();

        }
    }
}
