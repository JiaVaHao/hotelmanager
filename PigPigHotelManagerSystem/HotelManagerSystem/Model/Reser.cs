using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagerSystem.Model
{
   public class Reser
    {
        public string ReserId { get; set; }
        public string CustoName { get; set; }
        public string CustoTel { get; set; }
        public string ReserWay { get; set; }
        public string ReserRoom { get; set; }
        public decimal ReserCash { get; set; }
        public DateTime ReserDate { get; set; }
        public int ReserPerson { get; set; }
    }
}
