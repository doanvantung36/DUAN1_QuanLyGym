
using DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.IService
{
    public interface ILichLamViecService
    {
        List<LichLamViec> GetAllLichLamViec();
        LichLamViec GetLichLamViecById(string maLich);
        void AddLichLamViec(LichLamViec lichLamViec);
        void UpdateLichLamViec(LichLamViec lichLamViec);
        void DeleteLichLamViec(string maLich);
    }
}
