using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QLNhaSach.MODEL;

namespace QLNhaSach.BLL
{
    class DAO_STAFF
    {
        QLNhaSachDataContext QLNS = new QLNhaSachDataContext();
        public List<TBL_NHANVIEN> loadStaff() => QLNS.TBL_NHANVIENs.ToList();

        public void addStaff(string manv, string tennv, string gioitinh, int cmnd, string diachi, string chucvu)
        {
            TBL_NHANVIEN staff = new TBL_NHANVIEN();
            staff.MANV = manv;
            staff.TENNV = tennv;
            staff.GIOTINH = gioitinh;
            staff.CMND = cmnd;
            staff.DIACHI = diachi;
            staff.CHUCVU = chucvu;

            QLNS.TBL_NHANVIENs.InsertOnSubmit(staff);
            QLNS.SubmitChanges();
        }
    }
}
