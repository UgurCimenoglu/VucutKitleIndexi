using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string kullaniciadi = textBox1.Text.ToString();
            string sifre = textBox2.Text.ToString();

            LoginBLL loginbll = new LoginBLL();

            if (loginbll.Login(kullaniciadi, sifre))
            {
                adminForm adminform = new adminForm();
                adminform.Show();
                textBox1.Text = "";
                textBox2.Text = "";

            }
            else
            {
                MessageBox.Show("Hatalı Kullanıcı Adı Veya Şifre Girdiniz!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string kullaniciadi = textBox3.Text.ToString();
            string sifre = textBox4.Text.ToString();

            LoginBLL loginbll = new LoginBLL();

            if (loginbll.UserLogin(kullaniciadi, sifre))
            {
                UserForm userform = new UserForm();
                userform.kullaniciadi = kullaniciadi;
                userform.ShowDialog();
                textBox3.Text = "";
                textBox4.Text = "";

            }
            else
            {
                MessageBox.Show("Hatalı Kullanıcı Adı Veya Şifre Girdiniz!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            UserKayit kayitform = new UserKayit();
            kayitform.ShowDialog();
        }
    }
}
