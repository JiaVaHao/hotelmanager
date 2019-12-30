using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagerSystem.Model
{
    public class SpendLog
    {
        public int SpendId { get; set; }
        public string RoomNo { get; set; }
        public string CustoNo { get; set; }
        public decimal SpendMoney { get; set; }
        public DateTime SpendTime { get; set; }
    }
}
