using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using static MemoryGame.Form1;

namespace MemoryGame
{
    public partial class Form2 : Form
    {
        int user = 0;
        int txt_box_1;
        int txt_box_2;
        int txt_box_3;
        
        private List<Label> labels = new List<Label>();
        private Rectangle rectArea;

        public Form2(int user)
        {
            InitializeComponent();
            rectArea = new Rectangle(50, 50, 300, 200);
            DisplayLabels(Class1.labelDataList);
            this.user = user;
            this.Text = "USER " + user;
            
        }

        private void DisplayLabels(List<Form1.LabelData> labelDataList)
        {
            foreach (var labelData in labelDataList)
            {
                Label label = new Label
                {
                    Text = labelData.Symbol.ToString(),
                    AutoSize = true,
                    Location = labelData.Position
                };
                this.Controls.Add(label);
                labels.Add(label);
            }
        }

        public void HideLabelsAndRepaint()
        {
            foreach (var label in labels)
            {
                label.Visible = false;
            }
            this.Invalidate(rectArea);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            using (SolidBrush brush = new SolidBrush(Color.White))
            {
                e.Graphics.FillRectangle(brush, rectArea);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            txt_box_1 = int.Parse(textBox1.Text);           
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            txt_box_2 = int.Parse(textBox2.Text);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            txt_box_3 = int.Parse(textBox3.Text);
        }

        private void btn_predict_Click(object sender, EventArgs e)
        {
            int calculate = Math.Abs(Class1.countX - txt_box_1) + Math.Abs(Class1.countY - txt_box_2) + Math.Abs((Class1.countZ - txt_box_1));
            
            MessageBox.Show(calculate.ToString(), "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (user == 1)
            {
                Class1.user1Score = calculate;
            }
            else
            {
                Class1.user2Score = calculate;
            }
            
            this.Hide();
            Form1 form1 = new Form1();

            if(user == 2)
            {
                form1.ShowDialog();
            }
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            if(user == 1) {
                this.Location = new Point(141, 270);
            }
            else if(user == 2)
            {
                this.Location = new Point(960, 270);
            }
            
        }

        private void btn_predict_MouseEnter(object sender, EventArgs e)
        {
            btn_predict.Location = new Point(btn_predict.Location.X + 2, btn_predict.Location.Y - 2);
        }

        private void btn_predict_MouseLeave(object sender, EventArgs e)
        {
            btn_predict.Location = new Point(btn_predict.Location.X - 2, btn_predict.Location.Y + 2);
        }
    }
}
