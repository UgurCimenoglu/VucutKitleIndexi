using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace UI
{
    public partial class UserForm : Form
    {
        public UserForm()
        {
            InitializeComponent();
        }

        public string kullaniciadi { get; set; }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                double boy = double.Parse(textBox1.Text);
                double kilogram = double.Parse(textBox2.Text);
                double index = kilogram / ((boy / 100) * (boy / 100));
                double raunt = Math.Round(index);
                string sonuc = raunt.ToString();
                MessageBox.Show("İndex : " + sonuc);

                if(raunt < 19)
                {
                    MessageBox.Show("İndex : " + sonuc + " Zayıfsınız!");
                }
                else if (raunt >= 19 && raunt <= 25)
                {
                    MessageBox.Show("Normal Kilodasınız!");
                }
                else if (raunt >= 26 && raunt <= 30)
                {
                    MessageBox.Show("Fazla Kilonuz var biraz diyet iyi gelebilir.");
                }
                else if (raunt >= 31 && raunt <= 40)
                {
                    MessageBox.Show("Obezite Derecesinde kilolusunuz Acilen doktora gidiniz!");
                }
                else if (raunt >= 41 && raunt <= 100)
                {
                    MessageBox.Show(" İleri derecede obezsiniz(morbid obez). Acilen doktora gidiniz!");
                }
                else
                {
                    MessageBox.Show("Hesaplanamadı!");
                }


                IndexKayitBLL indexKayit = new IndexKayitBLL();

                if(raunt>0 && raunt < 1000)
                {
                    indexKayit.IndexKayit(sonuc, kullaniciadi);
                }
                else
                {
                    MessageBox.Show("Lütfen Girdiğiniz Değeri Kontrol Ediniz!");
                }
                
            }
            catch (Exception)
            {
                MessageBox.Show("Beklenmeyen bir hata oluştu işlem yapılmadı!");
            }
        }

        private void UserForm_Load(object sender, EventArgs e)
        {
            label2.Text = "Hoşgeldin "+ kullaniciadi;
        }
    }
}
