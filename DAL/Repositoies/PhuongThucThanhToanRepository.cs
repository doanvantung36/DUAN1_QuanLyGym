
using DAL.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositoies
{
    public class PhuongThucThanhToanRepository : IPhuongThucThanhToan
    {
        //private readonly DBContext dbContext;

        //public PhuongThucThanhToanRepository(DBContext context)
        //{
        //    dbContext = context;
        //}

        //public List<PhuongThucThanhToan> LayDanhSachPhuongThucThanhToan()
        //{
        //    return dbContext.PhuongThucThanhToans.ToList();
        //}

        //public PhuongThucThanhToan LayThongTinPhuongThucThanhToan(string maPhuongThuc)
        //{
        //    return dbContext.PhuongThucThanhToans.FirstOrDefault(p => p.MaPhuongThuc == maPhuongThuc);
        //}

        //public void ThemPhuongThucThanhToan(PhuongThucThanhToan phuongThuc)
        //{
        //    dbContext.PhuongThucThanhToans.Add(phuongThuc);
        //    dbContext.SaveChanges();
        //}

        //public void CapNhatPhuongThucThanhToan(PhuongThucThanhToan phuongThuc)
        //{
        //    var existingPhuongThuc = dbContext.PhuongThucThanhToans.Find(phuongThuc.MaPhuongThuc);
        //    if (existingPhuongThuc != null)
        //    {
        //        existingPhuongThuc.TenPhuongThuc = phuongThuc.TenPhuongThuc;
        //        existingPhuongThuc.TrangThai = phuongThuc.TrangThai;

        //        dbContext.SaveChanges();
        //    }
        //}

        //public void XoaPhuongThucThanhToan(string maPhuongThuc)
        //{
        //    var phuongThucToDelete = dbContext.PhuongThucThanhToans.Find(maPhuongThuc);
        //    if (phuongThucToDelete != null)
        //    {
        //        dbContext.PhuongThucThanhToans.Remove(phuongThucToDelete);
        //        dbContext.SaveChanges();
        //    }
        //}
    }
}
