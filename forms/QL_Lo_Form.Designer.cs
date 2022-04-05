
namespace QL_2.forms
{
    partial class QL_Lo_Form
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
            this.dataGridView_Lo = new System.Windows.Forms.DataGridView();
            this.maLo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nsx = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hsd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.textBox_Finding = new Guna.UI2.WinForms.Guna2TextBox();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Lo)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.BackgroundImage = global::QL_2.Properties.Resources.Rectangle_4;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.dataGridView_Lo);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 200);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1000, 417);
            this.panel2.TabIndex = 1;
            // 
            // dataGridView_Lo
            // 
            this.dataGridView_Lo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_Lo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Lo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maLo,
            this.Nsx,
            this.Hsd,
            this.edit,
            this.delete});
            this.dataGridView_Lo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_Lo.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_Lo.Name = "dataGridView_Lo";
            this.dataGridView_Lo.Size = new System.Drawing.Size(1000, 417);
            this.dataGridView_Lo.TabIndex = 0;
            this.dataGridView_Lo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Lo_CellContentClick);
            // 
            // maLo
            // 
            this.maLo.FillWeight = 20.61856F;
            this.maLo.HeaderText = "Mã lô";
            this.maLo.Name = "maLo";
            // 
            // Nsx
            // 
            this.Nsx.FillWeight = 20.61856F;
            this.Nsx.HeaderText = "Ngày sản xuất ";
            this.Nsx.Name = "Nsx";
            // 
            // Hsd
            // 
            this.Hsd.FillWeight = 20.61856F;
            this.Hsd.HeaderText = "Hạn sử dụng ";
            this.Hsd.Name = "Hsd";
            // 
            // edit
            // 
            this.edit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.edit.HeaderText = "";
            this.edit.Name = "edit";
            this.edit.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.edit.Text = "Sửa";
            this.edit.ToolTipText = "Sửa";
            this.edit.UseColumnTextForButtonValue = true;
            // 
            // delete
            // 
            this.delete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.delete.FillWeight = 338.1443F;
            this.delete.HeaderText = "";
            this.delete.Name = "delete";
            this.delete.Text = "Xóa";
            this.delete.ToolTipText = "Xóa";
            this.delete.UseColumnTextForButtonValue = true;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::QL_2.Properties.Resources.Rectangle_4;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.guna2Button2);
            this.panel1.Controls.Add(this.guna2Button1);
            this.panel1.Controls.Add(this.textBox_Finding);
            this.panel1.Controls.Add(this.iconPictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1000, 200);
            this.panel1.TabIndex = 0;
            // 
            // guna2Button2
            // 
            this.guna2Button2.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button2.BorderRadius = 20;
            this.guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button2.FillColor = System.Drawing.Color.BlueViolet;
            this.guna2Button2.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.guna2Button2.ForeColor = System.Drawing.Color.White;
            this.guna2Button2.Image = global::QL_2.Properties.Resources.plus;
            this.guna2Button2.Location = new System.Drawing.Point(829, 28);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.Size = new System.Drawing.Size(133, 45);
            this.guna2Button2.TabIndex = 3;
            this.guna2Button2.Text = "Thêm lô";
            // 
            // guna2Button1
            // 
            this.guna2Button1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button1.BorderRadius = 20;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(28, 28);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(180, 45);
            this.guna2Button1.TabIndex = 2;
            this.guna2Button1.Text = "QL sản phẩm";
            // 
            // textBox_Finding
            // 
            this.textBox_Finding.Anchor = System.Windows.Forms.AnchorStyles.None;
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
            this.textBox_Finding.Location = new System.Drawing.Point(297, 124);
            this.textBox_Finding.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.textBox_Finding.Name = "textBox_Finding";
            this.textBox_Finding.PasswordChar = '\0';
            this.textBox_Finding.PlaceholderText = "nhập mã lô";
            this.textBox_Finding.SelectedText = "";
            this.textBox_Finding.Size = new System.Drawing.Size(450, 40);
            this.textBox_Finding.TabIndex = 1;
            this.textBox_Finding.TextChanged += new System.EventHandler(this.guna2TextBox1_TextChanged);
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.iconPictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.iconPictureBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.iconPictureBox1.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 50;
            this.iconPictureBox1.Location = new System.Drawing.Point(239, 124);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(50, 50);
            this.iconPictureBox1.TabIndex = 0;
            this.iconPictureBox1.TabStop = false;
            // 
            // QL_Lo_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 617);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "QL_Lo_Form";
            this.Text = "QL_Lo_Form";
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Lo)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView_Lo;
        private System.Windows.Forms.DataGridViewTextBoxColumn maLo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nsx;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hsd;
        private System.Windows.Forms.DataGridViewButtonColumn edit;
        private System.Windows.Forms.DataGridViewButtonColumn delete;
        private Guna.UI2.WinForms.Guna2TextBox textBox_Finding;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
    }
}