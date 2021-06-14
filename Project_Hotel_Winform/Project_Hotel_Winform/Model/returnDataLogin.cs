using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Hotel_Winform.Model
{
    public class returnDataLogin
    {
        List<userLogin> Data = new List<userLogin>();

        public List<userLogin> data { get => Data; set => Data = value; }
    }
}
