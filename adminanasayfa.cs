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
    public partial class adminanasayfa : Form
    {
        public adminanasayfa()
        {
            InitializeComponent();
        }

        public string adminno;

        sqlbaglanti bgl = new sqlbaglanti();

        private void adminanasayfa_Load(object sender, EventArgs e)
        {

            lbladminno.Text = adminno;


        }

        private void buttonadminkargolis_Click(object sender, EventArgs e)
        {

            //Bu komutu çalıştıramadım

           //SqlDataAdapter d = new SqlDataAdapter("Select [kargomanagement].[dbo].[krgo].kargoid ,[kargomanagement].[dbo].[krgo].kargotakipno,[kargomanagement].[dbo].[krgo].aliciad, [kargomanagement].[dbo].[krgo].alicisoyad,[kargomanagement].[dbo].[krgo]. alicitelno, [kargomanagement].[dbo].[krgo].kargoteslimadres, [kargomanagement].[dbo].[krgo].verilistarihi, [kargomanagement].[dbo].[odemetipi].odemetipi, [kargomanagement].[dbo].[krgo].ucret, [kargomanagement].[dbo].[krgo].personelTC, [kargomanagement].[dbo].[kargodurum].kargodurum, [kargomanagement].[dbo].[krgo].faturaid, [kargomanagement].[dbo].[musterii].musteriad, [kargomanagement].[dbo].[il].ilad From [kargomanagement].[dbo].[krgo] Join [kargomanagement].[dbo].[odemetipi] On [kargomanagement].[dbo].[odemetipi].odemeid = [kargomanagement].[dbo].[krgo].odemetipiid  Join [kargomanagement].[dbo].[kargodurum] On [kargomanagement].[dbo].[kargodurum].kargodurumid = [kargomanagement].[dbo].[krgo].kargodurumid Join [kargomanagement].[dbo].[il] On [kargomanagement].[dbo].[il].ilid = [kargomanagement].[dbo].[krgo].ilid Join [kargomanagement].[dbo].[musterii] On [kargomanagement].[dbo].[musterii].musteriid = [kargomanagement].[dbo].[krgo].musteriid ", bgl.baglanti());

           SqlDataAdapter da = new SqlDataAdapter("select * from [kargomanagement].[dbo].[krgo]", bgl.baglanti());



            DataTable tb = new DataTable();

            da.Fill(tb);

            listeadmin.DataSource = tb;



        }

        private void buttonadminfatıralist_Click(object sender, EventArgs e)
        {

            SqlDataAdapter dad = new SqlDataAdapter("select * from [kargomanagement].[dbo].[fattura]", bgl.baglanti());

            DataTable tbl = new DataTable();

            dad.Fill(tbl);

            liste2.DataSource = tbl;


        }

        private void buttonadminpersonlist_Click(object sender, EventArgs e)
        {

            //BU  şekilde illerin şubelerin adını getirdim 

            SqlDataAdapter dene = new SqlDataAdapter("select personelid, personelad, personelsoyad, personelTC, personelsifre, personeltel, gorevad, subead, ilad From [kargomanagement].[dbo].[prsonel] Join [kargomanagement].[dbo].[personelgorev] On [kargomanagement].[dbo].[prsonel].personelgorevid = [kargomanagement].[dbo].[personelgorev].gorevid Join [kargomanagement].[dbo].[sube] On [kargomanagement].[dbo].[sube].subeid = [kargomanagement].[dbo].[prsonel].subeid Join [kargomanagement].[dbo].[il]  On  [kargomanagement].[dbo].[il].ilid = [kargomanagement].[dbo].[prsonel].ilid  ", bgl.baglanti());

           // SqlDataAdapter dada = new SqlDataAdapter("select * from [kargomanagement].[dbo].[prsonel]", bgl.baglanti());

            DataTable tbl2 = new DataTable();

            dene.Fill(tbl2);

            liste3.DataSource = tbl2;


        }

        private void button2_Click(object sender, EventArgs e)
        {

            SqlDataAdapter dada2 = new SqlDataAdapter("select * from [kargomanagement].[dbo].[skayett]", bgl.baglanti());

            DataTable tbl3 = new DataTable();

            dada2.Fill(tbl3);

            liste4.DataSource = tbl3;


        }

        private void buttonadminsil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Delete from [kargomanagement].[dbo].[prsonel] Where personelid=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", textBoxa1.Text);

            komut.ExecuteNonQuery();
            bgl.baglanti().Close();

            MessageBox.Show("Deleted Personel");

            

        }

        private void listeadmin_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            int secilen = listeadmin.SelectedCells[0].RowIndex;

            textBoxa1.Text = listeadmin.Rows[secilen].Cells[0].Value.ToString();
            textBoxa2.Text=listeadmin.Rows[secilen].Cells[1].Value.ToString();
            textBox3a3.Text = listeadmin.Rows[secilen].Cells[2].Value.ToString();
            textBox4a4.Text = listeadmin.Rows[secilen].Cells[3].Value.ToString();
            textBox5a5.Text = listeadmin.Rows[secilen].Cells[4].Value.ToString();
            textBox6a6.Text = listeadmin.Rows[secilen].Cells[5].Value.ToString();
            textBox7a7.Text = listeadmin.Rows[secilen].Cells[6].Value.ToString();
            textBox8a8.Text = listeadmin.Rows[secilen].Cells[7].Value.ToString();
            textBox9a9.Text = listeadmin.Rows[secilen].Cells[8].Value.ToString();
            textBox10a10.Text = listeadmin.Rows[secilen].Cells[9].Value.ToString();
            textBox11a11.Text = listeadmin.Rows[secilen].Cells[10].Value.ToString();
            textBox12a12.Text = listeadmin.Rows[secilen].Cells[11].Value.ToString();
            textBox13a13.Text = listeadmin.Rows[secilen].Cells[12].Value.ToString();
            textBox14a14.Text = listeadmin.Rows[secilen].Cells[13].Value.ToString();



        }

        private void liste2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            textBox10a10.Clear();
            textBox9a9.Clear();
            textBox11a11.Clear();
            textBox12a12.Clear();
            textBox13a13.Clear();
            textBox14a14.Clear();



            int sec = liste2.SelectedCells[0].RowIndex;

            textBoxa1.Text = liste2.Rows[sec].Cells[0].Value.ToString();
            textBoxa2.Text = liste2.Rows[sec].Cells[1].Value.ToString();
            textBox3a3.Text = liste2.Rows[sec].Cells[2].Value.ToString();
            textBox4a4.Text = liste2.Rows[sec].Cells[3].Value.ToString();
            textBox5a5.Text = liste2.Rows[sec].Cells[4].Value.ToString();
            textBox6a6.Text = liste2.Rows[sec].Cells[5].Value.ToString();
            textBox7a7.Text = liste2.Rows[sec].Cells[6].Value.ToString();
            textBox8a8.Text = liste2.Rows[sec].Cells[7].Value.ToString();
            //textBox9a9.Text = liste2.Rows[sec].Cells[8].Value.ToString();



        }

        private void liste3_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            textBox10a10.Clear();
            textBox11a11.Clear();
            textBox12a12.Clear();
            textBox13a13.Clear();
            textBox14a14.Clear();

            int secilen2 = liste3.SelectedCells[0].RowIndex;

            textBoxa1.Text = liste3.Rows[secilen2].Cells[0].Value.ToString();
            textBoxa2.Text = liste3.Rows[secilen2].Cells[1].Value.ToString();
            textBox3a3.Text = liste3.Rows[secilen2].Cells[2].Value.ToString();
            textBox4a4.Text = liste3.Rows[secilen2].Cells[3].Value.ToString();
            textBox5a5.Text = liste3.Rows[secilen2].Cells[4].Value.ToString();
            textBox6a6.Text = liste3.Rows[secilen2].Cells[5].Value.ToString();
            textBox7a7.Text = liste3.Rows[secilen2].Cells[6].Value.ToString();
            textBox8a8.Text = liste3.Rows[secilen2].Cells[7].Value.ToString();
            textBox9a9.Text = liste3.Rows[secilen2].Cells[8].Value.ToString();



        }

        private void liste4_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            textBox5a5.Clear();
            textBox6a6.Clear();
            textBox7a7.Clear();
            textBox8a8.Clear();
            textBox10a10.Clear();
            textBox9a9.Clear();
            textBox11a11.Clear();
            textBox12a12.Clear();
            textBox13a13.Clear();
            textBox14a14.Clear();

            int s = liste4.SelectedCells[0].RowIndex;

            textBoxa1.Text = liste4.Rows[s].Cells[0].Value.ToString();
            textBoxa2.Text = liste4.Rows[s].Cells[1].Value.ToString();
            textBox3a3.Text = liste4.Rows[s].Cells[2].Value.ToString();
            textBox4a4.Text = liste4.Rows[s].Cells[3].Value.ToString();

        }


        //Kargokarı sildirme 
        private void button3_Click(object sender, EventArgs e)
        {

            SqlCommand komut2 = new SqlCommand("Delete from [kargomanagement].[dbo].[krgo] Where kargoid=@p1", bgl.baglanti());
            komut2.Parameters.AddWithValue("@p1", textBoxa1.Text);

            SqlCommand komut4 = new SqlCommand("Delete from [kargomanagement].[dbo].[musterii] Where kargotakipno=@p7", bgl.baglanti());
            komut4.Parameters.AddWithValue("@p7", textBoxa2.Text);

            SqlCommand komut3 = new SqlCommand("Delete from [kargomanagement].[dbo].[fattura] Where kargotakipno=@p6", bgl.baglanti());
            komut3.Parameters.AddWithValue("@p6", textBoxa2.Text);


            komut2.ExecuteNonQuery();
            komut3.ExecuteNonQuery();
            komut4.ExecuteNonQuery();
            bgl.baglanti().Close();

            MessageBox.Show("Kargo Silindi.");



        }

        private void faturasil_Click(object sender, EventArgs e)
        {

        }

        private void personelekle_Click(object sender, EventArgs e)
        {

            personelekle pe = new personelekle();
            pe.Show();


        }

        private void buttonadmingüncelle_Click(object sender, EventArgs e)
        {

            //SqlCommand gkomut = new SqlCommand("update  [kargomanagement].[dbo].[prsonel] set personelad= @p1, personelsoyad=@p2, personelTC=@p3, personelsifre=@p4, personeltel=@p5, personelgorev=@p6, subeid=@p7, ilid=@p8    ",bgl.baglanti());


        }

        private void buttonadmingüncelle_Click_1(object sender, EventArgs e)
        {
            /*SqlCommand günkom = new SqlCommand("Update [kargomanagement].[dbo].[prsonel] set personelad=@p1, personelsoyad=@p2, personelTC=@p3, personelsifre=@p4, personeltel=@p5 Where personelTC=@p3", bgl.baglanti());

            günkom.Parameters.AddWithValue("@p1", textBoxa1.Text);
            günkom.Parameters.AddWithValue("@p2", textBoxa2.Text);
            günkom.Parameters.AddWithValue("@p3", textBox3a3.Text);
            günkom.Parameters.AddWithValue("@p4", textBox4a4.Text);
            günkom.Parameters.AddWithValue("@p5", textBox5a5.Text);*/



           // günkom.ExecuteNonQuery();
            bgl.baglanti().Close();
        }

        private void personelgncelle_Click(object sender, EventArgs e)
        {

            personelgüncel ac = new personelgüncel();

            ac.Show();

        }
    }
}
