using DAL.DomainClass;
using DAL.Interface;
using DAL.Repositoies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.IService
{
    public class HopDongService : IHopDongService
    {
        private readonly IHopDong _hopDongRepo;

        public HopDongService(IHopDong hopDongRepo)
        {
            _hopDongRepo = hopDongRepo;
        }

        public List<HopDong> GetAll()
        {
            return _hopDongRepo.GetAll();
        }

        public void Add(HopDong hopDong)
        {
            _hopDongRepo.ThemHopDong(hopDong);
        }

        public void Update(HopDong hopDong)
        {
            _hopDongRepo.CapNhatHopDong(hopDong);
        }

        public void Delete(string maHopDong)
        {
            _hopDongRepo.XoaHopDong(maHopDong);
        }

        public HopDong GetById(string maHopDong)
        {
            return _hopDongRepo.LayTheoMaHopDong(maHopDong);
        }
    }
}
