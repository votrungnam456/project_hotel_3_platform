using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Hotel_Winform.Model
{
    public class listHistoryService
    {
        List<historyService> Data = new List<historyService>();

        public List<historyService> data { get => Data; set => Data = value; }
    }
}
