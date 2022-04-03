
namespace QL_2.forms
{
    partial class LoginForm
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
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.guna2Button1_submit = new Guna.UI2.WinForms.Guna2Button();
            this.guna2TextBox_pwd = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2_nhoUseName = new System.Windows.Forms.Label();
            this.guna2ToggleSwitch1 = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.label1 = new System.Windows.Forms.Label();
            this.iconPictureBox_pwd = new FontAwesome.Sharp.IconPictureBox();
            this.guna2TextBox_taikhoan = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox_pwd)).BeginInit();
            this.SuspendLayout();
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.iconPictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.iconPictureBox1.ForeColor = System.Drawing.Color.Black;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.User;
            this.iconPictureBox1.IconColor = System.Drawing.Color.Black;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Regular;
            this.iconPictureBox1.IconSize = 50;
            this.iconPictureBox1.Location = new System.Drawing.Point(237, 188);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(70, 50);
            this.iconPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.iconPictureBox1.TabIndex = 16;
            this.iconPictureBox1.TabStop = false;
            // 
            // guna2Button1_submit
            // 
            this.guna2Button1_submit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guna2Button1_submit.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button1_submit.BorderRadius = 20;
            this.guna2Button1_submit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1_submit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1_submit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1_submit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1_submit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.guna2Button1_submit.Font = new System.Drawing.Font("Segoe UI", 24F);
            this.guna2Button1_submit.ForeColor = System.Drawing.Color.White;
            this.guna2Button1_submit.Location = new System.Drawing.Point(427, 478);
            this.guna2Button1_submit.Name = "guna2Button1_submit";
            this.guna2Button1_submit.Size = new System.Drawing.Size(205, 64);
            this.guna2Button1_submit.TabIndex = 15;
            this.guna2Button1_submit.Text = "Đăng nhập";
            this.guna2Button1_submit.Click += new System.EventHandler(this.guna2Button1_submit_Click_1);
            // 
            // guna2TextBox_pwd
            // 
            this.guna2TextBox_pwd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guna2TextBox_pwd.BackColor = System.Drawing.Color.Transparent;
            this.guna2TextBox_pwd.BorderRadius = 20;
            this.guna2TextBox_pwd.BorderThickness = 0;
            this.guna2TextBox_pwd.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox_pwd.DefaultText = "";
            this.guna2TextBox_pwd.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox_pwd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox_pwd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox_pwd.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox_pwd.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox_pwd.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.guna2TextBox_pwd.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox_pwd.Location = new System.Drawing.Point(310, 278);
            this.guna2TextBox_pwd.Margin = new System.Windows.Forms.Padding(0);
            this.guna2TextBox_pwd.Name = "guna2TextBox_pwd";
            this.guna2TextBox_pwd.PasswordChar = '*';
            this.guna2TextBox_pwd.PlaceholderText = "Nhập mật khẩu";
            this.guna2TextBox_pwd.SelectedText = "";
            this.guna2TextBox_pwd.Size = new System.Drawing.Size(500, 50);
            this.guna2TextBox_pwd.TabIndex = 19;
            // 
            // label2_nhoUseName
            // 
            this.label2_nhoUseName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2_nhoUseName.AutoSize = true;
            this.label2_nhoUseName.BackColor = System.Drawing.Color.Transparent;
            this.label2_nhoUseName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label2_nhoUseName.Location = new System.Drawing.Point(486, 392);
            this.label2_nhoUseName.Name = "label2_nhoUseName";
            this.label2_nhoUseName.Size = new System.Drawing.Size(146, 26);
            this.label2_nhoUseName.TabIndex = 14;
            this.label2_nhoUseName.Text = "Nhớ tài khoản";
            // 
            // guna2ToggleSwitch1
            // 
            this.guna2ToggleSwitch1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guna2ToggleSwitch1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ToggleSwitch1.Checked = true;
            this.guna2ToggleSwitch1.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ToggleSwitch1.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ToggleSwitch1.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch1.CheckedState.InnerColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch1.Location = new System.Drawing.Point(427, 392);
            this.guna2ToggleSwitch1.Name = "guna2ToggleSwitch1";
            this.guna2ToggleSwitch1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.guna2ToggleSwitch1.Size = new System.Drawing.Size(53, 26);
            this.guna2ToggleSwitch1.TabIndex = 13;
            this.guna2ToggleSwitch1.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2ToggleSwitch1.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2ToggleSwitch1.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch1.UncheckedState.InnerColor = System.Drawing.Color.White;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(418, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 46);
            this.label1.TabIndex = 12;
            this.label1.Text = "Đăng nhập";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // iconPictureBox_pwd
            // 
            this.iconPictureBox_pwd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.iconPictureBox_pwd.BackColor = System.Drawing.Color.Transparent;
            this.iconPictureBox_pwd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.iconPictureBox_pwd.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox_pwd.IconChar = FontAwesome.Sharp.IconChar.Lock;
            this.iconPictureBox_pwd.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox_pwd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox_pwd.IconSize = 50;
            this.iconPictureBox_pwd.Location = new System.Drawing.Point(237, 278);
            this.iconPictureBox_pwd.Name = "iconPictureBox_pwd";
            this.iconPictureBox_pwd.Size = new System.Drawing.Size(70, 50);
            this.iconPictureBox_pwd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.iconPictureBox_pwd.TabIndex = 18;
            this.iconPictureBox_pwd.TabStop = false;
            // 
            // guna2TextBox_taikhoan
            // 
            this.guna2TextBox_taikhoan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guna2TextBox_taikhoan.BackColor = System.Drawing.Color.Transparent;
            this.guna2TextBox_taikhoan.BorderRadius = 20;
            this.guna2TextBox_taikhoan.BorderThickness = 0;
            this.guna2TextBox_taikhoan.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox_taikhoan.DefaultText = "";
            this.guna2TextBox_taikhoan.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox_taikhoan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox_taikhoan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox_taikhoan.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox_taikhoan.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox_taikhoan.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.guna2TextBox_taikhoan.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox_taikhoan.Location = new System.Drawing.Point(310, 188);
            this.guna2TextBox_taikhoan.Margin = new System.Windows.Forms.Padding(0);
            this.guna2TextBox_taikhoan.Name = "guna2TextBox_taikhoan";
            this.guna2TextBox_taikhoan.PasswordChar = '\0';
            this.guna2TextBox_taikhoan.PlaceholderText = "Nhập tài khoản";
            this.guna2TextBox_taikhoan.SelectedText = "";
            this.guna2TextBox_taikhoan.Size = new System.Drawing.Size(500, 50);
            this.guna2TextBox_taikhoan.TabIndex = 17;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QL_2.Properties.Resources.Rectangle_3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1000, 617);
            this.Controls.Add(this.iconPictureBox1);
            this.Controls.Add(this.guna2Button1_submit);
            this.Controls.Add(this.guna2TextBox_pwd);
            this.Controls.Add(this.label2_nhoUseName);
            this.Controls.Add(this.guna2ToggleSwitch1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.iconPictureBox_pwd);
            this.Controls.Add(this.guna2TextBox_taikhoan);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox_pwd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private Guna.UI2.WinForms.Guna2Button guna2Button1_submit;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox_pwd;
        private System.Windows.Forms.Label label2_nhoUseName;
        private Guna.UI2.WinForms.Guna2ToggleSwitch guna2ToggleSwitch1;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox_pwd;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox_taikhoan;
    }
}