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
    public partial class Form3 : Form
    {
        Form1 form1;
        public Form3()
        {
            InitializeComponent();
            string[] categories = { "Science", "Health", "Technology", "Music" };
            foreach (string category in categories)
            {
                comboBox1.Items.Add(category);
            }
        }

        private void lblNormal_MouseEnter(object sender, EventArgs e)
        {
            lblNormalInfo.Visible = true;
        }

        private void lblNormal_MouseLeave(object sender, EventArgs e)
        {
            lblNormalInfo.Visible = false;
        }

        private void lblMedium_MouseEnter(object sender, EventArgs e)
        {
            lblMediumInfo.Visible = true;
        }

        private void lblMedium_MouseLeave(object sender, EventArgs e)
        {
            lblMediumInfo.Visible = false;
        }

        private void lblHard_MouseEnter(object sender, EventArgs e)
        {
            lblHardInfo.Visible = true;
        }

        private void lblHard_MouseLeave(object sender, EventArgs e)
        {
            lblHardInfo.Visible = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.Hide();
            if(!(comboBox1.SelectedIndex == -1))
            {
                Degiskenler.category = comboBox1.SelectedItem.ToString();
            }
            

            foreach (RadioButton timeRadio in groupBox1.Controls.OfType<RadioButton>())
            {
                if (timeRadio.Checked)
                {
                    Degiskenler.time = timeRadio.Text;
                    break;
                }
            }
            foreach (RadioButton difficultyRadio in groupBox2.Controls.OfType<RadioButton>())
            {
                if (difficultyRadio.Checked)
                {
                    Degiskenler.difficulty = difficultyRadio.Text;
                    break;
                }
            }
            foreach (RadioButton hintRadio in groupBox3.Controls.OfType<RadioButton>())
            {
                if (hintRadio.Checked)
                {
                    Degiskenler.hints = hintRadio.Text;
                    break;
                }
            }

            form1 = new Form1();
            form1.ShowDialog();
            
        }

        private void btnSave_MouseEnter(object sender, EventArgs e)
        {
            btnSave.BackColor = Color.LightGray;
            btnSave.Location = new Point(513, 422);
        }

        private void btnSave_MouseLeave(object sender, EventArgs e)
        {
            btnSave.BackColor = Color.LightGray;
            btnSave.Location = new Point(510, 425);
        }
    }
    
}
