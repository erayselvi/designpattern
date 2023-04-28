using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace ReservationSystem
{
    class DataBase
    {
        //Data Source = DESKTOP - 1SGNBLK\SQL;Initial Catalog = tasarimimari; User ID = sa; Password=password1
        private static string SQLConnectionString = @"Data Source=DESKTOP-1SGNBLK\SQL;Initial Catalog=tasarimimari;User ID=sa;Password=password1";
        private static SqlConnection con = new SqlConnection();
        private static SqlDataAdapter da = new SqlDataAdapter();
        private static SqlCommand com = new SqlCommand();


        public void Baglanti()
        {
            con = new SqlConnection(SQLConnectionString);
            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
        }

        public object KomutExecuteScalar(string query)
        {
            Baglanti();
            object obj;
            com.Connection = con; // SqlCommand
            com.CommandText = query; // SqlCommand
            obj = com.ExecuteScalar();
            return obj;
        }
        //public static object KomutExecuteNonQuery(string query)
        //{
        //    object obj;
        //    com.Connection = con; // SqlCommand
        //    com.CommandText = query; // SqlCommand
        //    obj = com.ExecuteScalar();
        //    return obj;
        //}
        //public static object KomutExecuteReader(string query)
        //{
        //    object obj;
        //    com.Connection = con; // SqlCommand
        //    com.CommandText = query; // SqlCommand
        //    obj = com.ExecuteScalar();
        //    return obj;
        //}
        public DataTable Table(string query)
        {
            Baglanti();
            DataTable dt = new DataTable();
            com.Connection = con; // SqlCommand
            com.CommandText = query; // SqlCommand
            da.SelectCommand = com; // // SqlCommand'ın bir select sorgusu olduğunu belirtiyoruz.
            da.Fill(dt);
            return dt;
        }
    }
}
