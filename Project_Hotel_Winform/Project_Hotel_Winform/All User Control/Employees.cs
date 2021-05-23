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
    public partial class Employees : UserControl
    {
        ConnectAPI api = new ConnectAPI();
        List<Employee> lstEmployees;
        List<Decentralization> lstPQ;
        public Employees()
        {
            InitializeComponent();
            cboGender.Items.Add("Nam");
            cboGender.Items.Add("Nữ");
            loadcboBoxPhanQuyen();
        }

        public async void loadcboBoxPhanQuyen()
        {
            lstPQ = new List<Decentralization>();
            var returnData = api.getAPI("employees/decentralization");
            var result = await Task.WhenAll(returnData);
            var data = JsonConvert.DeserializeObject<listDecentralization>(result[0]);
            foreach (Decentralization item in data.data)
            {
                lstPQ.Add(item);
            }
            cboPhanQuyen.DataSource = lstPQ;
            cboPhanQuyen.DisplayMember = "TenQuyen";
            cboPhanQuyen.ValueMember = "ID_Quyen";
        }
        private async void guna2Button1_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "" || txtCMND.Text == "" || txtSDT.Text == "" || txtEmail.Text == "" || txtPassword.Text == "" || txtAddress.Text == "" || cboGender.SelectedItem == null)
            {
                MessageBox.Show("Thông tin của nhân viên mới không được để trống");
                return;
            }
            string name = txtName.Text.ToString();
            string CMND = txtCMND.Text.ToString();
            string SDT = txtSDT.Text.ToString();
            string gender = cboGender.SelectedItem.ToString();
            string email = txtEmail.Text.ToString();
            string pwd = txtPassword.Text.ToString();
            string phanQuyen = cboPhanQuyen.SelectedValue.ToString();
            string address = txtAddress.Text.ToString();
            //MessageBox.Show(name + CMND+ SDT+ gender+ email+ pwd+ phanQuyen+ address);
            Dictionary<string, string> values = new Dictionary<string, string>
            {
                { "TenNV",name},
                { "Gtinh",gender},
                { "Cmnd",CMND},
                { "Dchi",address},
                { "Sodt",SDT},
                { "Email",email},
                { "MatKhau",pwd},
                { "ID_Quyen",phanQuyen},
            };
            var returnData = api.postAPI("employees/create", values);
            var result = await Task.WhenAll(returnData);
            var convertData = JsonConvert.DeserializeObject<returnData>(result[0]);
            if (int.Parse(convertData.data) == -2)
            {
                MessageBox.Show("CMND này đã được dùng");
            }
            else if (int.Parse(convertData.data) == -1)
            {
                MessageBox.Show("Email này đã được sử dụng");
            }
            else if (int.Parse(convertData.data) == 1)
            {
                MessageBox.Show("Thêm thành công");
            }
            else
            {
                MessageBox.Show("Có lỗi trong quá trình xử lý, vui lòng thử lại");
            }
        }

        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
            if (txtSDT.TextLength == 10 && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtCMND_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
            if (txtCMND.TextLength == 9 && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtCMND_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
