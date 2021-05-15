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
        
        public Dashboard()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void visibleControl(bool manageRoom,bool customerRegis, bool checkOut, bool customerDetail, bool employees, bool history, bool service)
        {

            //managementRooms1.Visible = manageRoom;
            UserControl managementRooms = new UserControl();
            managementRooms = managementRooms1;
            managementRooms.Visible = manageRoom;


            customerRegistation1.Visible = customerRegis;
            checkOut1.Visible = checkOut;
            customerDetail1.Visible = customerDetail;
            employees1.Visible = employees;
            history1.Visible = history;
            service1.Visible = service;
        }

        private void btnNewCustomer_Click(object sender, EventArgs e)
        {
            panelMoving.Visible = true;
            panelMoving.Size = new Size(199, 5);
            panelMoving.Left = btnNewCustomer.Left;
            visibleControl(false, true,false,false,false,false,false);
            ManagementRooms a = new ManagementRooms();
            a.Visible = true;
            panel1.Controls.Add(a);

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            panelMoving.Visible = true;
            panelMoving.Size = new Size(199, 5);
            panelMoving.Left = btnAdd.Left;
            visibleControl(true, false, false, false, false, false, false);
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            panelMoving.Visible = true;
            panelMoving.Size = new Size(199, 5);
            panelMoving.Left = btnCheckOut.Left;
            visibleControl(false, false, true, false, false, false, false);
        }

        private void btnCustomerDetails_Click(object sender, EventArgs e)
        {
            panelMoving.Visible = true;
            panelMoving.Size = new Size (220,5);
            panelMoving.Left = btnCustomerDetails.Left;
            visibleControl(false, false, false, true, false, false, false);
        }

        private void btnEmployees_Click(object sender, EventArgs e)
        {
            panelMoving.Visible = true;
            panelMoving.Size = new Size(199, 5);
            panelMoving.Left = btnEmployees.Left;
            visibleControl(false, false, false, false, true, false, false);
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            panelMoving.Visible = false;
            visibleControl(false, false, false, false, false, false, false);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            panelMoving.Visible = false;
            visibleControl(false, false, false, false, false, true, false);
        }

        private void btnService_Click(object sender, EventArgs e)
        {
            panelMoving.Visible = true;
            panelMoving.Size = new Size(199, 5);
            panelMoving.Left = btnEmployees.Left;
            visibleControl(false, false, false, false, false, false, true);
        }




    }
}
