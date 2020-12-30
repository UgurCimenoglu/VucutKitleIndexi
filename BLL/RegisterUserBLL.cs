using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class RegisterUserBLL
    {
        private RegisterUserDAL registeruser;
        public RegisterUserBLL()
        {
            registeruser = new RegisterUserDAL();
        }
        public bool RegisterUser(string kullaniciadi, string sifre, string adsoyad)
        {
            if (registeruser.RegisterUser(kullaniciadi,  sifre,  adsoyad))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
