using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookShopManagement.DTO;

namespace BookShopManagement.BLL
{
    public class login
    {
        QLNSDataContext QLNS = new QLNSDataContext();

        public bool funtionLogin(string username, string password)
        {
            var q = (from p in QLNS.ACCOUNTs where p.USERNAME == username && p.PASSWORD == password select p);
            if (q.Any())
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public string phanQuyen(string username)
        {
            string a = (from p in QLNS.ACCOUNTs where p.USERNAME == username select p.MaPQ).First().ToString();
            return a;
        }
    }
}
