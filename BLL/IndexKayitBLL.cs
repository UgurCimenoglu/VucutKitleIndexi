using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class IndexKayitBLL
    {
        private IndexKayitDAL indexkayit;
        public IndexKayitBLL()
        {
            indexkayit = new IndexKayitDAL();
        }
        public void IndexKayit(string index , string kullaniciadi)
        {
            indexkayit.IndexKayit(index, kullaniciadi);
        }
    }
}
