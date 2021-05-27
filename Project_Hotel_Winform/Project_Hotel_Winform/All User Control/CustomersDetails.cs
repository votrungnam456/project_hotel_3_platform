using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Project_Hotel_Winform.Model;

namespace Project_Hotel_Winform.All_User_Control
{
    public partial class CustomersDetails : UserControl
    {
        ConnectAPI api = new ConnectAPI();
        List<Customers> lstCus;
        int check = 1;
        public CustomersDetails()
        {
            InitializeComponent();
            loadCustomers();
            cboFilter.Items.Clear();
            cboFilter.Items.Add("Tất cả");
            cboFilter.Items.Add("Khách hàng đang ở");
            cboFilter.Items.Add("Khách hàng không ở");
            cboGender.Items.Add("Nam");
            cboGender.Items.Add("Nữ");
            cboGender.Items.Add("Khác");

        }
        public async void loadCustomers()
        {
            lstCus = new List<Customers>();
            var returnData = api.getAPI("customers/list");
            var result = await Task.WhenAll(returnData);
            var data = JsonConvert.DeserializeObject<listCustomers>(result[0]);
            foreach (Customers item in data.data)
            {
                lstCus.Add(item);
            }

            GridViewCustomers.DataSource = lstCus;
            GridViewCustomers.Columns[8].Visible = false;
        }
        public async void loadExisBookingCustomers()
        {
            lstCus = new List<Customers>();
            var returnData = api.getAPI("customers/listExist");
            var result = await Task.WhenAll(returnData);
            var data = JsonConvert.DeserializeObject<listCustomers>(result[0]);
            foreach (Customers item in data.data)
            {
                lstCus.Add(item);
            }

            GridViewCustomers.DataSource = lstCus;
            GridViewCustomers.Columns[8].Visible = false;
        }
        private void GridViewCustomers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cboFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(cboFilter.SelectedItem.ToString());
            if (cboFilter.SelectedItem.ToString().Contains("Khách hàng đang ở"))
            {
                loadExisBookingCustomers();
                check = 2;
                return;
            }
            else if (cboFilter.SelectedItem.ToString().Contains("Tất cả"))
            {
                loadCustomers();
                check = 1;
                return;
            }
        }

        private void GridViewCustomers_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void GridViewCustomers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtName.Text = GridViewCustomers.CurrentRow.Cells[1].Value.ToString();
            cboGender.SelectedItem = GridViewCustomers.CurrentRow.Cells[2].Value.ToString();
            txtCMND.Text = GridViewCustomers.CurrentRow.Cells[3].Value.ToString();
            txtAddress.Text = GridViewCustomers.CurrentRow.Cells[4].Value.ToString();
            txtCountry.Text = GridViewCustomers.CurrentRow.Cells[5].Value.ToString();
            txtSDT.Text = GridViewCustomers.CurrentRow.Cells[6].Value.ToString();
            txtEmail.Text = GridViewCustomers.CurrentRow.Cells[7].Value.ToString();
            txtPwd.Text = GridViewCustomers.CurrentRow.Cells[8].Value.ToString();
        }

        private async void guna2Button1_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "" || txtCMND.Text == ""|| txtAddress.Text == "" || txtCountry.Text == "" || txtSDT.Text == "" || txtEmail.Text == "" || cboGender.SelectedItem.ToString() == "" || txtPwd.Text == "")
            {
                MessageBox.Show("Thông tin dịch vụ không được để trống");
                return;
            }
            if(txtCMND.Text.Length != 9)
            {
                MessageBox.Show("CMND phải đúng định dạng");
                return;
            }
            if(!txtEmail.Text.Contains("@") || !txtEmail.Text.Contains(".com"))
            {
                MessageBox.Show("Email phải đúng định dạng");
                return;
            }   
            string ID_KH = GridViewCustomers.CurrentRow.Cells[0].Value.ToString();
            string Name = txtName.Text;
            string Gender = cboGender.SelectedItem.ToString();
            string CMND = txtCMND.Text;
            string Address = txtAddress.Text;
            string Country = txtCountry.Text;
            string SDT = txtSDT.Text;
            string Email = txtEmail.Text;
            string Pwd = txtPwd.Text;

            Dictionary<string, string> values = new Dictionary<string, string>
            {
                { "TenKH",Name},
                { "GTinh",Gender},
                { "CMND",CMND},
                { "Dchi",Address},
                { "QTich",Country},
                { "SoDT",SDT},
                { "Email",Email},
                { "MatKhau",Pwd}
            };

            var returnData = api.putAPI("customers/"+ID_KH, values);
            var result = await Task.WhenAll(returnData);
            var convertData = JsonConvert.DeserializeObject<returnData>(result[0]);
            if (int.Parse(convertData.data) == 0)
            {
                MessageBox.Show("Có lỗi trong quá trình xử lý vui long thử lại!!!");
            }
            else if (int.Parse(convertData.data) == 1)
            {
                MessageBox.Show("Sửa thông tin khách hàng thành công");
            }
            if (check == 2)
            {
                loadExisBookingCustomers();
            }
            else if(check == 1)
            {
                loadCustomers();
            }
        }

        private void GridViewCustomers_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
