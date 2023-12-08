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

        public LichLamViec GetById(string maLich)
        {
            return _context.LichLamViecs.FirstOrDefault(llv => llv.MaLich == maLich);
        }

        public void Add(LichLamViec lichLamViec)
        {
            _context.LichLamViecs.Add(lichLamViec);
            _context.SaveChanges();
        }

        public void Update(LichLamViec lichLamViec)
        {
            var existingLichLamViec = _context.LichLamViecs.Find(lichLamViec.MaLich);
            if (existingLichLamViec != null)
            {
                existingLichLamViec.Ca = lichLamViec.Ca;
                existingLichLamViec.NgayTap = lichLamViec.NgayTap;
                existingLichLamViec.TrangThai = lichLamViec.TrangThai;

                _context.SaveChanges();
            }
        }

        public void Delete(string maLich)
        {
            var lichLamViec = _context.LichLamViecs.Find(maLich);
            if (lichLamViec != null)
            {
                _context.LichLamViecs.Remove(lichLamViec);
                _context.SaveChanges();
            }
        }

    }
}
