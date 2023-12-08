using DAL.Context;
using DAL.DomainClass;
using DAL.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositoies
{
    public class KhachHangRepository : IKhachHang
    {
        private readonly DBContext _context;

        public KhachHangRepository(DBContext context)
        {
            _context = context;
        }


        public KhachHang LayThongTinKhachHang(string maKhachHang)
        {
            return _context.KhachHangs.FirstOrDefault(kh => kh.MaKhachHang == maKhachHang);
        }

        public void ThemKhachHang(KhachHang khachHang)
        {
            _context.KhachHangs.Add(khachHang);
            _context.SaveChanges();
        }

        public void CapNhatThongTinKhachHang(KhachHang khachHang)
        {
            var existingKhachHang = _context.KhachHangs.Find(khachHang.MaKhachHang);
            if (existingKhachHang != null)
            {
                existingKhachHang.TenKhachHang = khachHang.TenKhachHang;
                existingKhachHang.NgaySinh = khachHang.NgaySinh;
                existingKhachHang.GioiTinh = khachHang.GioiTinh;
                existingKhachHang.DiaChi = khachHang.DiaChi;
                existingKhachHang.SoDienThoai = khachHang.SoDienThoai;
                existingKhachHang.Email = khachHang.Email;

                _context.SaveChanges();
            }
        }

        public void XoaKhachHang(string maKhachHang)
        {
            var khachHang = _context.KhachHangs.Find(maKhachHang);
            if (khachHang != null)
            {
                _context.KhachHangs.Remove(khachHang);
                _context.SaveChanges();
            }
        }
        public KhachHang LayTheoMaKhachHang(string maKhachHang)
        {
            // Triển khai truy vấn để lấy thông tin khách hàng dựa trên mã khách hàng
            return _context.KhachHangs.FirstOrDefault(kh => kh.MaKhachHang == maKhachHang);
        }

        public List<KhachHang> LayDanhSachKhachHang()
        {
            throw new NotImplementedException();
        }

        public void CapNhatKhachHang(KhachHang khachHang)
        {
            throw new NotImplementedException();
        }

        public List<KhachHang> GetAll()
        {
            return _context.KhachHangs.ToList();
        }
        public bool Exists(string maKhachHang)
        {
            return _context.KhachHangs.Any(kh => kh.MaKhachHang == maKhachHang);
        }

        public List<KhachHang> Search(string tuKhoa)
        {
            // Tìm kiếm theo tên khách hàng hoặc mã khách hàng
            return _context.KhachHangs
                .Where(kh => kh.TenKhachHang.Contains(tuKhoa) || kh.MaKhachHang.Contains(tuKhoa))
                .ToList();
        }
    }
}
