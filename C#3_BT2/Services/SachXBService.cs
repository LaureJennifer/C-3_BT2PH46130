using C_3_BT2.DomainClass;
using C_3_BT2.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_3_BT2.Services
{
    internal class SachXBService
    {
        SachXBRepository _sachXBRepository ;
        public SachXBService() 
        { 
            _sachXBRepository = new SachXBRepository();
        }

        public List<Nxb> Getnxbs()
        {
            return _sachXBRepository.GetNxb();
        }

        public List<Sach> GetSach(string textSearch)
        {
            return _sachXBRepository.GetSach(textSearch);
        }
        public List<Sach> GetAll()
        {
            return _sachXBRepository.GetAll();
        }
        public bool Add(Sach sach)
        {
            return _sachXBRepository.Add(sach);
        }
        public bool Delete(Guid id)
        {
            return _sachXBRepository.Delete(id);
        }
        public bool Update(Guid id,Sach sach)
        {
            return _sachXBRepository.Update(id,sach);
        }
        public bool CheckDuplic(string maSach)
        {
            return _sachXBRepository.CheckDuplicate(maSach);
        }
    }
}
