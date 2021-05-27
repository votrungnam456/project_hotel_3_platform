using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Hotel_Winform.Model
{
    public class listHistoryBookingRoom
    {
        List<historyBookingRoom> Data = new List<historyBookingRoom>();

        public List<historyBookingRoom> data { get => Data; set => Data = value; }
    }
}
