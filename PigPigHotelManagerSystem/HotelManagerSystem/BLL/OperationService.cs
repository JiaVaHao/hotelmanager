using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelManagerSystem.DAL;
using HotelManagerSystem.Model;

namespace HotelManagerSystem.BLL
{
    public class OperationService
    {
        public static int InsertOperationLog(OperationLog opr)
        {
            return OperationDao.InsertOperationLog(opr);
        }
        public static List<OperationLog> SelectOperationlogAll()
        {
            return OperationDao.SelectOperationlogAll();
        }
    }
}