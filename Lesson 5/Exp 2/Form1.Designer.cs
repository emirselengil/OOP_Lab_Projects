namespace InClass_152120211124_152120211106_Group3
{
    partial class Form1
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
            this.isim = new System.Windows.Forms.TextBox();
            this.Tel = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.ayakkabı = new System.Windows.Forms.ComboBox();
            this.sehir = new System.Windows.Forms.ComboBox();
            this.siparis = new System.Windows.Forms.ComboBox();
            this.ilce = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.ayknum = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // isim
            // 
            this.isim.Location = new System.Drawing.Point(58, 115);
            this.isim.Multiline = true;
            this.isim.Name = "isim";
            this.isim.Size = new System.Drawing.Size(160, 21);
            this.isim.TabIndex = 0;
            this.isim.WordWrap = false;
            this.isim.TextChanged += new System.EventHandler(this.isim_TextChanged);
            // 
            // Tel
            // 
            this.Tel.Location = new System.Drawing.Point(58, 168);
            this.Tel.Multiline = true;
            this.Tel.Name = "Tel";
            this.Tel.Size = new System.Drawing.Size(160, 21);
            this.Tel.TabIndex = 1;
            this.Tel.TextChanged += new System.EventHandler(this.Tel_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(55, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Müşteri Ad-Soyad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(55, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Müşteri Telefon";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(310, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Adres İl";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(310, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Adres İlçe";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(306, 201);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Siparişlerim";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(174, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(347, 25);
            this.label6.TabIndex = 19;
            this.label6.Text = "AYAKKABI SİPARİŞ SİSTEMİ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(58, 343);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 36);
            this.button1.TabIndex = 20;
            this.button1.Text = "Sipariş Oluştur";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(55, 225);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(147, 16);
            this.label7.TabIndex = 21;
            this.label7.Text = "Ayakkabı Marka/Model";
            // 
            // ayakkabı
            // 
            this.ayakkabı.FormattingEnabled = true;
            this.ayakkabı.Location = new System.Drawing.Point(58, 244);
            this.ayakkabı.Name = "ayakkabı";
            this.ayakkabı.Size = new System.Drawing.Size(160, 21);
            this.ayakkabı.TabIndex = 23;
            // 
            // sehir
            // 
            this.sehir.FormattingEnabled = true;
            this.sehir.Items.AddRange(new object[] {
            ""});
            this.sehir.Location = new System.Drawing.Point(296, 115);
            this.sehir.Name = "sehir";
            this.sehir.Size = new System.Drawing.Size(133, 21);
            this.sehir.TabIndex = 24;
            this.sehir.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // siparis
            // 
            this.siparis.FormattingEnabled = true;
            this.siparis.Location = new System.Drawing.Point(296, 220);
            this.siparis.Name = "siparis";
            this.siparis.Size = new System.Drawing.Size(257, 21);
            this.siparis.TabIndex = 25;
            this.siparis.SelectedIndexChanged += new System.EventHandler(this.siparis_SelectedIndexChanged);
            // 
            // ilce
            // 
            this.ilce.FormattingEnabled = true;
            this.ilce.Location = new System.Drawing.Point(296, 168);
            this.ilce.Name = "ilce";
            this.ilce.Size = new System.Drawing.Size(133, 21);
            this.ilce.TabIndex = 26;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(13, 33);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 14);
            this.label8.TabIndex = 29;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Location = new System.Drawing.Point(296, 261);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(352, 165);
            this.panel1.TabIndex = 30;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(13, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(146, 14);
            this.label9.TabIndex = 30;
            this.label9.Text = "Seçilen Sipariş Detayı:";
            // 
            // ayknum
            // 
            this.ayknum.Location = new System.Drawing.Point(58, 295);
            this.ayknum.Name = "ayknum";
            this.ayknum.Size = new System.Drawing.Size(160, 20);
            this.ayknum.TabIndex = 31;
            this.ayknum.TextChanged += new System.EventHandler(this.ayknum_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(55, 276);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(125, 16);
            this.label10.TabIndex = 32;
            this.label10.Text = "Ayakkabı Numarası";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(683, 453);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.ayknum);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ilce);
            this.Controls.Add(this.siparis);
            this.Controls.Add(this.sehir);
            this.Controls.Add(this.ayakkabı);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Tel);
            this.Controls.Add(this.isim);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox isim;
        private System.Windows.Forms.TextBox Tel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox ayakkabı;
        private System.Windows.Forms.ComboBox sehir;
        private System.Windows.Forms.ComboBox siparis;
        private System.Windows.Forms.ComboBox ilce;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox ayknum;
        private System.Windows.Forms.Label label10;
    }
}

