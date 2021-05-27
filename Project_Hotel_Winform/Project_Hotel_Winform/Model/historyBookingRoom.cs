using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Hotel_Winform.Model
{
    public class historyBookingRoom
    {
        string maPDK;
        string tenKH;
        string tenphong;
        int giaPhong;
        DateTime ngayden;
        DateTime ngaydi;
        string chuthich;
        
        public string MaPDK { get => maPDK; set => maPDK = value; }
        public string TenKH { get => tenKH; set => tenKH = value; }
        public string Tenphong { get => tenphong; set => tenphong = value; }
        public int GiaPhong { get => giaPhong; set => giaPhong = value; }
        public DateTime Ngayden { get => ngayden; set => ngayden = value; }
        public DateTime Ngaydi { get => ngaydi; set => ngaydi = value; }
        public string Chuthich { get => chuthich; set => chuthich = value; }
        
       
        
    }
}
