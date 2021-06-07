
namespace Project_Hotel_Winform.All_User_Control
{
    partial class Apriori
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
            this.label1 = new System.Windows.Forms.Label();
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
            this.btnTuVan.Location = new System.Drawing.Point(1078, 659);
            this.btnTuVan.Name = "btnTuVan";
            this.btnTuVan.ShadowDecoration.Parent = this.btnTuVan;
            this.btnTuVan.Size = new System.Drawing.Size(149, 48);
            this.btnTuVan.TabIndex = 34;
            this.btnTuVan.Text = "Tư vấn";
            this.btnTuVan.Click += new System.EventHandler(this.btnTuVan_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(507, 350);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 35;
            this.label1.Text = "label1";
            // 
            // Apriori
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTuVan);
            this.Name = "Apriori";
            this.Size = new System.Drawing.Size(1560, 752);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnTuVan;
        private System.Windows.Forms.Label label1;
    }
}
