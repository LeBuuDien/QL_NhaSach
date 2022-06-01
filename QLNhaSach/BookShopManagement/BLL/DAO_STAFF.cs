using BookShopManagement.DTO;
using System.Collections.Generic;
using System.Linq;

namespace BookShopManagement.BLL
{
    class DAO_NhanVien
    {
        QLNSDataContext QLNS = new QLNSDataContext();
        public List<NHANVIEN> loadNhanVien() => QLNS.NHANVIENs.ToList();

        public void addNhanVien(NHANVIEN NV)
        {

            QLNS.NHANVIENs.InsertOnSubmit(NV);
            QLNS.SubmitChanges();
        }
        public bool updateNhanVien(NHANVIEN nv)
        {
            try
            {
                NHANVIEN NhanVien = QLNS.NHANVIENs.Where(t => t.MaNV == nv.MaNV).FirstOrDefault();
                NhanVien = nv;
                
                QLNS.SubmitChanges();
                return true;
            }
            catch (System.Exception)
            {
                return false;
            }
        }
        public bool delNhanVien(string manv)
        {
            try
            {
                NHANVIEN NhanVien = QLNS.NHANVIENs.Where(t => t.MaNV == manv).FirstOrDefault();
                QLNS.NHANVIENs.DeleteOnSubmit(NhanVien);
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
