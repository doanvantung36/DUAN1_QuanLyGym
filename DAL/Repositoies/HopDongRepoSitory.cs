
using DAL.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositoies
{
    public class HopDongRepoSitory : IHopDong
    {
        //private readonly DBContext _dbContext;

        //public HopDongRepoSitory(DBContext dbContext)
        //{
        //    _dbContext = dbContext;
        //}

        //public List<HopDong> GetAll()
        //{
        //    return _dbContext.HopDongs.ToList();
        //}

        //public HopDong GetByMa(string maHopDong)
        //{
        //    return _dbContext.HopDongs.FirstOrDefault(hd => hd.MaHopDong == maHopDong);
        //}

        //public void Create(HopDong hopDong)
        //{
        //    _dbContext.HopDongs.Add(hopDong);
        //    _dbContext.SaveChanges();
        //}

        //public void Update(HopDong hopDong)
        //{
        //    _dbContext.HopDongs.Update(hopDong);
        //    _dbContext.SaveChanges();
        //}

        //public void Delete(string maHopDong)
        //{
        //    var hopDong = _dbContext.HopDongs.FirstOrDefault(hd => hd.MaHopDong == maHopDong);
        //    if (hopDong != null)
        //    {
        //        _dbContext.HopDongs.Remove(hopDong);
        //        _dbContext.SaveChanges();
        //    }
        //}
        //public List<HopDong> Search(string keyword)
        //{
        //    return _dbContext.HopDongs
        //        .Where(hd => hd.MaHopDong.Contains(keyword) || hd.MaKhachHang.Contains(keyword))
        //        .ToList();
        //}
    }
}
