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

namespace kargomanagement
{
    public partial class kargoekle : Form
    {
        public kargoekle()
        {
            InitializeComponent();


        }

        public string tc;
        sqlbaglanti bgl = new sqlbaglanti();

        public string musteriad;

    private void buttonkargotemizle_Click(object sender, EventArgs e)
        {

            textBoxgad.Text = " ";
            textBoxgsoy.Text = " ";
            textBoxgtel.Text = " ";
            comboBox1.Text = " ";
            textBoxkargotakipno.Text = " ";
            textBoxaad.Text = " ";
            textBoxasoy.Text = " ";
            textBoxatel.Text = " ";
            cmbil.Text = " ";
            textBoxkargoadres.Text = " ";
            textBoxucret.Text = " ";
            comboBoxucretsekli.Text = " ";
            txtfaturaid.Text = " ";
            cmbkargodurum.Text = " ";



        }

        bool durum;
        void tekrarlama()
        {
            SqlCommand tekrarkomut = new SqlCommand("select* from [kargomanagement].[dbo].[musterii] Where musteriid=@p1", bgl.baglanti());
            tekrarkomut.Parameters.AddWithValue("@p1", txtmusteriid.Text);

            SqlCommand komuttakip = new SqlCommand("select* from [kargomanagement].[dbo].[krgo] Where kargotakipno=@p2", bgl.baglanti());
            komuttakip.Parameters.AddWithValue("@p2", textBoxkargotakipno.Text);


            SqlDataReader oku = tekrarkomut.ExecuteReader();
            oku = komuttakip.ExecuteReader();

            if (oku.Read())
            {
                durum = false;
            }
            else
            {
                durum = true;
            }

            bgl.baglanti().Close();

        }

      


        private void buttonkargoekle_Click(object sender, EventArgs e)
        {

            tekrarlama();

            if (durum == true)
            {

                SqlCommand kom = new SqlCommand("insert into [kargomanagement].[dbo].[musterii] (musteriid, musteriad, musterisoyad, musteritel, musteriturid, kargotakipno) values (@p1,@p2,@p3,@p4,@p5,@p6 )", bgl.baglanti());

                SqlCommand komut = new SqlCommand("insert into [kargomanagement].[dbo].[krgo] (kargotakipno, aliciad, alicisoyad,alicitelno, kargoteslimadres, verilistarihi, odemetipiid, ucret, personelTC, kargodurumid,faturaid, musteriid,ilid) values (@p10,@p20,@p30,@p40,@p50,@p60,@p70,@p80,@p90,@p100,@p110,@p120,@p130)", bgl.baglanti());



                kom.Parameters.AddWithValue("@p1", txtmusteriid.Text);
                kom.Parameters.AddWithValue("@p2", textBoxgad.Text);
                kom.Parameters.AddWithValue("@p3", textBoxgsoy.Text);
                kom.Parameters.AddWithValue("@p4", textBoxgtel.Text);
                kom.Parameters.AddWithValue("@p5", comboBox1.SelectedIndex.ToString());
                kom.Parameters.AddWithValue("@p6", textBoxkargotakipno.Text);

                komut.Parameters.AddWithValue("@p120", txtmusteriid.Text);
                komut.Parameters.AddWithValue("@p20", textBoxaad.Text);
                komut.Parameters.AddWithValue("@p30", textBoxasoy.Text);
                komut.Parameters.AddWithValue("@p40", textBoxatel.Text);
                komut.Parameters.AddWithValue("@p130", cmbil.SelectedIndex.ToString());
                komut.Parameters.AddWithValue("@p50", textBoxkargoadres.Text);
                komut.Parameters.AddWithValue("@p60", dateTimePicker1.Value.ToString("yyyy-MM-dd"));
                komut.Parameters.AddWithValue("@p70", comboBoxucretsekli.SelectedIndex.ToString());
                komut.Parameters.AddWithValue("@p80", textBoxucret.Text);
                komut.Parameters.AddWithValue("@p10", textBoxkargotakipno.Text);
                komut.Parameters.AddWithValue("@p90", lblpersonel.Text);
                komut.Parameters.AddWithValue("@p110", txtfaturaid.Text);
                komut.Parameters.AddWithValue("@p100", cmbkargodurum.SelectedIndex.ToString());



                kom.ExecuteNonQuery();
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();

                MessageBox.Show("Kargo Eklendi");

            }

            else
            {
                MessageBox.Show("Farklı bir müşteri ID giriniz");
            }

        }

        private void kargoekle_Load(object sender, EventArgs e)
        {

            lblpersonel.Text = tc;

            SqlCommand komut3 = new SqlCommand("select ilad from [kargomanagement].[dbo].[il]", bgl.baglanti());
            SqlDataReader dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            {
                cmbil.Items.Add(dr3[0]);
            }

            SqlCommand k = new SqlCommand("select odemetipi from  [kargomanagement].[dbo].[odemetipi] ", bgl.baglanti());
            SqlDataReader r = k.ExecuteReader();
            while (r.Read())
            {
                comboBoxucretsekli.Items.Add(r[0]);
            }

            SqlCommand k2 = new SqlCommand("select kargodurum from  [kargomanagement].[dbo].[kargodurum] ", bgl.baglanti());
            SqlDataReader r2 = k2.ExecuteReader();
            while (r2.Read())
            {
                cmbkargodurum.Items.Add(r2[0]);
            }


            SqlCommand k4 = new SqlCommand("select turad from  [kargomanagement].[dbo].[musteritur] ", bgl.baglanti());
            SqlDataReader r4 = k4.ExecuteReader();
            while (r4.Read())
            {
                comboBox1.Items.Add(r4[0]);
            }

        }
    }
}
