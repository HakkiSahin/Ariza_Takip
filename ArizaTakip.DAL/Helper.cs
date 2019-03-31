using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArizaTakip.DAL
{
    class Helper
    {
        SqlConnection conn;
        SqlCommand cmd;

        public Helper()
        {
            conn = new SqlConnection(Properties.Settings.Default.OklidTeknik);
            cmd = new SqlCommand();
            cmd.Connection = conn;
        }

        public int ExecuteNonQuery(string commandText)
        {
            cmd.CommandText = commandText;
            Open();
            int result = cmd.ExecuteNonQuery();
            Close();

            return result;
        }

        public T ExecuteScalar<T>(string commandText)
        {
            cmd.CommandText = commandText;
            Open();
            T result = (T)cmd.ExecuteScalar();
            Close();

            return result;
        }

        public DataTable ExecuteReader(string commandText)
        {
            DataTable dt = new DataTable();
            cmd.CommandText = commandText;

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);

            //SqlDataReader reader = cmd.ExecuteReader();
            //dt.Load(reader);

            return dt;
        }

        public void AddParameters(List<SqlParameter> parameters)
        {
            cmd.Parameters.Clear();
            foreach (SqlParameter item in parameters)
            {
                cmd.Parameters.Add(item);
            }
        }

        void Open()
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        void Close()
        {
            conn.Close();
        }
    }
}
