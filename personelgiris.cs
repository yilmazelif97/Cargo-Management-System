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
    public partial class personelgiris : Form
    {
        public personelgiris()
        {
            InitializeComponent();
        }

        sqlbaglanti bgl = new sqlbaglanti();
        private void btngiris_Click(object sender, EventArgs e)
        {

            SqlCommand komut = new SqlCommand("Select* from [kargomanagement].[dbo].[prsonel] Where personelTC = @p1 and personelsifre=@p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", msktc.Text);
            komut.Parameters.AddWithValue("@p2", sifre.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if(dr.Read())
            {
                personelanasayfa pa = new personelanasayfa();

                pa.tc = msktc.Text;
                pa.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı Kullanıcı");

            }
            bgl.baglanti().Close();


        }

        private void personelgiris_Load(object sender, EventArgs e)
        {

        }
    }
}
