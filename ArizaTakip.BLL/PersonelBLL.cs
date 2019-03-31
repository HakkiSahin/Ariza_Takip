using ArizaTakip.DAL;
using ArizaTakip.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArizaTakip.BLL
{
    public class PersonelBLL
    {
        PersonelDAL _personelDAL;

        public PersonelBLL()
        {
            _personelDAL = new PersonelDAL();
        }

        public bool Add(Personel personel)
        {
            return _personelDAL.Add(personel) > 0;
        }

        public bool Update(Personel personel)
        {
            return _personelDAL.Update(personel) > 0;
        }

        public bool Delete(Personel personel)
        {
            return _personelDAL.Delete(personel.PersonelID) > 0;
        }

        public List<Personel> GetAll()
        {
            return _personelDAL.GetAll();
        }

        public Personel GetByID(int personelID)
        {
            return _personelDAL.GetByID(personelID);
        }

        public Personel GetByLogin(string kullaniciAdi, string sifre)
        {
            Personel personel = null;

            foreach (Personel item in GetAll())
            {
                if (item.KullaniciAdi == kullaniciAdi && item.Sifre == sifre)
                {
                    personel = item;
                    break;
                }
            }

            return personel;
        }
    }
}
