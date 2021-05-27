using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Hotel_Winform.Model
{
    public class historyBill
    {
        private string maPTT;
        private string maPDK;
        private string tenKH;
        private int tienThuePhong;
        private string tienDichVu;
        private string tongTien;
        private DateTime ngayThanhToan;
        private string iD_NV;
        private string tenNV;
        public string MaPTT { get => maPTT; set => maPTT = value; }
        public string MaPDK { get => maPDK; set => maPDK = value; }
        public string TenKH { get => tenKH; set => tenKH = value; }
        public int TienThuePhong { get => tienThuePhong; set => tienThuePhong = value; }
        public string TienDichVu { get => tienDichVu; set => tienDichVu = value; }
        public string TongTien { get => tongTien; set => tongTien = value; }
        public DateTime NgayThanhToan { get => ngayThanhToan; set => ngayThanhToan = value; }
        public string ID_NV { get => iD_NV; set => iD_NV = value; }
        public string TenNV { get => tenNV; set => tenNV = value; }
    }
}
