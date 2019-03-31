using ArizaTakip.DAL;
using ArizaTakip.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArizaTakip.BLL
{
    public class DurumBLL
    {
        DurumDAL _durumDAL;

        public DurumBLL()
        {
            _durumDAL = new DurumDAL();
        }

        public bool Add(Durum durum)
        {
            return _durumDAL.Add(durum) > 0;
        }

        public bool Update(Durum durum)
        {
            return _durumDAL.Update(durum) > 0;
        }

        public bool Delete(Durum durum)
        {
            return _durumDAL.Delete(durum.DurumID) > 0;
        }

        public List<Durum> GetAll()
        {
            return _durumDAL.GetAll();
        }

        public Durum GetByID(int durumID)
        {
            return _durumDAL.GetByID(durumID);
        }
    }
}
