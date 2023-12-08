
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
        LichLamViec GetById(string maLich);
        void Add(LichLamViec lichLamViec);
        void Update(LichLamViec lichLamViec);
        void Delete(string maLich);
    }
}
