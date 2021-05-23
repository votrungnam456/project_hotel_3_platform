using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Hotel_Winform.Model
{
    public class returnDataLogin
    {
        List<UserLogin> Data = new List<UserLogin>();

        public List<UserLogin> data { get => Data; set => Data = value; }
    }
}
