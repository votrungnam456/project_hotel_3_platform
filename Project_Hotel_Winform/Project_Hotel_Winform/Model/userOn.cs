using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Hotel_Winform.Model
{
    public class userOn
    {

        private string nameUserLogin;
        private string quyen;
        private string iD_NV;
        private int coQuyen;
        public string NameUserLogin { get => nameUserLogin; set => nameUserLogin = value; }
        public string Quyen { get => quyen; set => quyen = value; }
        public string ID_NV { get => iD_NV; set => iD_NV = value; }
        public int CoQuyen { get => coQuyen; set => coQuyen = value; }

        public userOn(string NameUser, string Quyen, string ID_NV, int CoQuyen)
        {
            NameUserLogin = NameUser;
            this.Quyen = Quyen;
            this.ID_NV = ID_NV;
            this.CoQuyen = CoQuyen;
        }
        public userOn()
        {
            
        }
    }
}
