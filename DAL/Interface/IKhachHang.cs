using DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interface
{
    public interface IKhachHang
    {
        // Lấy thông tin khách hàng dựa trên mã khách hàng
        KhachHang LayThongTinKhachHang(string maKhachHang);

        // Thêm mới khách hàng
        void ThemKhachHang(KhachHang khachHang);

        // Cập nhật thông tin khách hàng
        void CapNhatThongTinKhachHang(KhachHang khachHang);

        // Xóa khách hàng
        void XoaKhachHang(string maKhachHang);
        KhachHang LayTheoMaKhachHang(string maKhachHang);
    }
}
