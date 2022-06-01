
using System;
using System.Collections.Generic;
using System.Linq;
using BookShopManagement.DTO;

namespace BookShopManagement.BLL
{
    class DAO_Bill
    {
        QLNSDataContext QLNS = new QLNSDataContext();

        public List<HOADON> LoadHoaDon() => QLNS.HOADONs.Select(s => s).ToList();

        public bool addBill(HOADON bill)
        {
            try
            {
                QLNS.HOADONs.InsertOnSubmit(bill);
                QLNS.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool updateBill(HOADON hOADON)
        {
            try
            {
                HOADON bill = QLNS.HOADONs.Where(h => h.MaHD == hOADON.MaHD).FirstOrDefault();
                bill = hOADON;

                QLNS.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }
        public bool deleteBill(string maHD)
        {
            try
            {
                HOADON bill = QLNS.HOADONs.Where(h => h.MaHD == maHD).FirstOrDefault();
                QLNS.HOADONs.DeleteOnSubmit(bill);
                QLNS.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }

        ///Chi tiet hoa don
        ///
        ///
        public List<CHITIETHOADON> LoadCTHD(string maHD)
        {
            IQueryable<CHITIETHOADON> x = (from q in QLNS.CHITIETHOADONs where q.MaHD == maHD select q);
            return x.ToList();
        }

        public bool addBillInformation(CHITIETHOADON cHITIETHOADON)
        {
            try
            {
                QLNS.CHITIETHOADONs.InsertOnSubmit(cHITIETHOADON);
                QLNS.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool updateBillInformation(CHITIETHOADON cHITIETHOADON)
        {
            try
            {
                CHITIETHOADON cthd = QLNS.CHITIETHOADONs.Where(ct => ct.MaHD == cHITIETHOADON.MaHD && ct.MaSach == cHITIETHOADON.MaSach).FirstOrDefault();
                cthd = cHITIETHOADON;
                QLNS.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }
        public bool deleteBillInformation(string maHD, string maSP)
        {
            try
            {
                CHITIETHOADON cthd = QLNS.CHITIETHOADONs.Where(ct => ct.MaHD == maHD && ct.MaSach == maSP).FirstOrDefault();
                QLNS.CHITIETHOADONs.DeleteOnSubmit(cthd);
                QLNS.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }


    }
}
