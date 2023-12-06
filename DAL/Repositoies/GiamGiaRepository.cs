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
    public class GiamGiaRepository:IGiamGia
    {
        private readonly DBContext dbContext;

        public GiamGiaRepository(DBContext context)
        {
            dbContext = context;
        }

        public List<GiamGium> LayDanhSachGiamGia()
        {
            return dbContext.GiamGia.ToList();
        }

        public GiamGium LayThongTinGiamGia(string maGiamGia)
        {
            return dbContext.GiamGia.FirstOrDefault(g => g.MaGiamGia == maGiamGia);
        }

        public void ThemGiamGia(GiamGium giamGia)
        {
            dbContext.GiamGia.Add(giamGia);
            dbContext.SaveChanges();
        }

        public void CapNhatGiamGia(GiamGium giamGia)
        {
            var existingGiamGia = dbContext.GiamGia.Find(giamGia.MaGiamGia);
            if (existingGiamGia != null)
            {
                existingGiamGia.MoTa = giamGia.MoTa;
                existingGiamGia.GiaGiam = giamGia.GiaGiam;
                existingGiamGia.NgayHetHan = giamGia.NgayHetHan;

                dbContext.SaveChanges();
            }
        }

        public void XoaGiamGia(string maGiamGia)
        {
            var giamGiaToDelete = dbContext.GiamGia.Find(maGiamGia);
            if (giamGiaToDelete != null)
            {
                dbContext.GiamGia.Remove(giamGiaToDelete);
                dbContext.SaveChanges();
            }
        }
    }
}
