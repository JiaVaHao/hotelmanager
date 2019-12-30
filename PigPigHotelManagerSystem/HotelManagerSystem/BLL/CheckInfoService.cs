using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelManagerSystem.DAL;
using HotelManagerSystem.Model;

namespace HotelManagerSystem.BLL
{
   public class CheckInfoService
    {
        public static List<CheckInfo> SelectCheckInfoAll()
        {
            return CheckInfoDao.SelectCheckInfoAll();
        }
    }
}
