namespace Hangman
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTime = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblIpucu = new System.Windows.Forms.Label();
            this.btnIpucu = new System.Windows.Forms.Button();
            this.btnBitir = new System.Windows.Forms.Button();
            this.btnTahmin = new System.Windows.Forms.Button();
            this.lblKelime = new System.Windows.Forms.Label();
            this.lblTahmin = new System.Windows.Forms.Label();
            this.lblUzunluk = new System.Windows.Forms.Label();
            this.lblPuan = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.images = new System.Windows.Forms.ImageList(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.lblTime);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.lblIpucu);
            this.panel1.Controls.Add(this.btnIpucu);
            this.panel1.Controls.Add(this.btnBitir);
            this.panel1.Controls.Add(this.btnTahmin);
            this.panel1.Controls.Add(this.lblKelime);
            this.panel1.Controls.Add(this.lblTahmin);
            this.panel1.Controls.Add(this.lblUzunluk);
            this.panel1.Controls.Add(this.lblPuan);
            this.panel1.Location = new System.Drawing.Point(35, 93);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(359, 314);
            this.panel1.TabIndex = 0;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTime.Location = new System.Drawing.Point(203, 224);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(0, 16);
            this.lblTime.TabIndex = 11;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox1.Location = new System.Drawing.Point(41, 259);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(42, 35);
            this.textBox1.TabIndex = 10;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblIpucu
            // 
            this.lblIpucu.AutoSize = true;
            this.lblIpucu.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblIpucu.Location = new System.Drawing.Point(24, 128);
            this.lblIpucu.Name = "lblIpucu";
            this.lblIpucu.Size = new System.Drawing.Size(42, 16);
            this.lblIpucu.TabIndex = 9;
            this.lblIpucu.Text = "Hint:";
            this.lblIpucu.Visible = false;
            // 
            // btnIpucu
            // 
            this.btnIpucu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(20)))));
            this.btnIpucu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIpucu.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIpucu.Location = new System.Drawing.Point(264, 86);
            this.btnIpucu.Name = "btnIpucu";
            this.btnIpucu.Size = new System.Drawing.Size(76, 34);
            this.btnIpucu.TabIndex = 8;
            this.btnIpucu.Text = "Hint";
            this.btnIpucu.UseVisualStyleBackColor = false;
            this.btnIpucu.Click += new System.EventHandler(this.btnIpucu_Click);
            this.btnIpucu.MouseEnter += new System.EventHandler(this.btnIpucu_MouseEnter);
            this.btnIpucu.MouseLeave += new System.EventHandler(this.btnIpucu_MouseLeave);
            // 
            // btnBitir
            // 
            this.btnBitir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(20)))));
            this.btnBitir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBitir.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBitir.Location = new System.Drawing.Point(217, 259);
            this.btnBitir.Name = "btnBitir";
            this.btnBitir.Size = new System.Drawing.Size(123, 36);
            this.btnBitir.TabIndex = 7;
            this.btnBitir.Text = "Finish the Game";
            this.btnBitir.UseVisualStyleBackColor = false;
            this.btnBitir.Click += new System.EventHandler(this.btnBitir_Click);
            this.btnBitir.MouseEnter += new System.EventHandler(this.btnBitir_MouseEnter);
            this.btnBitir.MouseLeave += new System.EventHandler(this.btnBitir_MouseLeave);
            // 
            // btnTahmin
            // 
            this.btnTahmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(20)))));
            this.btnTahmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTahmin.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTahmin.Location = new System.Drawing.Point(110, 259);
            this.btnTahmin.Name = "btnTahmin";
            this.btnTahmin.Size = new System.Drawing.Size(81, 36);
            this.btnTahmin.TabIndex = 6;
            this.btnTahmin.Text = "Guess";
            this.btnTahmin.UseVisualStyleBackColor = false;
            this.btnTahmin.Click += new System.EventHandler(this.btnTahmin_Click);
            this.btnTahmin.MouseEnter += new System.EventHandler(this.btnTahmin_MouseEnter);
            this.btnTahmin.MouseLeave += new System.EventHandler(this.btnTahmin_MouseLeave);
            // 
            // lblKelime
            // 
            this.lblKelime.BackColor = System.Drawing.Color.DimGray;
            this.lblKelime.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblKelime.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKelime.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblKelime.Location = new System.Drawing.Point(21, 20);
            this.lblKelime.Name = "lblKelime";
            this.lblKelime.Size = new System.Drawing.Size(319, 54);
            this.lblKelime.TabIndex = 3;
            this.lblKelime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTahmin
            // 
            this.lblTahmin.AutoSize = true;
            this.lblTahmin.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTahmin.Location = new System.Drawing.Point(24, 197);
            this.lblTahmin.Name = "lblTahmin";
            this.lblTahmin.Size = new System.Drawing.Size(115, 16);
            this.lblTahmin.TabIndex = 2;
            this.lblTahmin.Text = "Wrong Letters:";
            // 
            // lblUzunluk
            // 
            this.lblUzunluk.AutoSize = true;
            this.lblUzunluk.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUzunluk.Location = new System.Drawing.Point(24, 171);
            this.lblUzunluk.Name = "lblUzunluk";
            this.lblUzunluk.Size = new System.Drawing.Size(104, 16);
            this.lblUzunluk.TabIndex = 1;
            this.lblUzunluk.Text = "Word Length:";
            // 
            // lblPuan
            // 
            this.lblPuan.AutoSize = true;
            this.lblPuan.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPuan.Location = new System.Drawing.Point(38, 224);
            this.lblPuan.Name = "lblPuan";
            this.lblPuan.Size = new System.Drawing.Size(59, 18);
            this.lblPuan.TabIndex = 0;
            this.lblPuan.Text = "Puan:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Elephant", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(314, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 41);
            this.label1.TabIndex = 2;
            this.label1.Text = "HANGMAN";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightGray;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(442, 93);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(364, 314);
            this.panel2.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = global::Hangman.Resource1.adam;
            this.pictureBox1.Location = new System.Drawing.Point(23, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(316, 242);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // images
            // 
            this.images.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("images.ImageStream")));
            this.images.TransparentColor = System.Drawing.Color.Transparent;
            this.images.Images.SetKeyName(0, "01.jpg");
            this.images.Images.SetKeyName(1, "02.jpg");
            this.images.Images.SetKeyName(2, "03.jpg");
            this.images.Images.SetKeyName(3, "04.jpg");
            this.images.Images.SetKeyName(4, "05.jpg");
            this.images.Images.SetKeyName(5, "06.jpg");
            this.images.Images.SetKeyName(6, "07.jpg");
            this.images.Images.SetKeyName(7, "08.jpg");
            this.images.Images.SetKeyName(8, "09.jpg");
            this.images.Images.SetKeyName(9, "10.jpg");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(32, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 18);
            this.label2.TabIndex = 3;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(850, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTahmin;
        private System.Windows.Forms.Label lblUzunluk;
        private System.Windows.Forms.Label lblPuan;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblKelime;
        private System.Windows.Forms.Label lblIpucu;
        private System.Windows.Forms.Button btnIpucu;
        private System.Windows.Forms.Button btnBitir;
        private System.Windows.Forms.Button btnTahmin;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ImageList images;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblTime;
    }
}