using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookShopManagement.DTO;

namespace BookShopManagement.BLL
{
    internal class DAO_ACCOUNT
    {
        QLNSDataContext QLNS = new QLNSDataContext();
        public List<ACCOUNT> loadAccount() => QLNS.ACCOUNTs.Select(c => c).ToList();

        public void addAccount(ACCOUNT aCCOUNT)
        {
            QLNS.ACCOUNTs.InsertOnSubmit(aCCOUNT);
            QLNS.SubmitChanges();
        }
        public bool updateAccount(ACCOUNT aCCOUNT)
        {
            try
            {
                ACCOUNT a = QLNS.ACCOUNTs.Where(c => c.USERNAME == aCCOUNT.USERNAME).FirstOrDefault();
                a = aCCOUNT;

                QLNS.SubmitChanges();
                return true;
            }
            catch (System.Exception)
            {
                return false;
            }
        }
        public bool delC(string userName)
        {
            try
            {
                ACCOUNT a = QLNS.ACCOUNTs.Where(c => c.USERNAME == userName).FirstOrDefault();
                QLNS.ACCOUNTs.DeleteOnSubmit(a);
                QLNS.SubmitChanges();
                return true;
            }
            catch (System.Exception)
            {
                return false;
            }
        }
    }
}
