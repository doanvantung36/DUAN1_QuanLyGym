using DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interface
{
    public interface IThietBiRepo
    {
        public List<ThietBi> GetAllThietBi();
        public ThietBi GetByIDTB(string id);
        public bool AddThietBi(ThietBi thetBi);
        public bool DeleteThietBi(string id);
        public bool UpdateThietBi(string id, ThietBi thetBi);
    }
}
