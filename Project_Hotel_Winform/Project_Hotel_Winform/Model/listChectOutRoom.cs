using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Hotel_Winform.Model
{
    public class listChectOutRoom
    {
        List<checkOutRoom> Data = new List<checkOutRoom>();

        public List<checkOutRoom> data { get => Data; set => Data = value; }
    }
}
