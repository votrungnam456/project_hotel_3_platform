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

namespace Project_Hotel_Winform.All_User_Control
{
    public partial class CheckOut : UserControl
    {
        ConnectAPI api = new ConnectAPI();
        List<Room> listRooms = new List<Room>();
        List<Button> lstbtn = new List<Button>();
        List<Customers> lstCus = new List<Customers>();
        List<checkInRoom> listNhanPhong = new List<checkInRoom>();
        public CheckOut()
        {
            InitializeComponent();
            loadRooms();
            loadCboboxCustomers();
            string now = DateTime.Now.ToString("MM/dd/yyyy");
            dateTimeCheckOut.MinDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
            loadNhanPhong();
            
        }
        public async void loadNhanPhong()
        {
            listNhanPhong = new List<checkInRoom>();
            var returnData = api.getAPI("rooms/listCheckIn");
            var result = await Task.WhenAll(returnData);
            var data = JsonConvert.DeserializeObject<listCheckInRoom>(result[0]);
            foreach (checkInRoom item in data.data)
            {
                listNhanPhong.Add(item);
            }
            GridViewCheckInRoom.DataSource = listNhanPhong;
            GridViewCheckInRoom.Columns[0].Visible = false;
        }
        public async void loadRooms() {
            guna2Panel1.Controls.Clear();
            listRooms = new List<Room>();
            var returnData = api.getAPI("rooms/list");
            var result = await Task.WhenAll(returnData);
            var data = JsonConvert.DeserializeObject<listRooms>(result[0]);
            foreach (Room item in data.data)
            {
                listRooms.Add(item);
            }
            int j = 0;
            int count = 0;
            for (int i = 0; i < listRooms.Count; i++)
            {
                Button myButton = new Button();
                myButton.Tag = listRooms[i].MaPhong;
                myButton.Text = listRooms[i].Tenphong+ "-" +listRooms[i].TenKP;
                myButton.Height = 100;
                myButton.Width = 100;
                myButton.Left = count * 100;
                myButton.Top = 100 * j;
                if(int.Parse(listRooms[i].TinhTrang) == 1)
                {
                    myButton.BackColor = Color.Yellow;
                }
                else if(int.Parse(listRooms[i].TinhTrang) == 2)
                {
                    myButton.BackColor = Color.Red;
                }
                else
                {
                    myButton.BackColor = Color.White;
                }
                count++;
                if (i % 8 == 0 && i != 0)
                {
                    j++;
                    count = 0;
                }
                myButton.Click += myButton_Click;
                guna2Panel1.Controls.Add(myButton);
                lstbtn.Add(myButton);
            }
            //////////////////////////////////////////
            ///            
        }

        void myButton_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if(button.BackColor == Color.White)
            {
                button.BackColor = Color.SkyBlue;
            }
            else if(button.BackColor == Color.SkyBlue)
            {
                button.BackColor = Color.White;
            }    
            else if(button.BackColor == Color.Yellow)
            {
                MessageBox.Show("Phòng này đã được đặt");
            }
            else if (button.BackColor == Color.Red)
            {
                MessageBox.Show("Phòng này đang được sử dụng");
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
            string checkIn = dateTimeCheckOut.Value.ToShortDateString();
            int dayStay;
            if (txtDay.Text != "")
            {
               
                dayStay = int.Parse(txtDay.Text);
            }
            else
            {
                dayStay = 0;
            }
            string checkOut = dateTimeCheckOut.Value.AddDays(dayStay).ToShortDateString();
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
            foreach (Button btn in lstbtn)
            {
                if (btn.BackColor == Color.SkyBlue)
                {
                    string maPhong = btn.Tag.ToString();
                    //MessageBox.Show(maPhong);
                    //MessageBox.Show(checkIn);
                    //if(checkOut == null)
                    //{
                    //    MessageBox.Show("True");
                    //}
                    //MessageBox.Show(chuThich);
                    //MessageBox.Show(id_KH);
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
                    MessageBox.Show(convertData.data);
                    if (int.Parse(convertData.data) == 1)
                    {
                        check = true;
                    }
                }
            }
            if (check)
            {
                MessageBox.Show("Đặt phòng thành công");
                loadRooms();
            }
            else
            {
                MessageBox.Show("Đặt phòng thất bại");
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
            if(GridViewCheckInRoom.CurrentRow.Cells[0].Value.ToString() != null)
            {
                string MaPhong = GridViewCheckInRoom.CurrentRow.Cells[0].Value.ToString();
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
            }
            else
            {
                MessageBox.Show("Vui lòng chọn phòng để nhận");
                return;
            }
            
        }
    }
}
