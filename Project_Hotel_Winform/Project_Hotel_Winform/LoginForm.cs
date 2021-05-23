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
        List<UserLogin> lstReturnDataLogin = new List<UserLogin>();
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
            lstReturnDataLogin = new List<UserLogin>();
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

            foreach (UserLogin user in convertData.data)
            {
                lstReturnDataLogin.Add(user);

            }
            if (lstReturnDataLogin[0].checkError == 0)
            {
                MessageBox.Show("Sai email hoặc mật khẩu");
                return;
            }
            ID_NV1 =  lstReturnDataLogin[0].ID_NV;
            Quyen1 = lstReturnDataLogin[0].Quyen;
            TenNV1 = lstReturnDataLogin[0].TenNV;
            CoQuyen1 = lstReturnDataLogin[0].CoQuyen;
            Dashboard ds = new Dashboard();
            ds.NameUserLogin = TenNV1;
            ds.CoQuyen = CoQuyen1;
            ds.Quyen = Quyen1;
            ds.ID_NV = ID_NV1;
            ds.Show();
            this.Hide();
        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
