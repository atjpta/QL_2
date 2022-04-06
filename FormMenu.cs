using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using QL_2.forms;

namespace QL_2
{
    public partial class FormMenu : Form
    {
        // các thuộc tính
        private IconButton currentbtn;
        private Panel leftBorderBtn;
        private Form currentChilForm;
        


        // hàm xây dựng 
        public FormMenu()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60); // chỉnh size  
            panelMenu.Controls.Add(leftBorderBtn);

            // tắt thanh tieu đề mặc định và các tùy chỉnh liên quan    
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea; // k cho che đi thanh bên dưới của máy
            
            OpenchildForm(new LoginForm(this));
        }

        // hàm màu
        private struct RBGColor
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);
        }

        // hàm thêm hiệu ứng cho nút dc ấn 
        public void ActivateBtn(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                disableBtn();
                //nút btn
                currentbtn = (IconButton)senderBtn;
                currentbtn.BackColor = Color.FromArgb(37, 36, 81); //thay đổi màu nền btn
                currentbtn.ForeColor = color; //thay đổi màu chữ 
                currentbtn.TextAlign = ContentAlignment.MiddleCenter; //căn chỉnh về chính giữa
                currentbtn.IconColor = color; // thay đổi màu icon
                currentbtn.TextImageRelation = TextImageRelation.TextBeforeImage; // thay đổi tỉ lệ văn bản và hình ảnh
                currentbtn.ImageAlign = ContentAlignment.MiddleRight; // chuyển icon sang phải

                // chỉnh màu cạnh bên trái
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentbtn.Location.Y); // vị trí 
                leftBorderBtn.Visible = true; // hiển thị ra
                leftBorderBtn.BringToFront();

            }
        }

        // hàm hủy bỏ hiệu ứng
        public void disableBtn()
        {
            if (currentbtn != null)
            {
                currentbtn.BackColor = Color.FromArgb(30, 0, 90); //thay đổi màu nền btn
                currentbtn.ForeColor = Color.White; //thay đổi màu chữ 
                currentbtn.TextAlign = ContentAlignment.MiddleLeft; //căn chỉnh về chính giữa
                currentbtn.IconColor = Color.White; // thay đổi màu icon
                currentbtn.TextImageRelation = TextImageRelation.ImageBeforeText; // thay đổi tỉ lệ văn bản và hình ảnh
                currentbtn.ImageAlign = ContentAlignment.MiddleLeft; // chuyển icon sang phải

            }
        }

        // hàm chuyển sang tab con
        public void OpenchildForm(Form childForm)
        {
            if(currentChilForm != null)
            {
                //đóng form hiện tại lại 
                currentChilForm.Close();
                labelchild.Text = "";
            }
            currentChilForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            childForm.Dock = DockStyle.Fill;
        }


        //  ----các nút tab
        private void iconButton1_Click(object sender, EventArgs e)
        {
            ActivateBtn(sender, RBGColor.color1);
            OpenchildForm(new HomeForm(this));

        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            ActivateBtn(sender, RBGColor.color1);

        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            ActivateBtn(sender, RBGColor.color2);
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            ActivateBtn(sender, RBGColor.color3);
        }

        private void iconButton5_Click(object sender, EventArgs e)
        {
            ActivateBtn(sender, RBGColor.color4);
        }

        private void iconButton6_Click(object sender, EventArgs e)
        {
            ActivateBtn(sender, RBGColor.color5);
            OpenchildForm(new LoginForm(this));
        }

       


        //hàm reset lại ban đầu
        private void Reset()
        {
            disableBtn();
            leftBorderBtn.Visible = false;
            OpenchildForm(new HomeForm(this));

        }

        //di chuyển app
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private static extern void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wMsg, int wParam, int lparam);

        private void panelTitle_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_max_Click(object sender, EventArgs e)
        {
            if(WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                WindowState = FormWindowState.Normal;
            }
        }

        private void btn_min_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }


        // ấn logo thì quay về home
        private void Logo_Click(object sender, EventArgs e)
        {
            if (currentChilForm != null)
            {
                currentChilForm.Close();
            }
            Reset();
        }

        public void GoToHome()
        {
            OpenchildForm(new HomeForm(this));
        }
        
        public void chargeTitle(string title )
        {
            labelchild.Text = title;
        }
    }
}