
using DAL.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositoies
{
    public class DatLichRepo : IDatLich
    {

        //DBContext _contextDatLich;
        //public DatLichRepo()
        //{
        //    _contextDatLich = new();
        //}

        //public bool AddDatLich(DatLich datLich)
        //{
        //    try
        //    {
        //        _contextDatLich.DatLiches.Add(datLich);
        //        _contextDatLich.SaveChanges();
        //        return true;
        //    }
        //    catch { return false; }
        //}

        //public bool DeleteHuyLich(string huyLichId)
        //{
        //    var checkn = _contextDatLich.DatLiches.FirstOrDefault(x => x.Equals(huyLichId));
        //    if (checkn == null) return false;
        //    _contextDatLich.DatLiches.Remove(checkn);
        //    _contextDatLich.SaveChanges();
        //    return true;
        //}

        //public List<DatLich> GetAllDatLich()
        //{
        //    throw new NotImplementedException();
        //}
    }
}
