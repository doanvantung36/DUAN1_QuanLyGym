using DAL.Context;
using DAL.DomainClass;
using DAL.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositoies
{
    public class LichLamViecRepository : ILichLamViec
    {
        private readonly DBContext _context;

        public LichLamViecRepository(DBContext context)
        {
            _context = context;
        }

        public List<LichLamViec> GetAll()
        {
            return _context.LichLamViecs.ToList();
        }

        public LichLamViec GetById(int id)
        {
            return _context.LichLamViecs.Find(id);
        }

        public void Add(LichLamViec lichLamViec)
        {
            _context.LichLamViecs.Add(lichLamViec);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var lichLamViec = _context.LichLamViecs.Find(id);
            if (lichLamViec != null)
            {
                _context.LichLamViecs.Remove(lichLamViec);
                _context.SaveChanges();
            }
        }

        public void Update(LichLamViec lichLamViec)
        {
            _context.Entry(lichLamViec).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public List<LichLamViec> Search(Func<LichLamViec, bool> condition)
        {
            return _context.LichLamViecs.Where(condition).ToList();
        }

    }
}
