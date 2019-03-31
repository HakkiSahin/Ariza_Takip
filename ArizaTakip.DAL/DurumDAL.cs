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
    public class DurumDAL
    {
        Helper h;

        public DurumDAL()
        {
            h = new Helper();
        }

        public int Add(Durum durum)
        {
            string query = "INSERT INTO Durum(Ad) VALUES(@ad)";
            SqlParameter ad = new SqlParameter("@ad", durum.Ad);
            List<SqlParameter> sqlParams = new List<SqlParameter>() { ad };

            h.AddParameters(sqlParams);
            return h.ExecuteNonQuery(query);
        }

        public int Update(Durum durum)
        {
            string query = "UPDATE Durum SET AD = @ad WHERE DurumID = @id";
            SqlParameter id = new SqlParameter("@id", durum.DurumID);
            SqlParameter ad = new SqlParameter("@ad", durum.Ad);
            List<SqlParameter> sqlParams = new List<SqlParameter>() { ad, id };

            h.AddParameters(sqlParams);
            return h.ExecuteNonQuery(query);
        }

        public int Delete(int durumID)
        {
            string query = "DELETE FROM Durum WHERE DurumID = @id";
            SqlParameter id = new SqlParameter("@id", durumID);
            List<SqlParameter> sqlParams = new List<SqlParameter>() { id };

            h.AddParameters(sqlParams);
            return h.ExecuteNonQuery(query);
        }

        public List<Durum> GetAll()
        {
            string query = "SELECT * FROM Durum";
            List<Durum> durumlar = new List<Durum>();

            foreach (DataRow item in h.ExecuteReader(query).Rows)
            {
                durumlar.Add(new Durum() {
                    Ad = item["Ad"].ToString(),
                    DurumID = (int)item["DurumID"]
                });
            }

            return durumlar;
        }

        public Durum GetByID(int durumID)
        {
            string query = "SELECT * FROM Durum WHERE DurumID = @id";
            Durum durum = new Durum();
            SqlParameter id = new SqlParameter("@id", durumID);

            h.AddParameters(new List<SqlParameter>() { id });
            DataRow satir = h.ExecuteReader(query).Rows[0];
            durum.Ad = satir["Ad"].ToString();
            durum.DurumID = durumID;

            return durum;
        }
    }
}
