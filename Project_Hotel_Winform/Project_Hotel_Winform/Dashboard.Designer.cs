namespace Project_Hotel_Winform
{
    partial class Dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnExit = new Guna.UI2.WinForms.Guna2CircleButton();
            this.btnMinimize = new Guna.UI2.WinForms.Guna2CircleButton();
            this.btnAdd = new Guna.UI2.WinForms.Guna2Button();
            this.btnNewCustomer = new Guna.UI2.WinForms.Guna2Button();
            this.btnCheckOut = new Guna.UI2.WinForms.Guna2Button();
            this.btnCustomerDetails = new Guna.UI2.WinForms.Guna2Button();
            this.btnEmployees = new Guna.UI2.WinForms.Guna2Button();
            this.panelMoving = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panelMoving);
            this.panel1.Controls.Add(this.btnEmployees);
            this.panel1.Controls.Add(this.btnCustomerDetails);
            this.panel1.Controls.Add(this.btnCheckOut);
            this.panel1.Controls.Add(this.btnNewCustomer);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Location = new System.Drawing.Point(295, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1373, 132);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(295, 255);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1373, 507);
            this.panel2.TabIndex = 1;
            // 
            // btnExit
            // 
            this.btnExit.CheckedState.Parent = this.btnExit;
            this.btnExit.CustomImages.Parent = this.btnExit;
            this.btnExit.FillColor = System.Drawing.Color.Empty;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.HoverState.Parent = this.btnExit;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageSize = new System.Drawing.Size(30, 30);
            this.btnExit.Location = new System.Drawing.Point(1767, 1);
            this.btnExit.Name = "btnExit";
            this.btnExit.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnExit.ShadowDecoration.Parent = this.btnExit;
            this.btnExit.Size = new System.Drawing.Size(41, 36);
            this.btnExit.TabIndex = 0;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.CheckedState.Parent = this.btnMinimize;
            this.btnMinimize.CustomImages.Parent = this.btnMinimize;
            this.btnMinimize.FillColor = System.Drawing.Color.Empty;
            this.btnMinimize.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnMinimize.ForeColor = System.Drawing.Color.White;
            this.btnMinimize.HoverState.Parent = this.btnMinimize;
            this.btnMinimize.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimize.Image")));
            this.btnMinimize.ImageSize = new System.Drawing.Size(30, 30);
            this.btnMinimize.Location = new System.Drawing.Point(1720, 1);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnMinimize.ShadowDecoration.Parent = this.btnMinimize;
            this.btnMinimize.Size = new System.Drawing.Size(41, 36);
            this.btnMinimize.TabIndex = 2;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BorderRadius = 26;
            this.btnAdd.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnAdd.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnAdd.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btnAdd.CheckedState.Parent = this.btnAdd;
            this.btnAdd.CustomImages.Parent = this.btnAdd;
            this.btnAdd.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.HoverState.Parent = this.btnAdd;
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.ImageSize = new System.Drawing.Size(40, 40);
            this.btnAdd.Location = new System.Drawing.Point(32, 16);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.ShadowDecoration.Parent = this.btnAdd;
            this.btnAdd.Size = new System.Drawing.Size(236, 85);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Thêm phòng";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnNewCustomer
            // 
            this.btnNewCustomer.BorderRadius = 26;
            this.btnNewCustomer.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnNewCustomer.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnNewCustomer.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btnNewCustomer.CheckedState.Parent = this.btnNewCustomer;
            this.btnNewCustomer.CustomImages.Parent = this.btnNewCustomer;
            this.btnNewCustomer.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.btnNewCustomer.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewCustomer.ForeColor = System.Drawing.Color.White;
            this.btnNewCustomer.HoverState.Parent = this.btnNewCustomer;
            this.btnNewCustomer.Image = ((System.Drawing.Image)(resources.GetObject("btnNewCustomer.Image")));
            this.btnNewCustomer.ImageSize = new System.Drawing.Size(40, 40);
            this.btnNewCustomer.Location = new System.Drawing.Point(274, 16);
            this.btnNewCustomer.Name = "btnNewCustomer";
            this.btnNewCustomer.ShadowDecoration.Parent = this.btnNewCustomer;
            this.btnNewCustomer.Size = new System.Drawing.Size(259, 85);
            this.btnNewCustomer.TabIndex = 1;
            this.btnNewCustomer.Text = "Khách hàng mới";
            this.btnNewCustomer.Click += new System.EventHandler(this.btnNewCustomer_Click);
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.BorderRadius = 26;
            this.btnCheckOut.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnCheckOut.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnCheckOut.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btnCheckOut.CheckedState.Parent = this.btnCheckOut;
            this.btnCheckOut.CustomImages.Parent = this.btnCheckOut;
            this.btnCheckOut.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.btnCheckOut.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckOut.ForeColor = System.Drawing.Color.White;
            this.btnCheckOut.HoverState.Parent = this.btnCheckOut;
            this.btnCheckOut.Image = ((System.Drawing.Image)(resources.GetObject("btnCheckOut.Image")));
            this.btnCheckOut.ImageSize = new System.Drawing.Size(40, 40);
            this.btnCheckOut.Location = new System.Drawing.Point(539, 16);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.ShadowDecoration.Parent = this.btnCheckOut;
            this.btnCheckOut.Size = new System.Drawing.Size(236, 85);
            this.btnCheckOut.TabIndex = 2;
            this.btnCheckOut.Text = "Trả phòng";
            this.btnCheckOut.Click += new System.EventHandler(this.btnCheckOut_Click);
            // 
            // btnCustomerDetails
            // 
            this.btnCustomerDetails.BorderRadius = 26;
            this.btnCustomerDetails.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnCustomerDetails.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnCustomerDetails.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btnCustomerDetails.CheckedState.Parent = this.btnCustomerDetails;
            this.btnCustomerDetails.CustomImages.Parent = this.btnCustomerDetails;
            this.btnCustomerDetails.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.btnCustomerDetails.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomerDetails.ForeColor = System.Drawing.Color.White;
            this.btnCustomerDetails.HoverState.Parent = this.btnCustomerDetails;
            this.btnCustomerDetails.Image = ((System.Drawing.Image)(resources.GetObject("btnCustomerDetails.Image")));
            this.btnCustomerDetails.ImageSize = new System.Drawing.Size(40, 40);
            this.btnCustomerDetails.Location = new System.Drawing.Point(781, 16);
            this.btnCustomerDetails.Name = "btnCustomerDetails";
            this.btnCustomerDetails.ShadowDecoration.Parent = this.btnCustomerDetails;
            this.btnCustomerDetails.Size = new System.Drawing.Size(321, 85);
            this.btnCustomerDetails.TabIndex = 3;
            this.btnCustomerDetails.Text = "Thông tin khách hàng";
            this.btnCustomerDetails.Click += new System.EventHandler(this.btnCustomerDetails_Click);
            // 
            // btnEmployees
            // 
            this.btnEmployees.BorderRadius = 26;
            this.btnEmployees.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnEmployees.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnEmployees.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btnEmployees.CheckedState.Parent = this.btnEmployees;
            this.btnEmployees.CustomImages.Parent = this.btnEmployees;
            this.btnEmployees.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.btnEmployees.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployees.ForeColor = System.Drawing.Color.White;
            this.btnEmployees.HoverState.Parent = this.btnEmployees;
            this.btnEmployees.Image = ((System.Drawing.Image)(resources.GetObject("btnEmployees.Image")));
            this.btnEmployees.ImageSize = new System.Drawing.Size(40, 40);
            this.btnEmployees.Location = new System.Drawing.Point(1108, 16);
            this.btnEmployees.Name = "btnEmployees";
            this.btnEmployees.ShadowDecoration.Parent = this.btnEmployees;
            this.btnEmployees.Size = new System.Drawing.Size(248, 85);
            this.btnEmployees.TabIndex = 4;
            this.btnEmployees.Text = "Nhân viên";
            this.btnEmployees.Click += new System.EventHandler(this.btnEmployees_Click);
            // 
            // panelMoving
            // 
            this.panelMoving.BackColor = System.Drawing.Color.Cyan;
            this.panelMoving.Location = new System.Drawing.Point(52, 107);
            this.panelMoving.Name = "panelMoving";
            this.panelMoving.Size = new System.Drawing.Size(199, 5);
            this.panelMoving.TabIndex = 0;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.ClientSize = new System.Drawing.Size(1820, 908);
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2CircleButton btnExit;
        private Guna.UI2.WinForms.Guna2CircleButton btnMinimize;
        private Guna.UI2.WinForms.Guna2Button btnEmployees;
        private Guna.UI2.WinForms.Guna2Button btnCustomerDetails;
        private Guna.UI2.WinForms.Guna2Button btnCheckOut;
        private Guna.UI2.WinForms.Guna2Button btnNewCustomer;
        private Guna.UI2.WinForms.Guna2Button btnAdd;
        private System.Windows.Forms.Panel panelMoving;
    }
}