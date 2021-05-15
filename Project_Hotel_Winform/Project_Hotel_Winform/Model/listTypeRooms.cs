using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Hotel_Winform.Model
{
    public class listTypeRooms
    {
        List<typeRoom> Data = new List<typeRoom>();

        public List<typeRoom> data { get => Data; set => Data = value; }
    }
}
