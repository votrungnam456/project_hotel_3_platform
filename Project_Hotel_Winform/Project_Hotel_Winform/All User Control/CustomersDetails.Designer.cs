
namespace Project_Hotel_Winform.All_User_Control
{
    partial class CustomersDetails
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.GridViewCustomers = new Guna.UI2.WinForms.Guna2DataGridView();
            this.cboFilter = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewCustomers)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(85, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(364, 40);
            this.label1.TabIndex = 25;
            this.label1.Text = "Thông tin khách hàng";
            // 
            // GridViewCustomers
            // 
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.GridViewCustomers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.GridViewCustomers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridViewCustomers.BackgroundColor = System.Drawing.Color.White;
            this.GridViewCustomers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GridViewCustomers.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.GridViewCustomers.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridViewCustomers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.GridViewCustomers.ColumnHeadersHeight = 4;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GridViewCustomers.DefaultCellStyle = dataGridViewCellStyle9;
            this.GridViewCustomers.EnableHeadersVisualStyles = false;
            this.GridViewCustomers.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.GridViewCustomers.Location = new System.Drawing.Point(29, 219);
            this.GridViewCustomers.Name = "GridViewCustomers";
            this.GridViewCustomers.RowHeadersVisible = false;
            this.GridViewCustomers.RowHeadersWidth = 51;
            this.GridViewCustomers.RowTemplate.Height = 24;
            this.GridViewCustomers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridViewCustomers.Size = new System.Drawing.Size(1374, 540);
            this.GridViewCustomers.TabIndex = 27;
            this.GridViewCustomers.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.GridViewCustomers.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.GridViewCustomers.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.GridViewCustomers.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.GridViewCustomers.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.GridViewCustomers.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.GridViewCustomers.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.GridViewCustomers.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.GridViewCustomers.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.GridViewCustomers.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.GridViewCustomers.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.GridViewCustomers.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.GridViewCustomers.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.GridViewCustomers.ThemeStyle.HeaderStyle.Height = 4;
            this.GridViewCustomers.ThemeStyle.ReadOnly = false;
            this.GridViewCustomers.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.GridViewCustomers.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.GridViewCustomers.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.GridViewCustomers.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.GridViewCustomers.ThemeStyle.RowsStyle.Height = 24;
            this.GridViewCustomers.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.GridViewCustomers.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.GridViewCustomers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridViewCustomers_CellContentClick);
            // 
            // cboFilter
            // 
            this.cboFilter.BackColor = System.Drawing.Color.Transparent;
            this.cboFilter.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFilter.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboFilter.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboFilter.FocusedState.Parent = this.cboFilter;
            this.cboFilter.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboFilter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboFilter.HoverState.Parent = this.cboFilter;
            this.cboFilter.ItemHeight = 30;
            this.cboFilter.Items.AddRange(new object[] {
            "Tất cả khách hàng",
            "Khách hàng đang ở",
            "Khách hàng đã trả phòng"});
            this.cboFilter.ItemsAppearance.Parent = this.cboFilter;
            this.cboFilter.Location = new System.Drawing.Point(495, 157);
            this.cboFilter.Name = "cboFilter";
            this.cboFilter.ShadowDecoration.Parent = this.cboFilter;
            this.cboFilter.Size = new System.Drawing.Size(294, 36);
            this.cboFilter.TabIndex = 36;
            this.cboFilter.SelectedIndexChanged += new System.EventHandler(this.cboFilter_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(491, 115);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 19);
            this.label7.TabIndex = 35;
            this.label7.Text = "Tìm kiếm";
            // 
            // CustomersDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.cboFilter);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.GridViewCustomers);
            this.Controls.Add(this.label1);
            this.Name = "CustomersDetails";
            this.Size = new System.Drawing.Size(1424, 800);
            ((System.ComponentModel.ISupportInitialize)(this.GridViewCustomers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2DataGridView GridViewCustomers;
        private Guna.UI2.WinForms.Guna2ComboBox cboFilter;
        private System.Windows.Forms.Label label7;
    }
}
