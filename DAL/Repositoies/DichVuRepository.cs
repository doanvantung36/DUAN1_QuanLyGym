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
    public class DichVuRepository : IDichVu
    {
        private readonly DBContext dbContext;

        public DichVuRepository(DBContext context)
        {
            dbContext = context;
        }

        public List<DichVu> GetAll()
        {
            return dbContext.DichVus.ToList();
        }

        public DichVu GetByID(string maDichVu)
        {
            return dbContext.DichVus.FirstOrDefault(d => d.MaDichVu == maDichVu);
        }

        public void Add(DichVu dichVu)
        {
            dbContext.DichVus.Add(dichVu);
            dbContext.SaveChanges();
        }

        public void Update(DichVu dichVu)
        {
            var existingDichVu = dbContext.DichVus.Find(dichVu.MaDichVu);
            if (existingDichVu != null)
            {
                existingDichVu.TenDichVu = dichVu.TenDichVu;
                existingDichVu.Gia = dichVu.Gia;
                existingDichVu.ThoiHan = dichVu.ThoiHan;
                existingDichVu.GhiChu = dichVu.GhiChu;

                dbContext.SaveChanges();
            }
        }

        public void Delete(string maDichVu)
        {
            var dichVuToDelete = dbContext.DichVus.Find(maDichVu);
            if (dichVuToDelete != null)
            {
                dbContext.DichVus.Remove(dichVuToDelete);
                dbContext.SaveChanges();
            }
        }
    }
}
