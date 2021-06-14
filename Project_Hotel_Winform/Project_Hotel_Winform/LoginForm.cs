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
namespace Project_Hotel_Winform
{
    public partial class LoginForm : Form
    {
        ConnectAPI api = new ConnectAPI();
        private userOn user;
        private string ID_NV, Quyen, TenNV;
        int CoQuyen;

        public string ID_NV1 { get => ID_NV; set => ID_NV = value; }
        public string Quyen1 { get => Quyen; set => Quyen = value; }
        public string TenNV1 { get => TenNV; set => TenNV = value; }
        public int CoQuyen1 { get => CoQuyen; set => CoQuyen = value; }

        public LoginForm()
        {
            InitializeComponent();
        }

        private void guna2PictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            user = new userOn();
            string email = txtUser.Text;
            string pwd = txtPwd.Text;
            Dictionary<string, string> values = new Dictionary<string, string>
            {
                { "Email",email},
                { "pwd",pwd},
            };
            var returnData = api.postAPI("employees/user", values);
            var result = await Task.WhenAll(returnData);
            var convertData = JsonConvert.DeserializeObject<returnDataLogin>(result[0]);
            if(convertData.data[0].ID_NV.Equals("-1"))
            {
                MessageBox.Show("Email hoặc mật khẩu sai");
                return;
            }
            user.ID_NV = convertData.data[0].ID_NV;
            user.Quyen = convertData.data[0].Quyen;
            user.NameUserLogin = convertData.data[0].TenNV;
            user.CoQuyen = convertData.data[0].CoQuyen;
            Dashboard ds = new Dashboard(user);
            ds.Show();
            this.Hide();
        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
