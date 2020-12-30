using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;

namespace BLL
{
    public class LoginBLL
    {
        private LoginDAL logindal;
        private LoginDAL userlogin;
        public LoginBLL()
        {
            logindal = new LoginDAL();
            userlogin = new LoginDAL();
           
        }

        public bool Login(string id, string password) {

            if (logindal.Login(id, password))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool UserLogin(string id, string password)
        {

            if (userlogin.UserLogin(id, password))
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
