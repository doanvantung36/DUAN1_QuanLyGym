
using DAL.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Service
{
    public class PTService
    {
        //private readonly IPTRepository ptRepository;

        public PTService(IPTRepository ptRepo)
        {
            //ptRepository = ptRepo;
        }

        //public List<Pt> GetAllPTs()
        //{
        //    return ptRepository.GetAll();
        //}

        //public Pt GetPTById(string maPT)
        //{
        //    return ptRepository.GetById(maPT);
        //}

        //public void AddPT(Pt pt)
        //{
        //    ptRepository.Add(pt);
        //}

        //public void UpdatePT(Pt pt)
        //{
        //    ptRepository.Update(pt);
        //}

        //public void DeletePT(string maPT)
        //{
        //    ptRepository.Delete(maPT);
        //}
    }
}
