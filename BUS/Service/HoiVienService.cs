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
    public class HoiVienService
    {
        //private readonly IKhachHang _khachHangRepository;

        public HoiVienService(IKhachHang khachHangRepository)
        {
            //_khachHangRepository = khachHangRepository;
        }

        //public List<KhachHang> GetAllKhachHangs()
        //{
        //    return _khachHangRepository.GetAll();
        //}

        //public KhachHang GetKhachHangById(string maKhachHang)
        //{
        //    return _khachHangRepository.GetById(maKhachHang);
        //}

        //public void CreateKhachHang(KhachHang khachHang)
        //{
        //    _khachHangRepository.Create(khachHang);
        //}

        //public void UpdateKhachHang(KhachHang khachHang)
        //{
        //    _khachHangRepository.Update(khachHang);
        //}

        //public void DeleteKhachHang(string maKhachHang)
        //{
        //    _khachHangRepository.Delete(maKhachHang);
        //}

        //public List<KhachHang> SearchKhachHangs(string keyword)
        //{
        //    return _khachHangRepository.SearchKhachHangs(keyword);
        //}
    }
}
