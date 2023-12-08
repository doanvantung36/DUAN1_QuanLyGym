
using DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.IService
{
    public interface IDatLichService
    {
        public List<DatLich> GetAllDatLich();
        public bool AddDatLich(DatLich datLich);
        public bool DeleteHuyLich(string huyLichId);
    }
}
