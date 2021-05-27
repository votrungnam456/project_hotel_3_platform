using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Hotel_Winform.Model
{
    public class historyService
    {
        private string iDHDDV;
        private string tenDV;
        private string tenKH;
        private DateTime ngayLap;
        private int giaDichVu;

        public string IDHDDV { get => iDHDDV; set => iDHDDV = value; }
        public string TenDV { get => tenDV; set => tenDV = value; }
        public string TenKH { get => tenKH; set => tenKH = value; }
        public DateTime NgayLap { get => ngayLap; set => ngayLap = value; }
        public int GiaDichVu { get => giaDichVu; set => giaDichVu = value; }
    }
}
