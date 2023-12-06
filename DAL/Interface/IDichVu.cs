using DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interface
{
    public interface IDichVu
    {
        // Định nghĩa các phương thức (nếu có) mà các lớp sẽ triển khai
        List<DichVu> LayDanhSachDichVu();
        DichVu LayThongTinDichVu(string maDichVu);
        void ThemDichVu(DichVu dichVu);
        void CapNhatDichVu(DichVu dichVu);
        void XoaDichVu(string maDichVu);
    }
}
