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
        public CustomersDetails()
        {
            InitializeComponent();
            loadCustomers();
            cboFilter.Items.Clear();
            cboFilter.Items.Add("Tất cả");
            cboFilter.Items.Add("Khách hàng đang ở");
            cboFilter.Items.Add("Khách hàng không ở");

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
                return;
            }
            else if (cboFilter.SelectedItem.ToString().Contains("Tất cả"))
            {
                loadCustomers();
                return;
            }
        }
    }
}
