﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kargomanagement
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        private void main_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            musterigiris mg = new musterigiris();

            mg.Show();
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            personelgiris pg = new personelgiris();
            pg.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            admingiris ag = new admingiris();
            ag.Show();
            this.Hide();
        }
    }
}
