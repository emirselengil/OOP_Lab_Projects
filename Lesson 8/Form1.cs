using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace MemoryGame
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            
            InitializeComponent();
        }

        public class LabelData
        {
            public char Symbol { get; set; }
            public Point Position { get; set; }

            public LabelData(char symbol, Point position)
            {
                Symbol = symbol;
                Position = position;
            }
        }

        private void button_start_Click(object sender, EventArgs e)
        {
            Class1.labelDataList = GenerateLabelData();

            Class1.countX = Class1.labelDataList.Count(ld => ld.Symbol == 'X');
            Class1.countY = Class1.labelDataList.Count(ld => ld.Symbol == 'Y');
            Class1.countZ = Class1.labelDataList.Count(ld => ld.Symbol == 'Z');

            Form2 user1 = new Form2(1);
            Form2 user2 = new Form2(2);
            user1.Location = new Point(0, 0);
            user2.Location = new Point(user1.Width, 0);
            

            user1.Show();
            user2.Show();
            this.Hide();

            Timer timer = new Timer();
            timer.Interval = 10000; // 10 seconds
            timer.Tick += (s, args) =>
            {
                timer.Stop();
                user1.HideLabelsAndRepaint();
                user2.HideLabelsAndRepaint();
                PromptUserForGuesses(Class1.labelDataList);
            };
            timer.Start();
        }


        private List<LabelData> GenerateLabelData()
        {
            Random random = new Random();
            List<LabelData> labelDataList = new List<LabelData>();

            int numX = random.Next(1, 10); 
            int numY = random.Next(1, 10); 
            int numZ = random.Next(1, 10); 

            int rectX = 50; 
            int rectY = 50; 
            int rectWidth = 250; 
            int rectHeight = 150; 
            
            void CreateLabels(char symbol, int count)
            {
                for (int i = 0; i < count; i++)
                {
                    int x = random.Next(rectX, rectX + rectWidth);
                    int y = random.Next(rectY, rectY + rectHeight);
                    Point position = new Point(x, y);
                    labelDataList.Add(new LabelData(symbol, position));
                }
            }

            CreateLabels('X', numX);
            CreateLabels('Y', numY);
            CreateLabels('Z', numZ);

            return labelDataList;
        }

        private void PromptUserForGuesses(List<LabelData> labelDataList)
        {
            int countX = labelDataList.Count(ld => ld.Symbol == 'X');
            int countY = labelDataList.Count(ld => ld.Symbol == 'Y');
            int countZ = labelDataList.Count(ld => ld.Symbol == 'Z');

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if(Class1.roundCount == 0)
            {  
               label1.Text = Class1.roundWinU1.ToString();
               label2.Text = Class1.roundWinU2.ToString();
               Class1.roundCount++;
            }
            else
            {
                if (Class1.user1Score == Class1.user2Score)
                {
                    Class1.roundWinU1++;
                    Class1.roundWinU2++;
                    label1.Text = Class1.roundWinU1.ToString();
                    label2.Text = Class1.roundWinU2.ToString();
                }
                else if (Class1.user1Score > Class1.user2Score)
                {
                    Class1.roundWinU2++;
                    label1.Text = Class1.roundWinU1.ToString();
                    label2.Text = Class1.roundWinU2.ToString();
                }
                else
                {
                    Class1.roundWinU1++;
                    label1.Text = Class1.roundWinU1.ToString();
                    label2.Text = Class1.roundWinU2.ToString();
                }
                Class1.roundCount++;
            }
            if (Class1.roundCount == 3)
            {
                if (Class1.roundWinU1 == Class1.roundWinU2)
                {
                    MessageBox.Show("        Draw Game!" + Environment.NewLine + " User1 Score: "+ Class1.roundWinU1 + " User2 Score: " + Class1.roundWinU2, "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Application.Exit();
                }
                else if (Class1.roundWinU1 > Class1.roundWinU2)
                {
                    MessageBox.Show("        User 1 WİN!"+ Environment.NewLine + " User1 Score: " + Class1.roundWinU1 + " User2 Score: " + Class1.roundWinU2, "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Application.Exit();
                }
                else
                {
                    MessageBox.Show("        User 2 WİN!" + Environment.NewLine + " User1 Score: " + Class1.roundWinU1 + " User2 Score: " + Class1.roundWinU2, "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Application.Exit();
                }
            }
        }

        private void button_start_MouseEnter(object sender, EventArgs e)
        {
            button_start.Location = new Point(button_start.Location.X+2, button_start.Location.Y-2);
        }

        private void button_start_MouseLeave(object sender, EventArgs e)
        {
            button_start.Location = new Point(button_start.Location.X - 2, button_start.Location.Y + 2);
        }
    }
}
