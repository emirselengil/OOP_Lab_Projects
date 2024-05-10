using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hangman
{
    public partial class Form1 : Form
    {
        Form3 form3;
        Form2 form2;
        
        public Form1()
        {
            InitializeComponent();
            label1.BackColor = Color.Transparent;
            this.FormClosing += MainForm_FormClosing;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.BackColor = Color.LightGray;
            button1.Location = new Point(312, 320);
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.LightGray;
            button1.Location = new Point(309, 323);
        }
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {

            if (e.CloseReason == CloseReason.UserClosing)
            {

                DialogResult result = MessageBox.Show("Do you want to close?", "Close", MessageBoxButtons.YesNo, MessageBoxIcon.Question);


                if (result == DialogResult.Yes)
                {
                    Application.Exit();

                }
                else
                {
                    e.Cancel = true;
                }
            }
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            button2.BackColor = Color.LightGray;
            button2.Location = new Point(312, 261);
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackColor = Color.LightGray;
            button2.Location = new Point(309, 264);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            form3 = new Form3();
            this.Hide();
            form3.ShowDialog();
            
        }
    }
}
