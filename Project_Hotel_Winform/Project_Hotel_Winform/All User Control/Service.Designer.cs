namespace Project_Hotel_Winform.All_User_Control
{
    partial class Service
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnAddService = new Guna.UI2.WinForms.Guna2Button();
            this.btnDelService = new Guna.UI2.WinForms.Guna2Button();
            this.GridViewDichVu = new Guna.UI2.WinForms.Guna2DataGridView();
            this.txtPriceService = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnUpdateService = new Guna.UI2.WinForms.Guna2Button();
            this.txtNameService = new Guna.UI2.WinForms.Guna2TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.listBoxService = new System.Windows.Forms.CheckedListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cboRoom = new Guna.UI2.WinForms.Guna2ComboBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewDichVu)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(71, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 40);
            this.label1.TabIndex = 1;
            this.label1.Text = "Dịch vụ";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(28, 103);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1202, 535);
            this.tabControl1.TabIndex = 30;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnAddService);
            this.tabPage1.Controls.Add(this.btnDelService);
            this.tabPage1.Controls.Add(this.GridViewDichVu);
            this.tabPage1.Controls.Add(this.txtPriceService);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.btnUpdateService);
            this.tabPage1.Controls.Add(this.txtNameService);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1194, 506);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Quản lý dịch vụ";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnAddService
            // 
            this.btnAddService.BorderRadius = 20;
            this.btnAddService.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.btnAddService.BorderThickness = 1;
            this.btnAddService.CheckedState.BorderColor = System.Drawing.Color.White;
            this.btnAddService.CheckedState.CustomBorderColor = System.Drawing.Color.White;
            this.btnAddService.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(221)))));
            this.btnAddService.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btnAddService.CheckedState.Parent = this.btnAddService;
            this.btnAddService.CustomImages.Parent = this.btnAddService;
            this.btnAddService.FillColor = System.Drawing.Color.White;
            this.btnAddService.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddService.ForeColor = System.Drawing.Color.Black;
            this.btnAddService.HoverState.Parent = this.btnAddService;
            this.btnAddService.Location = new System.Drawing.Point(729, 440);
            this.btnAddService.Name = "btnAddService";
            this.btnAddService.ShadowDecoration.Parent = this.btnAddService;
            this.btnAddService.Size = new System.Drawing.Size(149, 48);
            this.btnAddService.TabIndex = 63;
            this.btnAddService.Text = "Thêm dịch vụ";
            this.btnAddService.Click += new System.EventHandler(this.btnThemDichVu_Click);
            // 
            // btnDelService
            // 
            this.btnDelService.BorderRadius = 20;
            this.btnDelService.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.btnDelService.BorderThickness = 1;
            this.btnDelService.CheckedState.BorderColor = System.Drawing.Color.White;
            this.btnDelService.CheckedState.CustomBorderColor = System.Drawing.Color.White;
            this.btnDelService.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(221)))));
            this.btnDelService.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btnDelService.CheckedState.Parent = this.btnDelService;
            this.btnDelService.CustomImages.Parent = this.btnDelService;
            this.btnDelService.FillColor = System.Drawing.Color.White;
            this.btnDelService.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelService.ForeColor = System.Drawing.Color.Black;
            this.btnDelService.HoverState.Parent = this.btnDelService;
            this.btnDelService.Location = new System.Drawing.Point(884, 440);
            this.btnDelService.Name = "btnDelService";
            this.btnDelService.ShadowDecoration.Parent = this.btnDelService;
            this.btnDelService.Size = new System.Drawing.Size(149, 48);
            this.btnDelService.TabIndex = 62;
            this.btnDelService.Text = "Xoá dịch vụ";
            // 
            // GridViewDichVu
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.GridViewDichVu.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.GridViewDichVu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridViewDichVu.BackgroundColor = System.Drawing.Color.White;
            this.GridViewDichVu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GridViewDichVu.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.GridViewDichVu.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridViewDichVu.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.GridViewDichVu.ColumnHeadersHeight = 4;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GridViewDichVu.DefaultCellStyle = dataGridViewCellStyle3;
            this.GridViewDichVu.EnableHeadersVisualStyles = false;
            this.GridViewDichVu.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.GridViewDichVu.Location = new System.Drawing.Point(3, 6);
            this.GridViewDichVu.Name = "GridViewDichVu";
            this.GridViewDichVu.RowHeadersVisible = false;
            this.GridViewDichVu.RowHeadersWidth = 51;
            this.GridViewDichVu.RowTemplate.Height = 24;
            this.GridViewDichVu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridViewDichVu.Size = new System.Drawing.Size(722, 482);
            this.GridViewDichVu.TabIndex = 61;
            this.GridViewDichVu.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.GridViewDichVu.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.GridViewDichVu.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.GridViewDichVu.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.GridViewDichVu.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.GridViewDichVu.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.GridViewDichVu.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.GridViewDichVu.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.GridViewDichVu.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.GridViewDichVu.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.GridViewDichVu.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.GridViewDichVu.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.GridViewDichVu.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.GridViewDichVu.ThemeStyle.HeaderStyle.Height = 4;
            this.GridViewDichVu.ThemeStyle.ReadOnly = false;
            this.GridViewDichVu.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.GridViewDichVu.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.GridViewDichVu.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.GridViewDichVu.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.GridViewDichVu.ThemeStyle.RowsStyle.Height = 24;
            this.GridViewDichVu.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.GridViewDichVu.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.GridViewDichVu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridViewDichVu_CellClick);
            // 
            // txtPriceService
            // 
            this.txtPriceService.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPriceService.DefaultText = "";
            this.txtPriceService.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPriceService.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPriceService.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPriceService.DisabledState.Parent = this.txtPriceService;
            this.txtPriceService.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPriceService.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPriceService.FocusedState.Parent = this.txtPriceService;
            this.txtPriceService.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPriceService.HoverState.Parent = this.txtPriceService;
            this.txtPriceService.Location = new System.Drawing.Point(751, 336);
            this.txtPriceService.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPriceService.Name = "txtPriceService";
            this.txtPriceService.PasswordChar = '\0';
            this.txtPriceService.PlaceholderText = "";
            this.txtPriceService.SelectedText = "";
            this.txtPriceService.ShadowDecoration.Parent = this.txtPriceService;
            this.txtPriceService.Size = new System.Drawing.Size(415, 41);
            this.txtPriceService.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtPriceService.TabIndex = 24;
            this.txtPriceService.TextChanged += new System.EventHandler(this.txtSDT_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(747, 265);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 19);
            this.label2.TabIndex = 23;
            this.label2.Text = "Giá dịch vụ";
            // 
            // btnUpdateService
            // 
            this.btnUpdateService.BorderRadius = 20;
            this.btnUpdateService.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.btnUpdateService.BorderThickness = 1;
            this.btnUpdateService.CheckedState.BorderColor = System.Drawing.Color.White;
            this.btnUpdateService.CheckedState.CustomBorderColor = System.Drawing.Color.White;
            this.btnUpdateService.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(221)))));
            this.btnUpdateService.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btnUpdateService.CheckedState.Parent = this.btnUpdateService;
            this.btnUpdateService.CustomImages.Parent = this.btnUpdateService;
            this.btnUpdateService.FillColor = System.Drawing.Color.White;
            this.btnUpdateService.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateService.ForeColor = System.Drawing.Color.Black;
            this.btnUpdateService.HoverState.Parent = this.btnUpdateService;
            this.btnUpdateService.Location = new System.Drawing.Point(1039, 440);
            this.btnUpdateService.Name = "btnUpdateService";
            this.btnUpdateService.ShadowDecoration.Parent = this.btnUpdateService;
            this.btnUpdateService.Size = new System.Drawing.Size(149, 48);
            this.btnUpdateService.TabIndex = 19;
            this.btnUpdateService.Text = "Sửa dịch vụ";
            // 
            // txtNameService
            // 
            this.txtNameService.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNameService.DefaultText = "";
            this.txtNameService.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNameService.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNameService.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNameService.DisabledState.Parent = this.txtNameService;
            this.txtNameService.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNameService.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNameService.FocusedState.Parent = this.txtNameService;
            this.txtNameService.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNameService.HoverState.Parent = this.txtNameService;
            this.txtNameService.Location = new System.Drawing.Point(751, 172);
            this.txtNameService.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNameService.Name = "txtNameService";
            this.txtNameService.PasswordChar = '\0';
            this.txtNameService.PlaceholderText = "";
            this.txtNameService.SelectedText = "";
            this.txtNameService.ShadowDecoration.Parent = this.txtNameService;
            this.txtNameService.Size = new System.Drawing.Size(415, 41);
            this.txtNameService.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtNameService.TabIndex = 8;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(747, 112);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(87, 19);
            this.label11.TabIndex = 7;
            this.label11.Text = "Tên dịch vụ";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.cboRoom);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.guna2Button1);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.listBoxService);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1194, 506);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Đăng ký dịch vụ";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // listBoxService
            // 
            this.listBoxService.FormattingEnabled = true;
            this.listBoxService.Location = new System.Drawing.Point(17, 65);
            this.listBoxService.Name = "listBoxService";
            this.listBoxService.Size = new System.Drawing.Size(434, 395);
            this.listBoxService.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(34, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Dịch vụ";
            // 
            // guna2Button1
            // 
            this.guna2Button1.BorderRadius = 20;
            this.guna2Button1.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.guna2Button1.BorderThickness = 1;
            this.guna2Button1.CheckedState.BorderColor = System.Drawing.Color.White;
            this.guna2Button1.CheckedState.CustomBorderColor = System.Drawing.Color.White;
            this.guna2Button1.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(221)))));
            this.guna2Button1.CheckedState.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.FillColor = System.Drawing.Color.White;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.Black;
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Location = new System.Drawing.Point(1022, 412);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(149, 48);
            this.guna2Button1.TabIndex = 64;
            this.guna2Button1.Text = "Đăng ký dịch vụ";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(590, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(280, 25);
            this.label4.TabIndex = 65;
            this.label4.Text = "Các phòng đang được sử dụng";
            // 
            // cboRoom
            // 
            this.cboRoom.BackColor = System.Drawing.Color.Transparent;
            this.cboRoom.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboRoom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRoom.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboRoom.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboRoom.FocusedState.Parent = this.cboRoom;
            this.cboRoom.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboRoom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboRoom.HoverState.Parent = this.cboRoom;
            this.cboRoom.ItemHeight = 30;
            this.cboRoom.Items.AddRange(new object[] {
            "ac",
            "non-ac"});
            this.cboRoom.ItemsAppearance.Parent = this.cboRoom;
            this.cboRoom.Location = new System.Drawing.Point(595, 65);
            this.cboRoom.Name = "cboRoom";
            this.cboRoom.ShadowDecoration.Parent = this.cboRoom;
            this.cboRoom.Size = new System.Drawing.Size(576, 36);
            this.cboRoom.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.cboRoom.TabIndex = 66;
            // 
            // Service
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label1);
            this.Name = "Service";
            this.Size = new System.Drawing.Size(1255, 654);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewDichVu)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private Guna.UI2.WinForms.Guna2TextBox txtPriceService;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button btnUpdateService;
        private Guna.UI2.WinForms.Guna2TextBox txtNameService;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TabPage tabPage2;
        private Guna.UI2.WinForms.Guna2DataGridView GridViewDichVu;
        private Guna.UI2.WinForms.Guna2Button btnAddService;
        private Guna.UI2.WinForms.Guna2Button btnDelService;
        private System.Windows.Forms.CheckedListBox listBoxService;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2ComboBox cboRoom;
    }
}
