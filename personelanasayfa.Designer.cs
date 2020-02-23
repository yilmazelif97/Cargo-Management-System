namespace kargomanagement
{
    partial class personelanasayfa
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblsoyad = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblad = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.faturaliste = new System.Windows.Forms.Button();
            this.kargoliste = new System.Windows.Forms.Button();
            this.buttonkargodurumliste = new System.Windows.Forms.Button();
            this.ftrekle = new System.Windows.Forms.Button();
            this.krgekle = new System.Windows.Forms.Button();
            this.comboBoxsondurum = new System.Windows.Forms.ComboBox();
            this.comboBoxkargotakipno = new System.Windows.Forms.ComboBox();
            this.buttonkargogüncelle = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.labeltc = new System.Windows.Forms.Label();
            this.lblTC = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxkargoid = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labeltc);
            this.groupBox1.Controls.Add(this.lblTC);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lblsoyad);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lblad);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(244, 201);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(50, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "Sisteme Hoşgeldiniz";
            // 
            // lblsoyad
            // 
            this.lblsoyad.AutoSize = true;
            this.lblsoyad.Location = new System.Drawing.Point(125, 117);
            this.lblsoyad.Name = "lblsoyad";
            this.lblsoyad.Size = new System.Drawing.Size(80, 17);
            this.lblsoyad.TabIndex = 26;
            this.lblsoyad.Text = "_________";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(8, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 17);
            this.label3.TabIndex = 25;
            this.label3.Text = "Personel Soyadı";
            // 
            // lblad
            // 
            this.lblad.AutoSize = true;
            this.lblad.Location = new System.Drawing.Point(125, 69);
            this.lblad.Name = "lblad";
            this.lblad.Size = new System.Drawing.Size(80, 17);
            this.lblad.TabIndex = 24;
            this.lblad.Text = "_________";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(8, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 17);
            this.label2.TabIndex = 23;
            this.label2.Text = "Personal Adı";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(281, 22);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(628, 201);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // faturaliste
            // 
            this.faturaliste.Location = new System.Drawing.Point(343, 383);
            this.faturaliste.Name = "faturaliste";
            this.faturaliste.Size = new System.Drawing.Size(75, 23);
            this.faturaliste.TabIndex = 10;
            this.faturaliste.Text = "Listele";
            this.faturaliste.UseVisualStyleBackColor = true;
            this.faturaliste.Click += new System.EventHandler(this.faturaliste_Click);
            // 
            // kargoliste
            // 
            this.kargoliste.Location = new System.Drawing.Point(65, 383);
            this.kargoliste.Name = "kargoliste";
            this.kargoliste.Size = new System.Drawing.Size(75, 23);
            this.kargoliste.TabIndex = 9;
            this.kargoliste.Text = "Listele";
            this.kargoliste.UseVisualStyleBackColor = true;
            this.kargoliste.Click += new System.EventHandler(this.kargoliste_Click);
            // 
            // buttonkargodurumliste
            // 
            this.buttonkargodurumliste.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonkargodurumliste.ImageKey = "liste.jpg";
            this.buttonkargodurumliste.Location = new System.Drawing.Point(588, 257);
            this.buttonkargodurumliste.Name = "buttonkargodurumliste";
            this.buttonkargodurumliste.Size = new System.Drawing.Size(131, 81);
            this.buttonkargodurumliste.TabIndex = 8;
            this.buttonkargodurumliste.Text = "Kargo Durumları";
            this.buttonkargodurumliste.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonkargodurumliste.UseVisualStyleBackColor = true;
            this.buttonkargodurumliste.Click += new System.EventHandler(this.buttonkargodurumliste_Click);
            // 
            // ftrekle
            // 
            this.ftrekle.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ftrekle.ImageKey = "ekle.png";
            this.ftrekle.Location = new System.Drawing.Point(313, 257);
            this.ftrekle.Name = "ftrekle";
            this.ftrekle.Size = new System.Drawing.Size(131, 81);
            this.ftrekle.TabIndex = 7;
            this.ftrekle.Text = "Fatura Ekleme";
            this.ftrekle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ftrekle.UseVisualStyleBackColor = true;
            this.ftrekle.Click += new System.EventHandler(this.ftrekle_Click);
            // 
            // krgekle
            // 
            this.krgekle.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.krgekle.ImageKey = "(none)";
            this.krgekle.Location = new System.Drawing.Point(37, 257);
            this.krgekle.Name = "krgekle";
            this.krgekle.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.krgekle.Size = new System.Drawing.Size(131, 81);
            this.krgekle.TabIndex = 6;
            this.krgekle.Text = "Kargo Ekleme ";
            this.krgekle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.krgekle.UseVisualStyleBackColor = true;
            this.krgekle.Click += new System.EventHandler(this.krgekle_Click);
            // 
            // comboBoxsondurum
            // 
            this.comboBoxsondurum.FormattingEnabled = true;
            this.comboBoxsondurum.Location = new System.Drawing.Point(755, 489);
            this.comboBoxsondurum.Name = "comboBoxsondurum";
            this.comboBoxsondurum.Size = new System.Drawing.Size(164, 24);
            this.comboBoxsondurum.TabIndex = 18;
            // 
            // comboBoxkargotakipno
            // 
            this.comboBoxkargotakipno.FormattingEnabled = true;
            this.comboBoxkargotakipno.Location = new System.Drawing.Point(755, 384);
            this.comboBoxkargotakipno.Name = "comboBoxkargotakipno";
            this.comboBoxkargotakipno.Size = new System.Drawing.Size(164, 24);
            this.comboBoxkargotakipno.TabIndex = 17;
            // 
            // buttonkargogüncelle
            // 
            this.buttonkargogüncelle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonkargogüncelle.ImageKey = "güncelle.png";
            this.buttonkargogüncelle.Location = new System.Drawing.Point(602, 391);
            this.buttonkargogüncelle.Name = "buttonkargogüncelle";
            this.buttonkargogüncelle.Size = new System.Drawing.Size(117, 60);
            this.buttonkargogüncelle.TabIndex = 16;
            this.buttonkargogüncelle.Text = "Güncelle";
            this.buttonkargogüncelle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonkargogüncelle.UseVisualStyleBackColor = true;
            this.buttonkargogüncelle.Click += new System.EventHandler(this.buttonkargogüncelle_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(752, 447);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 17);
            this.label6.TabIndex = 15;
            this.label6.Text = "Son durum";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(752, 340);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "Kargo Takip No";
            // 
            // labeltc
            // 
            this.labeltc.AutoSize = true;
            this.labeltc.Location = new System.Drawing.Point(125, 31);
            this.labeltc.Name = "labeltc";
            this.labeltc.Size = new System.Drawing.Size(80, 17);
            this.labeltc.TabIndex = 28;
            this.labeltc.Text = "_________";
            // 
            // lblTC
            // 
            this.lblTC.AutoSize = true;
            this.lblTC.ForeColor = System.Drawing.Color.Red;
            this.lblTC.Location = new System.Drawing.Point(8, 31);
            this.lblTC.Name = "lblTC";
            this.lblTC.Size = new System.Drawing.Size(82, 17);
            this.lblTC.TabIndex = 27;
            this.lblTC.Text = "PersonelTC";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(752, 261);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 17);
            this.label1.TabIndex = 19;
            this.label1.Text = "KargoID";
            // 
            // textBoxkargoid
            // 
            this.textBoxkargoid.Location = new System.Drawing.Point(755, 297);
            this.textBoxkargoid.Name = "textBoxkargoid";
            this.textBoxkargoid.Size = new System.Drawing.Size(154, 22);
            this.textBoxkargoid.TabIndex = 20;
            // 
            // personelanasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 530);
            this.Controls.Add(this.textBoxkargoid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxsondurum);
            this.Controls.Add(this.comboBoxkargotakipno);
            this.Controls.Add(this.buttonkargogüncelle);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.faturaliste);
            this.Controls.Add(this.kargoliste);
            this.Controls.Add(this.buttonkargodurumliste);
            this.Controls.Add(this.ftrekle);
            this.Controls.Add(this.krgekle);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Name = "personelanasayfa";
            this.Text = "personelanasayfa";
            this.Load += new System.EventHandler(this.personelanasayfa_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblsoyad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button faturaliste;
        private System.Windows.Forms.Button kargoliste;
        private System.Windows.Forms.Button buttonkargodurumliste;
        private System.Windows.Forms.Button ftrekle;
        private System.Windows.Forms.Button krgekle;
        private System.Windows.Forms.ComboBox comboBoxsondurum;
        private System.Windows.Forms.ComboBox comboBoxkargotakipno;
        private System.Windows.Forms.Button buttonkargogüncelle;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labeltc;
        private System.Windows.Forms.Label lblTC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxkargoid;
    }
}