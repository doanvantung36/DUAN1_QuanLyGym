using DAL.DomainClass;
using DAL.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class LịchLamViecService : ILichLamViec
    {
        private readonly ILichLamViec _lichLamViecRepo;

        public LịchLamViecService(ILichLamViec lichLamViecRepo)
        {
            _lichLamViecRepo = lichLamViecRepo;
        }

        public List<LichLamViec> GetAll()
        {
            return _lichLamViecRepo.GetAll();
        }

        public LichLamViec GetById(int id)
        {
            return _lichLamViecRepo.GetById(id);
        }

        public void Add(LichLamViec lichLamViec)
        {
            _lichLamViecRepo.Add(lichLamViec);
        }

        public void Update(LichLamViec lichLamViec)
        {
            _lichLamViecRepo.Update(lichLamViec);
        }

        public void Delete(int id)
        {
            _lichLamViecRepo.Delete(id);
        }

        public List<LichLamViec> Search(Func<LichLamViec, bool> condition)
        {
            return _lichLamViecRepo.Search(condition);
        }
    }
}
