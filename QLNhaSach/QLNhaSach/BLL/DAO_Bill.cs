﻿using QLNhaSach.DTO.MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNhaSach.BLL
{
    class DAO_Bill
    {
        QLNSDataContext QLNS = new QLNSDataContext();
        public List<BILL> loadCustomer() => QLNS.BILLs.Select(c => c).ToList();

        //public void addCustomer(string makh, string tenKH, string un, string sdt, string email, string address)
        //{
        //    CUSTOMER customer = new CUSTOMER();
        //    customer.MaKH = makh;
        //    customer.TenKH = tenKH;
        //    customer.sdt = sdt;
        //    customer.Email = email;
        //    customer.address = address;
        //    customer.Username = un;

        //    QLNS.CUSTOMERs.InsertOnSubmit(customer);
        //    QLNS.SubmitChanges();
        //}
        //public bool updateC(string maKH, string tenKH, string email, string address, string sdt, string un)
        //{
        //    try
        //    {
        //        CUSTOMER customer = QLNS.CUSTOMERs.Where(c => c.MaKH == maKH).FirstOrDefault();
        //        customer.TenKH = tenKH;
        //        customer.sdt = sdt;
        //        customer.Email = email;
        //        customer.address = address;
        //        customer.Username = un;

        //        QLNS.CUSTOMERs.InsertOnSubmit(customer);
        //        QLNS.SubmitChanges();
        //        return true;
        //    }
        //    catch (System.Exception)
        //    {
        //        return false;
        //    }
        //}
        //public bool delC(string maKH)
        //{
        //    try
        //    {
        //        CUSTOMER customer = QLNS.CUSTOMERs.Where(c => c.MaKH == maKH).FirstOrDefault();
        //        QLNS.CUSTOMERs.DeleteOnSubmit(customer);
        //        QLNS.SubmitChanges();
        //        return true;
        //    }
        //    catch (System.Exception)
        //    {
        //        return false;
        //    }
        }
    }
}