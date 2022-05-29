using QLNhaSach.DTO.MODEL;
using System.Collections.Generic;
using System.Linq;

namespace QLNhaSach.BLL
{
    public class Dao_QLSP
    {
        QLNSDataContext QLNS = new QLNSDataContext();

        //trong class này sẽ bao gồm sản phẩm như: Sách, tác giả, thể loại, NXB

        //public List<> loadNXB() => QLNS.TBL_NHAXUATBANs.Select(nxb => nxb).ToList();

        public List<Sach> loadSach() => QLNS.Saches.Select(b => b).ToList();

        //public List<TBL_TACGIA> loadTacGia() => QLNS.TBL_TACGIAs.Select(tg => tg).ToList();

        //public List<TBL_THELOAI> loadTheLoai() => QLNS.TBL_THELOAIs.Select(tl => tl).ToList();

    }
}
