using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Hotel_Winform.All_User_Control
{
    public partial class Employees : UserControl
    {
        public Employees()
        {
            InitializeComponent();
            cboGender.Items.Add("Nam");
            cboGender.Items.Add("Nữ");
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string CMND = txtCMND.Text;
            string SDT = txtSDT.Text;
            string gender = cboGender.SelectedItem.ToString();
            string email = txtEmail.Text;
            string pwd = txtPassword.Text;
            string phanQuyen = cboPhanQuyen.SelectedItem.ToString();
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
