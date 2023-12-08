
using DAL.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositoies
{
    public class HoaDonChiTietRepository : IHoaDonChiTiet
    {
        //private readonly DBContext dbContext;

        //public HoaDonChiTietRepository(DBContext context)
        //{
        //    dbContext = context;
        //}

        //public List<HoaDonChiTiet> LayDanhSachHoaDonChiTiet()
        //{
        //    return dbContext.HoaDonChiTiets.ToList();
        //}

        //public HoaDonChiTiet LayThongTinHoaDonChiTiet(string maHoaDonChiTiet)
        //{
        //    return dbContext.HoaDonChiTiets.FirstOrDefault(h => h.MaHoaDonCt == maHoaDonChiTiet);
        //}

        //public void ThemHoaDonChiTiet(HoaDonChiTiet hoaDonChiTiet)
        //{
        //    dbContext.HoaDonChiTiets.Add(hoaDonChiTiet);
        //    dbContext.SaveChanges();
        //}

        //public void CapNhatHoaDonChiTiet(HoaDonChiTiet hoaDonChiTiet)
        //{
        //    var existingHoaDonChiTiet = dbContext.HoaDonChiTiets.Find(hoaDonChiTiet.MaHoaDonCt);
        //    if (existingHoaDonChiTiet != null)
        //    {
        //        existingHoaDonChiTiet.Gia = hoaDonChiTiet.Gia;
        //        existingHoaDonChiTiet.MaGiamGia = hoaDonChiTiet.MaGiamGia;
        //        existingHoaDonChiTiet.TienCocTruoc = hoaDonChiTiet.TienCocTruoc;
        //        existingHoaDonChiTiet.TienCanThanhToan = hoaDonChiTiet.TienCanThanhToan;
        //        existingHoaDonChiTiet.MaDichVu = hoaDonChiTiet.MaDichVu;

        //        dbContext.SaveChanges();
        //    }
        //}

        //public void XoaHoaDonChiTiet(string maHoaDonChiTiet)
        //{
        //    var hoaDonChiTietToDelete = dbContext.HoaDonChiTiets.Find(maHoaDonChiTiet);
        //    if (hoaDonChiTietToDelete != null)
        //    {
        //        dbContext.HoaDonChiTiets.Remove(hoaDonChiTietToDelete);
        //        dbContext.SaveChanges();
        //    }
        //}
    }
}
