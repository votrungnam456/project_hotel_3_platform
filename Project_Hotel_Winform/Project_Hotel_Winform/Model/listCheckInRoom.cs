using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Hotel_Winform.Model
{
    public class listCheckInRoom
    {
        List<checkInRoom> Data = new List<checkInRoom>();

        public List<checkInRoom> data { get => Data; set => Data = value; }
    }
}
