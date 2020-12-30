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
    public partial class UserKayit : Form
    {
        public UserKayit()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RegisterUserBLL register = new RegisterUserBLL();
            string adsoyad = textBox1.Text.ToString();
            string kullaniciadi = textBox2.Text.ToString();
            string sifre = textBox3.Text.ToString();

            if(adsoyad =="" || kullaniciadi == "" || sifre == "")
            {
                MessageBox.Show("Lütfen Boş Alan Bırakmayınız!");
            }
            else
            {
                if (register.RegisterUser(kullaniciadi, sifre, adsoyad))
                {
                    MessageBox.Show("Girdiğiniz Kullanıcı Adı Sistemde Kayıtlıdır!");
                }
                else
                {
                    MessageBox.Show("Kayıt Başarılı! Giriş Ekranına Yönlendiriliyorsunuz...");
                    this.Hide();
                }
            }

        }


    }
}
