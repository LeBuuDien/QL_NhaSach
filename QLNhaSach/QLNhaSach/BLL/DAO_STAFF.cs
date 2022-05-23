using QLNhaSach.DTO.MODEL;
using System.Collections.Generic;
using System.Linq;

namespace QLNhaSach.BLL
{
    class DAO_STAFF
    {
        QLNSDataContext QLNS = new QLNSDataContext();
        public List<STAFF> loadStaff() => QLNS.STAFFs.ToList();

        public void addStaff(string manv, string tennv, string email, string diachi, string sdt, string username)
        {
            STAFF staff = new STAFF();
            staff.MaNV = manv;
            staff.TenNV = tennv;
            staff.SDT = sdt;
            staff.Email = email;
            staff.address = diachi;
            staff.Username = username;


            QLNS.STAFFs.InsertOnSubmit(staff);
            QLNS.SubmitChanges();
        }
        public bool updateStaff(string manv, string tennv, string email, string diachi, string sdt, string username)
        {
            try
            {
                STAFF staff = QLNS.STAFFs.Where(t => t.MaNV == manv).FirstOrDefault();
                staff.TenNV = tennv;
                staff.SDT = sdt;
                staff.Email = email;
                staff.address = diachi;
                staff.Username = username;

                QLNS.STAFFs.InsertOnSubmit(staff);
                QLNS.SubmitChanges();
                return true;
            }
            catch (System.Exception)
            {
                return false;
            }
        }
        public bool delStaff(string manv)
        {
            try
            {
                STAFF staff = QLNS.STAFFs.Where(t => t.MaNV == manv).FirstOrDefault();
                QLNS.STAFFs.DeleteOnSubmit(staff);
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
