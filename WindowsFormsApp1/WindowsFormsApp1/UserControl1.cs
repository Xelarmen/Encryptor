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
    public partial class UserControl1 : UserControl
    {

        public UserControl1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string word, key="";
            int keynmbr, sayac=0;
            string deger="";
            textBox2.Text = "";
            if (textBox1.Text != "")//boş karakter şifre çözme bugu fixlendi
            {
                word = textBox1.Text;
                char[] metin = word.ToCharArray();//harf dizisi yaptı tek tek değer okumak için
                for (int i = metin.Length - 2; i <= metin.Length - 1; i++)
                {
                    key += metin[i];//metinden keyi alır
                }
                keynmbr = Convert.ToInt32(key);//şifre çözmek için gerekli olan bölümü int yapar
                key = "";
                //---------------------------------------

                for (int i = 0; i <= metin.Length - 1; i++)//key - şifrelenmiş metin
                {
                    //int kontrol = metin[i];
                    if (metin[i] == ' ')
                    {
                        for (int y = i - sayac; y <= i - 1; y++)
                        {
                            deger += metin[y];
                        }
                        textBox2.Text += ((char)(Convert.ToInt64(deger) / keynmbr)).ToString();//şifresi çözülen ascii değerini karakter yapar
                        sayac = 0;
                        deger = "";
                    }

                    else if (metin[i] != ' ')
                    {
                        //textBox2.Text += "sayi";
                        sayac++;
                    }
                }
            }
        }
    }
}
