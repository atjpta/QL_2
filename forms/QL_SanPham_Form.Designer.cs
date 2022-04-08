
namespace QL_2.forms
{
    partial class QL_SanPham_Form
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView_SanPham = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.guna2Button_refresh = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button_switch = new Guna.UI2.WinForms.Guna2Button();
            this.textBox_Finding = new Guna.UI2.WinForms.Guna2TextBox();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.ảnh = new System.Windows.Forms.DataGridViewImageColumn();
            this.Name_sanpham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maSp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonViTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_SanPham)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.BackgroundImage = global::QL_2.Properties.Resources.Rectangle_4;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.dataGridView_SanPham);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 200);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1000, 417);
            this.panel2.TabIndex = 3;
            // 
            // dataGridView_SanPham
            // 
            this.dataGridView_SanPham.AllowUserToAddRows = false;
            this.dataGridView_SanPham.AllowUserToDeleteRows = false;
            this.dataGridView_SanPham.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_SanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_SanPham.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ảnh,
            this.Name_sanpham,
            this.maSp,
            this.DonViTinh,
            this.SoLuong,
            this.edit,
            this.delete});
            this.dataGridView_SanPham.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_SanPham.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_SanPham.Name = "dataGridView_SanPham";
            this.dataGridView_SanPham.ReadOnly = true;
            this.dataGridView_SanPham.RowHeadersWidth = 24;
            this.dataGridView_SanPham.RowTemplate.Height = 220;
            this.dataGridView_SanPham.Size = new System.Drawing.Size(1000, 417);
            this.dataGridView_SanPham.TabIndex = 0;
            this.dataGridView_SanPham.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_SanPham_CellClick);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::QL_2.Properties.Resources.Rectangle_4;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.guna2Button_refresh);
            this.panel1.Controls.Add(this.guna2Button2);
            this.panel1.Controls.Add(this.guna2Button_switch);
            this.panel1.Controls.Add(this.textBox_Finding);
            this.panel1.Controls.Add(this.iconPictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1000, 200);
            this.panel1.TabIndex = 2;
            // 
            // guna2Button_refresh
            // 
            this.guna2Button_refresh.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button_refresh.BorderRadius = 20;
            this.guna2Button_refresh.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button_refresh.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button_refresh.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button_refresh.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button_refresh.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.guna2Button_refresh.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.guna2Button_refresh.ForeColor = System.Drawing.Color.White;
            this.guna2Button_refresh.Image = global::QL_2.Properties.Resources.refresh;
            this.guna2Button_refresh.ImageSize = new System.Drawing.Size(40, 40);
            this.guna2Button_refresh.Location = new System.Drawing.Point(12, 105);
            this.guna2Button_refresh.Name = "guna2Button_refresh";
            this.guna2Button_refresh.Size = new System.Drawing.Size(160, 60);
            this.guna2Button_refresh.TabIndex = 4;
            this.guna2Button_refresh.Text = "Làm mới";
            this.guna2Button_refresh.Click += new System.EventHandler(this.guna2Button_refresh_Click);
            // 
            // guna2Button2
            // 
            this.guna2Button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Button2.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button2.BorderRadius = 20;
            this.guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.guna2Button2.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.guna2Button2.ForeColor = System.Drawing.Color.White;
            this.guna2Button2.Image = global::QL_2.Properties.Resources.plus;
            this.guna2Button2.ImageSize = new System.Drawing.Size(40, 40);
            this.guna2Button2.Location = new System.Drawing.Point(748, 24);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.Size = new System.Drawing.Size(240, 60);
            this.guna2Button2.TabIndex = 3;
            this.guna2Button2.Text = "Thêm sản phẩm";
            this.guna2Button2.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // guna2Button_switch
            // 
            this.guna2Button_switch.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button_switch.BorderRadius = 20;
            this.guna2Button_switch.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button_switch.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button_switch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button_switch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button_switch.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.guna2Button_switch.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.guna2Button_switch.ForeColor = System.Drawing.Color.White;
            this.guna2Button_switch.Image = global::QL_2.Properties.Resources.backk;
            this.guna2Button_switch.ImageSize = new System.Drawing.Size(40, 40);
            this.guna2Button_switch.Location = new System.Drawing.Point(12, 24);
            this.guna2Button_switch.Name = "guna2Button_switch";
            this.guna2Button_switch.Size = new System.Drawing.Size(160, 60);
            this.guna2Button_switch.TabIndex = 2;
            this.guna2Button_switch.Text = "QL số lô";
            this.guna2Button_switch.Click += new System.EventHandler(this.guna2Button_switch_Click);
            // 
            // textBox_Finding
            // 
            this.textBox_Finding.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.textBox_Finding.BackColor = System.Drawing.Color.Transparent;
            this.textBox_Finding.BorderRadius = 20;
            this.textBox_Finding.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox_Finding.DefaultText = "";
            this.textBox_Finding.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBox_Finding.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBox_Finding.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBox_Finding.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBox_Finding.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBox_Finding.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.textBox_Finding.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBox_Finding.Location = new System.Drawing.Point(538, 105);
            this.textBox_Finding.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.textBox_Finding.Name = "textBox_Finding";
            this.textBox_Finding.PasswordChar = '\0';
            this.textBox_Finding.PlaceholderText = "nhập mã, tên sản phẩm ...";
            this.textBox_Finding.SelectedText = "";
            this.textBox_Finding.Size = new System.Drawing.Size(450, 60);
            this.textBox_Finding.TabIndex = 1;
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.iconPictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.iconPictureBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.iconPictureBox1.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 60;
            this.iconPictureBox1.Location = new System.Drawing.Point(478, 113);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(61, 60);
            this.iconPictureBox1.TabIndex = 0;
            this.iconPictureBox1.TabStop = false;
            // 
            // ảnh
            // 
            this.ảnh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ảnh.HeaderText = "Img";
            this.ảnh.Name = "ảnh";
            this.ảnh.ReadOnly = true;
            // 
            // Name_sanpham
            // 
            this.Name_sanpham.FillWeight = 25.77319F;
            this.Name_sanpham.HeaderText = "Tên sản phẩm";
            this.Name_sanpham.Name = "Name_sanpham";
            this.Name_sanpham.ReadOnly = true;
            // 
            // maSp
            // 
            this.maSp.FillWeight = 25.77319F;
            this.maSp.HeaderText = "Mã sản phẩm";
            this.maSp.Name = "maSp";
            this.maSp.ReadOnly = true;
            // 
            // DonViTinh
            // 
            this.DonViTinh.FillWeight = 25.77319F;
            this.DonViTinh.HeaderText = "Đơn vị tính";
            this.DonViTinh.Name = "DonViTinh";
            this.DonViTinh.ReadOnly = true;
            // 
            // SoLuong
            // 
            this.SoLuong.FillWeight = 25.77319F;
            this.SoLuong.HeaderText = "Số lượng";
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.ReadOnly = true;
            // 
            // edit
            // 
            this.edit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.edit.HeaderText = "Sửa";
            this.edit.Name = "edit";
            this.edit.ReadOnly = true;
            this.edit.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.edit.Text = "Sửa";
            this.edit.ToolTipText = "Sửa";
            this.edit.UseColumnTextForButtonValue = true;
            this.edit.Width = 50;
            // 
            // delete
            // 
            this.delete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.delete.FillWeight = 338.1443F;
            this.delete.HeaderText = "Xóa";
            this.delete.Name = "delete";
            this.delete.ReadOnly = true;
            this.delete.Text = "Xóa";
            this.delete.ToolTipText = "Xóa";
            this.delete.UseColumnTextForButtonValue = true;
            this.delete.Width = 50;
            // 
            // QL_SanPham_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 617);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "QL_SanPham_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QL_SanPham_Form";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.QL_SanPham_Form_FormClosing);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_SanPham)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView_SanPham;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button guna2Button_refresh;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2Button guna2Button_switch;
        private Guna.UI2.WinForms.Guna2TextBox textBox_Finding;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.DataGridViewImageColumn ảnh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name_sanpham;
        private System.Windows.Forms.DataGridViewTextBoxColumn maSp;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonViTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewButtonColumn edit;
        private System.Windows.Forms.DataGridViewButtonColumn delete;
    }
}