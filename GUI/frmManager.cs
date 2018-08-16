using QUANLYWIN10.GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUANLYWIN10
{
    public partial class frmManager : Form
    {
        public frmManager()
        {
            InitializeComponent();
        }
        Form lockscreen,  Load;
        public frmManager(Form f, Form f2)
        {
            InitializeComponent();
            lockscreen = f;
            f.Close();
            pnTrangThaiBan.Visible = false;
            Load = f2;
            DLL.QuanLy.KhuVuc(lvBan);
            DLL.QuanLy.BanAn(lvBan,imlTable);
            DLL.QuanLy.DanhSachHoaDon(lvHoaDon);

        }
     
        private void tắtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Load.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            //panel1.Visible = !panel1.Visible;
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            if(lvBan.SelectedIndices.Count>0)
            {
                ListViewItem it = lvBan.SelectedItems[0];
                if (it.ImageIndex == 1)
                {
                    lblBan.Text = it.Text;
                    lblBan.Tag = lvBan.SelectedItems[0].Tag;
                    lblKhuVuc.Text = it.Group.Header;
                    lvCacMonDaGoi.Items.Clear();
                    pnTrangThaiBan.Visible = true;
                    DLL.QuanLy.DanhSachMonAnBan(lvCacMonDaGoi, lblBan.Tag.ToString());
                    try
                    {

                    }
                    catch { }
                }
                else pnTrangThaiBan.Visible = false;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pnGoiMon.Visible = !pnGoiMon.Visible;
            DLL.QuanLy.CapNhatGoiMon(tvGoiMon,imglMonAn);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
           
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if(e.Button==MouseButtons.Left)
                panel3.Visible = !panel3.Visible;
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (tvGoiMon.SelectedNode.Parent!=null)
            {
                lblLoai.Text = tvGoiMon.SelectedNode.Parent.Text;
                lblTenMon.Text = tvGoiMon.SelectedNode.Text;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pnGoiMon.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e) //Thêm món
        {
            
            if(lblBan.Tag.ToString()!="")
            {   string soban = lblBan.Tag.ToString();
                if (DLL.QuanLy.GoiMon(soban, tvGoiMon.SelectedNode.Tag.ToString(), txtSoLuongMon.Text))
                {
                    DLL.QuanLy.DanhSachMonAnBan(lvCacMonDaGoi, soban);
                    DLL.QuanLy.DanhSachHoaDon(lvHoaDon);
                }
            }
            //
           
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            panel3.Visible = false;
            Form f = new ThucDon();
            f.ShowInTaskbar = false;
            f.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lvBan.Items.Clear();
            DLL.QuanLy.KhuVuc(lvBan);
            DLL.QuanLy.BanAn(lvBan, imlTable);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            panel3.Visible = false;
            Form f = new frmQuanLyNhanVien();
            f.ShowInTaskbar = false;
            f.ShowDialog();
        }

        private void xóaBànToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void lvCacMonDaGoi_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void lvBan_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void lvBan_MouseDown(object sender, MouseEventArgs e)
        {
            if(e.Button==MouseButtons.Left)
            if (lvBan.SelectedItems.Count == 0)
            {
                pnTrangThaiBan.Visible = false;
                pnGoiMon.Visible = false;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (lvCacMonDaGoi.Items.Count > 0)
            {
                Form f = new ThanhToan(lblBan.Tag.ToString());
                f.ShowDialog();
            }
            else
                MessageBox.Show("Bàn chưa gọi món!");
        }

        private void mởBànToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(lvBan.SelectedItems.Count>0)
            if (DLL.QuanLy.MoBan(lvBan.SelectedItems[0].Tag.ToString(), "1"))
            {
                DLL.QuanLy.BanAn(lvBan, imlTable);
            }
            else
                MessageBox.Show("Không mở được bàn");
        }

        private void đóngBànToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lvBan.SelectedItems.Count > 0)
                if (DLL.QuanLy.DongBan(lvBan.SelectedItems[0].Tag.ToString()))
                {
                    DLL.QuanLy.BanAn(lvBan, imlTable);
                }
                else
                    MessageBox.Show("Không đóng được bàn");
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            Form f = new frmThongKe();
            panel3.Visible = false;
            f.ShowDialog();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new frmLockScreen(this, Load);
            f.Show();
        }
    }
}
