using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Project_Hotel_Winform.Model;

using System.Globalization;

namespace Project_Hotel_Winform.All_User_Control
{
    public partial class Rooms : UserControl
    {
        ConnectAPI api = new ConnectAPI();
        List<Room> listRooms = new List<Room>();
        List<Button> lstbtn = new List<Button>();
        List<Customers> lstCus = new List<Customers>();
        List<checkInRoom> listNhanPhong = new List<checkInRoom>();
        List<checkOutRoom> listTraPhong = new List<checkOutRoom>();
        List<checkOutRoom> listPhongTrong = new List<checkOutRoom>();
        List<checkOutRoom> listPhongDangSuDung = new List<checkOutRoom>();
        WordExport word = new WordExport();
        private string iD_NV;
        private string tenNV;
        public string ID_NV { get => iD_NV; set => iD_NV = value; }
        public string TenNV { get => tenNV; set => tenNV = value; }

        public Rooms()
        {
            InitializeComponent();
            disableTextBox();
            loadRooms();
            loadCboboxCustomers();
            string now = DateTime.Now.ToString("MM/dd/yyyy");
            dateTimeCheckOut.MinDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
            loadNhanPhong();
            loadTraPhong();

        }
        public Rooms(string id_nv, string tenNV)
        {
            ID_NV = id_nv;
            TenNV = tenNV;
            InitializeComponent();
            disableTextBox();
            loadRooms();
            loadCboboxCustomers();
            loadCboboxEmptyRooms();
            loadCboboxUsingRooms();
            string now = DateTime.Now.ToString("MM/dd/yyyy");
            dateTimeCheckOut.MinDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
            loadNhanPhong();
            loadTraPhong();

        }
        public void disableTextBox()
        {
            foreach (Control x in tabPage1.Controls)
            {
                if (x.GetType() == typeof(TextBox))
                {
                    x.Enabled = false;
                    MessageBox.Show("true");
                }
            }
        }
        public async void loadNhanPhong()
        {
            listNhanPhong = new List<checkInRoom>();
            var returnData = api.getAPI("rooms/listCheckIn");
            var result = await Task.WhenAll(returnData);
            var data = JsonConvert.DeserializeObject<listCheckInRoom>(result[0]);
            foreach (checkInRoom item in data.data)
            {
                item.NgayDen = DateTime.ParseExact(item.NgayDen.ToString("dd/MM/yyyy"), "dd/MM/yyyy", CultureInfo.InvariantCulture);
                listNhanPhong.Add(item);
            }

            GridViewCheckIn.DataSource = listNhanPhong;
            GridViewCheckIn.Columns[0].Visible = false;

        }
        public async void loadTraPhong()
        {
            listTraPhong = new List<checkOutRoom>();
            var returnData = api.getAPI("rooms/listCheckOut");
            var result = await Task.WhenAll(returnData);
            var data = JsonConvert.DeserializeObject<listChectOutRoom>(result[0]);
            foreach (checkOutRoom item in data.data)
            {
                listTraPhong.Add(item);
            }

            GridViewCheckOut.DataSource = listTraPhong;
            //GridViewCheckOut.Columns[0].Visible = false;
            //GridViewCheckOut.Columns[5].Visible = false;
        }
        public async void loadRooms()
        {

            flowPanelRooms.Controls.Clear();
            listRooms = new List<Room>();
            lstbtn = new List<Button>();
            var returnData = api.getAPI("rooms/list");
            var result = await Task.WhenAll(returnData);
            var data = JsonConvert.DeserializeObject<listRooms>(result[0]);
            foreach (Room item in data.data)
            {
                listRooms.Add(item);
            }

            for (int i = 0; i < listRooms.Count; i++)
            {
                Button myButton = new Button();
                myButton.Tag = listRooms[i].MaPhong;
                myButton.Text = listRooms[i].Tenphong + "-" + listRooms[i].TenKP;
                myButton.Height = 100;
                myButton.Width = 100;
                if (int.Parse(listRooms[i].TinhTrang) == 1)
                {
                    myButton.BackColor = Color.Yellow;
                }
                else if (int.Parse(listRooms[i].TinhTrang) == 2)
                {
                    myButton.BackColor = Color.Red;
                }
                else
                {
                    myButton.BackColor = Color.White;
                }
                myButton.Click += myButton_Click;
                flowPanelRooms.Controls.Add(myButton);
                lstbtn.Add(myButton);
            }
        }

