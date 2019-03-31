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
    public class ArizaDAL
    {
        Helper h;

        public ArizaDAL()
        {
            h = new Helper();
        }

        public int Add(Ariza ariza)
        {
            string query = "INSERT INTO Ariza(Tanim,Ucret) VALUES(@tanim,@ucret)";
            SqlParameter tanim = new SqlParameter("@tanim", ariza.Tanim);
            SqlParameter ucret = new SqlParameter("@ucret",ariza.Ucret);
            List<SqlParameter> sqlParams = new List<SqlParameter>() { tanim, ucret};

            h.AddParameters(sqlParams);
            return h.ExecuteNonQuery(query);
        }

        public int Update(Ariza ariza)
        {
            string query = "UPDATE Ariza SET Tanim = @tanim, Ucret = @ucret WHERE ArizaID = @id";
            SqlParameter id = new SqlParameter("@id",ariza.ArizaID);
            SqlParameter tanim = new SqlParameter("@tanim", ariza.Tanim);
            SqlParameter ucret = new SqlParameter("@ucret", ariza.Ucret);
            List<SqlParameter> sqlParams = new List<SqlParameter>() { tanim, ucret, id };

            h.AddParameters(sqlParams);
            return h.ExecuteNonQuery(query);
        }

        public int Delete(int arizaID)
        {
            string query = "DELETE FROM Ariza WHERE ArizaID = @id";
            SqlParameter id = new SqlParameter("@id",arizaID);
            List<SqlParameter> sqlParams = new List<SqlParameter>() { id };

            h.AddParameters(sqlParams);
            return h.ExecuteNonQuery(query);
        }

        public List<Ariza> GetAll()
        {
            List<Ariza> arizalar = new List<Ariza>();
            string query = "SELECT * FROM Ariza";
            Ariza ariza = null;

            foreach (DataRow item in h.ExecuteReader(query).Rows)
            {
                ariza = new Ariza();
                ariza.ArizaID = (int)item[0];
                ariza.Tanim = item[1].ToString();
                ariza.Ucret = (decimal)item[2];
                arizalar.Add(ariza);
            }

            return arizalar;
        }

        public Ariza GetByID(int arizaID)
        {
            Ariza ariza = new Ariza();
            string query = "SELECT * FROM Ariza WHERE ArizaID = @id";
            SqlParameter id = new SqlParameter("@id",arizaID);
            List<SqlParameter> sqlParams = new List<SqlParameter>() { id};

            h.AddParameters(sqlParams);
            DataRow satir = h.ExecuteReader(query).Rows[0];
            ariza.ArizaID = arizaID;
            ariza.Tanim = satir["Tanim"].ToString();
            ariza.Ucret = (decimal)satir["Ucret"];

            return ariza;
        }
    }
}
