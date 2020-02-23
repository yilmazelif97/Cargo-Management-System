namespace kargomanagement
{
    partial class musterigiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(musterigiris));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btngiriis = new System.Windows.Forms.Button();
            this.sifre = new System.Windows.Forms.TextBox();
            this.mskid = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(357, 79);
            this.label1.TabIndex = 51;
            this.label1.Text = "YLW Kargo";
            this.label1.UseMnemonic = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(437, 39);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(317, 109);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 50;
            this.pictureBox1.TabStop = false;
            // 
            // btngiriis
            // 
            this.btngiriis.Location = new System.Drawing.Point(252, 330);
            this.btngiriis.Name = "btngiriis";
            this.btngiriis.Size = new System.Drawing.Size(108, 46);
            this.btngiriis.TabIndex = 56;
            this.btngiriis.Text = "Giriş Yap";
            this.btngiriis.UseVisualStyleBackColor = true;
            this.btngiriis.Click += new System.EventHandler(this.btngiriis_Click);
            // 
            // sifre
            // 
            this.sifre.Location = new System.Drawing.Point(214, 251);
            this.sifre.Name = "sifre";
            this.sifre.Size = new System.Drawing.Size(195, 22);
            this.sifre.TabIndex = 55;
            // 
            // mskid
            // 
            this.mskid.Location = new System.Drawing.Point(214, 182);
            this.mskid.Mask = "00000000000";
            this.mskid.Name = "mskid";
            this.mskid.Size = new System.Drawing.Size(195, 22);
            this.mskid.TabIndex = 54;
            this.mskid.ValidatingType = typeof(int);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(62, 249);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 25);
            this.label2.TabIndex = 53;
            this.label2.Text = "Soy Adınız";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(62, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 25);
            this.label3.TabIndex = 52;
            this.label3.Text = "Müşteri ID";
            // 
            // musterigiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 424);
            this.Controls.Add(this.btngiriis);
            this.Controls.Add(this.sifre);
            this.Controls.Add(this.mskid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "musterigiris";
            this.Text = "musterigiris";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btngiriis;
        private System.Windows.Forms.TextBox sifre;
        private System.Windows.Forms.MaskedTextBox mskid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}