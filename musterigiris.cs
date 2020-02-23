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
    public partial class musterigiris : Form
    {
        public musterigiris()
        {
            InitializeComponent();
        }
        sqlbaglanti bgl = new sqlbaglanti();

        private void btngiriis_Click(object sender, EventArgs e)
        {

            SqlCommand komut = new SqlCommand("Select* from [kargomanagement].[dbo].[musterii] Where musteriid = @p1 and musterisoyad=@p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", mskid.Text);
            komut.Parameters.AddWithValue("@p2", sifre.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                musterianasayfa ma = new musterianasayfa();

                ma.musteriid = mskid.Text;
                ma.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı Kullanıcı");

            }
            bgl.baglanti().Close();




        }
    }
}
