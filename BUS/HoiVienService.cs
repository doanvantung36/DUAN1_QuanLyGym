using BUS.IService;
using DAL.DomainClass;
using DAL.Interface;
using DAL.Repositoies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class HoiVienService : IKhachHangService
    {
        private readonly IKhachHang _khachHangRepository;

        //public IKhachHangService(IKhachHang khachHangRepository)
        //{
        //    _khachHangRepository = khachHangRepository;
        //}
        public List<KhachHang> GetAll()
        {
            return _khachHangRepository.GetAll();
        }
        public List<KhachHang> LayDanhSachKhachHang()
        {
            return _khachHangRepository.LayDanhSachKhachHang();
        }

        public KhachHang LayThongTinKhachHang(string maKhachHang)
        {
            return _khachHangRepository.LayThongTinKhachHang(maKhachHang);
        }

        public void ThemKhachHang(KhachHang khachHang)
        {
            _khachHangRepository.ThemKhachHang(khachHang);
        }

        public void CapNhatKhachHang(KhachHang khachHang)
        {
            _khachHangRepository.CapNhatKhachHang(khachHang);
        }

        public void XoaKhachHang(string maKhachHang)
        {
            _khachHangRepository.XoaKhachHang(maKhachHang);
        }
        public bool Exists(string maKhachHang)
        {
            return _khachHangRepository.Exists(maKhachHang);
        }

        public List<KhachHang> Search(string tuKhoa)
        {
            return _khachHangRepository.Search(tuKhoa);
        }
    }
}
