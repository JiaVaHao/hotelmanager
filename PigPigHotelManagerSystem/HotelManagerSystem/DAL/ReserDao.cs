using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelManagerSystem.Model;

namespace HotelManagerSystem.DAL
{
   public class ReserDao
    {
        public static List<Reser> SelectReserAll()
        {
            List<Reser> rss = new List<Reser>();
            string sql = "select * from reser";
            MySqlDataReader dr = DBHelper.ExecuteReader(sql);
            while (dr.Read())
            {
                Reser rs = new Reser();
                rs.ReserId = (string)dr["ReserId"];
                rs.CustoName = (string)dr["CustoName"];
                rs.CustoTel = (string)dr["CustoTel"];
                rs.ReserWay = (string)dr["ReserWay"];
                rs.ReserRoom = (string)dr["ReserRoom"];
                rs.ReserCash = (decimal)dr["ReserCash"];
                rs.ReserDate = (DateTime)dr["ReserDate"];
                rs.ReserPerson = (int)dr["ReserPerson"];     
                rss.Add(rs);
            }
            dr.Close();
            DBHelper.Closecon();
            return rss;
        }

        public static List<Reser> SelectReserInfoByConn(string tel)
        {
            List<Reser> tis = new List<Reser>();
            string sql = "select * from reser where CustoTel = '" + tel + "'";
            MySqlDataReader dr = DBHelper.ExecuteReader(sql);
            while (dr.Read())
            {
                Reser ti = new Reser();
                ti.ReserId = (string)dr["ReserId"];
                ti.CustoName = (string)dr["CustoName"];
                ti.CustoTel = (string)dr["CustoTel"];
                ti.ReserWay = (string)dr["ReserWay"];
                ti.ReserRoom = (string)dr["ReserRoom"];
                ti.ReserCash = (decimal)dr["ReserCash"];
                ti.ReserDate = DateTime.Parse(dr["ReserDate"].ToString());
                ti.ReserPerson = (int)dr["ReserPerson"];
                tis.Add(ti);
            }
            dr.Close();
            DBHelper.Closecon();
            return tis;
        }
    }
}
