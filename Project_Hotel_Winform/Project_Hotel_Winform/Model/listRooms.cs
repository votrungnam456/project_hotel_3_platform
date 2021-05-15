using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Hotel_Winform.Model
{
    public class listRooms
    {
        List<Room> Data = new List<Room>();

        public List<Room> data { get => Data; set => Data = value; }
    }
}
