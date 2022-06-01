using BookShopManagement.DTO;
using System.Collections.Generic;
using System.Linq;

namespace BookShopManagement.BLL
{
    class DAO_Books
    {
        QLNSDataContext QLNS = new QLNSDataContext();
        public List<Sach> loadSach() => QLNS.Saches.Select(b => b).ToList();

        public bool addSach(Sach sach)
        {
            try
            {
                QLNS.Saches.InsertOnSubmit(sach);
                QLNS.SubmitChanges();
                return true;
            }
            catch (System.Exception)
            {

                return false;
            }
          
        }

        public bool updateSach(Sach sach)
        {
            try
            {
                Sach book = QLNS.Saches.Where(s => s.MaSach == sach.MaSach).FirstOrDefault();
                book = sach;

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
                Sach sach = QLNS.Saches.Where(c => c.MaSach == ID).FirstOrDefault();
                QLNS.Saches.DeleteOnSubmit(sach);
                QLNS.SubmitChanges();
                return true;
            }
            catch (System.Exception)
            {
                return false;
            }
        }
        public string loadGiaSP(string maSP)
        {
            string r = (from x in QLNS.Saches where x.MaSach == maSP select x.gia).First().ToString();
            return r;
        }
    }
}
