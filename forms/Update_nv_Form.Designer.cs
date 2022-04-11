
namespace QL_2.forms
{
    partial class Update_nv_Form
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
            this.date = new System.Windows.Forms.DateTimePicker();
            this.panel6 = new System.Windows.Forms.Panel();
            this.combo_sex = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label_sex = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.text_usename = new Guna.UI2.WinForms.Guna2TextBox();
            this.label_usename = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.text_name = new Guna.UI2.WinForms.Guna2TextBox();
            this.label_name_nv = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_Title = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.text_sdt = new Guna.UI2.WinForms.Guna2TextBox();
            this.label_date = new System.Windows.Forms.Label();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.combo_chuc_vu = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label_chuc_vu = new System.Windows.Forms.Label();
            this.label_x = new System.Windows.Forms.Label();
            this.btn_cancel = new Guna.UI2.WinForms.Guna2Button();
            this.btn_update = new Guna.UI2.WinForms.Guna2Button();
            this.panel9 = new System.Windows.Forms.Panel();
            this.guna2TextBox_sdt = new Guna.UI2.WinForms.Guna2TextBox();
            this.label_sdt = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.text_address = new Guna.UI2.WinForms.Guna2TextBox();
            this.label_address = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel12.SuspendLayout();
            this.SuspendLayout();
            // 
            // date
            // 
            this.date.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.date.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date.Location = new System.Drawing.Point(271, 10);
            this.date.MaxDate = new System.DateTime(2005, 12, 31, 0, 0, 0, 0);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(164, 31);
            this.date.TabIndex = 5;
            this.date.Value = new System.DateTime(2005, 12, 31, 0, 0, 0, 0);
            // 
            // panel6
            // 
            this.panel6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel6.Controls.Add(this.combo_sex);
            this.panel6.Controls.Add(this.label_sex);
            this.panel6.Controls.Add(this.label6);
            this.panel6.Location = new System.Drawing.Point(10, 100);
            this.panel6.Name = "panel6";
            this.panel6.Padding = new System.Windows.Forms.Padding(100, 10, 120, 0);
            this.panel6.Size = new System.Drawing.Size(790, 50);
            this.panel6.TabIndex = 5;
            // 
            // combo_sex
            // 
            this.combo_sex.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.combo_sex.BackColor = System.Drawing.Color.Transparent;
            this.combo_sex.BorderRadius = 10;
            this.combo_sex.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.combo_sex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_sex.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.combo_sex.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.combo_sex.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.combo_sex.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.combo_sex.ItemHeight = 30;
            this.combo_sex.Items.AddRange(new object[] {
            "Nam",
            "Nữ",
            "Khác"});
            this.combo_sex.Location = new System.Drawing.Point(271, 9);
            this.combo_sex.Name = "combo_sex";
            this.combo_sex.Size = new System.Drawing.Size(164, 36);
            this.combo_sex.StartIndex = 0;
            this.combo_sex.TabIndex = 5;
            // 
            // label_sex
            // 
            this.label_sex.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_sex.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_sex.Location = new System.Drawing.Point(271, 10);
            this.label_sex.Name = "label_sex";
            this.label_sex.Size = new System.Drawing.Size(399, 40);
            this.label_sex.TabIndex = 4;
            this.label_sex.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label6.Location = new System.Drawing.Point(100, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(171, 40);
            this.label6.TabIndex = 3;
            this.label6.Text = "Giới tính :";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel5
            // 
            this.panel5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel5.Controls.Add(this.text_usename);
            this.panel5.Controls.Add(this.label_usename);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Location = new System.Drawing.Point(10, 50);
            this.panel5.Name = "panel5";
            this.panel5.Padding = new System.Windows.Forms.Padding(100, 10, 120, 0);
            this.panel5.Size = new System.Drawing.Size(790, 50);
            this.panel5.TabIndex = 4;
            // 
            // text_usename
            // 
            this.text_usename.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.text_usename.BorderRadius = 20;
            this.text_usename.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.text_usename.DefaultText = "";
            this.text_usename.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.text_usename.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.text_usename.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.text_usename.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.text_usename.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.text_usename.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.text_usename.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.text_usename.Location = new System.Drawing.Point(271, 10);
            this.text_usename.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.text_usename.Name = "text_usename";
            this.text_usename.PasswordChar = '\0';
            this.text_usename.PlaceholderText = "nhập tài khoản";
            this.text_usename.SelectedText = "";
            this.text_usename.Size = new System.Drawing.Size(399, 40);
            this.text_usename.TabIndex = 6;
            // 
            // label_usename
            // 
            this.label_usename.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_usename.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_usename.Location = new System.Drawing.Point(271, 10);
            this.label_usename.Name = "label_usename";
            this.label_usename.Size = new System.Drawing.Size(399, 40);
            this.label_usename.TabIndex = 4;
            this.label_usename.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label4.Location = new System.Drawing.Point(100, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(171, 40);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tài khoản :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // guna2TextBox1
            // 
            this.guna2TextBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guna2TextBox1.BorderRadius = 20;
            this.guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox1.DefaultText = "nhập địa chỉ";
            this.guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.Location = new System.Drawing.Point(271, 10);
            this.guna2TextBox1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.guna2TextBox1.Name = "guna2TextBox1";
            this.guna2TextBox1.PasswordChar = '\0';
            this.guna2TextBox1.PlaceholderText = "nhập sđt";
            this.guna2TextBox1.SelectedText = "";
            this.guna2TextBox1.Size = new System.Drawing.Size(399, 40);
            this.guna2TextBox1.TabIndex = 7;
            // 
            // text_name
            // 
            this.text_name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.text_name.BorderRadius = 20;
            this.text_name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.text_name.DefaultText = "";
            this.text_name.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.text_name.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.text_name.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.text_name.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.text_name.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.text_name.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_name.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.text_name.Location = new System.Drawing.Point(271, 10);
            this.text_name.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.text_name.Name = "text_name";
            this.text_name.PasswordChar = '\0';
            this.text_name.PlaceholderText = "nhập họ và tên ";
            this.text_name.SelectedText = "";
            this.text_name.Size = new System.Drawing.Size(399, 40);
            this.text_name.TabIndex = 5;
            // 
            // label_name_nv
            // 
            this.label_name_nv.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_name_nv.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_name_nv.Location = new System.Drawing.Point(271, 10);
            this.label_name_nv.Name = "label_name_nv";
            this.label_name_nv.Size = new System.Drawing.Size(399, 40);
            this.label_name_nv.TabIndex = 4;
            this.label_name_nv.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(100, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 40);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tên nhân viên :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // guna2Button2
            // 
            this.guna2Button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guna2Button2.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button2.BorderRadius = 20;
            this.guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.guna2Button2.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.guna2Button2.ForeColor = System.Drawing.Color.White;
            this.guna2Button2.Location = new System.Drawing.Point(486, 275);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.Size = new System.Drawing.Size(180, 45);
            this.guna2Button2.TabIndex = 7;
            this.guna2Button2.Text = "Hủy bỏ";
            // 
            // guna2Button1
            // 
            this.guna2Button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guna2Button1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button1.BorderRadius = 20;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(133, 275);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(180, 45);
            this.guna2Button1.TabIndex = 6;
            this.guna2Button1.Text = "Thêm";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackgroundImage = global::QL_2.Properties.Resources.Rectangle_4;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.label_Title);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 83);
            this.panel1.TabIndex = 4;
            // 
            // label_Title
            // 
            this.label_Title.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_Title.AutoSize = true;
            this.label_Title.BackColor = System.Drawing.Color.Transparent;
            this.label_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Title.Location = new System.Drawing.Point(285, 25);
            this.label_Title.Name = "label_Title";
            this.label_Title.Size = new System.Drawing.Size(236, 39);
            this.label_Title.TabIndex = 0;
            this.label_Title.Text = "Sửa nhân viên";
            // 
            // panel4
            // 
            this.panel4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel4.Controls.Add(this.text_name);
            this.panel4.Controls.Add(this.label_name_nv);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Location = new System.Drawing.Point(10, 0);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(100, 10, 120, 0);
            this.panel4.Size = new System.Drawing.Size(790, 50);
            this.panel4.TabIndex = 3;
            // 
            // text_sdt
            // 
            this.text_sdt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.text_sdt.BorderRadius = 20;
            this.text_sdt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.text_sdt.DefaultText = "";
            this.text_sdt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.text_sdt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.text_sdt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.text_sdt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.text_sdt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.text_sdt.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.text_sdt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.text_sdt.Location = new System.Drawing.Point(271, 10);
            this.text_sdt.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.text_sdt.Name = "text_sdt";
            this.text_sdt.PasswordChar = '\0';
            this.text_sdt.PlaceholderText = "nhập số điện thoại";
            this.text_sdt.SelectedText = "";
            this.text_sdt.Size = new System.Drawing.Size(399, 40);
            this.text_sdt.TabIndex = 8;
            // 
            // label_date
            // 
            this.label_date.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_date.Location = new System.Drawing.Point(271, 10);
            this.label_date.Name = "label_date";
            this.label_date.Size = new System.Drawing.Size(399, 40);
            this.label_date.TabIndex = 4;
            this.label_date.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel11
            // 
            this.panel11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel11.BackColor = System.Drawing.Color.Transparent;
            this.panel11.BackgroundImage = global::QL_2.Properties.Resources.Rectangle6;
            this.panel11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel11.Controls.Add(this.panel10);
            this.panel11.Controls.Add(this.btn_cancel);
            this.panel11.Controls.Add(this.btn_update);
            this.panel11.Controls.Add(this.panel9);
            this.panel11.Controls.Add(this.panel8);
            this.panel11.Controls.Add(this.panel7);
            this.panel11.Controls.Add(this.panel6);
            this.panel11.Controls.Add(this.panel5);
            this.panel11.Controls.Add(this.panel4);
            this.panel11.Location = new System.Drawing.Point(0, 0);
            this.panel11.Name = "panel11";
            this.panel11.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.panel11.Size = new System.Drawing.Size(800, 467);
            this.panel11.TabIndex = 3;
            // 
            // panel10
            // 
            this.panel10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel10.Controls.Add(this.combo_chuc_vu);
            this.panel10.Controls.Add(this.label_chuc_vu);
            this.panel10.Controls.Add(this.label_x);
            this.panel10.Location = new System.Drawing.Point(10, 300);
            this.panel10.Name = "panel10";
            this.panel10.Padding = new System.Windows.Forms.Padding(100, 10, 120, 0);
            this.panel10.Size = new System.Drawing.Size(790, 50);
            this.panel10.TabIndex = 10;
            // 
            // combo_chuc_vu
            // 
            this.combo_chuc_vu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.combo_chuc_vu.BackColor = System.Drawing.Color.Transparent;
            this.combo_chuc_vu.BorderRadius = 10;
            this.combo_chuc_vu.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.combo_chuc_vu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_chuc_vu.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.combo_chuc_vu.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.combo_chuc_vu.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.combo_chuc_vu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.combo_chuc_vu.ItemHeight = 30;
            this.combo_chuc_vu.Items.AddRange(new object[] {
            "Nhân viên",
            "Quản lý"});
            this.combo_chuc_vu.Location = new System.Drawing.Point(271, 6);
            this.combo_chuc_vu.Name = "combo_chuc_vu";
            this.combo_chuc_vu.Size = new System.Drawing.Size(164, 36);
            this.combo_chuc_vu.StartIndex = 0;
            this.combo_chuc_vu.TabIndex = 6;
            // 
            // label_chuc_vu
            // 
            this.label_chuc_vu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_chuc_vu.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_chuc_vu.Location = new System.Drawing.Point(271, 10);
            this.label_chuc_vu.Name = "label_chuc_vu";
            this.label_chuc_vu.Size = new System.Drawing.Size(399, 40);
            this.label_chuc_vu.TabIndex = 4;
            this.label_chuc_vu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_x
            // 
            this.label_x.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_x.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_x.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label_x.Location = new System.Drawing.Point(100, 10);
            this.label_x.Name = "label_x";
            this.label_x.Size = new System.Drawing.Size(171, 40);
            this.label_x.TabIndex = 3;
            this.label_x.Text = "Chức vụ";
            this.label_x.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_cancel
            // 
            this.btn_cancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_cancel.BackColor = System.Drawing.Color.Transparent;
            this.btn_cancel.BorderRadius = 20;
            this.btn_cancel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_cancel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_cancel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_cancel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_cancel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.btn_cancel.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.btn_cancel.ForeColor = System.Drawing.Color.White;
            this.btn_cancel.ImageSize = new System.Drawing.Size(40, 40);
            this.btn_cancel.Location = new System.Drawing.Point(486, 376);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(160, 60);
            this.btn_cancel.TabIndex = 9;
            this.btn_cancel.Text = "Hủy";
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_update
            // 
            this.btn_update.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_update.BackColor = System.Drawing.Color.Transparent;
            this.btn_update.BorderRadius = 20;
            this.btn_update.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_update.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_update.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_update.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_update.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.btn_update.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.btn_update.ForeColor = System.Drawing.Color.White;
            this.btn_update.ImageSize = new System.Drawing.Size(40, 40);
            this.btn_update.Location = new System.Drawing.Point(133, 376);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(160, 60);
            this.btn_update.TabIndex = 5;
            this.btn_update.Text = "Sửa";
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // panel9
            // 
            this.panel9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel9.Controls.Add(this.text_sdt);
            this.panel9.Controls.Add(this.guna2TextBox1);
            this.panel9.Controls.Add(this.guna2TextBox_sdt);
            this.panel9.Controls.Add(this.label_sdt);
            this.panel9.Controls.Add(this.label12);
            this.panel9.Location = new System.Drawing.Point(10, 250);
            this.panel9.Name = "panel9";
            this.panel9.Padding = new System.Windows.Forms.Padding(100, 10, 120, 0);
            this.panel9.Size = new System.Drawing.Size(790, 50);
            this.panel9.TabIndex = 8;
            // 
            // guna2TextBox_sdt
            // 
            this.guna2TextBox_sdt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guna2TextBox_sdt.BorderRadius = 20;
            this.guna2TextBox_sdt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox_sdt.DefaultText = "";
            this.guna2TextBox_sdt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox_sdt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox_sdt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox_sdt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox_sdt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox_sdt.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.guna2TextBox_sdt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox_sdt.Location = new System.Drawing.Point(271, 10);
            this.guna2TextBox_sdt.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.guna2TextBox_sdt.Name = "guna2TextBox_sdt";
            this.guna2TextBox_sdt.PasswordChar = '\0';
            this.guna2TextBox_sdt.PlaceholderText = "nhập sđt";
            this.guna2TextBox_sdt.SelectedText = "";
            this.guna2TextBox_sdt.Size = new System.Drawing.Size(399, 40);
            this.guna2TextBox_sdt.TabIndex = 6;
            // 
            // label_sdt
            // 
            this.label_sdt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_sdt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_sdt.Location = new System.Drawing.Point(271, 10);
            this.label_sdt.Name = "label_sdt";
            this.label_sdt.Size = new System.Drawing.Size(399, 40);
            this.label_sdt.TabIndex = 4;
            this.label_sdt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label12.Location = new System.Drawing.Point(100, 10);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(171, 40);
            this.label12.TabIndex = 3;
            this.label12.Text = "Số điện thoại :";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel8
            // 
            this.panel8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel8.Controls.Add(this.text_address);
            this.panel8.Controls.Add(this.label_address);
            this.panel8.Controls.Add(this.label10);
            this.panel8.Location = new System.Drawing.Point(10, 200);
            this.panel8.Name = "panel8";
            this.panel8.Padding = new System.Windows.Forms.Padding(100, 10, 120, 0);
            this.panel8.Size = new System.Drawing.Size(790, 50);
            this.panel8.TabIndex = 7;
            // 
            // text_address
            // 
            this.text_address.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.text_address.BorderRadius = 20;
            this.text_address.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.text_address.DefaultText = "";
            this.text_address.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.text_address.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.text_address.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.text_address.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.text_address.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.text_address.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.text_address.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.text_address.Location = new System.Drawing.Point(271, 10);
            this.text_address.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.text_address.Name = "text_address";
            this.text_address.PasswordChar = '\0';
            this.text_address.PlaceholderText = "nhập địa chỉ";
            this.text_address.SelectedText = "";
            this.text_address.Size = new System.Drawing.Size(399, 40);
            this.text_address.TabIndex = 6;
            // 
            // label_address
            // 
            this.label_address.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_address.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_address.Location = new System.Drawing.Point(271, 10);
            this.label_address.Name = "label_address";
            this.label_address.Size = new System.Drawing.Size(399, 40);
            this.label_address.TabIndex = 4;
            this.label_address.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label10.Location = new System.Drawing.Point(100, 10);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(171, 40);
            this.label10.TabIndex = 3;
            this.label10.Text = "Địa chỉ :";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel7
            // 
            this.panel7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel7.Controls.Add(this.date);
            this.panel7.Controls.Add(this.label_date);
            this.panel7.Controls.Add(this.label8);
            this.panel7.Location = new System.Drawing.Point(10, 150);
            this.panel7.Name = "panel7";
            this.panel7.Padding = new System.Windows.Forms.Padding(100, 10, 120, 0);
            this.panel7.Size = new System.Drawing.Size(790, 50);
            this.panel7.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label8.Location = new System.Drawing.Point(100, 10);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(171, 40);
            this.label8.TabIndex = 3;
            this.label8.Text = "Ngày sinh :";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.BackgroundImage = global::QL_2.Properties.Resources.Rectangle_5;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.panel12);
            this.panel2.Controls.Add(this.guna2Button2);
            this.panel2.Controls.Add(this.guna2Button1);
            this.panel2.Location = new System.Drawing.Point(0, 83);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 467);
            this.panel2.TabIndex = 5;
            // 
            // panel12
            // 
            this.panel12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel12.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel12.BackgroundImage = global::QL_2.Properties.Resources.Rectangle_4;
            this.panel12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel12.Controls.Add(this.panel11);
            this.panel12.Location = new System.Drawing.Point(0, 0);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(800, 467);
            this.panel12.TabIndex = 9;
            // 
            // Update_nv_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 550);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.MaximumSize = new System.Drawing.Size(816, 589);
            this.MinimumSize = new System.Drawing.Size(816, 589);
            this.Name = "Update_nv_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update_nv_Form";
            this.panel6.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel12.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.Panel panel6;
        private Guna.UI2.WinForms.Guna2ComboBox combo_sex;
        private System.Windows.Forms.Label label_sex;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel5;
        private Guna.UI2.WinForms.Guna2TextBox text_usename;
        private System.Windows.Forms.Label label_usename;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
        private Guna.UI2.WinForms.Guna2TextBox text_name;
        private System.Windows.Forms.Label label_name_nv;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_Title;
        private System.Windows.Forms.Panel panel4;
        private Guna.UI2.WinForms.Guna2TextBox text_sdt;
        private System.Windows.Forms.Label label_date;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel10;
        private Guna.UI2.WinForms.Guna2ComboBox combo_chuc_vu;
        private System.Windows.Forms.Label label_chuc_vu;
        private System.Windows.Forms.Label label_x;
        private Guna.UI2.WinForms.Guna2Button btn_cancel;
        private Guna.UI2.WinForms.Guna2Button btn_update;
        private System.Windows.Forms.Panel panel9;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox_sdt;
        private System.Windows.Forms.Label label_sdt;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel8;
        private Guna.UI2.WinForms.Guna2TextBox text_address;
        private System.Windows.Forms.Label label_address;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel12;
    }
}