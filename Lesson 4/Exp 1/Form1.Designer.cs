namespace _152120211106_Ex_4
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
            this.components = new System.ComponentModel.Container();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.buttonAddTimeZone = new System.Windows.Forms.Button();
            this.buttonDeleteTimeZones = new System.Windows.Forms.Button();
            this.txt = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(61, 183);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(120, 94);
            this.checkedListBox1.TabIndex = 0;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Current Time İstanbul (GTC +3)"});
            this.comboBox1.Location = new System.Drawing.Point(61, 144);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 2;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 45F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(3, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(275, 73);
            this.label1.TabIndex = 3;
            this.label1.Text = "00:00:00";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonAddTimeZone
            // 
            this.buttonAddTimeZone.Location = new System.Drawing.Point(262, 193);
            this.buttonAddTimeZone.Name = "buttonAddTimeZone";
            this.buttonAddTimeZone.Size = new System.Drawing.Size(109, 23);
            this.buttonAddTimeZone.TabIndex = 5;
            this.buttonAddTimeZone.Text = "Add TimeZone";
            this.buttonAddTimeZone.UseVisualStyleBackColor = true;
            this.buttonAddTimeZone.Click += new System.EventHandler(this.buttonAddTimeZone_Click);
            // 
            // buttonDeleteTimeZones
            // 
            this.buttonDeleteTimeZones.Location = new System.Drawing.Point(262, 222);
            this.buttonDeleteTimeZones.Name = "buttonDeleteTimeZones";
            this.buttonDeleteTimeZones.Size = new System.Drawing.Size(109, 23);
            this.buttonDeleteTimeZones.TabIndex = 7;
            this.buttonDeleteTimeZones.Text = "Delete TimeZone";
            this.buttonDeleteTimeZones.UseVisualStyleBackColor = true;
            this.buttonDeleteTimeZones.Click += new System.EventHandler(this.buttonDeleteTimeZones_Click);
            // 
            // txt
            // 
            this.txt.Location = new System.Drawing.Point(262, 145);
            this.txt.Name = "txt";
            this.txt.Size = new System.Drawing.Size(109, 20);
            this.txt.TabIndex = 8;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(415, 145);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 9;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged_1);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(62, 41);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Select color";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(185, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(282, 95);
            this.panel1.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(629, 289);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txt);
            this.Controls.Add(this.buttonDeleteTimeZones);
            this.Controls.Add(this.buttonAddTimeZone);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.checkedListBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonAddTimeZone;
        private System.Windows.Forms.Button buttonDeleteTimeZones;
        private System.Windows.Forms.TextBox txt;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
    }
}

