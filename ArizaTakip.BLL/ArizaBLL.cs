using ArizaTakip.DAL;
using ArizaTakip.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArizaTakip.BLL
{
    public class ArizaBLL
    {
        ArizaDAL _arizaDAL;

        public ArizaBLL()
        {
            _arizaDAL = new ArizaDAL();
        }

        public bool Add(Ariza ariza)
        {
            return _arizaDAL.Add(ariza) > 0;
        }

        public bool Update(Ariza ariza)
        {
            return _arizaDAL.Update(ariza) > 0;
        }

        public bool Delete(Ariza ariza)
        {
            return _arizaDAL.Delete(ariza.ArizaID) > 0;
        }

        public List<Ariza> GetAll()
        {
            return _arizaDAL.GetAll();
        }

        public Ariza GetByID(int arizaID)
        {
            return _arizaDAL.GetByID(arizaID);
        }
    }
}
