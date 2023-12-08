
using DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interface
{
    public interface IHoaDon
    {
        // Định nghĩa các phương thức mà các lớp sẽ triển khai
        public List<HoaDon> LayDanhSachHoaDon();
        HoaDon LayThongTinHoaDon(string maHoaDon);
        void ThemHoaDon(HoaDon hoaDon);
        void CapNhatHoaDon(HoaDon hoaDon);
        void XoaHoaDon(string maHoaDon);
        bool ThemMoiHoaDon(HoaDon hoaDon);
    }
}
