
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
    public class ThanhToanRepository : IThanhToan
    {
        private readonly DBContext dbContext;

        public ThanhToanRepository(DBContext context)
        {
            dbContext = context;
        }

        public List<ThanhToan> LayDanhSachThanhToan()
        {
            return dbContext.ThanhToans.ToList();
        }

        public ThanhToan LayThongTinThanhToan(string maThanhToan)
        {
            return dbContext.ThanhToans.FirstOrDefault(t => t.MaThanhToan == maThanhToan);
        }

        public void ThemThanhToan(ThanhToan thanhToan)
        {
            dbContext.ThanhToans.Add(thanhToan);
            dbContext.SaveChanges();
        }

        public void CapNhatThanhToan(ThanhToan thanhToan)
        {
            var existingThanhToan = dbContext.ThanhToans.Find(thanhToan.MaThanhToan);
            if (existingThanhToan != null)
            {
                existingThanhToan.MaPhuongThuc = thanhToan.MaPhuongThuc;
                existingThanhToan.TrangThai = thanhToan.TrangThai;

                dbContext.SaveChanges();
            }
        }

        public void XoaThanhToan(string maThanhToan)
        {
            var thanhToanToDelete = dbContext.ThanhToans.Find(maThanhToan);
            if (thanhToanToDelete != null)
            {
                dbContext.ThanhToans.Remove(thanhToanToDelete);
                dbContext.SaveChanges();
            }
        }
    }
}
