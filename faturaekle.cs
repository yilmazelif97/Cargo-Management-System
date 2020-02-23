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
    public partial class faturaekle : Form
    {
        public faturaekle()
        {
            InitializeComponent();
        }

        sqlbaglanti bgl = new sqlbaglanti();
        private void faturaekle_Load(object sender, EventArgs e)
        {
            SqlCommand komut2 = new SqlCommand("select kargotakipno from [kargomanagement].[dbo].[krgo]", bgl.baglanti());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                comboBox1.Items.Add(dr2[0]);
            }
            bgl.baglanti().Close();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            SqlCommand k = new SqlCommand(" select  musteriad, musterisoyad, musteritel from [kargomanagement].[dbo].[musterii] Where kargotakipno = '" + comboBox1.SelectedItem.ToString() + "'", bgl.baglanti());

            SqlCommand k2 = new SqlCommand(" select aliciad, alicisoyad, ucret, faturaid from [kargomanagement].[dbo].[krgo] Where kargotakipno='" + comboBox1.SelectedItem.ToString() + "'", bgl.baglanti());



            k.ExecuteNonQuery();

            k2.ExecuteNonQuery();

            SqlDataReader dr1 = k.ExecuteReader();
            SqlDataReader dr2 = k2.ExecuteReader();
           

            while (dr1.Read())
            {

                textBoxgad.Text = dr1["musteriad"].ToString();
                textBoxgsoy.Text = dr1["musterisoyad"].ToString();
                textBoxgtel.Text = dr1["musteritel"].ToString();
                
            }

            while (dr2.Read())
            {

                textBox7aad.Text = dr2["aliciad"].ToString();
                textBox8asoy.Text = dr2["alicisoyad"].ToString();
                textBox9kargoucret.Text = dr2["ucret"].ToString();
                textBoxfaturaıd.Text = dr2["faturaid"].ToString();

            }


            bgl.baglanti().Close();



        }

        private void textBoxfaturaıd_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        bool durum;
        void tekrarlama()
        {
            SqlCommand tekrarkomut = new SqlCommand("select* from [kargomanagement].[dbo].[fattura] Where faturaid=@p1", bgl.baglanti());
            tekrarkomut.Parameters.AddWithValue("@p1", textBoxfaturaıd.Text);

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






        private void buttonkargoekle_Click(object sender, EventArgs e)
        {
            tekrarlama();

            if (durum == true)
            {


                SqlCommand k4 = new SqlCommand("insert into [kargomanagement].[dbo].[fattura] (faturaid, kargotakipno, gonderenad, gonderensoyad, gonderentelno,aliciad, alicisoyad,ucret ) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8) ", bgl.baglanti());


                k4.Parameters.AddWithValue("@p1", textBoxfaturaıd.Text);
                k4.Parameters.AddWithValue("@p2", comboBox1.SelectedItem.ToString());
                k4.Parameters.AddWithValue("@p3", textBoxgad.Text);
                k4.Parameters.AddWithValue("@p4", textBoxgsoy.Text);
                k4.Parameters.AddWithValue("@p5", textBoxgtel.Text);
                k4.Parameters.AddWithValue("@p6", textBox7aad.Text);
                k4.Parameters.AddWithValue("@p7", textBox8asoy.Text);
                k4.Parameters.AddWithValue("@p8", textBox9kargoucret.Text);
                // k5.Parameters.AddWithValue("@p1", textBoxfaturaıd.Text);


                k4.ExecuteNonQuery();



                bgl.baglanti().Close();

                MessageBox.Show("Fatura Eklendi");
            }
            else
            {
                MessageBox.Show("Bu kargoya ait fatura bulunmakta");
            }


        }

        }
    
}
