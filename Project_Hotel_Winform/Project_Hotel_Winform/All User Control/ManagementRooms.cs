using Newtonsoft.Json;
using Project_Hotel_Winform.Model;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Project_Hotel_Winform.All_User_Control
{
    public partial class ManagementRooms : UserControl
    {
        ConnectAPI api = new ConnectAPI();
        List<Room> listRooms = new List<Room>();
        List<typeRoom> listTypeRooms = new List<typeRoom>();
        public ManagementRooms()
        {
            InitializeComponent();
            loadRooms();
            loadComboBoxTypeRooms();
            txtTrangThai.Enabled = false;
        }

        public async void loadRooms()
        {
            listRooms = new List<Room>();
            var returnData = api.getAPI("rooms/list");
            var result = await Task.WhenAll(returnData);
            var data = JsonConvert.DeserializeObject<listRooms>(result[0]);
            foreach (Room item in data.data)
            {
                listRooms.Add(item);
            }
            for (int i = 0; i < listRooms.Count; i++)
            {
                if (int.Parse(listRooms[i].TinhTrang) == 0)
                {
                    listRooms[i].TinhTrang = "Trống";
                }
                else if (int.Parse(listRooms[i].TinhTrang) == 1)
                {
                    listRooms[i].TinhTrang = "Đã đặt";
                }
                else if (int.Parse(listRooms[i].TinhTrang) == 2)
                {
                    listRooms[i].TinhTrang = "Đang sử dụng";
                }
            }
            GridViewRooms.DataSource = listRooms;
            GridViewRooms.Columns[5].Visible = false;
        }
        public async void loadComboBoxTypeRooms()
        {
            var returnData = api.getAPI("rooms/typeRooms");
            var result = await Task.WhenAll(returnData);
            var data = JsonConvert.DeserializeObject<listTypeRooms>(result[0]);
            foreach (typeRoom item in data.data)
            {
                listTypeRooms.Add(item);
            }
            cboLoaiPhong.DataSource = listTypeRooms;
            cboLoaiPhong.DisplayMember = "TenKP";
            cboLoaiPhong.ValueMember = "MaKP";

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private async void guna2Button1_Click(object sender, EventArgs e)
        {
            if (txtMaPhong.Text == "" || txtMaPhong.Text == "" || txtMaPhong.Text == "" || txtMaPhong.Text == "" || txtMaPhong.Text == "")
            {
                MessageBox.Show("Thông tin phòng không được để trống");
                return;
            }
            string maPhong = txtMaPhong.Text;
            string tenPhong = txtTenPhong.Text;
            string loaiPhong = cboLoaiPhong.SelectedValue.ToString();
            string gia = txtPrice.Text;
            string moTa = txtDescription.Text;
            Dictionary<string, string> values = new Dictionary<string, string>
            {
                { "MaPhong",maPhong},
                { "Tenphong",tenPhong},
                { "MaKP",loaiPhong},
                { "Gia",gia},
                { "Mota",moTa}
            };
            var returnData = api.postAPI("rooms/create", values);
            var result = await Task.WhenAll(returnData);
            var convertData = JsonConvert.DeserializeObject<returnData>(result[0]);
            if (int.Parse(convertData.data) == 0)
            {
                MessageBox.Show("Mã phòng đã tồn tại");
            }
            else if (int.Parse(convertData.data) == 1)
            {
                MessageBox.Show("Thêm thành công");
            }
            loadRooms();
        }

        private void GridViewRooms_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string id = GridViewRooms.CurrentRow.Cells[0].Value.ToString();
            string name = GridViewRooms.CurrentRow.Cells[1].Value.ToString();
            string type = GridViewRooms.CurrentRow.Cells[5].Value.ToString();
            string price = GridViewRooms.CurrentRow.Cells[3].Value.ToString();
            string description = GridViewRooms.CurrentRow.Cells[2].Value.ToString();
            string status = GridViewRooms.CurrentRow.Cells[6].Value.ToString();
            txtMaPhong.Text = id;
            txtTenPhong.Text = name;
            txtPrice.Text = price;
            txtDescription.Text = description;
            cboLoaiPhong.SelectedValue = type;
            txtTrangThai.Text = status;
        }

        private void cboLoaiPhong_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private async void guna2Button2_Click(object sender, EventArgs e)
        {
            if (txtMaPhong.Text == "" || txtMaPhong.Text == "" || txtMaPhong.Text == "" || txtMaPhong.Text == "" || txtMaPhong.Text == "")
            {
                MessageBox.Show("Thông tin phòng không được để trống");
            }
            string maPhong = txtMaPhong.Text;
            string tenPhong = txtTenPhong.Text;
            string loaiPhong = cboLoaiPhong.SelectedValue.ToString();
            string gia = txtPrice.Text;
            string moTa = txtDescription.Text;
            string status;
            if (txtTrangThai.Text.Equals("Trống"))
            {
                status = "0";
            }
            else if(txtTrangThai.Text.Equals("Đã đặt"))
            {
                status = "1";
            }
            else
            {
                status = "2";
            }
            Dictionary<string, string> values = new Dictionary<string, string>
            {
                { "Tenphong",tenPhong},
                { "MaKP",loaiPhong},
                { "Gia",gia},
                { "Mota",moTa},
                { "TinhTrang",status}
            };
            var returnData = api.putAPI("rooms/"+maPhong, values);
            var result = await Task.WhenAll(returnData);
            var convertData = JsonConvert.DeserializeObject<returnData>(result[0]);
            if (int.Parse(convertData.data) == 0)
            {
                MessageBox.Show("Mã phòng không tồn tại");
            }
            else if (int.Parse(convertData.data) == 1)
            {
                MessageBox.Show("Update thông tin phòng thành công");
            }
            loadRooms();
        }

        private void txtTrangThai_TextChanged(object sender, EventArgs e)
        {

        }

        private void GridViewRooms_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
