using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLNhaSach.MODEL;
using System.Data.Linq.SqlClient;
using System.Data;

namespace QLNhaSach.BLL
{
    public class Dao_Customer
    {
        QLNhaSachDataContext QLNS = new QLNhaSachDataContext();
        public DataTable loadCustomer()
        {
            var query = from kh in QLNS.TBL_KHACHHANGs select kh;
            return (DataTable)query;
        }

        public void addCustomer(string makh, string tenKH, string gioiTinh, int sdt, string email, string address)
        {
            TBL_KHACHHANG customer = new TBL_KHACHHANG();
            customer.MAKH = makh;
            customer.TENKH = tenKH;
            customer.GIOITINH = gioiTinh;
            customer.SDT = sdt;
            customer.EMAIL = email;
            customer.DIACHI = address;

            QLNS.TBL_KHACHHANGs.InsertOnSubmit(customer);
            QLNS.SubmitChanges();
        }
    }
}