        void myButton_Click(object sender, EventArgs e)
        {

            Button button = (Button)sender;
            if (checkBoxHuyDat.Checked)
            {
                if (button.BackColor == Color.Yellow)
                {
                    button.BackColor = Color.Aqua;
                }
                else if (button.BackColor == Color.Aqua)
                {
                    button.BackColor = Color.Yellow;
                }
            }
            else
            {
                if (button.BackColor == Color.White)
                {
                    button.BackColor = Color.SkyBlue;
                }
                else if (button.BackColor == Color.SkyBlue)
                {
                    button.BackColor = Color.White;
                }
                else if (button.BackColor == Color.Yellow)
                {
                    MessageBox.Show("Phòng này đã được đặt");
                }
                else if (button.BackColor == Color.Red)
                {
                    MessageBox.Show("Phòng này đang được sử dụng");
                }
            }
        }

        public async void loadCboboxCustomers()
        {
            var returnData = api.getAPI("customers/list");
            var result = await Task.WhenAll(returnData);
            var data = JsonConvert.DeserializeObject<listCustomers>(result[0]);
            foreach (Customers item in data.data)
            {
                lstCus.Add(item);
            }
            cboCustomer.DataSource = lstCus;
            cboCustomer.DisplayMember = "TenKH";
            cboCustomer.ValueMember = "ID_KH";
        }
        public async void loadCboboxUsingRooms()
        {
            listPhongDangSuDung = new List<checkOutRoom>();
            var returnData = api.getAPI("rooms/listUsingRooms");
            var result = await Task.WhenAll(returnData);
            var data = JsonConvert.DeserializeObject<listChectOutRoom>(result[0]);
            foreach (checkOutRoom item in data.data)
            {
                listPhongDangSuDung.Add(item);
            }
            cboUsingRooms.DataSource = listPhongDangSuDung;
            cboUsingRooms.DisplayMember = "Tenphong";
            cboUsingRooms.ValueMember = "Maphong";
        }
        public async void loadCboboxEmptyRooms() {
            listPhongTrong = new List<checkOutRoom>();
            var returnData = api.getAPI("rooms/listEmptyRooms");
            var result = await Task.WhenAll(returnData);
            var data = JsonConvert.DeserializeObject<listChectOutRoom>(result[0]);
            foreach (checkOutRoom item in data.data)
            {
                listPhongTrong.Add(item);
            }
            cboEmptyRooms.DataSource = listPhongTrong;
            cboEmptyRooms.DisplayMember = "Tenphong";
            cboEmptyRooms.ValueMember = "Maphong";
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private async void guna2Button1_Click(object sender, EventArgs e)
        {
            if (btnDatPhong.Tag.ToString() == "1")
            {
                string checkIn = dateTimeCheckOut.Value.AddDays(1).ToString("yyyy-MM-dd");
                int dayStay;
                if (txtDay.Text != "")
                {

                    dayStay = int.Parse(txtDay.Text);
                }
                else
                {
                    dayStay = 0;
                }
                string checkOut = dateTimeCheckOut.Value.AddDays(dayStay + 1).ToString("yyyy-MM-dd");
                string id_KH = cboCustomer.SelectedValue.ToString();

                string chuThich;
                if (txtChuThich.Text != "")
                {
                    chuThich = txtChuThich.Text;
                }
                else
                {
                    chuThich = "";
                }
                bool check = false;
                int count = 0;
                foreach (Button btn in lstbtn)
                {
                    if (btn.BackColor == Color.SkyBlue)
                    {
                        count++;
                        string maPhong = btn.Tag.ToString();
                        Dictionary<string, string> values = new Dictionary<string, string>
                    {
                        { "Maphong",maPhong},
                        { "Ngayden",checkIn},
                        { "Ngaydi",checkOut},
                        { "Chuthich",chuThich},
                        { "ID_KH",id_KH},
                    };

                        var returnData = api.postAPI("booking/create", values);
                        var result = await Task.WhenAll(returnData);
                        var convertData = JsonConvert.DeserializeObject<returnData>(result[0]);
                        if (int.Parse(convertData.data) == 1)
                        {
                            check = true;
                            btn.BackColor = Color.SkyBlue;
                        }
                        
                    }
                }
                if(count == 0)
                {
                    MessageBox.Show("Vui lòng chọn phòng để đặt");
                }
                else if (check)
                {
                    MessageBox.Show("Đặt phòng thành công");
                    loadCboboxUsingRooms();
                    loadCboboxEmptyRooms();
                    loadNhanPhong();
                    loadRooms();
                    loadTraPhong();
                }
                else
                {
                    MessageBox.Show("Đặt phòng thất bại");
                }
            }
            else if (btnDatPhong.Tag.ToString() == "0")
            {
                bool check = false;
                int count = 0;
                foreach (Button btn in lstbtn)
                {
                    if (btn.BackColor == Color.Aqua)
                    {
                        count++;
                        var returnData = api.deleteAPI("rooms/cancelBooking/" + btn.Tag.ToString());
                        var result = await Task.WhenAll(returnData);
                        var convertData = JsonConvert.DeserializeObject<returnData>(result[0]);
                        if (int.Parse(convertData.data) == 1)
                        {
                            check = true;
                            btn.BackColor = Color.White;
                        }
                    }
                }
                if(count == 0)
                {
                    MessageBox.Show("Vui lòng chọn phòng để huỷ đặt");
                }
                else if (!check)
                {
                    MessageBox.Show("Có lỗi vui lòng thử lại");
                }
                else
                {
                    MessageBox.Show("Huỷ đặt phòng thành công");
                    loadNhanPhong();
                    loadRooms();
                    loadTraPhong();
                    loadCboboxUsingRooms();
                    loadCboboxEmptyRooms();
                }
            }
        }
   

        private void txtDay_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void GridViewNhanPhong_Paint(object sender, PaintEventArgs e)
        {

        }

        private async void txtNhanPhong_Click(object sender, EventArgs e)
        {
            if (GridViewCheckIn.CurrentRow.Cells[0].Value.ToString() != null)
            {
                string MaPhong = GridViewCheckIn.CurrentRow.Cells[0].Value.ToString();
                Dictionary<string, string> values = new Dictionary<string, string>
                {
                    {"MaPhong",MaPhong }
                };
                var returnData = api.putAPI("rooms/checkIn/" + MaPhong, values);
                var result = await Task.WhenAll(returnData);
                var convertData = JsonConvert.DeserializeObject<returnData>(result[0]);
                if (int.Parse(convertData.data) == 0)
                {
                    MessageBox.Show("Mã phòng không tồn tại");
                }
                else if (int.Parse(convertData.data) == 1)
                {
                    MessageBox.Show("Nhận phòng thành công");
                }
                loadNhanPhong();
                loadRooms();
                loadTraPhong();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn phòng để nhận");
                return;
            }

        }

        private void guna2TextBox4_TextChanged(object sender, EventArgs e)
        {
            //(GridViewCheckInRoom.DataSource as DataTable).DefaultView.RowFilter = string.Format("TenPhong = '{0}'", guna2TextBox4.Text);
        }

        private void GridViewCheckInRoom_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string phong = GridViewCheckIn.CurrentRow.Cells[1].Value.ToString();
            string KieuPhong = GridViewCheckIn.CurrentRow.Cells[3].Value.ToString();
            string TenKH = GridViewCheckIn.CurrentRow.Cells[4].Value.ToString();
            string price = GridViewCheckIn.CurrentRow.Cells[2].Value.ToString();
            string email = GridViewCheckIn.CurrentRow.Cells[6].Value.ToString();
            string CMND = GridViewCheckIn.CurrentRow.Cells[5].Value.ToString();
            string SoDT = GridViewCheckIn.CurrentRow.Cells[7].Value.ToString();
            txtPhong.Text = phong;
            txtName.Text = TenKH;
            txtLoaiPhong.Text = KieuPhong;
            txtGia.Text = price;
            txtSDT.Text = SoDT;
            txtCMND.Text = CMND;
            txtEmail.Text = email;
        }

