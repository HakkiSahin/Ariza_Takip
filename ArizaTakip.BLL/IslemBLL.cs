using ArizaTakip.DAL;
using ArizaTakip.DTO;
using ArizaTakip.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArizaTakip.BLL
{
    public class IslemBLL
    {
        IslemDAL _islemDAL;
        ArizaDAL _arizaDAL;
        MusteriDAL _musteriDAL;
        PersonelDAL _personelDAL;
        DurumDAL _durumDAL;

        public IslemBLL()
        {
            _islemDAL = new IslemDAL();
            _arizaDAL = new ArizaDAL();
            _musteriDAL = new MusteriDAL();
            _personelDAL = new PersonelDAL();
            _durumDAL = new DurumDAL();
        }

        public bool Add(Islem islem)
        {
            islem.DurumID = 1;
            return _islemDAL.Add(islem) > 0;
        }

        public bool Update(Islem islem)
        {
            return _islemDAL.Update(islem) > 0;
        }

        public bool Delete(Islem islem)
        {
            return _islemDAL.Delete(islem.IslemNo) > 0;
        }

        public List<Islem> GetAll()
        {
            return _islemDAL.GetAll();
        }

        public Islem GetByID(int islemNo)
        {
            return _islemDAL.GetByID(islemNo);
        }

        public IslemDTO GetAllDataByID(int islemNo)
        {
            IslemDTO istenenIslem = new IslemDTO();
            istenenIslem.Islem = GetByID(islemNo);
            istenenIslem.Ariza = _arizaDAL.GetByID(istenenIslem.Islem.ArizaID);
            istenenIslem.Durum = _durumDAL.GetByID(istenenIslem.Islem.DurumID);
            istenenIslem.Musteri = _musteriDAL.GetByID(istenenIslem.Islem.MusteriID);

            return istenenIslem;
        }

        public List<IslemDTO> GetAllByPersonel(int personelID)
        {
            List<Islem> islemler = _islemDAL.GetAllByPersonel(personelID);
            List<IslemDTO> islemDetayListesi = new List<IslemDTO>();
            IslemDTO islemDetay;

            foreach (Islem item in islemler)
            {
                islemDetay = GetAllDataByID(item.IslemNo);
                islemDetayListesi.Add(islemDetay);
            }

            return islemDetayListesi;
        }
    }
}
