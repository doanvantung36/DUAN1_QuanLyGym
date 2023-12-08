using BUS.IService;

using DAL.Interface;
using DAL.Repositoies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Service
{
    public class HopDongService : IHopDongService
    {
        //private readonly IHopDong _hopDongRepo;

        public HopDongService(IHopDong hopDongRepo)
        {
            //_hopDongRepo = hopDongRepo;
        }

        //public List<HopDong> GetAll()
        //{
        //    return _hopDongRepo.GetAll();
        //}

        //public void Add(HopDong hopDong)
        //{
        //    _hopDongRepo.Create(hopDong);
        //}

        //public void Update(HopDong hopDong)
        //{
        //    _hopDongRepo.Update(hopDong);
        //}

        //public void Delete(string maHopDong)
        //{
        //    _hopDongRepo.Delete(maHopDong);
        //}

        //public HopDong GetById(string maHopDong)
        //{
        //    return _hopDongRepo.GetByMa(maHopDong);
        //}
    }
}
