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
        public DataTable loadStaff()
        {
            var lstStaff = QLNS.TBL_NHANVIENs.Select(nv => nv);
            return (DataTable)lstStaff;
        }

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
