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
    public partial class musterianasayfa : Form
    {
        public musterianasayfa()
        {
            InitializeComponent();
        }
        sqlbaglanti bgl = new sqlbaglanti();

        public string musteriid;
        private void musterianasayfa_Load(object sender, EventArgs e)
        {

            lnlmusteriid.Text = musteriid;

            SqlCommand komut = new SqlCommand("Select musteriad, musterisoyad  From [kargomanagement].[dbo].[musterii] Where musteriid=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", lnlmusteriid.Text);

            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                lnlmusteriad.Text = dr[0] + " ";
                lnlmusterisoyad.Text = dr[1] + " ";

            }

            //Şuraya kadar olan kısımda groupboxın içerisindeki bilgileri doldurdum 

            SqlCommand k = new SqlCommand("select kargotakipno from [kargomanagement].[dbo].[musterii] Where musteriid=@p2 ", bgl.baglanti());
            k.Parameters.AddWithValue("@p2", lnlmusteriid.Text);

            SqlDataReader r = k.ExecuteReader();

            while (r.Read())
            {
                lbltakip.Text = r[0] + " ";

            }

            SqlCommand a = new SqlCommand("select kargodurumid from [kargomanagement].[dbo].[krgo] Where kargotakipno=@p3  ", bgl.baglanti());
            a.Parameters.AddWithValue("@p3", lbltakip.Text);

            string takipno = lbltakip.Text;


            SqlCommand deneme = new SqlCommand("select kargodurum FROM  [kargomanagement].[dbo].[krgo] Join [kargomanagement].[dbo].[kargodurum]  On [kargomanagement].[dbo].[kargodurum].kargodurumid =  [kargomanagement].[dbo].[kargodurum].kargodurumid Where kargotakipno = @p6 ", bgl.baglanti());
            deneme.Parameters.AddWithValue("@p6", lbltakip.Text);

            SqlDataReader r3 = deneme.ExecuteReader();
            while (r3.Read())
            {
                lblsond.Text = r3[0] + " ";
            }
            
           



            bgl.baglanti().Close();


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        bool durum;
        void tekrarlama()
        {
            SqlCommand tekrarkomut = new SqlCommand("select* from [kargomanagement].[dbo].[musterii] Where kargotakipno=@p1", bgl.baglanti());
            tekrarkomut.Parameters.AddWithValue("@p1", lbltakip.Text);

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


        private void btnsikayetal_Click(object sender, EventArgs e)
        {

            if (durum == true)
            {


                SqlCommand komut = new SqlCommand("insert into  [kargomanagement].[dbo].[skayett] (sikayet, musteriid, kargotakipno) Values (@p1,@p2,@p3)", bgl.baglanti());


                //SqlCommand kyeni = new SqlCommand("select [kargomanagement].[dbo].[skayett].sikayetid From [kargomanagement].[dbo].[skayett] Join [kargomanagement].[dbo].[musterii] On [kargomanagement].[dbo].[musterii].kargotakipno = [kargomanagement].[dbo].[skayett].kargotakipno Where musteriid=@p5  ", bgl.baglanti());
                //kyeni.Parameters.AddWithValue("@p5", lnlmusteriid.Text);

                komut.Parameters.AddWithValue("@p1", sikayet.Text);
                komut.Parameters.AddWithValue("@p2", musteriid);
                komut.Parameters.AddWithValue("@p3", lbltakip.Text);

                komut.ExecuteNonQuery();


                //Müşteri tablosuna eklenen şikayetin ID sini gönderme 


                SqlCommand komut2 = new SqlCommand("Update [kargomanagement].[dbo].[musterii] set sikayetid= [kargomanagement].[dbo].[skayett].sikayetid From [kargomanagement].[dbo].[musterii] Join  [kargomanagement].[dbo].[skayett] On  [kargomanagement].[dbo].[skayett].kargotakipno = [kargomanagement].[dbo].[musterii].kargotakipno Where [kargomanagement].[dbo].[musterii].kargotakipno=@p3 ", bgl.baglanti());

                komut2.Parameters.AddWithValue("@p3", lbltakip.Text);


                komut2.ExecuteNonQuery();



                MessageBox.Show("Şikayetiniz başarıyla kaydedilmiştir");


                bgl.baglanti().Close();

            }
            else
            {
                MessageBox.Show("Zaten şikayet girmiştiniz");
            }
        }

        private void lblsond_AutoSizeChanged(object sender, EventArgs e)
        {

        }
    }
}
