namespace Calculator
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ExpressionTextBox = new System.Windows.Forms.TextBox();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.fact = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.evaluateButton = new System.Windows.Forms.Button();
            this.nokta = new System.Windows.Forms.Button();
            this.sıfır = new System.Windows.Forms.Button();
            this.üsAlma = new System.Windows.Forms.Button();
            this.sub = new System.Windows.Forms.Button();
            this.multi = new System.Windows.Forms.Button();
            this.div = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.üç = new System.Windows.Forms.Button();
            this.iki = new System.Windows.Forms.Button();
            this.altı = new System.Windows.Forms.Button();
            this.beş = new System.Windows.Forms.Button();
            this.dokuz = new System.Windows.Forms.Button();
            this.sekiz = new System.Windows.Forms.Button();
            this.mod = new System.Windows.Forms.Button();
            this.parantezKapa = new System.Windows.Forms.Button();
            this.bir = new System.Windows.Forms.Button();
            this.sqrt = new System.Windows.Forms.Button();
            this.dört = new System.Windows.Forms.Button();
            this.log = new System.Windows.Forms.Button();
            this.yedi = new System.Windows.Forms.Button();
            this.ln = new System.Windows.Forms.Button();
            this.parantezAç = new System.Windows.Forms.Button();
            this.exp = new System.Windows.Forms.Button();
            this.onUseri = new System.Windows.Forms.Button();
            this.tan = new System.Windows.Forms.Button();
            this.e = new System.Windows.Forms.Button();
            this.cos = new System.Windows.Forms.Button();
            this.piNumber = new System.Windows.Forms.Button();
            this.sin = new System.Windows.Forms.Button();
            this.Inv = new System.Windows.Forms.Button();
            this.History = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.ExpressionTextBox);
            this.panel2.Location = new System.Drawing.Point(16, 70);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(633, 146);
            this.panel2.TabIndex = 35;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Calculator.Properties.Resources.Synchronize;
            this.pictureBox1.Location = new System.Drawing.Point(10, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(39, 36);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.MouseEnter += new System.EventHandler(this.pictureBox1_MouseEnter);
            this.pictureBox1.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(46, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(214, 157);
            this.label2.TabIndex = 35;
            this.label2.Visible = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(277, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(346, 31);
            this.label1.TabIndex = 34;
            // 
            // ExpressionTextBox
            // 
            this.ExpressionTextBox.BackColor = System.Drawing.Color.LightGray;
            this.ExpressionTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ExpressionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ExpressionTextBox.Location = new System.Drawing.Point(277, 98);
            this.ExpressionTextBox.Multiline = true;
            this.ExpressionTextBox.Name = "ExpressionTextBox";
            this.ExpressionTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ExpressionTextBox.Size = new System.Drawing.Size(346, 34);
            this.ExpressionTextBox.TabIndex = 1;
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "Ekran görüntüsü 2024-05-15 125053.png");
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // fact
            // 
            this.fact.Location = new System.Drawing.Point(201, 242);
            this.fact.Name = "fact";
            this.fact.Size = new System.Drawing.Size(75, 36);
            this.fact.TabIndex = 68;
            this.fact.Text = "x!";
            this.fact.UseVisualStyleBackColor = true;
            this.fact.Click += new System.EventHandler(this.factorial_Click);
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(563, 410);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(75, 36);
            this.add.TabIndex = 67;
            this.add.Text = "+";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // evaluateButton
            // 
            this.evaluateButton.Location = new System.Drawing.Point(472, 410);
            this.evaluateButton.Name = "evaluateButton";
            this.evaluateButton.Size = new System.Drawing.Size(75, 36);
            this.evaluateButton.TabIndex = 66;
            this.evaluateButton.Text = "=";
            this.evaluateButton.UseVisualStyleBackColor = true;
            this.evaluateButton.Click += new System.EventHandler(this.evaluateButton_Click);
            // 
            // nokta
            // 
            this.nokta.Location = new System.Drawing.Point(381, 410);
            this.nokta.Name = "nokta";
            this.nokta.Size = new System.Drawing.Size(75, 36);
            this.nokta.TabIndex = 65;
            this.nokta.Text = ".";
            this.nokta.UseVisualStyleBackColor = true;
            this.nokta.Click += new System.EventHandler(this.nokta_Click);
            // 
            // sıfır
            // 
            this.sıfır.Location = new System.Drawing.Point(292, 410);
            this.sıfır.Name = "sıfır";
            this.sıfır.Size = new System.Drawing.Size(75, 36);
            this.sıfır.TabIndex = 64;
            this.sıfır.Text = "0";
            this.sıfır.UseVisualStyleBackColor = true;
            this.sıfır.Click += new System.EventHandler(this.sıfır_Click);
            // 
            // üsAlma
            // 
            this.üsAlma.Location = new System.Drawing.Point(201, 410);
            this.üsAlma.Name = "üsAlma";
            this.üsAlma.Size = new System.Drawing.Size(75, 36);
            this.üsAlma.TabIndex = 63;
            this.üsAlma.Text = "x^y";
            this.üsAlma.UseVisualStyleBackColor = true;
            this.üsAlma.Click += new System.EventHandler(this.üsAlma_Click);
            // 
            // sub
            // 
            this.sub.Location = new System.Drawing.Point(563, 368);
            this.sub.Name = "sub";
            this.sub.Size = new System.Drawing.Size(75, 36);
            this.sub.TabIndex = 62;
            this.sub.Text = "-";
            this.sub.UseVisualStyleBackColor = true;
            this.sub.Click += new System.EventHandler(this.sub_Click);
            // 
            // multi
            // 
            this.multi.Location = new System.Drawing.Point(563, 326);
            this.multi.Name = "multi";
            this.multi.Size = new System.Drawing.Size(75, 36);
            this.multi.TabIndex = 61;
            this.multi.Text = "x";
            this.multi.UseVisualStyleBackColor = true;
            this.multi.Click += new System.EventHandler(this.multi_Click);
            // 
            // div
            // 
            this.div.Location = new System.Drawing.Point(563, 284);
            this.div.Name = "div";
            this.div.Size = new System.Drawing.Size(75, 36);
            this.div.TabIndex = 60;
            this.div.Text = "/";
            this.div.UseVisualStyleBackColor = true;
            this.div.Click += new System.EventHandler(this.div_Click);
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(563, 242);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(75, 36);
            this.clear.TabIndex = 59;
            this.clear.Text = "CE";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // üç
            // 
            this.üç.Location = new System.Drawing.Point(472, 368);
            this.üç.Name = "üç";
            this.üç.Size = new System.Drawing.Size(75, 36);
            this.üç.TabIndex = 58;
            this.üç.Text = "3";
            this.üç.UseVisualStyleBackColor = true;
            this.üç.Click += new System.EventHandler(this.üç_Click);
            // 
            // iki
            // 
            this.iki.Location = new System.Drawing.Point(381, 368);
            this.iki.Name = "iki";
            this.iki.Size = new System.Drawing.Size(75, 36);
            this.iki.TabIndex = 57;
            this.iki.Text = "2";
            this.iki.UseVisualStyleBackColor = true;
            this.iki.Click += new System.EventHandler(this.iki_Click);
            // 
            // altı
            // 
            this.altı.Location = new System.Drawing.Point(472, 326);
            this.altı.Name = "altı";
            this.altı.Size = new System.Drawing.Size(75, 36);
            this.altı.TabIndex = 56;
            this.altı.Text = "6";
            this.altı.UseVisualStyleBackColor = true;
            this.altı.Click += new System.EventHandler(this.altı_Click);
            // 
            // beş
            // 
            this.beş.Location = new System.Drawing.Point(381, 326);
            this.beş.Name = "beş";
            this.beş.Size = new System.Drawing.Size(75, 36);
            this.beş.TabIndex = 55;
            this.beş.Text = "5";
            this.beş.UseVisualStyleBackColor = true;
            this.beş.Click += new System.EventHandler(this.beş_Click);
            // 
            // dokuz
            // 
            this.dokuz.Location = new System.Drawing.Point(472, 284);
            this.dokuz.Name = "dokuz";
            this.dokuz.Size = new System.Drawing.Size(75, 36);
            this.dokuz.TabIndex = 54;
            this.dokuz.Text = "9";
            this.dokuz.UseVisualStyleBackColor = true;
            this.dokuz.Click += new System.EventHandler(this.dokuz_Click);
            // 
            // sekiz
            // 
            this.sekiz.Location = new System.Drawing.Point(381, 284);
            this.sekiz.Name = "sekiz";
            this.sekiz.Size = new System.Drawing.Size(75, 36);
            this.sekiz.TabIndex = 53;
            this.sekiz.Text = "8";
            this.sekiz.UseVisualStyleBackColor = true;
            this.sekiz.Click += new System.EventHandler(this.sekiz_Click);
            // 
            // mod
            // 
            this.mod.Location = new System.Drawing.Point(472, 242);
            this.mod.Name = "mod";
            this.mod.Size = new System.Drawing.Size(75, 36);
            this.mod.TabIndex = 52;
            this.mod.Text = "%";
            this.mod.UseVisualStyleBackColor = true;
            this.mod.Click += new System.EventHandler(this.mod_Click);
            // 
            // parantezKapa
            // 
            this.parantezKapa.Location = new System.Drawing.Point(381, 242);
            this.parantezKapa.Name = "parantezKapa";
            this.parantezKapa.Size = new System.Drawing.Size(75, 36);
            this.parantezKapa.TabIndex = 51;
            this.parantezKapa.Text = ")";
            this.parantezKapa.UseVisualStyleBackColor = true;
            this.parantezKapa.Click += new System.EventHandler(this.parantezKapa_Click);
            // 
            // bir
            // 
            this.bir.Location = new System.Drawing.Point(292, 368);
            this.bir.Name = "bir";
            this.bir.Size = new System.Drawing.Size(75, 36);
            this.bir.TabIndex = 50;
            this.bir.Text = "1";
            this.bir.UseVisualStyleBackColor = true;
            this.bir.Click += new System.EventHandler(this.bir_Click);
            // 
            // sqrt
            // 
            this.sqrt.Location = new System.Drawing.Point(201, 368);
            this.sqrt.Name = "sqrt";
            this.sqrt.Size = new System.Drawing.Size(75, 36);
            this.sqrt.TabIndex = 49;
            this.sqrt.Text = "√";
            this.sqrt.UseVisualStyleBackColor = true;
            this.sqrt.Click += new System.EventHandler(this.sqrt_Click);
            // 
            // dört
            // 
            this.dört.Location = new System.Drawing.Point(292, 326);
            this.dört.Name = "dört";
            this.dört.Size = new System.Drawing.Size(75, 36);
            this.dört.TabIndex = 48;
            this.dört.Text = "4";
            this.dört.UseVisualStyleBackColor = true;
            this.dört.Click += new System.EventHandler(this.dört_Click);
            // 
            // log
            // 
            this.log.Location = new System.Drawing.Point(201, 326);
            this.log.Name = "log";
            this.log.Size = new System.Drawing.Size(75, 36);
            this.log.TabIndex = 47;
            this.log.Text = "log";
            this.log.UseVisualStyleBackColor = true;
            this.log.Click += new System.EventHandler(this.log_Click);
            // 
            // yedi
            // 
            this.yedi.Location = new System.Drawing.Point(292, 284);
            this.yedi.Name = "yedi";
            this.yedi.Size = new System.Drawing.Size(75, 36);
            this.yedi.TabIndex = 46;
            this.yedi.Text = "7";
            this.yedi.UseVisualStyleBackColor = true;
            this.yedi.Click += new System.EventHandler(this.yedi_Click);
            // 
            // ln
            // 
            this.ln.Location = new System.Drawing.Point(201, 284);
            this.ln.Name = "ln";
            this.ln.Size = new System.Drawing.Size(75, 36);
            this.ln.TabIndex = 45;
            this.ln.Text = "ln";
            this.ln.UseVisualStyleBackColor = true;
            this.ln.Click += new System.EventHandler(this.ln_Click);
            // 
            // parantezAç
            // 
            this.parantezAç.Location = new System.Drawing.Point(292, 242);
            this.parantezAç.Name = "parantezAç";
            this.parantezAç.Size = new System.Drawing.Size(75, 36);
            this.parantezAç.TabIndex = 44;
            this.parantezAç.Text = "(";
            this.parantezAç.UseVisualStyleBackColor = true;
            this.parantezAç.Click += new System.EventHandler(this.parantezAç_Click);
            // 
            // exp
            // 
            this.exp.Location = new System.Drawing.Point(117, 410);
            this.exp.Name = "exp";
            this.exp.Size = new System.Drawing.Size(75, 36);
            this.exp.TabIndex = 43;
            this.exp.Text = "EXP";
            this.exp.UseVisualStyleBackColor = true;
            this.exp.Click += new System.EventHandler(this.exp_Click);
            // 
            // onUseri
            // 
            this.onUseri.Location = new System.Drawing.Point(26, 410);
            this.onUseri.Name = "onUseri";
            this.onUseri.Size = new System.Drawing.Size(75, 36);
            this.onUseri.TabIndex = 42;
            this.onUseri.Text = "10^x";
            this.onUseri.UseVisualStyleBackColor = true;
            this.onUseri.Click += new System.EventHandler(this.onUseri_Click);
            // 
            // tan
            // 
            this.tan.Location = new System.Drawing.Point(117, 368);
            this.tan.Name = "tan";
            this.tan.Size = new System.Drawing.Size(75, 36);
            this.tan.TabIndex = 41;
            this.tan.Text = "tan";
            this.tan.UseVisualStyleBackColor = true;
            this.tan.Click += new System.EventHandler(this.tan_Click);
            // 
            // e
            // 
            this.e.Location = new System.Drawing.Point(26, 368);
            this.e.Name = "e";
            this.e.Size = new System.Drawing.Size(75, 36);
            this.e.TabIndex = 40;
            this.e.Text = "e";
            this.e.UseVisualStyleBackColor = true;
            this.e.Click += new System.EventHandler(this.e_Click);
            // 
            // cos
            // 
            this.cos.Location = new System.Drawing.Point(117, 326);
            this.cos.Name = "cos";
            this.cos.Size = new System.Drawing.Size(75, 36);
            this.cos.TabIndex = 39;
            this.cos.Text = "cos";
            this.cos.UseVisualStyleBackColor = true;
            this.cos.Click += new System.EventHandler(this.cos_Click);
            // 
            // piNumber
            // 
            this.piNumber.Location = new System.Drawing.Point(26, 326);
            this.piNumber.Name = "piNumber";
            this.piNumber.Size = new System.Drawing.Size(75, 36);
            this.piNumber.TabIndex = 38;
            this.piNumber.Text = "π";
            this.piNumber.UseVisualStyleBackColor = true;
            this.piNumber.Click += new System.EventHandler(this.piNumber_Click);
            // 
            // sin
            // 
            this.sin.Location = new System.Drawing.Point(117, 284);
            this.sin.Name = "sin";
            this.sin.Size = new System.Drawing.Size(75, 36);
            this.sin.TabIndex = 37;
            this.sin.Text = "sin";
            this.sin.UseVisualStyleBackColor = true;
            this.sin.Click += new System.EventHandler(this.sin_Click);
            // 
            // Inv
            // 
            this.Inv.Location = new System.Drawing.Point(26, 284);
            this.Inv.Name = "Inv";
            this.Inv.Size = new System.Drawing.Size(75, 36);
            this.Inv.TabIndex = 36;
            this.Inv.Text = "Inv";
            this.Inv.UseVisualStyleBackColor = true;
            // 
            // History
            // 
            this.History.Location = new System.Drawing.Point(26, 242);
            this.History.Name = "History";
            this.History.Size = new System.Drawing.Size(166, 36);
            this.History.TabIndex = 35;
            this.History.Text = "History";
            this.History.UseVisualStyleBackColor = true;
            this.History.Click += new System.EventHandler(this.History_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(242, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(214, 32);
            this.label3.TabIndex = 69;
            this.label3.Text = "CALCULATOR";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(668, 457);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.add);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.evaluateButton);
            this.Controls.Add(this.nokta);
            this.Controls.Add(this.sıfır);
            this.Controls.Add(this.sub);
            this.Controls.Add(this.multi);
            this.Controls.Add(this.div);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.üç);
            this.Controls.Add(this.iki);
            this.Controls.Add(this.altı);
            this.Controls.Add(this.parantezAç);
            this.Controls.Add(this.beş);
            this.Controls.Add(this.dokuz);
            this.Controls.Add(this.yedi);
            this.Controls.Add(this.sekiz);
            this.Controls.Add(this.dört);
            this.Controls.Add(this.mod);
            this.Controls.Add(this.parantezKapa);
            this.Controls.Add(this.bir);
            this.Controls.Add(this.fact);
            this.Controls.Add(this.log);
            this.Controls.Add(this.History);
            this.Controls.Add(this.Inv);
            this.Controls.Add(this.üsAlma);
            this.Controls.Add(this.sin);
            this.Controls.Add(this.piNumber);
            this.Controls.Add(this.cos);
            this.Controls.Add(this.e);
            this.Controls.Add(this.tan);
            this.Controls.Add(this.onUseri);
            this.Controls.Add(this.exp);
            this.Controls.Add(this.ln);
            this.Controls.Add(this.sqrt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.TextBox ExpressionTextBox;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button fact;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button evaluateButton;
        private System.Windows.Forms.Button nokta;
        private System.Windows.Forms.Button sıfır;
        private System.Windows.Forms.Button üsAlma;
        private System.Windows.Forms.Button sub;
        private System.Windows.Forms.Button multi;
        private System.Windows.Forms.Button div;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button üç;
        private System.Windows.Forms.Button iki;
        private System.Windows.Forms.Button altı;
        private System.Windows.Forms.Button beş;
        private System.Windows.Forms.Button dokuz;
        private System.Windows.Forms.Button sekiz;
        private System.Windows.Forms.Button mod;
        private System.Windows.Forms.Button parantezKapa;
        private System.Windows.Forms.Button bir;
        private System.Windows.Forms.Button sqrt;
        private System.Windows.Forms.Button dört;
        private System.Windows.Forms.Button log;
        private System.Windows.Forms.Button yedi;
        private System.Windows.Forms.Button ln;
        private System.Windows.Forms.Button parantezAç;
        private System.Windows.Forms.Button exp;
        private System.Windows.Forms.Button onUseri;
        private System.Windows.Forms.Button tan;
        private System.Windows.Forms.Button e;
        private System.Windows.Forms.Button cos;
        private System.Windows.Forms.Button piNumber;
        private System.Windows.Forms.Button sin;
        private System.Windows.Forms.Button Inv;
        private System.Windows.Forms.Button History;
        private System.Windows.Forms.Label label3;
    }
}