        private void guna2DataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void GridViewCheckOut_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (GridViewCheckOut.CurrentRow.Cells[0].Value.ToString() == null)
            {
                txtPhongCheckOut.Text = "";
                txtKieuPhongCheckOut.Text = "";
                txtTenKHCheckOut.Text = "";
                txtCMNDCheckOut.Text = "";
            }
            else
            {
                string phong = GridViewCheckOut.CurrentRow.Cells[1].Value.ToString();
                string KieuPhong = GridViewCheckOut.CurrentRow.Cells[2].Value.ToString();
                string TenKH = GridViewCheckOut.CurrentRow.Cells[3].Value.ToString();
                string cmnd = GridViewCheckOut.CurrentRow.Cells[4].Value.ToString();
                txtPhongCheckOut.Text = phong;
                txtKieuPhongCheckOut.Text = KieuPhong;
                txtTenKHCheckOut.Text = TenKH;
                txtCMNDCheckOut.Text = cmnd;
            }
        }

        private async void guna2Button2_Click(object sender, EventArgs e)
        {
            if (GridViewCheckOut.CurrentRow.Cells[0].Value.ToString() != null)
            {
                string maPhong = GridViewCheckOut.CurrentRow.Cells[0].Value.ToString();
                string phieuDangKy = GridViewCheckOut.CurrentRow.Cells[5].Value.ToString();
                string tenKH = GridViewCheckOut.CurrentRow.Cells[3].Value.ToString();
                string tenPhong = GridViewCheckOut.CurrentRow.Cells[1].Value.ToString();
                Dictionary<string, string> values = new Dictionary<string, string>
                {
                    {"MaPhong",maPhong},
                    {"MaPDK",phieuDangKy},
                    {"ID_NV",ID_NV}
                };
                var returnData = api.postAPI("paying/createPaying", values);
                var result = await Task.WhenAll(returnData);
                var convertData = JsonConvert.DeserializeObject<listHistoryBill>(result[0]);           
                if (convertData.data[0].MaPTT.ToString().Equals("-1"))
                {
                    MessageBox.Show("Lỗi trong quá trình xử lý, vui lòng thử lại !!");
                }
                else
                {
                    MessageBox.Show("Trả phòng thành công !! Nhấn OK để bắt đầu in hoá đơn");
                    DialogResult dialogResult = MessageBox.Show("Bạn có muốn in hoá đơn ??", "In hoá dơn", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        string tienPhong = convertData.data[0].TienThuePhong.ToString();
                        string tienDV = convertData.data[0].TienDichVu.ToString();
                        string tongTien = convertData.data[0].TongTien.ToString();
                        string ngayLap = convertData.data[0].NgayThanhToan.ToString();
                        word.InHoaDon(ngayLap, TenNV, tenKH, tenPhong, tienPhong, tienDV, tongTien);
                    }
                }
                loadCboboxUsingRooms();
                loadCboboxEmptyRooms();
                loadNhanPhong();
                loadRooms();
                loadTraPhong();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn phòng để trả");
                return;
            }
        }

