using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUANLYWIN10
{
    public partial class frmLockScreen : Form
    {
        public frmLockScreen()
        {
            InitializeComponent();
            SetTime();
        }
        Form Load;
        public frmLockScreen(Form form)
        {
            InitializeComponent();
            Load = form;          
            Load.Hide(); 
        }
        public frmLockScreen(Form f1, Form f2)
        {
            InitializeComponent();
            Load = f2;
            f1.Close();
            SetTime();
        }
        void SetTime()
        {
            if (DateTime.Now.Minute >= 10)
                lblTime.Text = DateTime.Now.Hour.ToString() + ":" + DateTime.Now.Minute.ToString();
            else
                lblTime.Text = DateTime.Now.Hour.ToString() + ":0" + DateTime.Now.Minute.ToString();
            lblDate.Text = DateTime.Now.Day.ToString() + "-" + DateTime.Now.Month.ToString() + "-" + DateTime.Now.Year.ToString();
        }
        private void timer1_Tick(object sender, EventArgs e) //Thời gian trên Màn hình khóa
        {
            SetTime();
        }

       
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        //public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        public static extern int SendMessage(IntPtr hWnd, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
      
        

        private void button1_Click(object sender, EventArgs e)
        {
            if (DLL.QuanLy.Login(txtUser.Text, txtPass.Text))
            {
                Form frm = new frmManager(this, Load);
                pnLock.Visible = true;
                frm.Show();
            }
            else
            {
                lblThongBao.ForeColor = Color.Red;
                lblThongBao.Text = "Đăng nhập thất bại";
            }
        }
        int Time = 15;
        void LockTime()
        {
            while (true)
            {
                if (Time == 0)
                {
                   
                    pnLock.Visible = true;
                    Time = 15;
                    break;     
                }
                Time--;
                Thread.Sleep(1000);
            }

        }

        private void pnLock_DoubleClick(object sender, EventArgs e)
        {
            pnLock.Visible = false;
            CheckForIllegalCrossThreadCalls = false;
            ThreadStart st = new ThreadStart(LockTime);
            Thread th = new Thread(st);
            th.Start();
            //th.Abort();
        }

        private void frmLockScreen_FormClosing(object sender, FormClosingEventArgs e)
        {
            Time = 0;
        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {
            lblThongBao.Text = "";
        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {
            lblThongBao.Text = "";
        }
    }
}

