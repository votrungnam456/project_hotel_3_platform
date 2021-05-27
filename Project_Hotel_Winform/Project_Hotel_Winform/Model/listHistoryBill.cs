using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Hotel_Winform.Model
{
    public class listHistoryBill
    {
        List<historyBill> Data = new List<historyBill>();

        public List<historyBill> data { get => Data; set => Data = value; }
    }
}
