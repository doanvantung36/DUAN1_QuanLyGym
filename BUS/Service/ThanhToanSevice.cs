
using DAL.DomainClass;
using DAL.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Service
{
    public class ThanhToanSevice
    {
        private readonly IThanhToan thanhToanRepository;

        public ThanhToanSevice(IThanhToan repository)
        {
            thanhToanRepository = repository;
        }

        public List<ThanhToan> LayDanhSachThanhToan()
        {
            return thanhToanRepository.LayDanhSachThanhToan();
        }

        public ThanhToan LayThongTinThanhToan(string maThanhToan)
        {
            return thanhToanRepository.LayThongTinThanhToan(maThanhToan);
        }

        public void ThemThanhToan(ThanhToan thanhToan)
        {
            thanhToanRepository.ThemThanhToan(thanhToan);
        }

        public void CapNhatThanhToan(ThanhToan thanhToan)
        {
            thanhToanRepository.CapNhatThanhToan(thanhToan);
        }

        public void XoaThanhToan(string maThanhToan)
        {
            thanhToanRepository.XoaThanhToan(maThanhToan);
        }

    }
}
