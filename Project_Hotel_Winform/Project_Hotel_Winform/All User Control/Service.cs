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
        List<Services> lstServices;
        ConnectAPI api = new ConnectAPI();
        List<checkOutRoom> lstCheckOutRoom;
        public Service()
        {
            InitializeComponent();
            loadService();
            loadCboBox();
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

        public async void loadCboBox()
        {
            lstCheckOutRoom = new List<checkOutRoom>();
            var returnData = api.getAPI("rooms/listCheckout");
            var result = await Task.WhenAll(returnData);
            var data = JsonConvert.DeserializeObject<listChectOutRoom>(result[0]);
            foreach (checkOutRoom item in data.data)
            {
                lstCheckOutRoom.Add(item);
            }
            cboRoom.DataSource = lstCheckOutRoom;
            cboRoom.DisplayMember = "Tenphong";
            cboRoom.ValueMember = "MaPDK";
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
            string maPDK = cboRoom.SelectedValue.ToString();
            if(listBoxService.CheckedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn dịch vụ để đăng ký");
                return;
            }
            foreach(Services a in listBoxService.CheckedItems){
                //MessageBox.Show(a.ID_DV.ToString());
                Dictionary<string, string> values = new Dictionary<string, string>
                {
                    { "ID_DV",a.ID_DV.ToString()},
                    { "MaPDK",maPDK},
                };
                var returnData = api.postAPI("paying/createPayingService", values);
                var result = await Task.WhenAll(returnData);
                var convertData = JsonConvert.DeserializeObject<returnData>(result[0]);
                if (int.Parse(convertData.data) == 0)
                {
                    MessageBox.Show("Có lỗi trong quá trình xử lý, vui lòng thử lại");
                }
                else if (int.Parse(convertData.data) == 1)
                {
                    MessageBox.Show("Đăng ký dịch vụ thành công");
                }
                loadService();
                loadCboBox();
            }
        }
    }
}
