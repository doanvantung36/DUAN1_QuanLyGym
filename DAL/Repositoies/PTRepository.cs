using DAL.Context;
using DAL.DomainClass;
using DAL.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositoies
{
    public class PTRepository : IPTRepository
    {
        private readonly DBContext dbContext;

        public PTRepository(DBContext context)
        {
            dbContext = context;
        }

        public List<Pt> GetAll()
        {
            return dbContext.Pts.ToList();
        }

        public Pt GetById(string maPT)
        {
            return dbContext.Pts.FirstOrDefault(pt => pt.MaPt == maPT);
        }

        public void Add(Pt pt)
        {
            dbContext.Pts.Add(pt);
            dbContext.SaveChanges();
        }

        public void Update(Pt pt)
        {
            var existingPT = dbContext.Pts.Find(pt.MaPt);
            if (existingPT != null)
            {
                existingPT.TenPt = pt.TenPt;
                // Cập nhật các trường khác tùy theo cấu trúc đối tượng PT

                dbContext.SaveChanges();
            }
        }

        public void Delete(string maPT)
        {
            var ptToDelete = dbContext.Pts.Find(maPT);
            if (ptToDelete != null)
            {
                dbContext.Pts.Remove(ptToDelete);
                dbContext.SaveChanges();
            }
        }
    }
}
