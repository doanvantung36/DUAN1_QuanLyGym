using BUS.IService;
using DAL.DomainClass;
using DAL.Repositoies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class DatLichService : IDatLichService
    {
        DatLichRepo _datLichRepo;
        public DatLichService()
        {
            _datLichRepo = new();
        }

        public bool AddDatLich(DatLich datLich)
        {
            return _datLichRepo.AddDatLich(datLich);
        }

        public bool DeleteHuyLich(string huyLichId)
        {
            return _datLichRepo.DeleteHuyLich(huyLichId);
        }

        public object DeleteHuyLich(int idCellClick)
        {
            throw new NotImplementedException();
        }

        public List<DatLich> GetAllDatLich()
        {
            throw new NotImplementedException();
        }
    }
}
