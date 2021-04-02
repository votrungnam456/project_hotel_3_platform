using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        public void visibleControl(bool manageRoom,bool customerRegis)
        {
            managementRooms1.Visible = manageRoom;
            customerRegistation1.Visible = customerRegis;
        }

        private void btnNewCustomer_Click(object sender, EventArgs e)
        {
            panelMoving.Size = new Size(199, 5);
            panelMoving.Left = btnNewCustomer.Left;
            visibleControl(false, true);

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            panelMoving.Size = new Size(199, 5);
            panelMoving.Left = btnAdd.Left;
            visibleControl(true, false);
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            panelMoving.Size = new Size(199, 5);
            panelMoving.Left = btnCheckOut.Left;
        }

        private void btnCustomerDetails_Click(object sender, EventArgs e)
        {
            panelMoving.Size = new Size (220,5);
            panelMoving.Left = btnCustomerDetails.Left;
        }

        private void btnEmployees_Click(object sender, EventArgs e)
        {
            panelMoving.Size = new Size(199, 5);
            panelMoving.Left = btnEmployees.Left;
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            visibleControl(false, false);
        }


    }
}
