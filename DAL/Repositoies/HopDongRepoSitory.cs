using DAL.Context;
using DAL.DomainClass;
using DAL.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositoies
{
    public class HopDongRepoSitory : IHopDong
    {
        private readonly DBContext _context;

        public HopDongRepoSitory(DBContext context)
        {
            _context = context;
        }

        public List<HopDong> GetAll()
        {
            return _context.HopDongs.ToList();
        }

        public HopDong LayThongTinHopDong(string maHopDong)
        {
            return _context.HopDongs.FirstOrDefault(kh => kh.MaHopDong == maHopDong);
        }

        public void ThemHopDong(HopDong maHopDong)
        {
            _context.HopDongs.Add(maHopDong);
            _context.SaveChanges();
        }

        public void CapNhatThongTinHopDong(HopDong maHopDong)
        {
            var existingHopDong = _context.HopDongs.Find(maHopDong.MaHopDong);
            if (existingHopDong != null)
            {
                existingHopDong.MaKhachHang = maHopDong.MaKhachHang;
                existingHopDong.MaPt = maHopDong.MaPt;
                existingHopDong.NgayDangKi = maHopDong.NgayDangKi;
                existingHopDong.NgayKetThuc = maHopDong.NgayKetThuc;

                _context.SaveChanges();
            }
        }

        public void XoaHopDong(string maHopDong)
        {
            var hopDong = _context.HopDongs.Find(maHopDong);
            if (hopDong != null)
            {
                _context.HopDongs.Remove(hopDong);
                _context.SaveChanges();
            }
        }

        public HopDong LayTheoMaMaHopDong(string maHopDong)
        {
            return _context.HopDongs.FirstOrDefault(kh => kh.MaHopDong == maHopDong);
        }

        public List<HopDong> LayDanhSachHopDong()
        {
            return _context.HopDongs.ToList();
        }

        public void CapNhatHopDong(HopDong maHopDong)
        {
            throw new NotImplementedException();
        }

        public HopDong LayTheoMaHopDong(string maHopDong)
        {
            return _context.HopDongs.FirstOrDefault(kh => kh.MaHopDong == maHopDong);
        }
    }
}
