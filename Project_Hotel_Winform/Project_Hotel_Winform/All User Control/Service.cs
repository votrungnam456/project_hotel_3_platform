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
    public partial class Service : UserControl
    {
        private userOn user = new userOn();
        List<Services> lstServices;
        ConnectAPI api = new ConnectAPI();
        List<checkOutRoom> lstCheckOutRoom;
        List<Button> listButtons;
        public Service()
        {
            InitializeComponent();
            loadService();
            loadRooms();
        }
        public Service(userOn user)
        {
            this.user = user;
            InitializeComponent();
            loadService();
            loadRooms();
            phanQuyen();
        }

        public void phanQuyen()
        {
            foreach(Control control in tabControl1.Controls)
            {
                if (!control.Tag.ToString().Contains(user.CoQuyen.ToString()))
                {
                    control.Enabled = false;
                }
                //MessageBox.Show(control.ToString());
            }
            
        }
        public async void loadService()
        {
            lstServices = new List<Services>();
            var returnData = api.getAPI("service/list");
            var result = await Task.WhenAll(returnData);
            var data = JsonConvert.DeserializeObject<listServices>(result[0]);
            foreach (Services item in data.data)
            {
                lstServices.Add(item);
            }
            listBoxService.DataSource = lstServices;
            listBoxService.DisplayMember = "TenDV";
            listBoxService.ValueMember = "ID_DV";
            GridViewDichVu.DataSource = lstServices;
            GridViewDichVu.Columns[0].Visible = false;
        }

        public async void loadRooms()
        {
            listButtons = new List<Button>();
            flowPanelRoomsUsing.Controls.Clear();
            //lstCheckOutRoom = new List<checkOutRoom>();
            var returnData = api.getAPI("rooms/listCheckout");
            var result = await Task.WhenAll(returnData);
            var data = JsonConvert.DeserializeObject<listChectOutRoom>(result[0]);
            foreach (checkOutRoom item in data.data)
            {
                Button button = new Button();
                button.BackColor = Color.White;
                button.Tag = item.MaPDK;
                button.Text = item.Tenphong;
                button.Height = 100;
                button.Width = 100;
                button.Click += Button_Click;
                listButtons.Add(button);
                flowPanelRoomsUsing.Controls.Add(button);
                //lstCheckOutRoom.Add(item);
            }
            //cboRoom.DataSource = lstCheckOutRoom;
            //cboRoom.DisplayMember = "Tenphong";
            //cboRoom.ValueMember = "MaPDK";
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (button.BackColor == Color.White)
            {
                button.BackColor = Color.SkyBlue;
            }
            else if (button.BackColor == Color.SkyBlue)
            {
                button.BackColor = Color.White;
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void txtSDT_TextChanged(object sender, EventArgs e)
        {

        }

        private async void btnThemDichVu_Click(object sender, EventArgs e)
        {
            if (txtNameService.Text == "" || txtPriceService.Text == "")
            {
                MessageBox.Show("Thông tin dịch vụ không được để trống");
                return;
            }
            string tenDV = txtNameService.Text;
            string Gia = txtPriceService.Text;
            Dictionary<string, string> values = new Dictionary<string, string>
            {
                { "TenDV",tenDV},
                { "Gia",Gia},
            };
            var returnData = api.postAPI("service/create", values);
            var result = await Task.WhenAll(returnData);
            MessageBox.Show(result.ToString());
            var convertData = JsonConvert.DeserializeObject<returnData>(result[0]);
            if (int.Parse(convertData.data) == 0)
            {
                MessageBox.Show("Dịch vụ đã tồn tại");
            }
            else if(int.Parse(convertData.data) == -1)
            {
                MessageBox.Show("Có lỗi trong quá trình xử lý !! Vui lòng thử lại");
            }
            else if (int.Parse(convertData.data) == 1)
            {
                MessageBox.Show("Thêm thành công");
            }
            loadService();
        }

        private void GridViewDichVu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string tenDV = GridViewDichVu.CurrentRow.Cells[1].Value.ToString();
            string giaDV = GridViewDichVu.CurrentRow.Cells[2].Value.ToString();
            txtNameService.Text = tenDV;
            txtPriceService.Text = giaDV;
        }

        private async void guna2Button1_Click(object sender, EventArgs e)
        {
            try
            {
                int count = 0;
                if (listBoxService.CheckedItems.Count == 0)
                {
                    MessageBox.Show("Vui lòng chọn dịch vụ để đăng ký");
                    return;
                }
                foreach (Button button in listButtons)
                {
                    if (button.BackColor == Color.SkyBlue)
                    {
                        count++;
                        foreach (Services service in listBoxService.CheckedItems)
                        {
                            Dictionary<string, string> values = new Dictionary<string, string>
                            {
                                { "ID_DV",service.ID_DV.ToString()},
                                { "MaPDK",button.Tag.ToString()},
                            };
                            var returnData = api.postAPI("paying/createPayingService", values);
                            var result = await Task.WhenAll(returnData);
                            var convertData = JsonConvert.DeserializeObject<returnData>(result[0]);
                            if (int.Parse(convertData.data) == 0)
                            {
                                MessageBox.Show("Có lỗi trong quá trình xử lý vui lòng thử lại!!");
                                return;
                            }
                            loadService();
                            loadRooms();
                        }
                    }
                }
                if (count > 0)
                {
                    MessageBox.Show("Đăng ký dịch vụ thành công");
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn phòng để đăng ký");
                }
            }
            catch
            {
                MessageBox.Show("Có lỗi trong quá trình xử lý!");
            }
        }

        private async void btnDelService_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có muốn xoá dịch vụ này ??", "Xoá dịch vụ", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                string ID_DV = GridViewDichVu.CurrentRow.Cells[0].Value.ToString();
                var returnData = api.deleteAPI("service/" + ID_DV);
                var result = await Task.WhenAll(returnData);
                var convertData = JsonConvert.DeserializeObject<returnData>(result[0]);
                if (int.Parse(convertData.data) == 0)
                {
                    MessageBox.Show("Có lỗi trong quá trình xử lý vui lòng thử lại!!");
                }
                else if (int.Parse(convertData.data) == 1)
                {
                    MessageBox.Show("Xoá dịch vụ thành công");
                }
                loadService();
            }
            else if (dialogResult == DialogResult.No)
            {
                return;
            }




        }

        private async void btnUpdateService_Click(object sender, EventArgs e)
        {
            if (GridViewDichVu.CurrentRow.Cells[0].Value.ToString() == null)
            {
                MessageBox.Show("Vui lòng chọn dịch vụ để sửa thông tin");
                return;
            }
            if (txtNameService.Text == "" || txtPriceService.Text == "")
            {
                MessageBox.Show("Thông tin dịch vụ không được để trống");
                return;
            }
            string tenDV = txtNameService.Text;
            string Gia = txtPriceService.Text;
            string ID_DV = GridViewDichVu.CurrentRow.Cells[0].Value.ToString();

            Dictionary<string, string> values = new Dictionary<string, string>
            {
                { "TenDV",tenDV},
                { "Gia",Gia},
            };
            var returnData = api.putAPI("service/" + ID_DV,values);
            var result = await Task.WhenAll(returnData);
            var convertData = JsonConvert.DeserializeObject<returnData>(result[0]);
            if (int.Parse(convertData.data) == 0)
            {
                MessageBox.Show("Có lỗi trong quá trình xử lý vui lòng thử lại!!");
            }
            else if (int.Parse(convertData.data) == 1)
            {
                MessageBox.Show("Sửa dịch vụ thành công");
            }
            loadService();
        }
    }
}