        private async void btnSearchCheckIn_Click(object sender, EventArgs e)
        {
            try
            {
                listNhanPhong = new List<checkInRoom>();
                GridViewCheckIn.Columns.Clear();
                if (txtSearchCheckIn.Text.Trim() == "")
                {
                    loadNhanPhong();
                }
                else
                {
                    string filter = txtSearchCheckIn.Text.Trim();
                    var returnData = api.getAPI("rooms/listCheckIn/search/" + filter);
                    var result = await Task.WhenAll(returnData);
                    var data = JsonConvert.DeserializeObject<listCheckInRoom>(result[0]);
                    foreach (checkInRoom item in data.data)
                    {
                        if (item.MaPhong.Equals("-1"))
                        {
                            MessageBox.Show("Không tìm thấy khách hàng nào đã đặt phòng");
                            loadNhanPhong();
                            return;
                        }
                        item.NgayDen = DateTime.ParseExact(item.NgayDen.ToString("dd/MM/yyyy"), "dd/MM/yyyy", CultureInfo.InvariantCulture);
                        listNhanPhong.Add(item);
                    }
                    GridViewCheckIn.DataSource = listNhanPhong;
                    GridViewCheckIn.Columns[0].Visible = false;
                }
            }
            catch
            {
                MessageBox.Show("Lỗi tìm kiếm");
                loadNhanPhong();
            }

        }

