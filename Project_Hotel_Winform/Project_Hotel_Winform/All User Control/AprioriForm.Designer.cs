
namespace Project_Hotel_Winform.All_User_Control
{
    partial class AprioriForm
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
            this.btnTuVan = new Guna.UI2.WinForms.Guna2Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.cboLoaiPhong = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnTuVan
            // 
            this.btnTuVan.BorderRadius = 20;
            this.btnTuVan.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.btnTuVan.BorderThickness = 1;
            this.btnTuVan.CheckedState.BorderColor = System.Drawing.Color.White;
            this.btnTuVan.CheckedState.CustomBorderColor = System.Drawing.Color.White;
            this.btnTuVan.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(221)))));
            this.btnTuVan.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btnTuVan.CheckedState.Parent = this.btnTuVan;
            this.btnTuVan.CustomImages.Parent = this.btnTuVan;
            this.btnTuVan.FillColor = System.Drawing.Color.White;
            this.btnTuVan.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTuVan.ForeColor = System.Drawing.Color.Black;
            this.btnTuVan.HoverState.Parent = this.btnTuVan;
            this.btnTuVan.Location = new System.Drawing.Point(1107, 91);
            this.btnTuVan.Name = "btnTuVan";
            this.btnTuVan.ShadowDecoration.Parent = this.btnTuVan;
            this.btnTuVan.Size = new System.Drawing.Size(149, 48);
            this.btnTuVan.TabIndex = 34;
            this.btnTuVan.Text = "Tư vấn";
            this.btnTuVan.Click += new System.EventHandler(this.btnTuVan_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(20, 145);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1510, 594);
            this.panel1.TabIndex = 35;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(48, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(516, 40);
            this.label1.TabIndex = 36;
            this.label1.Text = "Tư vấn dịch vụ cho khách hàng";
            // 
            // cboLoaiPhong
            // 
            this.cboLoaiPhong.BackColor = System.Drawing.Color.Transparent;
            this.cboLoaiPhong.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboLoaiPhong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLoaiPhong.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboLoaiPhong.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboLoaiPhong.FocusedState.Parent = this.cboLoaiPhong;
            this.cboLoaiPhong.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboLoaiPhong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboLoaiPhong.HoverState.Parent = this.cboLoaiPhong;
            this.cboLoaiPhong.ItemHeight = 30;
            this.cboLoaiPhong.ItemsAppearance.Parent = this.cboLoaiPhong;
            this.cboLoaiPhong.Location = new System.Drawing.Point(423, 91);
            this.cboLoaiPhong.Name = "cboLoaiPhong";
            this.cboLoaiPhong.ShadowDecoration.Parent = this.cboLoaiPhong;
            this.cboLoaiPhong.Size = new System.Drawing.Size(563, 36);
            this.cboLoaiPhong.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.cboLoaiPhong.TabIndex = 37;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(303, 108);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(85, 19);
            this.label12.TabIndex = 38;
            this.label12.Text = "Loại phòng";
            // 
            // AprioriForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label12);
            this.Controls.Add(this.cboLoaiPhong);
            this.Controls.Add(this.btnTuVan);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "AprioriForm";
            this.Size = new System.Drawing.Size(1560, 752);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnTuVan;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ComboBox cboLoaiPhong;
        private System.Windows.Forms.Label label12;
    }
}
