using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelManagerSystem.Model;

namespace HotelManagerSystem.DAL
{
   public class CheckInfoDao
    {
        public static List<CheckInfo> SelectCheckInfoAll()
        {
            List<CheckInfo> cif = new List<CheckInfo>();
            string sql = "select * from CHECKINFO";
            MySqlDataReader dr = DBHelper.ExecuteReader(sql);
            while (dr.Read())
            {
                CheckInfo ci = new CheckInfo();
                ci.CheckNo = (string)dr["CheckNo"];
                ci.CheckClub = dr["CheckClub"].ToString();
                ci.CheckProgres = (string)dr["CheckProgres"];
                ci.CheckCash = Convert.ToString(dr["CheckCash"]);
                ci.CheckScore = (int)dr["CheckScore"];
                ci.CheckPerson = dr["CheckPerson"].ToString();
                ci.CheckAdvice = dr["CheckAdvice"].ToString();
                cif.Add(ci);
            }
            dr.Close();
            DBHelper.Closecon();
            return cif;
        }
    }
}
