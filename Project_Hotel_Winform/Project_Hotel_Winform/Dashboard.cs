using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project_Hotel_Winform.All_User_Control;
namespace Project_Hotel_Winform
{
    public partial class Dashboard : Form
    {
        private string nameUserLogin;
        private string quyen;
        private string iD_NV;
        private int coQuyen;
        public string NameUserLogin { get => nameUserLogin; set => nameUserLogin = value; }
        public string Quyen { get => quyen; set => quyen = value; }
        public string ID_NV { get => iD_NV; set => iD_NV = value; }
        public int CoQuyen { get => coQuyen; set => coQuyen = value; }

        public Dashboard()
        {
            InitializeComponent();

        }
        public Dashboard(string NameUser,string Quyen,string ID_NV,int CoQuyen)
        {
            NameUserLogin = NameUser;
            this.Quyen = Quyen;
            this.ID_NV = ID_NV;
            this.CoQuyen = CoQuyen;
            InitializeComponent();
            label1.Text = "Xin chào " + Quyen + " " + NameUser;
            PhanQuyen();
        }
        public void PhanQuyen()
        {
            foreach(Control x in this.Controls)
            {
                if (x is Guna.UI2.WinForms.Guna2Button)
                {
                    if (!x.Tag.ToString().Contains(CoQuyen.ToString()))
                    {
                        x.Enabled = false;
                    }
                }
            }
            
            foreach(Control x in panel1.Controls)
            {
                if(x is Guna.UI2.WinForms.Guna2Button) 
                {
                    if (!x.Tag.ToString().Contains(CoQuyen.ToString()))
                    {
                        x.Enabled = false;
                    }
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void btnNewCustomer_Click(object sender, EventArgs e)
        {
            panelMoving.Visible = true;
            panelMoving.Size = new Size(199, 5);
            panelMoving.Left = btnNewCustomer.Left;

            panel3.Controls.Clear();
            CustomerRegistation customerRegistation = new CustomerRegistation();
            customerRegistation.Size = new Size(1575, 798);
            panel3.Controls.Add(customerRegistation);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            panelMoving.Visible = true;
            panelMoving.Size = new Size(199, 5);
            panelMoving.Left = btnAdd.Left;
            panel3.Controls.Clear();
            ManagementRooms managementRooms = new ManagementRooms();
            managementRooms.Size = new Size(1575, 798);
            panel3.Controls.Add(managementRooms);
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            panelMoving.Visible = true;
            panelMoving.Size = new Size(199, 5);
            panelMoving.Left = btnCheckOut.Left;
            panel3.Controls.Clear();
            CheckOut checkOut;
            if (ID_NV == "")
            {
                checkOut = new CheckOut();
                checkOut.Size = new Size(1575, 798);
            }
            else
            {
                checkOut = new CheckOut(ID_NV);
                checkOut.Size = new Size(1575, 798);
            }
            panel3.Controls.Add(checkOut);
        }

        private void btnCustomerDetails_Click(object sender, EventArgs e)
        {
            panelMoving.Visible = true;
            panelMoving.Size = new Size (220,5);
            panelMoving.Left = btnCustomerDetails.Left;
            panel3.Controls.Clear();
            CustomersDetails customersDetails = new CustomersDetails();
            customersDetails.Size = new Size(1575, 798);
            panel3.Controls.Add(customersDetails);
        }

        private void btnEmployees_Click(object sender, EventArgs e)
        {
            panelMoving.Visible = true;
            panelMoving.Size = new Size(199, 5);
            panelMoving.Left = btnEmployees.Left;
            panel3.Controls.Clear();
            Employees employees = new Employees(NameUserLogin,Quyen,ID_NV,CoQuyen);
            employees.Size = new Size(1575, 798);
            panel3.Controls.Add(employees);
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            panelMoving.Visible = false;

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            panelMoving.Visible = false;
            panel3.Controls.Clear();
            History history = new History();
            history.Size = new Size(1575, 798);
            panel3.Controls.Add(history);
        }

        private void btnService_Click(object sender, EventArgs e)
        {
            panelMoving.Visible = true;
            panelMoving.Size = new Size(180, 5);
            panelMoving.Left = btnService.Left;
            panel3.Controls.Clear();
            Service service = new Service();
            service.Size = new Size(1575, 798);
            panel3.Controls.Add(service);
        }

        private void guna2CircleButton1_Click_1(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnTuVan_Click(object sender, EventArgs e)
        {
            panelMoving.Visible = false;
            panel3.Controls.Clear();
            AprioriForm apriori = new AprioriForm();
            apriori.Size = new Size(1575, 798);
            panel3.Controls.Add(apriori);
        }
    }
}
