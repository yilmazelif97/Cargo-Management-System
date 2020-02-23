namespace kargomanagement
{
    partial class personelekle
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(personelekle));
            this.btntemizle = new System.Windows.Forms.Button();
            this.sifre = new System.Windows.Forms.TextBox();
            this.personelsoyad = new System.Windows.Forms.TextBox();
            this.personelad = new System.Windows.Forms.TextBox();
            this.textBoxpno = new System.Windows.Forms.TextBox();
            this.btnperekle = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.msktc = new System.Windows.Forms.MaskedTextBox();
            this.msktelno = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbsube = new System.Windows.Forms.ComboBox();
            this.cmbpergorev = new System.Windows.Forms.ComboBox();
            this.cmbil = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btntemizle
            // 
            this.btntemizle.ImageKey = "sil.png";
            this.btntemizle.Location = new System.Drawing.Point(552, 75);
            this.btntemizle.Name = "btntemizle";
            this.btntemizle.Size = new System.Drawing.Size(147, 71);
            this.btntemizle.TabIndex = 41;
            this.btntemizle.Text = "Temizle";
            this.btntemizle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btntemizle.UseVisualStyleBackColor = true;
            this.btntemizle.Click += new System.EventHandler(this.btntemizle_Click);
            // 
            // sifre
            // 
            this.sifre.Location = new System.Drawing.Point(581, 313);
            this.sifre.Name = "sifre";
            this.sifre.Size = new System.Drawing.Size(100, 22);
            this.sifre.TabIndex = 36;
            // 
            // personelsoyad
            // 
            this.personelsoyad.Location = new System.Drawing.Point(253, 371);
            this.personelsoyad.Name = "personelsoyad";
            this.personelsoyad.Size = new System.Drawing.Size(100, 22);
            this.personelsoyad.TabIndex = 34;
            // 
            // personelad
            // 
            this.personelad.Location = new System.Drawing.Point(253, 313);
            this.personelad.Name = "personelad";
            this.personelad.Size = new System.Drawing.Size(100, 22);
            this.personelad.TabIndex = 33;
            // 
            // textBoxpno
            // 
            this.textBoxpno.Location = new System.Drawing.Point(621, -29);
            this.textBoxpno.Name = "textBoxpno";
            this.textBoxpno.Size = new System.Drawing.Size(100, 22);
            this.textBoxpno.TabIndex = 32;
            // 
            // btnperekle
            // 
            this.btnperekle.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnperekle.ImageKey = "(none)";
            this.btnperekle.Location = new System.Drawing.Point(337, 75);
            this.btnperekle.Name = "btnperekle";
            this.btnperekle.Size = new System.Drawing.Size(147, 71);
            this.btnperekle.TabIndex = 31;
            this.btnperekle.Text = "Yeni Personel Ekle";
            this.btnperekle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnperekle.UseVisualStyleBackColor = true;
            this.btnperekle.Click += new System.EventHandler(this.btnperekle_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(94, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(183, 192);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(410, 425);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 17);
            this.label7.TabIndex = 27;
            this.label7.Text = "Personel Görev";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(410, 371);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 17);
            this.label6.TabIndex = 26;
            this.label6.Text = "Telefon Numarası";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(410, 318);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 17);
            this.label5.TabIndex = 25;
            this.label5.Text = "Şifre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(82, 425);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 17);
            this.label4.TabIndex = 24;
            this.label4.Text = "TC Kimlik No";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(82, 371);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 17);
            this.label3.TabIndex = 23;
            this.label3.Text = "Personel Soyadı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(82, 318);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 17);
            this.label2.TabIndex = 22;
            this.label2.Text = "Personal Adı";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(450, -26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 17);
            this.label1.TabIndex = 21;
            this.label1.Text = "Personel No";
            // 
            // msktc
            // 
            this.msktc.Location = new System.Drawing.Point(253, 422);
            this.msktc.Mask = "00000000000";
            this.msktc.Name = "msktc";
            this.msktc.Size = new System.Drawing.Size(100, 22);
            this.msktc.TabIndex = 42;
            this.msktc.ValidatingType = typeof(int);
            // 
            // msktelno
            // 
            this.msktelno.Location = new System.Drawing.Point(581, 368);
            this.msktelno.Mask = "(999) 000-0000";
            this.msktelno.Name = "msktelno";
            this.msktelno.Size = new System.Drawing.Size(100, 22);
            this.msktelno.TabIndex = 43;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(410, 478);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 17);
            this.label8.TabIndex = 45;
            this.label8.Text = "Çalıştığı Şube";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(82, 478);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 17);
            this.label9.TabIndex = 48;
            this.label9.Text = "Çalıştığı İl";
            // 
            // cmbsube
            // 
            this.cmbsube.FormattingEnabled = true;
            this.cmbsube.Location = new System.Drawing.Point(581, 471);
            this.cmbsube.Name = "cmbsube";
            this.cmbsube.Size = new System.Drawing.Size(100, 24);
            this.cmbsube.TabIndex = 53;
            // 
            // cmbpergorev
            // 
            this.cmbpergorev.FormattingEnabled = true;
            this.cmbpergorev.Location = new System.Drawing.Point(581, 420);
            this.cmbpergorev.Name = "cmbpergorev";
            this.cmbpergorev.Size = new System.Drawing.Size(100, 24);
            this.cmbpergorev.TabIndex = 54;
            // 
            // cmbil
            // 
            this.cmbil.FormattingEnabled = true;
            this.cmbil.Location = new System.Drawing.Point(253, 475);
            this.cmbil.Name = "cmbil";
            this.cmbil.Size = new System.Drawing.Size(100, 24);
            this.cmbil.TabIndex = 55;
            this.cmbil.SelectedIndexChanged += new System.EventHandler(this.cmbil_SelectedIndexChanged);
            // 
            // personelekle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 538);
            this.Controls.Add(this.cmbil);
            this.Controls.Add(this.cmbpergorev);
            this.Controls.Add(this.cmbsube);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.msktelno);
            this.Controls.Add(this.msktc);
            this.Controls.Add(this.btntemizle);
            this.Controls.Add(this.sifre);
            this.Controls.Add(this.personelsoyad);
            this.Controls.Add(this.personelad);
            this.Controls.Add(this.textBoxpno);
            this.Controls.Add(this.btnperekle);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "personelekle";
            this.Text = "personelekle";
            this.Load += new System.EventHandler(this.personelekle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btntemizle;
        private System.Windows.Forms.TextBox sifre;
        private System.Windows.Forms.TextBox personelsoyad;
        private System.Windows.Forms.TextBox personelad;
        private System.Windows.Forms.TextBox textBoxpno;
        private System.Windows.Forms.Button btnperekle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox msktc;
        private System.Windows.Forms.MaskedTextBox msktelno;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbsube;
        private System.Windows.Forms.ComboBox cmbpergorev;
        private System.Windows.Forms.ComboBox cmbil;
    }
}