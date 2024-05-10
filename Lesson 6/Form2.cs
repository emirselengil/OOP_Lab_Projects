using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace Hangman
{
    public partial class Form2 : Form
    {
        private int oyunSuresi = 30; // Oyun süresi (saniye cinsinden)
        private bool oyunDevamEdiyor = true;

        Dictionary<int, int> map = new Dictionary<int, int>() { { 90, 0 }, { 80, 1 }, { 70, 2 },
                                                                { 60, 3}, { 50, 4 }, { 40, 5 }, { 30, 6 } ,
                                                                {20,7 } ,{10 , 8 } , {0 , 9 } };

        Dictionary<string,string> Science = new Dictionary<string, string>()
        {
            { "atom","Basic unit of matter" }, { "energy","Power derived from sources" }, { "lab","Place for scientific work" },
            { "analysis","Study of data" }, { "ecosystem","Community of organisms" }, { "variable", "Changeable element" },
            { "biotechnology","Use of living systems" }, { "thermodynamic","Study of energy and heat" }, { "paleontology","Study of fossils" }
        };
        Dictionary<string, string> Health = new Dictionary<string, string>()
        {
            { "nurse","Healthcare professional" }, { "virus","Infectious agent" }, { "blood","Red liquid in body" }, 
            { "hospital","Medical facility" }, { "medicine","Treatment"}, { "symptom","Sign of illness" }, 
            { "immunization","Disease prevention" }, { "gastroenterology","Study of digestive system" }, { "anesthesia","Surgical anesthesia" }
        };
        Dictionary<string, string> Technology = new Dictionary<string, string>()
        {
            { "data","Healthcare professional" }, { "python","Infectious agent" }, { "Input","Red liquid in body" }, { "software","Resting state" },
            { "security","Medical facility" }, { "internet","Treatment"}, { "artificial intelligence","Sign of illness" },
            { "machine learning","Disease prevention" }, { "cybersecurity","Study of digestive system" }
        };

        string selectedWord;
        char[] hiddenWord;
        int puan = 100;        

        static string GetRandomItem(Dictionary<string, string> dictionary, int i, int j)
        {
            Random random = new Random();
            int randomIndex = random.Next(i, j);

            string randomKey = dictionary.Keys.ElementAt(randomIndex);

            return randomKey;
        }

        public string GetValue(Dictionary<string, string> dictionary, string key)
        {
            foreach (KeyValuePair<string, string> pair in dictionary)
            {
                if (pair.Key == key)
                {
                    return pair.Value;
                }
            }
            return null;
        }

        public Form2()
        {
            InitializeComponent();
            label2.Text = "Preferences: " + Degiskenler.category + "," + Degiskenler.time + "," + Degiskenler.difficulty + "," + Degiskenler.hints;
            this.FormClosing += MainForm_FormClosing;

            if (Degiskenler.hints == "No")
            {
                btnIpucu.Visible = false;
            }       

            if (Degiskenler.category == "Science")
            {
                if (Degiskenler.difficulty == "Normal")
                {
                    selectedWord = GetRandomItem(Science, 0, 2);
                }
                else if (Degiskenler.difficulty == "Medium")
                {
                    selectedWord = GetRandomItem(Science, 3, 5);
                }
                else if (Degiskenler.difficulty == "Hard")
                {
                    selectedWord = GetRandomItem(Science, 6, 8);
                }

            }
            else if (Degiskenler.category == "Health")
            {
                if (Degiskenler.difficulty == "Normal")
                {
                    selectedWord = GetRandomItem(Health, 0, 2);
                }
                else if (Degiskenler.difficulty == "Medium")
                {
                    selectedWord = GetRandomItem(Health, 3, 5);
                }
                else if (Degiskenler.difficulty == "Hard")
                {
                    selectedWord = GetRandomItem(Health, 6, 8);
                }
            }
            else if (Degiskenler.category == "Technology")
            {
                if (Degiskenler.difficulty == "Normal")
                {
                    selectedWord = GetRandomItem(Technology, 0, 2);
                }
                else if (Degiskenler.difficulty == "Medium")
                {
                    selectedWord = GetRandomItem(Technology, 3, 5);
                }
                else if (Degiskenler.difficulty == "Hard")
                {
                    selectedWord = GetRandomItem(Technology, 6, 8);
                }
            }
            
            if (selectedWord.Length > 11)
            {
                lblKelime.Font = new Font("Verdana", 16, FontStyle.Regular);                
            }
            hiddenWord = HideWord(selectedWord);
            //Word and hints
            foreach (char c in hiddenWord)
            {
                lblKelime.Text += c + " ";
            }
            //Puan and length
            lblUzunluk.Text += " " +selectedWord.Length.ToString();
            lblPuan.Text += " " + puan.ToString() + " P";
        }
        //Hint button
        bool ipucu = false;

        //Hint button click event
        private void btnIpucu_Click(object sender, EventArgs e)
        {
            //Hint button control
            if (!ipucu)
            {
                lblIpucu.Visible = true;
                string hint = "";

                // Seçilen kelimenin kategorisine göre ipucunu alın
                if (Degiskenler.category == "Science")
                {
                    hint = GetValue(Science, selectedWord);
                } 
                else if (Degiskenler.category == "Technology")
                {
                    hint = GetValue(Technology, selectedWord);
                }
                else if (Degiskenler.category == "Health")
                {
                    hint = GetValue(Health, selectedWord);
                }

                // İpucunu etikete ekleyin
                lblIpucu.Text += hint;
                ipucu = true;
            }
        }

        //Guess button click event
        int count = 0; bool firstGuess = true;
        Form1 form1 = new Form1();

        private void btnTahmin_Click(object sender, EventArgs e)
        {
            //Empty text control
            if (textBox1.Text == "" || textBox1.Text == " ")
            {
                //MessageBox for empty text
                MessageBox.Show("Type a letter.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Clear();
                return;
            }
            else
            {
                //Guess word control
                char[] guessedWordArray = hiddenWord;
                bool isInclude = false;
                //Guess word control
                for (int i = 0; i < selectedWord.Length; i++)
                {
                    //Guess word control
                    if (selectedWord[i].ToString() == textBox1.Text)
                    {
                        guessedWordArray[i] = selectedWord[i];
                        isInclude = true;
                    }
                }
                //Wrong guesses

                if (!isInclude)
                { 
                    //Wrong guesses
                    if (firstGuess)
                    {
                        lblTahmin.Text += textBox1.Text;
                        firstGuess = false;
                    }
                    else
                    {
                        lblTahmin.Text += "," + textBox1.Text;
                    }

                    lblPuan.Text = "Point: " + (puan - 10).ToString() + " P";
                    puan -= 10;
                    count++;

                }
                //Guess word control
                lblKelime.Text = "";
                for (int i = 0; i < guessedWordArray.Length; i++)
                {
                    lblKelime.Text += guessedWordArray[i] + " ";
                }
                hiddenWord = guessedWordArray;
                if (count == 10)
                {
                    pictureBox1.Image = images.Images[9];
                    this.BackColor = Color.Red;
                    MessageBox.Show("GAME OVER!.","Notify",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    DialogResult result = MessageBox.Show("Do you want to restart?", "Restart", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        this.Hide();
                        form1.ShowDialog();
                    }
                    else
                    {
                        Application.Exit();
                    }   
                }
                //Win control
                if (new string(hiddenWord) == selectedWord)
                {
                    this.BackColor = Color.Green;
                    MessageBox.Show("You Win.","Notify", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DialogResult result = MessageBox.Show("Do you want to restart??", "Restart", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        this.Hide();
                        form1.ShowDialog();
                    }
                    else
                    {
                        Application.Exit();
                    }
                }
                //Empty text
                textBox1.Text = "";
                //item control for image wit dictionary
                foreach (var item in map)
                {
                    if (puan == item.Key)
                    {
                        pictureBox1.Image = images.Images[item.Value];
                    }
                }
            }
            
        }

        //Hide word
        static char[] HideWord(string word)
        {
            char[] hiddenWord = new char[word.Length];
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == ' ')
                {
                    hiddenWord[i] = ' '; 
                }
                else
                {
                    hiddenWord[i] = '_'; 
                }
            }
            return hiddenWord;
        }

        //Close button
        private void btnBitir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Application ending.", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //Text control
            if (!IsAlphabetic(textBox1.Text))
            {
                MessageBox.Show("Type a Letter.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Clear();
            }
            if (textBox1.Text.Length > 1)
            {
                textBox1.Text = textBox1.Text.Substring(0, 1);
                textBox1.Select(1, 0);
            }
        }

        private bool IsAlphabetic(string input)
        {
            //Alphabetic control
            for (int i = 0; i < input.Length; i++)
            {
                char c = input[i];
                if (!char.IsLetter(c) && !char.IsWhiteSpace(c))
                {
                    return false;
                }
            }
            return true;
        }

        //Button animations
        private void btnTahmin_MouseEnter(object sender, EventArgs e)
        {
            btnTahmin.BackColor = Color.FromArgb(255, 69, 0);
            btnTahmin.Location = new Point(113, 256);
        }

        private void btnTahmin_MouseLeave(object sender, EventArgs e)
        {
            btnTahmin.BackColor = Color.FromArgb(255, 100, 20);
            btnTahmin.Location = new Point(110, 259);
        }

        private void btnBitir_MouseEnter(object sender, EventArgs e)
        {
            btnBitir.BackColor = Color.FromArgb(255, 69, 0);
            btnBitir.Location = new Point(220, 256);
        }

        private void btnBitir_MouseLeave(object sender, EventArgs e)
        {
            btnBitir.BackColor = Color.FromArgb(255, 100, 20);
            btnBitir.Location = new Point(217, 259);
        }

        private void btnIpucu_MouseEnter(object sender, EventArgs e)
        {
            btnIpucu.BackColor = Color.FromArgb(255, 69, 0);
            btnIpucu.Location = new Point(267, 83);
        }

        private void btnIpucu_MouseLeave(object sender, EventArgs e)
        {
            btnIpucu.BackColor = Color.FromArgb(255, 100, 20);
            btnIpucu.Location = new Point(264, 86);
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            oyunSuresi--;

            // Kalan süreyi göster
            lblTime.Text = "Remaining Time: " + oyunSuresi.ToString() + " sn";

            // Eğer süre dolduysa oyunu bitir
            if (oyunSuresi <= 0)
            {
                oyunDevamEdiyor = false;
                timer1.Stop(); // Timer'ı durdur
                this.BackColor = Color.Red;
                MessageBox.Show("GAME OVER! Time is up.", "GAME OVER", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close(); // Formu kapat
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            if(Degiskenler.time == "Challanged (30 seconds)")
            {
                oyunSuresi = 30;
                timer1.Start();
            }
        }
    }
}