        private async void btnSearchCheckOut_Click(object sender, EventArgs e)
        {
            try
            {
                listTraPhong = new List<checkOutRoom>();
                GridViewCheckIn.Columns.Clear();
                if (txtSearchCheckOut.Text.Trim() == "")
                {
                    loadTraPhong();
                    
                }
                else
                {
                    string filter = txtSearchCheckOut.Text.Trim();
                    var returnData = api.getAPI("rooms/listCheckOut/search/" + filter);
                    var result = await Task.WhenAll(returnData);
                    var data = JsonConvert.DeserializeObject<listChectOutRoom>(result[0]);
                    foreach (checkOutRoom item in data.data)
                    {
                        if (item.MaPhong.Equals("-1"))
                        {
                            MessageBox.Show("Không tìm thấy khách hàng nào đang sử dụng phòng");
                            loadTraPhong();
                            return;
                        }
                        
                        listTraPhong.Add(item);
                    }
                    GridViewCheckOut.DataSource = listTraPhong;
                    GridViewCheckOut.Columns[0].Visible = false;
                }
            }
            catch
            {
                MessageBox.Show("Lỗi tìm kiếm");
                loadTraPhong();
            }
        }

        private void checkBoxHuyDat_Click(object sender, EventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender;
            if(checkBox.Checked)
            {
                foreach (Button button in lstbtn)
                {
                    if (button.BackColor == Color.SkyBlue)
                    {
                        button.BackColor = Color.White;
                    }
                }
                btnDatPhong.Text = "Huỷ đặt phòng";
                btnDatPhong.Tag = 0;
            }
            else
            {
                foreach(Button button in lstbtn)
                {
                    if(button.BackColor == Color.Aqua)
                    {
                        button.BackColor = Color.Yellow;
                    }
                }
                btnDatPhong.Text = "Đặt phòng";
                btnDatPhong.Tag = 1;
            }
        }

        private async void guna2Button1_Click_1(object sender, EventArgs e)
        {
            string maPhongDoi = cboUsingRooms.SelectedValue.ToString();
            string maPhongBiDoi = cboEmptyRooms.SelectedValue.ToString();
            Dictionary<string, string> values = new Dictionary<string, string>
                {
                    {"MaPhongDoi",maPhongDoi },
                    {"MaPhongBiDoi",maPhongBiDoi }
                };
            var returnData = api.postAPI("rooms/changeRooms", values);
            var result = await Task.WhenAll(returnData);
            var convertData = JsonConvert.DeserializeObject<returnData>(result[0]);
            if (int.Parse(convertData.data) == 0)
            {
                MessageBox.Show("Có lỗi vui lòng thử lại !!");
            }
            else if (int.Parse(convertData.data) == 1)
            {
                MessageBox.Show("Đổi phòng thành công");
            }
            loadCboboxUsingRooms();
            loadCboboxEmptyRooms();
            loadNhanPhong();
            loadTraPhong();
            loadRooms();
        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }
    }
}
