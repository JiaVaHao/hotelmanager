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
   public class FontsDao
    {
        public List<Fonts> SelectFontAll()
        {
            List<Fonts> fonts = new List<Fonts>();
            string sql = "select * from Fonts";
            MySqlDataReader dr = DBHelper.ExecuteReader(sql);
            while (dr.Read())
            {
                Fonts font = new Fonts();
                font.FontsId = (int)dr["FontsId"];
                font.FontsMess = dr["FontsMess"].ToString();
                fonts.Add(font);
            }
            dr.Close();
            DBHelper.Closecon();
            return fonts;
        }
        
    }
}
