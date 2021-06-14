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
        public userOn user = new userOn();
        ConnectAPI api = new ConnectAPI();
        List<Employee> ListEmployees;
        List<Decentralization> lstPQ;
        public Employees()
        {
            InitializeComponent();
            cboGender.Items.Add("Nam");
            cboGender.Items.Add("Nữ");
            loadcboBoxPhanQuyen();
        }
        public Employees(userOn user)
        {
            this.user = user;
            InitializeComponent();
            cboGender.Items.Add("Nam");
            cboGender.Items.Add("Nữ");
            loadcboBoxPhanQuyen();
            phanQuyen();
            loadEmployees();
        }
        public async void loadEmployees()
        {
            try
            {
                ListEmployees = new List<Employee>();
                Task<string> initalData = null;
                var returnData = initalData;
                if (user.CoQuyen.ToString() == "1")
                {
                    returnData = api.getAPI("employees/" + user.ID_NV);
                }
                else
                {
                    returnData = api.getAPI("employees/list");
                }
                var result = await Task.WhenAll(returnData);
                var data = JsonConvert.DeserializeObject<listEmployees>(result[0]);
                foreach (Employee item in data.data)
                {
                    ListEmployees.Add(item);
                }
                GridViewEmployees.DataSource = ListEmployees;
                GridViewEmployees.Columns[0].Visible = false;
                GridViewEmployees.Columns[8].Visible = false;
            }
            catch
            {
                MessageBox.Show("Load thông tin nhân viên thất bại");
            }
        }
        public void phanQuyen()
        {
            foreach(Control control in panelEmp.Controls)
            {
                if (control is Guna.UI2.WinForms.Guna2Button || control is Guna.UI2.WinForms.Guna2ComboBox)
                {
                    if (!control.Tag.ToString().Contains(user.CoQuyen.ToString()))
                    {
                        control.Enabled = false;
                    }
                }
            }
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
            if(!txtEmail.Text.Contains("@") || !txtEmail.Text.Contains(".com"))
            {
                MessageBox.Show("Email không đúng định dạng");
                return;
            }
            string name = txtName.Text.ToString();
            string CMND = txtCMND.Text.ToString();
            string SDT = txtSDT.Text.ToString();
            string gender = cboGender.SelectedItem.ToString();
            string email = txtEmail.Text.ToString().ToLower();
            string pwd = txtPassword.Text.ToString();
            string phanQuyen = cboPhanQuyen.SelectedValue.ToString();
            string address = txtAddress.Text.ToString();
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

        }

        private void txtCMND_TextChanged(object sender, EventArgs e)
        {

        }

        private void GridViewThuePhong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void GridViewEmployees_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (GridViewEmployees.CurrentRow.Cells[0].Value.ToString() == null)
            {
                txtName.Text = "";
                txtAddress.Text = "";
                txtCMND.Text = "";
                txtEmail.Text = "";
                txtPassword.Text = "";
                txtSDT.Text = "";
            }
            else
            {               
                txtName.Text = GridViewEmployees.CurrentRow.Cells[1].Value.ToString();
                cboGender.SelectedItem = GridViewEmployees.CurrentRow.Cells[2].Value.ToString();
                txtCMND.Text = GridViewEmployees.CurrentRow.Cells[3].Value.ToString();
                txtAddress.Text = GridViewEmployees.CurrentRow.Cells[4].Value.ToString();
                txtSDT.Text = GridViewEmployees.CurrentRow.Cells[5].Value.ToString();
                txtEmail.Text = GridViewEmployees.CurrentRow.Cells[6].Value.ToString();
                txtPassword.Text = GridViewEmployees.CurrentRow.Cells[7].Value.ToString();
                cboPhanQuyen.SelectedValue = GridViewEmployees.CurrentRow.Cells[8].Value.ToString();
            }
        }

        private async void buttonDelEmp_Click(object sender, EventArgs e)
        {
            if (GridViewEmployees.CurrentRow.Cells[0].Value.ToString() == null)
            {
                MessageBox.Show("Vui lòng chọn nhân viên để xoá");
                return;
            }
            DialogResult dialogResult = MessageBox.Show("Bạn có muốn xoá nhân viên này ??", "Xoá dịch vụ", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                string idnv = GridViewEmployees.CurrentRow.Cells[0].Value.ToString();
                if (idnv.Equals(user.ID_NV))
                {
                    MessageBox.Show("Bạn không thể xoá nhân viên này, do tài khoản nhân viên này đang đăng nhập !!");
                    return;
                }
                var returnData = api.deleteAPI("employees/" + idnv);
                var result = await Task.WhenAll(returnData);
                var data = JsonConvert.DeserializeObject<returnData>(result[0]);
                if (int.Parse(data.data) == 1)
                {
                    MessageBox.Show("Xoá nhân viên thành công");
                }
                else
                {
                    MessageBox.Show("Có lỗi trong quá trình xử lý");
                }
                loadEmployees();
            }
        }

        private async void buttonUpdateEmp_Click(object sender, EventArgs e)
        {
            if (GridViewEmployees.CurrentRow.Cells[0].Value.ToString() == null)
            {
                MessageBox.Show("Hãy chọn nhân viên để sửa thông tin");
                return;
            }
            if (txtName.Text == "" || txtCMND.Text == "" || txtSDT.Text == "" || txtEmail.Text == "" || txtPassword.Text == "" || txtAddress.Text == "" || cboGender.SelectedItem == null)
            {
                MessageBox.Show("Thông tin nhân viên không được để trống");
                return;
            }
            string ID_NV = GridViewEmployees.CurrentRow.Cells[0].Value.ToString();
            string name = txtName.Text;
            string gender = cboGender.SelectedItem.ToString();
            string email = txtEmail.Text;
            string pwd = txtPassword.Text;
            string sdt = txtSDT.Text;
            string cmnd = txtCMND.Text;
            string PQ = cboPhanQuyen.SelectedValue.ToString();
            string address = txtAddress.Text;
            Dictionary<string, string> values = new Dictionary<string, string>
            {
                { "TenNV",name},
                { "GTinh",gender},
                { "Email",email},
                { "MatKhau",pwd},
                { "SoDT",sdt},
                { "CMND",cmnd},
                { "DChi",address},
                { "ID_Quyen",PQ},
            };
            var returnData = api.putAPI("employees/" + ID_NV, values);
            var result = await Task.WhenAll(returnData);
            var convertData = JsonConvert.DeserializeObject<returnData>(result[0]);
            if (int.Parse(convertData.data) == 0)
            {
                MessageBox.Show("Có lỗi trong quá trình xử lý vui lòng thử lại!!");
            }
            else if (int.Parse(convertData.data) == 1)
            {
                MessageBox.Show("Cập nhật thông tin nhân viên thành công");
            }
            loadEmployees();
        }

        private void GridViewEmployees_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                ListEmployees = new List<Employee>();
                GridViewEmployees.Columns.Clear();
                if (txtSearch.Text.Trim() == "")
                {
                    loadEmployees();
                }
                else
                {
                    string filter = txtSearch.Text.Trim();
                    var returnData = api.getAPI("employees/search/" + filter);
                    var result = await Task.WhenAll(returnData);
                    var data = JsonConvert.DeserializeObject<listEmployees>(result[0]);
                    foreach (Employee item in data.data)
                    {
                        if (item.ID_NV == "-1")
                        {
                            MessageBox.Show("Không tìm thấy nhân viên");
                            loadEmployees();
                            return;
                        }
                        ListEmployees.Add(item);
                    }
                    GridViewEmployees.DataSource = ListEmployees;
                    GridViewEmployees.Columns[0].Visible = false;
                    GridViewEmployees.Columns[8].Visible = false;
                }
            }
            catch
            {
                MessageBox.Show("Lỗi tìm kiếm");
                loadEmployees();
            }
        }
    }
}
