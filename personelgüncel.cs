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
    public partial class personelgüncel : Form
    {
        public personelgüncel()
        {
            InitializeComponent();
        }

        sqlbaglanti bgl = new sqlbaglanti();

        private void personelgüncel_Load(object sender, EventArgs e)
        {

            SqlCommand komut2 = new SqlCommand("select * from [kargomanagement].[dbo].[sube]", bgl.baglanti());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                comboBox2.Items.Add(dr2[1]);
            }

            SqlCommand komut3 = new SqlCommand("select * from [kargomanagement].[dbo].[personelgorev]", bgl.baglanti());
            SqlDataReader dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            {
                comboBox1.Items.Add(dr3[1]);
            }
            SqlCommand komut4 = new SqlCommand("select * from [kargomanagement].[dbo].[il]", bgl.baglanti());
            SqlDataReader dr4 = komut4.ExecuteReader();
            while (dr4.Read())
            {
                comboBox3.Items.Add(dr4[1]);
            }





            SqlDataAdapter dada = new SqlDataAdapter("select * from [kargomanagement].[dbo].[prsonel]", bgl.baglanti());

            DataTable tbl2 = new DataTable();

            dada.Fill(tbl2);

            liste3.DataSource = tbl2;


        }

        private void liste3_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            int secilen2 = liste3.SelectedCells[0].RowIndex;

            textBoxa1.Text = liste3.Rows[secilen2].Cells[0].Value.ToString();
            textBoxa2.Text = liste3.Rows[secilen2].Cells[1].Value.ToString();
            textBox3a3.Text = liste3.Rows[secilen2].Cells[2].Value.ToString();
            maskedTextBox1.Text = liste3.Rows[secilen2].Cells[3].Value.ToString();
            textBox5a5.Text = liste3.Rows[secilen2].Cells[4].Value.ToString();
            textBox6a6.Text = liste3.Rows[secilen2].Cells[5].Value.ToString();
            comboBox2.Text = liste3.Rows[secilen2].Cells[6].Value.ToString();
            comboBox3.Text = liste3.Rows[secilen2].Cells[7].Value.ToString();
            comboBox1.Text = liste3.Rows[secilen2].Cells[8].Value.ToString();




        }

        private void btngüncelle_Click(object sender, EventArgs e)
        {

            SqlCommand k = new SqlCommand("Update [kargomanagement].[dbo].[prsonel] set personelad=@p1, personelsoyad=@p2, personelTC=@p3, personelsifre=@p4, personeltel=@p5, personelgorevid=@p6, subeid=@p7, ilid=@p8 Where personelTC=@p3 ", bgl.baglanti());

           // k.Parameters.AddWithValue("@p1", textBoxa1.Text);
            k.Parameters.AddWithValue("@p1", textBoxa2.Text);
            k.Parameters.AddWithValue("@p2", textBox3a3.Text);
            k.Parameters.AddWithValue("@p3", maskedTextBox1.Text);
            k.Parameters.AddWithValue("@p4", textBox5a5.Text);
            k.Parameters.AddWithValue("@p5", textBox6a6.Text);
            k.Parameters.AddWithValue("@p6", comboBox2.SelectedIndex.ToString());
            k.Parameters.AddWithValue("@p7", comboBox3.SelectedIndex.ToString());
            k.Parameters.AddWithValue("@p8", comboBox1.SelectedIndex.ToString());

            k.ExecuteNonQuery();

            MessageBox.Show("Personel Bilgileri Güncellendi");

            bgl.baglanti().Close();



        }
    }
}
