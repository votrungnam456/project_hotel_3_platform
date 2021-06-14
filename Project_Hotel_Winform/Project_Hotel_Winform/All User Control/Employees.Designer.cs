﻿namespace Project_Hotel_Winform.All_User_Control
{
    partial class Employees
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label12 = new System.Windows.Forms.Label();
            this.panelEmp = new System.Windows.Forms.Panel();
            this.txtAddress = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.GridViewEmployees = new Guna.UI2.WinForms.Guna2DataGridView();
            this.buttonUpdateEmp = new Guna.UI2.WinForms.Guna2Button();
            this.buttonDelEmp = new Guna.UI2.WinForms.Guna2Button();
            this.txtSDT = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cboGender = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cboPhanQuyen = new Guna.UI2.WinForms.Guna2ComboBox();
            this.buttonAddEmp = new Guna.UI2.WinForms.Guna2Button();
            this.txtPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEmail = new Guna.UI2.WinForms.Guna2TextBox();
            this.Email = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCMND = new Guna.UI2.WinForms.Guna2TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtName = new Guna.UI2.WinForms.Guna2TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnSearch = new Guna.UI2.WinForms.Guna2Button();
            this.panelEmp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewEmployees)).BeginInit();
            this.SuspendLayout();
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(75, 32);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(180, 40);
            this.label12.TabIndex = 28;
            this.label12.Text = "Nhân viên";
            // 
            // panelEmp
            // 
            this.panelEmp.Controls.Add(this.btnSearch);
            this.panelEmp.Controls.Add(this.txtSearch);
            this.panelEmp.Controls.Add(this.txtAddress);
            this.panelEmp.Controls.Add(this.label2);
            this.panelEmp.Controls.Add(this.GridViewEmployees);
            this.panelEmp.Controls.Add(this.buttonUpdateEmp);
            this.panelEmp.Controls.Add(this.buttonDelEmp);
            this.panelEmp.Controls.Add(this.txtSDT);
            this.panelEmp.Controls.Add(this.label1);
            this.panelEmp.Controls.Add(this.cboGender);
            this.panelEmp.Controls.Add(this.cboPhanQuyen);
            this.panelEmp.Controls.Add(this.buttonAddEmp);
            this.panelEmp.Controls.Add(this.txtPassword);
            this.panelEmp.Controls.Add(this.label5);
            this.panelEmp.Controls.Add(this.txtEmail);
            this.panelEmp.Controls.Add(this.Email);
            this.panelEmp.Controls.Add(this.label8);
            this.panelEmp.Controls.Add(this.txtCMND);
            this.panelEmp.Controls.Add(this.label9);
            this.panelEmp.Controls.Add(this.label10);
            this.panelEmp.Controls.Add(this.txtName);
            this.panelEmp.Controls.Add(this.label11);
            this.panelEmp.Location = new System.Drawing.Point(3, 84);
            this.panelEmp.Name = "panelEmp";
            this.panelEmp.Size = new System.Drawing.Size(1557, 689);
            this.panelEmp.TabIndex = 29;
            // 
            // txtAddress
            // 
            this.txtAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAddress.DefaultText = "";
            this.txtAddress.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtAddress.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtAddress.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAddress.DisabledState.Parent = this.txtAddress;
            this.txtAddress.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAddress.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAddress.FocusedState.Parent = this.txtAddress;
            this.txtAddress.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAddress.HoverState.Parent = this.txtAddress;
            this.txtAddress.Location = new System.Drawing.Point(907, 471);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.PasswordChar = '\0';
            this.txtAddress.PlaceholderText = "";
            this.txtAddress.SelectedText = "";
            this.txtAddress.ShadowDecoration.Parent = this.txtAddress;
            this.txtAddress.Size = new System.Drawing.Size(615, 41);
            this.txtAddress.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtAddress.TabIndex = 71;
            this.txtAddress.Tag = "0,1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(903, 431);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 19);
            this.label2.TabIndex = 70;
            this.label2.Text = "Địa chỉ";
            // 
            // GridViewEmployees
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.GridViewEmployees.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.GridViewEmployees.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridViewEmployees.BackgroundColor = System.Drawing.Color.White;
            this.GridViewEmployees.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GridViewEmployees.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.GridViewEmployees.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridViewEmployees.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.GridViewEmployees.ColumnHeadersHeight = 4;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GridViewEmployees.DefaultCellStyle = dataGridViewCellStyle6;
            this.GridViewEmployees.EnableHeadersVisualStyles = false;
            this.GridViewEmployees.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.GridViewEmployees.Location = new System.Drawing.Point(3, 95);
            this.GridViewEmployees.Name = "GridViewEmployees";
            this.GridViewEmployees.RowHeadersVisible = false;
            this.GridViewEmployees.RowHeadersWidth = 51;
            this.GridViewEmployees.RowTemplate.Height = 24;
            this.GridViewEmployees.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridViewEmployees.Size = new System.Drawing.Size(892, 579);
            this.GridViewEmployees.TabIndex = 69;
            this.GridViewEmployees.Tag = "0,1";
            this.GridViewEmployees.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.GridViewEmployees.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.GridViewEmployees.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.GridViewEmployees.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.GridViewEmployees.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.GridViewEmployees.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.GridViewEmployees.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.GridViewEmployees.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.GridViewEmployees.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.GridViewEmployees.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.GridViewEmployees.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.GridViewEmployees.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.GridViewEmployees.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.GridViewEmployees.ThemeStyle.HeaderStyle.Height = 4;
            this.GridViewEmployees.ThemeStyle.ReadOnly = false;
            this.GridViewEmployees.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.GridViewEmployees.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.GridViewEmployees.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.GridViewEmployees.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.GridViewEmployees.ThemeStyle.RowsStyle.Height = 24;
            this.GridViewEmployees.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.GridViewEmployees.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.GridViewEmployees.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridViewEmployees_CellClick);
            // 
            // buttonUpdateEmp
            // 
            this.buttonUpdateEmp.BorderRadius = 20;
            this.buttonUpdateEmp.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.buttonUpdateEmp.BorderThickness = 1;
            this.buttonUpdateEmp.CheckedState.BorderColor = System.Drawing.Color.White;
            this.buttonUpdateEmp.CheckedState.CustomBorderColor = System.Drawing.Color.White;
            this.buttonUpdateEmp.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(221)))));
            this.buttonUpdateEmp.CheckedState.ForeColor = System.Drawing.Color.White;
            this.buttonUpdateEmp.CheckedState.Parent = this.buttonUpdateEmp;
            this.buttonUpdateEmp.CustomImages.Parent = this.buttonUpdateEmp;
            this.buttonUpdateEmp.FillColor = System.Drawing.Color.White;
            this.buttonUpdateEmp.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdateEmp.ForeColor = System.Drawing.Color.Black;
            this.buttonUpdateEmp.HoverState.Parent = this.buttonUpdateEmp;
            this.buttonUpdateEmp.Location = new System.Drawing.Point(1383, 565);
            this.buttonUpdateEmp.Name = "buttonUpdateEmp";
            this.buttonUpdateEmp.ShadowDecoration.Parent = this.buttonUpdateEmp;
            this.buttonUpdateEmp.Size = new System.Drawing.Size(149, 48);
            this.buttonUpdateEmp.TabIndex = 68;
            this.buttonUpdateEmp.Tag = "0,1";
            this.buttonUpdateEmp.Text = "Sửa nhân viên";
            this.buttonUpdateEmp.Click += new System.EventHandler(this.buttonUpdateEmp_Click);
            // 
            // buttonDelEmp
            // 
            this.buttonDelEmp.BorderRadius = 20;
            this.buttonDelEmp.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.buttonDelEmp.BorderThickness = 1;
            this.buttonDelEmp.CheckedState.BorderColor = System.Drawing.Color.White;
            this.buttonDelEmp.CheckedState.CustomBorderColor = System.Drawing.Color.White;
            this.buttonDelEmp.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(221)))));
            this.buttonDelEmp.CheckedState.ForeColor = System.Drawing.Color.White;
            this.buttonDelEmp.CheckedState.Parent = this.buttonDelEmp;
            this.buttonDelEmp.CustomImages.Parent = this.buttonDelEmp;
            this.buttonDelEmp.FillColor = System.Drawing.Color.White;
            this.buttonDelEmp.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDelEmp.ForeColor = System.Drawing.Color.Black;
            this.buttonDelEmp.HoverState.Parent = this.buttonDelEmp;
            this.buttonDelEmp.Location = new System.Drawing.Point(1163, 565);
            this.buttonDelEmp.Name = "buttonDelEmp";
            this.buttonDelEmp.ShadowDecoration.Parent = this.buttonDelEmp;
            this.buttonDelEmp.Size = new System.Drawing.Size(149, 48);
            this.buttonDelEmp.TabIndex = 67;
            this.buttonDelEmp.Tag = "0";
            this.buttonDelEmp.Text = "Xoá nhân viên";
            this.buttonDelEmp.Click += new System.EventHandler(this.buttonDelEmp_Click);
            // 
            // txtSDT
            // 
            this.txtSDT.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSDT.DefaultText = "";
            this.txtSDT.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSDT.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSDT.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSDT.DisabledState.Parent = this.txtSDT;
            this.txtSDT.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSDT.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSDT.FocusedState.Parent = this.txtSDT;
            this.txtSDT.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSDT.HoverState.Parent = this.txtSDT;
            this.txtSDT.Location = new System.Drawing.Point(908, 354);
            this.txtSDT.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.PasswordChar = '\0';
            this.txtSDT.PlaceholderText = "";
            this.txtSDT.SelectedText = "";
            this.txtSDT.ShadowDecoration.Parent = this.txtSDT;
            this.txtSDT.Size = new System.Drawing.Size(218, 41);
            this.txtSDT.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtSDT.TabIndex = 66;
            this.txtSDT.Tag = "0,1";
            this.txtSDT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSDT_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(904, 331);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 19);
            this.label1.TabIndex = 65;
            this.label1.Text = "Số điện thoại";
            // 
            // cboGender
            // 
            this.cboGender.BackColor = System.Drawing.Color.Transparent;
            this.cboGender.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGender.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboGender.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboGender.FocusedState.Parent = this.cboGender;
            this.cboGender.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboGender.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboGender.HoverState.Parent = this.cboGender;
            this.cboGender.ItemHeight = 30;
            this.cboGender.ItemsAppearance.Parent = this.cboGender;
            this.cboGender.Location = new System.Drawing.Point(1319, 135);
            this.cboGender.Name = "cboGender";
            this.cboGender.ShadowDecoration.Parent = this.cboGender;
            this.cboGender.Size = new System.Drawing.Size(213, 36);
            this.cboGender.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.cboGender.TabIndex = 64;
            this.cboGender.Tag = "0,1";
            // 
            // cboPhanQuyen
            // 
            this.cboPhanQuyen.BackColor = System.Drawing.Color.Transparent;
            this.cboPhanQuyen.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboPhanQuyen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPhanQuyen.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboPhanQuyen.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboPhanQuyen.FocusedState.Parent = this.cboPhanQuyen;
            this.cboPhanQuyen.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboPhanQuyen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboPhanQuyen.HoverState.Parent = this.cboPhanQuyen;
            this.cboPhanQuyen.ItemHeight = 30;
            this.cboPhanQuyen.ItemsAppearance.Parent = this.cboPhanQuyen;
            this.cboPhanQuyen.Location = new System.Drawing.Point(1354, 354);
            this.cboPhanQuyen.Name = "cboPhanQuyen";
            this.cboPhanQuyen.ShadowDecoration.Parent = this.cboPhanQuyen;
            this.cboPhanQuyen.Size = new System.Drawing.Size(178, 36);
            this.cboPhanQuyen.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.cboPhanQuyen.TabIndex = 63;
            this.cboPhanQuyen.Tag = "0";
            // 
            // buttonAddEmp
            // 
            this.buttonAddEmp.BorderRadius = 20;
            this.buttonAddEmp.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.buttonAddEmp.BorderThickness = 1;
            this.buttonAddEmp.CheckedState.BorderColor = System.Drawing.Color.White;
            this.buttonAddEmp.CheckedState.CustomBorderColor = System.Drawing.Color.White;
            this.buttonAddEmp.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(221)))));
            this.buttonAddEmp.CheckedState.ForeColor = System.Drawing.Color.White;
            this.buttonAddEmp.CheckedState.Parent = this.buttonAddEmp;
            this.buttonAddEmp.CustomImages.Parent = this.buttonAddEmp;
            this.buttonAddEmp.FillColor = System.Drawing.Color.White;
            this.buttonAddEmp.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddEmp.ForeColor = System.Drawing.Color.Black;
            this.buttonAddEmp.HoverState.Parent = this.buttonAddEmp;
            this.buttonAddEmp.Location = new System.Drawing.Point(907, 565);
            this.buttonAddEmp.Name = "buttonAddEmp";
            this.buttonAddEmp.ShadowDecoration.Parent = this.buttonAddEmp;
            this.buttonAddEmp.Size = new System.Drawing.Size(149, 48);
            this.buttonAddEmp.TabIndex = 62;
            this.buttonAddEmp.Tag = "0";
            this.buttonAddEmp.Text = "Thêm nhân viên";
            this.buttonAddEmp.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.DefaultText = "";
            this.txtPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassword.DisabledState.Parent = this.txtPassword;
            this.txtPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPassword.FocusedState.Parent = this.txtPassword;
            this.txtPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPassword.HoverState.Parent = this.txtPassword;
            this.txtPassword.Location = new System.Drawing.Point(1319, 247);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.PlaceholderText = "";
            this.txtPassword.SelectedText = "";
            this.txtPassword.ShadowDecoration.Parent = this.txtPassword;
            this.txtPassword.Size = new System.Drawing.Size(202, 41);
            this.txtPassword.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtPassword.TabIndex = 61;
            this.txtPassword.Tag = "0,1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1315, 211);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 19);
            this.label5.TabIndex = 60;
            this.label5.Text = "Password";
            // 
            // txtEmail
            // 
            this.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmail.DefaultText = "";
            this.txtEmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmail.DisabledState.Parent = this.txtEmail;
            this.txtEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEmail.FocusedState.Parent = this.txtEmail;
            this.txtEmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEmail.HoverState.Parent = this.txtEmail;
            this.txtEmail.Location = new System.Drawing.Point(907, 247);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.PlaceholderText = "";
            this.txtEmail.SelectedText = "";
            this.txtEmail.ShadowDecoration.Parent = this.txtEmail;
            this.txtEmail.Size = new System.Drawing.Size(405, 41);
            this.txtEmail.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtEmail.TabIndex = 59;
            this.txtEmail.Tag = "0,1";
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email.Location = new System.Drawing.Point(903, 221);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(46, 19);
            this.Email.TabIndex = 58;
            this.Email.Text = "Email";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(1360, 321);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 19);
            this.label8.TabIndex = 57;
            this.label8.Text = "Phân quyền";
            // 
            // txtCMND
            // 
            this.txtCMND.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCMND.DefaultText = "";
            this.txtCMND.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCMND.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCMND.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCMND.DisabledState.Parent = this.txtCMND;
            this.txtCMND.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCMND.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCMND.FocusedState.Parent = this.txtCMND;
            this.txtCMND.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCMND.HoverState.Parent = this.txtCMND;
            this.txtCMND.Location = new System.Drawing.Point(1134, 354);
            this.txtCMND.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCMND.Name = "txtCMND";
            this.txtCMND.PasswordChar = '\0';
            this.txtCMND.PlaceholderText = "";
            this.txtCMND.SelectedText = "";
            this.txtCMND.ShadowDecoration.Parent = this.txtCMND;
            this.txtCMND.Size = new System.Drawing.Size(213, 41);
            this.txtCMND.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtCMND.TabIndex = 56;
            this.txtCMND.Tag = "0,1";
            this.txtCMND.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCMND_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(1140, 321);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 19);
            this.label9.TabIndex = 55;
            this.label9.Text = "CMND";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(1315, 95);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 19);
            this.label10.TabIndex = 54;
            this.label10.Text = "Giới tính";
            // 
            // txtName
            // 
            this.txtName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtName.DefaultText = "";
            this.txtName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtName.DisabledState.Parent = this.txtName;
            this.txtName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtName.FocusedState.Parent = this.txtName;
            this.txtName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtName.HoverState.Parent = this.txtName;
            this.txtName.Location = new System.Drawing.Point(907, 135);
            this.txtName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtName.Name = "txtName";
            this.txtName.PasswordChar = '\0';
            this.txtName.PlaceholderText = "";
            this.txtName.SelectedText = "";
            this.txtName.ShadowDecoration.Parent = this.txtName;
            this.txtName.Size = new System.Drawing.Size(405, 41);
            this.txtName.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtName.TabIndex = 53;
            this.txtName.Tag = "0,1";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(903, 95);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 19);
            this.label11.TabIndex = 52;
            this.label11.Text = "Họ tên";
            // 
            // txtSearch
            // 
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.DefaultText = "";
            this.txtSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.DisabledState.Parent = this.txtSearch;
            this.txtSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.FocusedState.Parent = this.txtSearch;
            this.txtSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.HoverState.Parent = this.txtSearch;
            this.txtSearch.Location = new System.Drawing.Point(107, 25);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PlaceholderText = "";
            this.txtSearch.SelectedText = "";
            this.txtSearch.ShadowDecoration.Parent = this.txtSearch;
            this.txtSearch.Size = new System.Drawing.Size(405, 41);
            this.txtSearch.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtSearch.TabIndex = 72;
            this.txtSearch.Tag = "0,1";
            // 
            // btnSearch
            // 
            this.btnSearch.BorderRadius = 20;
            this.btnSearch.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.btnSearch.BorderThickness = 1;
            this.btnSearch.CheckedState.BorderColor = System.Drawing.Color.White;
            this.btnSearch.CheckedState.CustomBorderColor = System.Drawing.Color.White;
            this.btnSearch.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(221)))));
            this.btnSearch.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btnSearch.CheckedState.Parent = this.btnSearch;
            this.btnSearch.CustomImages.Parent = this.btnSearch;
            this.btnSearch.FillColor = System.Drawing.Color.White;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.Black;
            this.btnSearch.HoverState.Parent = this.btnSearch;
            this.btnSearch.Location = new System.Drawing.Point(540, 25);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.ShadowDecoration.Parent = this.btnSearch;
            this.btnSearch.Size = new System.Drawing.Size(123, 41);
            this.btnSearch.TabIndex = 74;
            this.btnSearch.Tag = "0";
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // Employees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panelEmp);
            this.Controls.Add(this.label12);
            this.Name = "Employees";
            this.Size = new System.Drawing.Size(1563, 776);
            this.panelEmp.ResumeLayout(false);
            this.panelEmp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewEmployees)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panelEmp;
        private Guna.UI2.WinForms.Guna2TextBox txtAddress;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2DataGridView GridViewEmployees;
        private Guna.UI2.WinForms.Guna2Button buttonUpdateEmp;
        private Guna.UI2.WinForms.Guna2Button buttonDelEmp;
        private Guna.UI2.WinForms.Guna2TextBox txtSDT;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ComboBox cboGender;
        private Guna.UI2.WinForms.Guna2ComboBox cboPhanQuyen;
        private Guna.UI2.WinForms.Guna2Button buttonAddEmp;
        private Guna.UI2.WinForms.Guna2TextBox txtPassword;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox txtEmail;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2TextBox txtCMND;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private Guna.UI2.WinForms.Guna2TextBox txtName;
        private System.Windows.Forms.Label label11;
        private Guna.UI2.WinForms.Guna2Button btnSearch;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
    }
}
