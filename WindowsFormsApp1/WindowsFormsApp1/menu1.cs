using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class menu1 : UserControl
    {
        //global değişkenler
         //sifrelenecek textbox'un içindeki metinler
        int time;  //saat+dk


        public menu1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            String word, sifreli;
            sifreli = "";
            textBox2.Clear();
            word = textBox1.Text;
            char[] metin = word.ToCharArray();//harf dizisi yaptı tek tek değer okumak için
            for (int i = 0; i <= metin.Length - 1; i++)//5 karakterli bir metnin son indexi 4'dür 
            {
                time = DateTime.Now.Minute + DateTime.Now.Hour;//dakika saat bilgisini topluyor
                int harf = metin[i];
                sifreli += harf * time + " ";
                                              
            }
            sifreli += time.ToString();
            textBox2.Text = sifreli;
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }
    }
}
