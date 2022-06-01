using BookShopManagement.DTO;
using System.Collections.Generic;
using System.Linq;

namespace BookShopManagement.BLL
{
    public class Dao_KhachHang
    {
        QLNSDataContext QLNS = new QLNSDataContext();
        public List<KhachHang> loadKhachHang() => QLNS.KhachHangs.Select(c => c).ToList();

        public bool addKhachHang(KhachHang khachHang)
        {
            try
            {
                QLNS.KhachHangs.InsertOnSubmit(khachHang);
                QLNS.SubmitChanges();
                return true;
            }
            catch (System.Exception)
            {

                return false;
            }

        }
        public bool updateC(KhachHang khach)
        {
            try
            {
                KhachHang customer = QLNS.KhachHangs.Where(c => c.MaKH == khach.MaKH).FirstOrDefault();
                customer = khach;

                QLNS.SubmitChanges();
                return true;
            }
            catch (System.Exception)
            {
                return false;
            }
        }
        public bool delC(string maKH)
        {
            try
            {
                KhachHang KhachHang = QLNS.KhachHangs.Where(c => c.MaKH == maKH).FirstOrDefault();
                QLNS.KhachHangs.DeleteOnSubmit(KhachHang);
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
