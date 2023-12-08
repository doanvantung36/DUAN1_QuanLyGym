using DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interface
{
    public interface IHopDong
    {
        // Lấy thông tin khách hàng dựa trên mã khách hàng
        HopDong LayThongTinHopDong(string maHopDong);
        // Lấy tất cả thông tin khách hàng
        List<HopDong> GetAll();
        // Thêm mới khách hàng
        void ThemHopDong(HopDong maHopDong);

        // Cập nhật thông tin khách hàng
        void CapNhatThongTinHopDong(HopDong maHopDong);

        // Xóa khách hàng
        void XoaHopDong(string maHopDong);
        HopDong LayTheoMaHopDong(string maHopDong);
        List<HopDong> LayDanhSachHopDong();
        void CapNhatHopDong(HopDong  maHopDong);
    }
}
