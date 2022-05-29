using QLNhaSach.DTO.MODEL;
using System.Collections.Generic;
using System.Linq;

namespace QLNhaSach.BLL
{
    public class Dao_KhachHang
    {
        QLNSDataContext QLNS = new QLNSDataContext();
        public List<KhachHang> loadKhachHang() => QLNS.KhachHangs.Select(c => c).ToList();

        public void addKhachHang(string makh, string tenKH, string sdt, string email, string address)
        {
            KhachHang KhachHang = new KhachHang();
            KhachHang.MaKH = makh;
            KhachHang.TenKH = tenKH;
            KhachHang.SDT = sdt;
            KhachHang.EMAIL = email;
            KhachHang.Address = address;

            QLNS.KhachHangs.InsertOnSubmit(KhachHang);
            QLNS.SubmitChanges();
        }
        public bool updateC(string maKH, string tenKH, string email, string address, string sdt, string un)
        {
            try
            {
                KhachHang KhachHang = QLNS.KhachHangs.Where(c => c.MaKH == maKH).FirstOrDefault();
                KhachHang.TenKH = tenKH;
                KhachHang.SDT = sdt;
                KhachHang.EMAIL = email;
                KhachHang.Address = address;
                

                QLNS.KhachHangs.InsertOnSubmit(KhachHang);
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
