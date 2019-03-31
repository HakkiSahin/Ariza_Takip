using ArizaTakip.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArizaTakip.DAL
{
    public class PersonelDAL
    {
        Helper h;

        public PersonelDAL()
        {
            h = new Helper();
        }

        public int Add(Personel personel)
        {
            string query = "INSERT INTO Personel(Ad,Soyad,KullaniciAdi,Sifre) VALUES(@ad,@soyad,@kAdi,@sifre)";
            SqlParameter ad = new SqlParameter("@ad",personel.Ad);
            SqlParameter soyad = new SqlParameter("@soyad",personel.Soyad);
            SqlParameter kAdi = new SqlParameter("@kAdi",personel.KullaniciAdi);
            SqlParameter sifre = new SqlParameter("@sifre",personel.Sifre);
            List<SqlParameter> sqlParams = new List<SqlParameter>() { ad, soyad, kAdi,sifre };

            h.AddParameters(sqlParams);
            return h.ExecuteNonQuery(query);
        }

        public int Update(Personel personel)
        {
            string query = "UPDATE Personel SET Ad = @ad, Soyad = @soyad, KullaniciAdi = @kAdi, Sifre = @sifre WHERE PersonelID = @id";
            SqlParameter id = new SqlParameter("@id", personel.PersonelID);
            SqlParameter ad = new SqlParameter("@ad", personel.Ad);
            SqlParameter soyad = new SqlParameter("@soyad", personel.Soyad);
            SqlParameter kAdi = new SqlParameter("@kAdi", personel.KullaniciAdi);
            SqlParameter sifre = new SqlParameter("@sifre", personel.Sifre);
            List<SqlParameter> sqlParams = new List<SqlParameter>() { id, ad, soyad, kAdi, sifre };

            h.AddParameters(sqlParams);
            return h.ExecuteNonQuery(query);
        }

        public int Delete(int personelID)
        {
            string query = "DELETE FROM Personel WHERE PersonelID = @id";
            SqlParameter id = new SqlParameter("@id", personelID);
            List<SqlParameter> sqlParams = new List<SqlParameter>() { id };

            h.AddParameters(sqlParams);
            return h.ExecuteNonQuery(query);
        }

        public List<Personel> GetAll()
        {
            List<Personel> personeller = new List<Personel>();
            string query = "SELECT * FROM Personel";
            Personel personel = null;

            foreach (DataRow item in h.ExecuteReader(query).Rows)
            {
                personel = new Personel();
                personel.PersonelID = (int)item[0];
                personel.Ad = item[1].ToString();
                personel.Soyad = item[2].ToString();
                personel.KullaniciAdi = item[3].ToString();
                personel.Sifre = item[4].ToString();
                personeller.Add(personel);
            }

            return personeller;
        }

        public Personel GetByID(int personelID)
        {
            Personel personel = new Personel();
            string query = "SELECT * FROM Personel WHERE PersonelID = @id";
            SqlParameter id = new SqlParameter("@id", personelID);
            List<SqlParameter> sqlParams = new List<SqlParameter>() { id };

            h.AddParameters(sqlParams);
            DataRow satir = h.ExecuteReader(query).Rows[0];
            personel.PersonelID = personelID;
            personel.Ad = satir["Ad"].ToString();
            personel.Soyad = satir["Soyad"].ToString();
            personel.KullaniciAdi = satir["KullaniciAdi"].ToString();
            personel.Sifre = satir["Sifre"].ToString();

            return personel;
        }
    }
}
