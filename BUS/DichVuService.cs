using DAL.DomainClass;
using DAL.Repositoies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class DichVuService
    {
        private readonly DichVuRepository dichVuRepository;

        public DichVuService(DichVuRepository dichVuRepo)
        {
            dichVuRepository = dichVuRepo;
        }

        public List<DichVu> LayDanhSachDichVu()
        {
            return dichVuRepository.GetAll();
        }

        public DichVu LayDichVuTheoMa(string maDichVu)
        {
            return dichVuRepository.GetByID(maDichVu);
        }

        public void ThemMoiDichVu(DichVu dichVu)
        {
            dichVuRepository.Add(dichVu);
        }

        public void CapNhatThongTinDichVu(DichVu dichVu)
        {
            dichVuRepository.Update(dichVu);
        }

        public void XoaDichVu(string maDichVu)
        {
            dichVuRepository.Delete(maDichVu);
        }
    }
}
