
using DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.IService
{
    public interface IThietBiService
    {
        public List<ThietBi> GetAllThietBi();
        public ThietBi GetByIDThietBi(string id);
        public bool AddThietBi(ThietBi thietBi);
        public bool UpdateThietBi(string id, ThietBi thietBi);
        public bool DeleteThietBi(string id);
    }
}
