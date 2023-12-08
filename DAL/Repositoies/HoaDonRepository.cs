
using DAL.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositoies
{
    public class HoaDonRepository : IHoaDon
    {
        //readonly DBContext dbContext;

        //public HoaDonRepository(DBContext context)
        //{
        //    dbContext = context;
        //}

        //public List<HoaDon> LayDanhSachHoaDon()
        //{
        //    return dbContext.HoaDons.ToList();
        //}

        //public HoaDon LayThongTinHoaDon(string maHoaDon)
        //{
        //    return dbContext.HoaDons.FirstOrDefault(h => h.MaHoaDon == maHoaDon);
        //}

        //public void ThemHoaDon(HoaDon hoaDon)
        //{
        //    dbContext.HoaDons.Add(hoaDon);
        //    dbContext.SaveChanges();
        //}

        //public void CapNhatHoaDon(HoaDon hoaDon)
        //{
        //    var existingHoaDon = dbContext.HoaDons.Find(hoaDon.MaHoaDon);
        //    if (existingHoaDon != null)
        //    {
        //        existingHoaDon.MaNhanVien = hoaDon.MaNhanVien;
        //        existingHoaDon.MaKhachHang = hoaDon.MaKhachHang;
        //        existingHoaDon.MaThanhToan = hoaDon.MaThanhToan;
        //        existingHoaDon.NgayLap = hoaDon.NgayLap;
        //        existingHoaDon.TongTien = hoaDon.TongTien;
        //        existingHoaDon.GiamGia = hoaDon.GiamGia;
        //        existingHoaDon.ThanhTien = hoaDon.ThanhTien;
        //        existingHoaDon.TrangThaiHoaDon = hoaDon.TrangThaiHoaDon;
        //        existingHoaDon.TrangThaiThanhToan = hoaDon.TrangThaiThanhToan;

        //        dbContext.SaveChanges();
        //    }
        //}

        //public void XoaHoaDon(string maHoaDon)
        //{
        //    var hoaDonToDelete = dbContext.HoaDons.Find(maHoaDon);
        //    if (hoaDonToDelete != null)
        //    {
        //        dbContext.HoaDons.Remove(hoaDonToDelete);
        //        dbContext.SaveChanges();
        //    }
        //}
        //public bool ThemMoiHoaDon(HoaDon hoaDon)
        //{
        //    try
        //    {
        //        dbContext.HoaDons.Add(hoaDon);
        //        dbContext.SaveChanges();
        //        return true;
        //    }
        //    catch (Exception ex)
        //    {
        //        // Xử lý lỗi (ghi log, thông báo, v.v.)
        //        return false;
        //    }
        //}
    }
}
