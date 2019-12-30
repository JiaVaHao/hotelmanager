using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagerSystem.Model
{
   public class OperationLog
    {
        public int OperationId { get; set; }
        public DateTime OperationTime { get; set; }
        public string Operationlog { get; set; }
        public string OperationAccount { get; set; }

    }
}
