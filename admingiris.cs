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
    public partial class admingiris : Form
    {
        public admingiris()
        {
            InitializeComponent();
        }

        sqlbaglanti bgl = new sqlbaglanti();

        private void btngiris_Click(object sender, EventArgs e)
        {

            SqlCommand komut = new SqlCommand("Select* from [kargomanagement].[dbo].[admin] Where adminno = @p1 and adminsifre=@p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", mskadminno.Text);
            komut.Parameters.AddWithValue("@p2", sifre.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                adminanasayfa yeni = new adminanasayfa();

                yeni.adminno = mskadminno.Text;
                yeni.Show();
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
