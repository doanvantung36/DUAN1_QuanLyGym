
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
    public class KhachHangRepository : IKhachHang
    {
        private readonly DBContext _dbContext;

        public KhachHangRepository(DBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<KhachHang> GetAll()
        {
            return _dbContext.KhachHangs.ToList();
        }

        public KhachHang GetById(string maKhachHang)
        {
            return _dbContext.KhachHangs.FirstOrDefault(kh => kh.MaKhachHang == maKhachHang);
        }

        public void Create(KhachHang khachHang)
        {
            _dbContext.KhachHangs.Add(khachHang);
            _dbContext.SaveChanges();
        }

        public void Update(KhachHang khachHang)
        {
            _dbContext.KhachHangs.Update(khachHang);
            _dbContext.SaveChanges();
        }

        public void Delete(string maKhachHang)
        {
            var khachHang = _dbContext.KhachHangs.FirstOrDefault(kh => kh.MaKhachHang == maKhachHang);
            if (khachHang != null)
            {
                _dbContext.KhachHangs.Remove(khachHang);
                _dbContext.SaveChanges();
            }
        }

        public List<KhachHang> SearchKhachHangs(string keyword)
        {
            return _dbContext.KhachHangs
                .Where(kh => kh.TenKhachHang.Contains(keyword) || kh.MaKhachHang.Contains(keyword))
                .ToList();
        }
    }
}
