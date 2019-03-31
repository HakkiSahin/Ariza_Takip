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
    public class MusteriDAL
    {
        Helper h;

        public MusteriDAL()
        {
            h = new Helper();
        }

        public int Add(Musteri musteri)
        {
            string query = "INSERT INTO Musteri(Ad,Soyad,Telefon) VALUES(@ad,@soyad,@tel)";
            SqlParameter ad = new SqlParameter("@ad", musteri.Ad);
            SqlParameter soyad = new SqlParameter("@soyad", musteri.Soyad);
            SqlParameter tel = new SqlParameter("@tel", musteri.Telefon);
            List<SqlParameter> sqlParams = new List<SqlParameter>() { ad, soyad, tel };

            h.AddParameters(sqlParams);
            return h.ExecuteNonQuery(query);
        }

        public int Update(Musteri musteri)
        {
            string query = "UPDATE Musteri SET Ad = @ad, Soyad = @soyad, Telefon = @tel WHERE MusteriID = @id";
            SqlParameter id = new SqlParameter("@id", musteri.MusteriID);
            SqlParameter ad = new SqlParameter("@ad", musteri.Ad);
            SqlParameter soyad = new SqlParameter("@soyad", musteri.Soyad);
            SqlParameter tel = new SqlParameter("@tel", musteri.Telefon);
            List<SqlParameter> sqlParams = new List<SqlParameter>() { ad, soyad, tel, id };

            h.AddParameters(sqlParams);
            return h.ExecuteNonQuery(query);
        }

        public int Delete(int musteriID)
        {
            string query = "DELETE FROM Musteri WHERE MusteriID = @id";
            SqlParameter id = new SqlParameter("@id", musteriID);
            List<SqlParameter> sqlParams = new List<SqlParameter>() {  id };

            h.AddParameters(sqlParams);
            return h.ExecuteNonQuery(query);
        }

        public List<Musteri> GetAll()
        {
            List<Musteri> musteriler = new List<Musteri>();
            string query = "SELECT * FROM Musteri";
            Musteri musteri = null;

            foreach (DataRow item in h.ExecuteReader(query).Rows)
            {
                musteri = new Musteri();
                musteri.MusteriID = (int)item[0];
                musteri.Ad = item[1].ToString();
                musteri.Soyad = item[2].ToString();
                musteri.Telefon = item[3].ToString();
                musteriler.Add(musteri);
            }

            return musteriler;
        }

        public Musteri GetByID(int musteriID)
        {
            Musteri musteri = new Musteri();
            string query = "SELECT * FROM Musteri WHERE MusteriID = @id";
            SqlParameter id = new SqlParameter("@id", musteriID);
            List<SqlParameter> sqlParams = new List<SqlParameter>() { id };

            h.AddParameters(sqlParams);
            DataRow satir = h.ExecuteReader(query).Rows[0];
            musteri.MusteriID = musteriID;
            musteri.Ad = satir["Ad"].ToString();
            musteri.Soyad = satir["Soyad"].ToString();
            musteri.Telefon = satir["Telefon"].ToString();

            return musteri;
        }
    }
}
