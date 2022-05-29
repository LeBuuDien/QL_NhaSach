using QLNhaSach.DTO.MODEL;
using System.Collections.Generic;
using System.Linq;

namespace QLNhaSach.BLL
{
    class DAO_NhanVien
    {
        QLNSDataContext QLNS = new QLNSDataContext();
        public List<NHANVIEN> loadNhanVien() => QLNS.NHANVIENs.ToList();

        public void addNhanVien(string manv, string tennv, string email, string diachi, string sdt, string username)
        {
            NHANVIEN NhanVien = new NHANVIEN();
            NhanVien.MaNV = manv;
            NhanVien.TenNV = tennv;
            NhanVien.SDT = sdt;
            NhanVien.Email = email;
            NhanVien.address = diachi;
           


            QLNS.NHANVIENs.InsertOnSubmit(NhanVien);
            QLNS.SubmitChanges();
        }
        public bool updateNhanVien(string manv, string tennv, string email, string diachi, string sdt)
        {
            try
            {
                NHANVIEN NhanVien = QLNS.NHANVIENs.Where(t => t.MaNV == manv).FirstOrDefault();
                NhanVien.TenNV = tennv;
                NhanVien.SDT = sdt;
                NhanVien.Email = email;
                NhanVien.address = diachi;
                

                QLNS.NHANVIENs.InsertOnSubmit(NhanVien);
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
