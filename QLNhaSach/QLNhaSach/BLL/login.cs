using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLNhaSach.DTO.MODEL;

namespace QLNhaSach.BLL
{
    public class login
    {
        QLNSDataContext QLNS = new QLNSDataContext();

        public bool funtionLogin(string username, string password)
        {
            var q = (from p in QLNS.ACCOUNTs where p.Username == username && p.Password == password select p);
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
            string a = (from p in QLNS.ACCOUNTs where p.Username == username select p.maPQ).First().ToString();
            return a;
        }
    }
}
