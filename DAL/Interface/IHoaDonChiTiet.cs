using DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interface
{
    public interface IHoaDonChiTiet
    {
        // Định nghĩa các phương thức mà các lớp sẽ triển khai
        List<HoaDonChiTiet> LayDanhSachHoaDonChiTiet();
        HoaDonChiTiet LayThongTinHoaDonChiTiet(string maHoaDonChiTiet);
        void ThemHoaDonChiTiet(HoaDonChiTiet hoaDonChiTiet);
        void CapNhatHoaDonChiTiet(HoaDonChiTiet hoaDonChiTiet);
        void XoaHoaDonChiTiet(string maHoaDonChiTiet);
    }
}
