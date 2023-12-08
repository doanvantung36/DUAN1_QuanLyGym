
using DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interface
{
    public interface IPTRepository
    {
        // Lấy danh sách tất cả PT
        List<Pt> GetAll();

        // Lấy thông tin PT dựa trên mã PT
        Pt GetById(string maPT);

        // Thêm mới PT
        void Add(Pt pt);

        // Cập nhật thông tin PT
        void Update(Pt pt);

        // Xóa PT dựa trên mã PT
        void Delete(string maPT);
    }
}
