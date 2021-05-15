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
    public partial class CustomerRegistation : UserControl
    {
        ConnectAPI api = new ConnectAPI();
        public CustomerRegistation()
        {
            InitializeComponent();
            cboGender.Items.Add("Nam");
            cboGender.Items.Add("Nữ");
            cboGender.Items.Add("Khác");
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtCMND_TextChanged(object sender, EventArgs e)
        {
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

        private void txtSDT_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
            if (txtCMND.TextLength == 10 && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private async void guna2Button1_Click(object sender, EventArgs e)
        {
            //string phong = cbRoom.SelectedItem.ToString();
            if (txtName.Text == "" || txtEmail.Text == "" || txtPwd.Text == "" || txtSDT.Text == "" || txtCMND.Text == "" || txtAddress.Text == "" || txtCountry.Text == "")
            {
                MessageBox.Show("Thông tin khách hàng không được để trống");
                return;
            }
            if(txtCMND.Text.Length != 9)
            {
                MessageBox.Show("CMND phải có 9 chữ số!!");
                return;
            }
            string name = txtName.Text;
            string email = txtEmail.Text;
            string pwd = txtPwd.Text;
            string phoneNum = txtSDT.Text;
            string cmnd = txtCMND.Text;
            string address = txtAddress.Text;
            string country = txtCountry.Text;
            string gender = cboGender.SelectedItem.ToString();
            Dictionary<string, string> values = new Dictionary<string, string>
            {
                { "TenKH",name},
                { "GTinh",gender},
                { "Email",email},
                { "MatKhau",pwd},
                { "SoDT",phoneNum},
                { "Dchi",address},
                { "QTich",country},
                { "CMND",cmnd}
            };
            var returnData = api.postAPI("customers/create", values);
            var result = await Task.WhenAll(returnData);
            var convertData = JsonConvert.DeserializeObject<returnData>(result[0]);
            if (int.Parse(convertData.data) == -2)
            {
                MessageBox.Show("CMND này đã được sử dụng");
            }
            else if (int.Parse(convertData.data) == -1)
            {
                MessageBox.Show("Email này đã được sử dụng");
            }
            else if (int.Parse(convertData.data) == 1)
            {
                MessageBox.Show("Thêm khách hàng thành công");
            }    
            //loadRooms();
        }

    }
}
