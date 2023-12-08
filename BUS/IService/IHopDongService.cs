
using DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.IService
{
    public interface IHopDongService
    {
        // Lấy danh sách tất cả hợp đồng
        List<HopDong> GetAll();

        // Lấy thông tin hợp đồng dựa trên mã hợp đồng
        HopDong GetById(string maHopDong);

        // Thêm mới hợp đồng
        void Add(HopDong hopDong);

        // Cập nhật thông tin hợp đồng
        void Update(HopDong hopDong);

        // Xóa hợp đồng dựa trên mã hợp đồng
        void Delete(string maHopDong);
    }
}
