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
    public partial class personelanasayfa : Form
    {
        public personelanasayfa()
        {
            InitializeComponent();
        }

        public string tc;

        sqlbaglanti bgl = new sqlbaglanti();

        private void personelanasayfa_Load(object sender, EventArgs e)
        {
            labeltc.Text = tc;


            // Personel Bilgilerini Çekme(ad-soyad-tc)
            SqlCommand komut = new SqlCommand("Select personelad, personelsoyad  From [kargomanagement].[dbo].[prsonel] Where personelTC=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", labeltc.Text);

            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                lblad.Text = dr[0] + " ";
                lblsoyad.Text = dr[1] + " ";
                
            }

            bgl.baglanti().Close();

            //Kargo Durumlarını Çekme

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select kargotakipno, kargodurumid from [kargomanagement].[dbo].[krgo]", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            // Kargo Takip no ları çekme

            SqlCommand komut2 = new SqlCommand("select kargotakipno from [kargomanagement].[dbo].[krgo]", bgl.baglanti());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                comboBoxkargotakipno.Items.Add(dr2[0]);
            }
            bgl.baglanti().Close();

            //KArgo son durumları çekme

            SqlCommand komut3 = new SqlCommand("select kargodurum from [kargomanagement].[dbo].[kargodurum]", bgl.baglanti());
            SqlDataReader dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            {
                comboBoxsondurum.Items.Add(dr3[0]);
            }

        }

        private void buttonkargogüncelle_Click(object sender, EventArgs e)
        {
            SqlCommand bud =new SqlCommand( "Update [kargomanagement].[dbo].[krgo] SET kargodurumid=@p1  WHERE kargotakipno =@p2", bgl.baglanti());
            //bu kargoid ye ait kargotakip noyu çıkartabilirim hepsini yaptıktan sonra


            bud.Parameters.AddWithValue("@p2", comboBoxkargotakipno.SelectedItem.ToString());

            bud.Parameters.AddWithValue("@p1", comboBoxsondurum.SelectedIndex.ToString());


           // "+comboBoxkargotakipno.SelectedIndex.ToString() +"'"

            bud.ExecuteNonQuery();

            bgl.baglanti().Close();

            MessageBox.Show("Kargo Son Durum güncellendi");



        }

        private void krgekle_Click(object sender, EventArgs e)
        {
            kargoekle ke = new kargoekle();
            ke.tc = labeltc.Text;
            ke.Show();


        }

        private void ftrekle_Click(object sender, EventArgs e)
        {

            faturaekle fe = new faturaekle();
            fe.Show();
            


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void kargoliste_Click(object sender, EventArgs e)
        {
            // KARgoları Listeleme

            SqlDataAdapter da = new SqlDataAdapter(" select * from [kargomanagement].[dbo].[krgo] ", bgl.baglanti());
            DataTable t1 = new DataTable();
            da.Fill(t1);

            dataGridView1.DataSource = t1;



        }

        private void faturaliste_Click(object sender, EventArgs e)
        {

            SqlDataAdapter dad = new SqlDataAdapter("select * from [kargomanagement].[dbo].[fattura]", bgl.baglanti());
            DataTable t = new DataTable();
            dad.Fill(t);

            dataGridView1.DataSource = t;


        }

        private void buttonkargodurumliste_Click(object sender, EventArgs e)
        {
            SqlDataAdapter dataad = new SqlDataAdapter("select kargotakipno, kargodurumid from [kargomanagement].[dbo].[krgo]  ", bgl.baglanti());
            DataTable dt = new DataTable();
            dataad.Fill(dt);

            dataGridView1.DataSource = dt;

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
