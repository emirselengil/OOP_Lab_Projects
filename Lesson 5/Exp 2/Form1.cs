using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Channels;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Resources.ResXFileRef;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;
namespace InClass_152120211124_152120211106_Group3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            string[] ayakkabılar = { "Adidas Stan Smith", "Converse Chuck Taylor All - Stars", "Dr.Martens 1460", "New Balance 574", "Nike Air Force 1", "Puma Suede Classic", "Sperry Authentic Boat Shoe", "Timberland 6 - Inch Premium Boot", "Vans Old Skool", "Veja V - 10" };
            foreach (string item in ayakkabılar)
            {
                ayakkabı.Items.Add(item);
            }
            sehir.Items.Clear();
            string[] iller = { "Eskişehir", "Bursa" };
            foreach (string item in iller)
            {
                sehir.Items.Add(item);
            }
        }
        
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(sehir.SelectedIndex == 0)
            {
                ilce.Text = "";
                ilce.Items.Clear();
                string[] ilceler = { "Alpu", "Beylikova","Çifteler", "Günyüzü", "Han", "İnönü", "Mahmudiye", "Mihalgazi", "Mihalıççık", "Tepebaşı", "Sarıcakaya", "Seyitgazi", "Sivrihisar" , "Odunpazarı" };
                foreach(string item in ilceler)
                {
                    ilce.Items.Add(item);
                }
            }
            else
            {
                ilce.Text = "";
                ilce.Items.Clear();
                string[] ilceler = { "Gürsu", "Kestel","Nilüfer", "Osmangazi", "Yıldırım", "Büyükorhan", "Gemlik", "Harmancık", "İnegöl", "İznik", "Karacabey", "Keles", "Mudanya", "Mustafakemalpaşa", "Orhaneli", "Orhangazi", "Yenişehir" };
                foreach (string item in ilceler)
                {
                    ilce.Items.Add(item);
                }
                
            }
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            if(isim.Text != "" && Tel.Text!= "" && ayakkabı.SelectedItem.ToString() != "" && ayknum.Text.ToString() != "" && sehir.SelectedItem.ToString() != "" && ilce.SelectedItem.ToString() != "")
            {
                string text = DateTime.Now + " tarihli siparişiniz oluşturuldu: " + "," + isim.Text + "," + Tel.Text + "," + ayakkabı.SelectedItem.ToString() + "," + ayknum.Text.ToString() + "," + sehir.SelectedItem.ToString() + "," + ilce.SelectedItem.ToString();
                siparis.Items.Add(text);
            }
            else
            {
                MessageBox.Show("Fill all blanks", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void siparis_SelectedIndexChanged(object sender, EventArgs e)
        {
            label8.Text = "";
            string[] siparis_ = siparis.SelectedItem.ToString().Split(',');
            
            foreach (string siparis_item in siparis_)
            {
                label8.Text += siparis_item+ Environment.NewLine;
            }
            
        }

        private bool IsNumeric(string text)
        {
            for (int i = 0; i < text.Length; i++)
            {
                char c = text[i];
                if (!char.IsDigit(c) || char.IsWhiteSpace(c))
                {
                    return false;
                }
            }
            return true;
        }
        private bool IsAlphabetic(string text)
        {
            for (int i = 0; i < text.Length; i++)
            {
                char c = text[i];
                if (!char.IsLetter(c) || char.IsWhiteSpace(c))
                {
                    return false;
                }
            }
            return true;
        }
        private void isim_TextChanged(object sender, EventArgs e)
        {
            if (!IsAlphabetic(isim.Text))
            {
                MessageBox.Show("Invalid Charecter", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                isim.Text = string.Empty;
            }
        }

        private void Tel_TextChanged(object sender, EventArgs e)
        {
            if (!IsNumeric(Tel.Text))
            {
                MessageBox.Show("Invalid Charecter", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Tel.Text = string.Empty;
            }
        }

        private void ayknum_TextChanged(object sender, EventArgs e)
        {
            if (!IsNumeric(Tel.Text))
            {
                MessageBox.Show("Invalid Charecter", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Tel.Text = string.Empty;
            }
        }
    }
}
