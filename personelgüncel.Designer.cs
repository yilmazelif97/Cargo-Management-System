namespace kargomanagement
{
    partial class personelgüncel
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
            this.liste3 = new System.Windows.Forms.DataGridView();
            this.textBox6a6 = new System.Windows.Forms.TextBox();
            this.textBox5a5 = new System.Windows.Forms.TextBox();
            this.textBoxa2 = new System.Windows.Forms.TextBox();
            this.textBoxa1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.btngüncelle = new System.Windows.Forms.Button();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.textBox3a3 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.liste3)).BeginInit();
            this.SuspendLayout();
            // 
            // liste3
            // 
            this.liste3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.liste3.Location = new System.Drawing.Point(28, 41);
            this.liste3.Name = "liste3";
            this.liste3.RowTemplate.Height = 24;
            this.liste3.Size = new System.Drawing.Size(745, 113);
            this.liste3.TabIndex = 56;
            this.liste3.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.liste3_CellDoubleClick);
            // 
            // textBox6a6
            // 
            this.textBox6a6.Location = new System.Drawing.Point(358, 262);
            this.textBox6a6.Name = "textBox6a6";
            this.textBox6a6.Size = new System.Drawing.Size(100, 22);
            this.textBox6a6.TabIndex = 62;
            // 
            // textBox5a5
            // 
            this.textBox5a5.Location = new System.Drawing.Point(358, 203);
            this.textBox5a5.Name = "textBox5a5";
            this.textBox5a5.Size = new System.Drawing.Size(100, 22);
            this.textBox5a5.TabIndex = 61;
            // 
            // textBoxa2
            // 
            this.textBoxa2.Location = new System.Drawing.Point(115, 262);
            this.textBoxa2.Name = "textBoxa2";
            this.textBoxa2.Size = new System.Drawing.Size(100, 22);
            this.textBoxa2.TabIndex = 58;
            // 
            // textBoxa1
            // 
            this.textBoxa1.Location = new System.Drawing.Point(115, 203);
            this.textBoxa1.Name = "textBoxa1";
            this.textBoxa1.Size = new System.Drawing.Size(100, 22);
            this.textBoxa1.TabIndex = 57;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(593, 201);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 65;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(358, 316);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(100, 24);
            this.comboBox2.TabIndex = 66;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(358, 375);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(100, 24);
            this.comboBox3.TabIndex = 67;
            // 
            // btngüncelle
            // 
            this.btngüncelle.Location = new System.Drawing.Point(593, 315);
            this.btngüncelle.Name = "btngüncelle";
            this.btngüncelle.Size = new System.Drawing.Size(121, 43);
            this.btngüncelle.TabIndex = 68;
            this.btngüncelle.Text = "Güncelle";
            this.btngüncelle.UseVisualStyleBackColor = true;
            this.btngüncelle.Click += new System.EventHandler(this.btngüncelle_Click);
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(115, 377);
            this.maskedTextBox1.Mask = "00000000000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(100, 22);
            this.maskedTextBox1.TabIndex = 69;
            this.maskedTextBox1.ValidatingType = typeof(int);
            // 
            // textBox3a3
            // 
            this.textBox3a3.Location = new System.Drawing.Point(115, 316);
            this.textBox3a3.Name = "textBox3a3";
            this.textBox3a3.Size = new System.Drawing.Size(100, 22);
            this.textBox3a3.TabIndex = 59;
            // 
            // personelgüncel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 492);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.btngüncelle);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox6a6);
            this.Controls.Add(this.textBox5a5);
            this.Controls.Add(this.textBox3a3);
            this.Controls.Add(this.textBoxa2);
            this.Controls.Add(this.textBoxa1);
            this.Controls.Add(this.liste3);
            this.Name = "personelgüncel";
            this.Text = "personelgüncel";
            this.Load += new System.EventHandler(this.personelgüncel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.liste3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView liste3;
        private System.Windows.Forms.TextBox textBox6a6;
        private System.Windows.Forms.TextBox textBox5a5;
        private System.Windows.Forms.TextBox textBoxa2;
        private System.Windows.Forms.TextBox textBoxa1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Button btngüncelle;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.TextBox textBox3a3;
    }
}