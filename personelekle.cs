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
    public partial class personelekle : Form
    {
        public personelekle()
        {
            InitializeComponent();
        }

        private void personelekle_Load(object sender, EventArgs e)
        {
            SqlCommand komut2 = new SqlCommand("select * from [kargomanagement].[dbo].[sube]", bgl.baglanti());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                cmbsube.Items.Add(dr2[1]);
            }
            SqlCommand komut3 = new SqlCommand("select * from [kargomanagement].[dbo].[personelgorev]", bgl.baglanti());
            SqlDataReader dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            {
                cmbpergorev.Items.Add(dr3[1]);
            }
            SqlCommand komut4 = new SqlCommand("select * from [kargomanagement].[dbo].[il]", bgl.baglanti());
            SqlDataReader dr4 = komut4.ExecuteReader();
            while (dr4.Read())
            {
                cmbil.Items.Add(dr4[1]);
            }




        }

        sqlbaglanti bgl = new sqlbaglanti();

        bool durum;
        void tekrarlama()
        {
            SqlCommand tekrarkomut = new SqlCommand("select* from [kargomanagement].[dbo].[prsonel] Where personelTC=@p1", bgl.baglanti());
            tekrarkomut.Parameters.AddWithValue("@p1", msktc.Text);

            SqlDataReader oku = tekrarkomut.ExecuteReader();

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
        private void btnperekle_Click(object sender, EventArgs e)
        {

            if (durum == true)
            {


                SqlCommand komut = new SqlCommand("insert into [kargomanagement].[dbo].[prsonel] (personelad, personelsoyad, personelTC, personelsifre, personeltel, personelgorevid, subeid, ilid) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8)", bgl.baglanti());




                komut.Parameters.AddWithValue("@p1", personelad.Text);
                komut.Parameters.AddWithValue("@p2", personelsoyad.Text);
                komut.Parameters.AddWithValue("@p3", msktc.Text);
                komut.Parameters.AddWithValue("@p4", sifre.Text);
                komut.Parameters.AddWithValue("@p5", msktelno.Text);
                komut.Parameters.AddWithValue("@p6", cmbpergorev.SelectedIndex.ToString());
                komut.Parameters.AddWithValue("@p7", cmbsube.SelectedIndex.ToString());
                komut.Parameters.AddWithValue("@p8", cmbil.SelectedIndex.ToString());

                komut.ExecuteNonQuery();
                bgl.baglanti().Close();

                MessageBox.Show("Personel Eklendi");

            }
            else
            {
                MessageBox.Show("Bu TC numarasıyla kayıtlı personel bulunmaktadır.");
            }
        }

        private void cmbil_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbsube.Items.Clear();

            SqlCommand k5 = new SqlCommand("select subead from [kargomanagement].[dbo].[il] join [kargomanagement].[dbo].[sube] ON [kargomanagement].[dbo].[il].subeid= [kargomanagement].[dbo].[sube].subeid Where ilad=@p1", bgl.baglanti());
            k5.Parameters.AddWithValue("@p1", cmbil.SelectedItem.ToString());
            SqlDataReader dr5 = k5.ExecuteReader();
            while (dr5.Read())
            {
                cmbsube.Items.Add(dr5[0]); 

                bgl.baglanti().Close();
            }
        }

        private void btntemizle_Click(object sender, EventArgs e)
        {
            personelad.Text = " ";
            personelsoyad.Text = " ";
            msktc.Text = " ";
            cmbil.Text = " ";
            sifre.Text = " ";
            msktelno.Text = " ";
            cmbpergorev.Text = " ";
            cmbsube.Text = " ";

        }
    }
}
