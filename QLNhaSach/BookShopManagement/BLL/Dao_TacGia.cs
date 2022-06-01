using BookShopManagement.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShopManagement.BLL
{
    class Dao_TacGia
    {
        QLNSDataContext QLNS = new QLNSDataContext();
        public List<TACGIA> loadTG() => QLNS.TACGIAs.Select(c => c).ToList();

        public void addTG(TACGIA tacGia)
        {
            QLNS.TACGIAs.InsertOnSubmit(tacGia);
            QLNS.SubmitChanges();
        }
        public bool updateTacGia(TACGIA tACGIA)
        {
            try
            {
                TACGIA TG = QLNS.TACGIAs.Where(s => s.MaTacGia == tACGIA.MaTacGia).FirstOrDefault();
                TG = tACGIA;

                QLNS.SubmitChanges();
                return true;
            }
            catch (System.Exception)
            {
                return false;
            }
        }
        public bool delC(string ID)
        {
            try
            {
                TACGIA TG = QLNS.TACGIAs.Where(s => s.MaTacGia == ID).FirstOrDefault();
                QLNS.TACGIAs.DeleteOnSubmit(TG);
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
