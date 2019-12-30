using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelManagerSystem.DAL;
using HotelManagerSystem.Model;

namespace HotelManagerSystem.DAL
{
   public class CustoTypeDao
    {
        public static List<CustoType> SelectCustoTypesAll()
        {
            List<CustoType> types = new List<CustoType>();
            string sql = "select * from usertype";
            MySqlDataReader dr = DBHelper.ExecuteReader(sql);
            while (dr.Read())
            {
                CustoType type = new CustoType();
                type.UserType = (int)dr["UserType"];
                type.TypeName = dr["TypeName"].ToString();
                types.Add(type);
            }
            dr.Close();
            DBHelper.Closecon();
            return types;
        }
    }
}
