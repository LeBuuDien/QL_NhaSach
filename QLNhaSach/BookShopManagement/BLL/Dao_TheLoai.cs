using BookShopManagement.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShopManagement.BLL
{
    class Dao_TheLoai
    {
        QLNSDataContext QLNS = new QLNSDataContext();
        public List<THELOAI> loadTL() => QLNS.THELOAIs.Select(c => c).ToList();

        public void addTL(THELOAI tl)
        {
            QLNS.THELOAIs.InsertOnSubmit(tl);
            QLNS.SubmitChanges();
        }
        public bool updateTL(THELOAI tl)
        {
            try
            {
                THELOAI tHELOAI = QLNS.THELOAIs.Where(s => s.MaTheLoai == tl.MaTheLoai).FirstOrDefault();
                tHELOAI = tl;

                QLNS.SubmitChanges();
                return true;
            }
            catch (System.Exception)
            {
                return false;
            }
        }
        public bool delTL(string ID)
        {
            try
            {
                THELOAI TL = QLNS.THELOAIs.Where(s => s.MaTheLoai == ID).FirstOrDefault();
                QLNS.THELOAIs.DeleteOnSubmit(TL);
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
