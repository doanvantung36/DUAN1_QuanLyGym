using DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interface
{
     public interface ILichLamViec
    {
        List<LichLamViec> GetAll();

        // Lấy thông tin lịch làm việc theo ID
        LichLamViec GetById(int id);

        // Thêm mới lịch làm việc
        void Add(LichLamViec lichLamViec);

        // Xóa lịch làm việc
        void Delete(int id);

        // Cập nhật thông tin lịch làm việc
        void Update(LichLamViec lichLamViec);

        // Tìm kiếm lịch làm việc dựa trên điều kiện nào đó
        List<LichLamViec> Search(Func<LichLamViec, bool> condition);
    }
}
