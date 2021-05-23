using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Hotel_Winform.Model
{
    public class UserLogin
    {
        public string ID_NV { get; set; }
        public string TenNV { get; set; }
        public int CoQuyen { get; set; }
        public string Quyen { get; set; }

        public int checkError { get; set; }

    }
}
