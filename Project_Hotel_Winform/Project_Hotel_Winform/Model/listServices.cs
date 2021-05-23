using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Hotel_Winform.Model
{
    public class listServices
    {
        List<Services> Data = new List<Services>();

        public List<Services> data { get => Data; set => Data = value; }
    }
}
