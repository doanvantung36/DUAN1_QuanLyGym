
using DAL.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositoies
{
    public class ThietBiRepo : IThietBiRepo
    {
        //DBContext _contextThietBi;
        //public ThietBiRepo()
        //{
        //    _contextThietBi = new();
        //}
        //public bool AddThietBi(ThietBi thetBi)
        //{
        //    try
        //    {
        //        _contextThietBi.ThietBis.Add(thetBi);
        //        _contextThietBi.SaveChanges();
        //        return true;

        //    }
        //    catch
        //    {
        //        return false;
        //    }
        //}

        //public bool DeleteThietBi(string id)
        //{
        //    try
        //    {
        //        var checkn = _contextThietBi.ThietBis.FirstOrDefault(x => x.MaThietBi == id);
        //        if (checkn == null) return false;
        //        _contextThietBi.ThietBis.Remove(checkn);
        //        _contextThietBi.SaveChanges();
        //        return true;
        //    }
        //    catch
        //    {
        //        return false;
        //    }
        //}

        //public List<ThietBi> GetAllThietBi()
        //{
        //    return _contextThietBi.ThietBis.ToList();
        //}

        //public ThietBi GetByIDTB(string id)
        //{
        //    return _contextThietBi.ThietBis.FirstOrDefault(x => x.MaThietBi == id);
        //}

        //public bool UpdateThietBi(string id, ThietBi thetBi)
        //{
        //    try
        //    {
        //        var checkn = _contextThietBi.ThietBis.FirstOrDefault(x => x.MaThietBi == id);
        //        if (checkn == null) return false;
        //        checkn.TenThietBi = thetBi.TenThietBi;
        //        checkn.MaThietBi = thetBi.MaThietBi;
        //        checkn.ViTri = thetBi.ViTri;
        //        checkn.Gia = thetBi.Gia;

        //        _contextThietBi.ThietBis.Update(checkn);
        //        _contextThietBi.SaveChanges();
        //        return true;

        //    }
        //    catch
        //    {
        //        return false;
        //    }
        //}
    }
}
