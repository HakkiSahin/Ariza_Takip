using ArizaTakip.DAL;
using ArizaTakip.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArizaTakip.BLL
{
    public class MusteriBLL
    {
        MusteriDAL _musteriDAL;

        public MusteriBLL()
        {
            _musteriDAL = new MusteriDAL();
        }

        public bool Add(Musteri musteri)
        {
            return _musteriDAL.Add(musteri) > 0;
        }

        public bool Update(Musteri musteri)
        {
            return _musteriDAL.Update(musteri) > 0;
        }

        public bool Delete(Musteri musteri)
        {
            return _musteriDAL.Delete(musteri.MusteriID) > 0;
        }

        public List<Musteri> GetAll()
        {
            return _musteriDAL.GetAll();
        }

        public Musteri GetByID(int musteriID)
        {
            return _musteriDAL.GetByID(musteriID);
        }
    }
}
