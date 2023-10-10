using Azure.Core;
using C_3_BT2.Context;
using C_3_BT2.DomainClass;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_3_BT2.Repositories
{
    internal class SachXBRepository
    {
        DBContext _dBContext;
        
        public SachXBRepository()
        {
            _dBContext = new DBContext();
        }
       
        public List<Nxb> GetNxb()
        {
            return _dBContext.Nxbs.ToList();
        }
        public List<Sach> GetAll()
        {
            return _dBContext.Saches.ToList();
        }
        public List<Sach> GetSach(string textSearch)
        {
            if (string.IsNullOrWhiteSpace(textSearch))
            {
                var listObj= _dBContext.Saches.ToList();
                return listObj;
            }
            else
            {
                var listObj =  _dBContext.Saches.Where(x => x.Ten.Contains(textSearch)).ToList();
                return listObj;
            }      
        }
        public Sach? GetById(Guid id)
        {
            var obj=_dBContext.Saches.FirstOrDefault(x=>x.Id == id);
            return obj;
        }

        public bool Add(Sach sach)
        {
            try
            {
                sach.Id = Guid.NewGuid();
                _dBContext.Add(sach);
                _dBContext.SaveChanges();

                return true;
            }
            catch (Exception )
            {
                return false;
            }
        }

        public bool Delete(Guid id) 
        {
            try
            {
                var obj = GetById(id);
                if (obj == null)
                {
                    return false;
                }
                _dBContext.Remove(obj);
                _dBContext.SaveChanges();
                return true;
            }
            catch (Exception )
            {
                return false;
            }
        }
        
        public bool Update(Guid id,Sach sach)
        {
            try
            {
                var obj = GetById(id);
                if (obj == null)
                {
                    return false;
                }
                obj.Ma=sach.Ma;
                obj.Ten=sach.Ten;
                obj.TrangThai=sach.TrangThai;
                obj.IdNxb=sach.IdNxb;

                _dBContext.Update(obj);
                _dBContext.SaveChanges() ;

                return true;
            }
            catch (Exception )
            {
                return false;
            }
        
        }
        public bool CheckDuplicate(string maSach)
        {
            var obj= _dBContext.Saches.FirstOrDefault(x=>x.Ma==maSach);
            if (obj == null)
            {
                return false;
            }
            return true;
        }
        
    }
}
