
using DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interface
{
    public interface IGiamGia
    {
        // Định nghĩa các phương thức (nếu có) mà các lớp sẽ triển khai
        List<GiamGium> LayDanhSachGiamGia();
        GiamGium LayThongTinGiamGia(string maGiamGia);
        void ThemGiamGia(GiamGium giamGia);
        void CapNhatGiamGia(GiamGium giamGia);
        void XoaGiamGia(string maGiamGia);
    }
}
