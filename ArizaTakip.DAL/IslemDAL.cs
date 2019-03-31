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
    public class IslemDAL
    {
        Helper h;

        public IslemDAL()
        {
            h = new Helper();
        }

        public int Add(Islem islem)
        {
            string query = "INSERT INTO Islem(MusteriID,PersonelID,ArizaID,DurumID) VALUES(@mus,@pers,@ariza,@durum)";
            SqlParameter mus = new SqlParameter("@mus", islem.MusteriID);
            SqlParameter pers = new SqlParameter("@pers", islem.PersonelID);
            SqlParameter ariza = new SqlParameter("@ariza", islem.ArizaID);
            SqlParameter durum = new SqlParameter("@durum", islem.DurumID);
            List<SqlParameter> sqlParams = new List<SqlParameter>() { mus, pers, ariza, durum };

            h.AddParameters(sqlParams);
            return h.ExecuteNonQuery(query);
        }

        public int Update(Islem islem)
        {
            string query = "UPDATE Islem SET MusteriID = @mus, PersonelID = @pers, ArizaID = @ariza, DurumID = @durum, VerilenTarih = @ver WHERE IslemNo = @no";
            SqlParameter no = new SqlParameter("@no", islem.IslemNo);
            SqlParameter ver = new SqlParameter("@ver", islem.VerilenTarih);
            SqlParameter mus = new SqlParameter("@mus", islem.MusteriID);
            SqlParameter pers = new SqlParameter("@pers", islem.PersonelID);
            SqlParameter ariza = new SqlParameter("@ariza", islem.ArizaID);
            SqlParameter durum = new SqlParameter("@durum", islem.DurumID);
            List<SqlParameter> sqlParams = new List<SqlParameter>() { no, ver, mus, pers, ariza, durum };

            h.AddParameters(sqlParams);
            return h.ExecuteNonQuery(query);
        }

        public int Delete(int islemNo)
        {
            string query = "DELETE FROM Islem WHERE IslemNo = @no";
            SqlParameter no = new SqlParameter("@no", islemNo);
            List<SqlParameter> sqlParams = new List<SqlParameter>() { no };

            h.AddParameters(sqlParams);
            return h.ExecuteNonQuery(query);
        }

        public List<Islem> GetAll()
        {
            List<Islem> islemler = new List<Islem>();
            string query = "SELECT * FROM Islem";
            Islem islem = null;

            foreach (DataRow item in h.ExecuteReader(query).Rows)
            {
                islem = new Islem();
                islem.IslemNo = (int)item[0];
                islem.MusteriID = (int)item[1];
                islem.PersonelID = (int)item[2];
                islem.ArizaID = (int)item[3];
                islem.DurumID = (int)item[4];
                islem.AlinanTarih = (DateTime)item[5];
                islem.VerilenTarih = (DateTime)item[6];
                islemler.Add(islem);
            }

            return islemler;
        }

        public Islem GetByID(int islemNo)
        {
            Islem islem = new Islem();
            string query = "SELECT * FROM Islem WHERE IslemNo = @no";
            SqlParameter no = new SqlParameter("@no", islemNo);
            List<SqlParameter> sqlParams = new List<SqlParameter>() { no };

            h.AddParameters(sqlParams);
            DataRow satir = h.ExecuteReader(query).Rows[0];
            islem.IslemNo = islemNo;
            islem.MusteriID = (int)satir[1];
            islem.PersonelID = (int)satir[2];
            islem.ArizaID = (int)satir[3];
            islem.DurumID = (int)satir[4];
            islem.AlinanTarih = (DateTime)satir[5];
            islem.VerilenTarih = satir[6] as DateTime?;

            return islem;
        }
        // Nullable
        public List<Islem> GetAllByPersonel(int personelID)
        {
            //Nullable<int> sayi = new Nullable<int>();
            //int? sayi = null;
            //int x = sayi.HasValue ? sayi.Value : 0;

            List<Islem> islemler = new List<Islem>();
            string query = "SELECT TOP 5 * FROM Islem WHERE PersonelID = @pID";
            SqlParameter pID = new SqlParameter("@pID", personelID);
            List<SqlParameter> sqlParams = new List<SqlParameter>() { pID };
            h.AddParameters(sqlParams);

            foreach (DataRow item in h.ExecuteReader(query).Rows)
            {
                islemler.Add(new Islem()
                {
                    ArizaID = (int)item["ArizaID"],
                    AlinanTarih = (DateTime)item["AlinanTarih"],
                    DurumID = (int)item["DurumID"],
                    IslemNo = (int)item["IslemNo"],
                    MusteriID = (int)item["MusteriID"],
                    PersonelID = personelID,
                    VerilenTarih = item["VerilenTarih"] as DateTime?
                });
            }

            return islemler;
        }
    }
}
