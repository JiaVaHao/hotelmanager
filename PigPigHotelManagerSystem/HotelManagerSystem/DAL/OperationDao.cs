using System;
using System.Collections.Generic;
using System.Data;
using MySql.Data.MySqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelManagerSystem.Model;

namespace HotelManagerSystem.DAL
{
   public class OperationDao
    {
        public static int InsertOperationLog(OperationLog opr)
        {
            int n = 0;
            string sql = "insert into OPERATIONLOG(OperationTime,OperationLog,OperationAccount) values(@OperationTime," +
                "@OperationLog,@OperationAccount)";
            n = DBHelper.ExecuteNonQuery(sql, CommandType.Text,
                new MySqlParameter[] {
                    new MySqlParameter("@OperationTime",opr.OperationTime),
                    new MySqlParameter("@OperationLog",opr.Operationlog),
                    new MySqlParameter("@OperationAccount",opr.OperationAccount),
                });
            return n;
        }

        public static List<OperationLog> SelectOperationlogAll()
        {
            List<OperationLog> custos = new List<OperationLog>();
            string sql = "select * from operationlog";
            MySqlDataReader dr = DBHelper.ExecuteReader(sql);
            while (dr.Read())
            {
                OperationLog cso = new OperationLog();
                cso.OperationId = (int)dr["OperationId"];
                cso.OperationTime = DateTime.Parse(dr["OperationTime"].ToString());
                cso.Operationlog = dr["Operationlog"].ToString();
                cso.OperationAccount = (string)dr["OperationAccount"];
                custos.Add(cso);
            }
            dr.Close();
            DBHelper.Closecon();
            return custos;
        }
    }
}
