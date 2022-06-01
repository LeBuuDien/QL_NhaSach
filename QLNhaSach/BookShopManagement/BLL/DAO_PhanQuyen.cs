using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookShopManagement.DTO;

namespace BookShopManagement.BLL
{
    internal class DAO_PhanQuyen
    {
        QLNSDataContext QLNS = new QLNSDataContext();
        PHANQUYEN pq = new PHANQUYEN();

        public List<PHANQUYEN> loadPQ() => QLNS.PHANQUYENs.Select(C => C).ToList();
    }
}
