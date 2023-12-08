
using DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interface
{
    public interface IPhuongThucThanhToan
    {
        // Định nghĩa các phương thức mà các lớp sẽ triển khai
        List<PhuongThucThanhToan> LayDanhSachPhuongThucThanhToan();
        PhuongThucThanhToan LayThongTinPhuongThucThanhToan(string maPhuongThuc);
        void ThemPhuongThucThanhToan(PhuongThucThanhToan phuongThucThanhToan);
        void CapNhatPhuongThucThanhToan(PhuongThucThanhToan phuongThucThanhToan);
        void XoaPhuongThucThanhToan(string maPhuongThuc);
    }
}
