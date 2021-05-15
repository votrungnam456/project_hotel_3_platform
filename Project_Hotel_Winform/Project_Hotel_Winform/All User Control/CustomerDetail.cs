using Newtonsoft.Json;
using Project_Hotel_Winform.Model;
using System;
using System.Collections.Generic;
using System.Net;
using System.Windows.Forms;

namespace Project_Hotel_Winform.All_User_Control
{
    public partial class ServiceCustomers : UserControl
    {
        ConnectAPI api = new ConnectAPI();
        List<Customers> listCus = new List<Customers>();
        List<String> arrayHead = new List<string> { "Mã khách hàng", "Tên khách hàng", "Giới tính", "CMND", "Địa chỉ", "Quốc tịch", "Số điện thoại", "Email", "Mật khẩu" };
        //HttpClient client;
        public ServiceCustomers()
        {
            InitializeComponent();
            //loadCustomer();
        }

        private void CustomerDetail_Load(object sender, EventArgs e)
        {
        }

        //private void loadCustomer()
        //{
        //    var data = JsonConvert.DeserializeObject<listCustomers>(api.getAPI("customers/list"));
        //    foreach (Customers item in data.data)
        //    {
        //        listCus.Add(item);
                
        //    }
        //    GridViewCustomers.DataSource = listCus;
        //    for (int i = 0; i < arrayHead.Count; i++)
        //    {
        //        GridViewCustomers.Columns[i].HeaderText = arrayHead[0].ToString();
        //    }
        //}
        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void guna2DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {

        }

        private void guna2DataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
