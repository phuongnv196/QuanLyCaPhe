using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUANLYWIN10.GUI
{
    public partial class frmQuanLyNhanVien : Form
    {
        public frmQuanLyNhanVien()
        {
            InitializeComponent();
            DLL.QuanLy.DanhSachNhanVien(lvNhanVien);
        }

        private void frmQuanLyNhanVien_Load(object sender, EventArgs e)
        {

        }
        bool KiemTraMaNhanVien(string manv, ListView lv)
        {
            foreach(ListViewItem it in lv.Items)
            {
                if (it.SubItems[0].Text == manv) return true;
            }
            return false;
        }
        private void btnThemNhanVien_Click(object sender, EventArgs e)
        {
            if (txtTenNhanVien.Text != "" && txtMaNhanVien.Text != "" && txtSoDienThoai.Text != "" && txtDia.Text != "" && txtSoNgayNghi.Text != "")
            {
                int kt = DLL.QuanLy.ThemNhanVien(txtMaNhanVien.Text, txtTenNhanVien.Text, txtDia.Text, txtSoDienThoai.Text, txtSoNgayNghi.Text, txtLuongCoBan.Text);
                 if(kt==0)    
                 {
                        MessageBox.Show("Thêm nhân viên không thành công!");
                 }
                 else if(kt == 1) 
                        DLL.QuanLy.DanhSachNhanVien(lvNhanVien);
                 else
                    MessageBox.Show("Mã nhân viên bị trùng!");
            }
            else MessageBox.Show("Thông tin không được trống!");
        }

        private void lvNhanVien_DoubleClick(object sender, EventArgs e)
        {
            ListViewItem it = lvNhanVien.SelectedItems[0];
            txtMaNhanVien.Text = it.SubItems[1].Text;
            txtTenNhanVien.Text = it.SubItems[2].Text;
            txtDia.Text = it.SubItems[3].Text;
            txtSoNgayNghi.Text = it.SubItems[5].Text;
            txtSoDienThoai.Text = it.SubItems[4].Text;
            txtLuongCoBan.Text = it.SubItems[6].Text;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtTenNhanVien.Text != "" && txtMaNhanVien.Text != "" && txtSoDienThoai.Text != "" && txtDia.Text != "" && txtSoNgayNghi.Text != "")
            {
                bool kt=DLL.QuanLy.SuaNhanVien(txtMaNhanVien.Text, txtTenNhanVien.Text, txtDia.Text, txtSoDienThoai.Text, txtSoNgayNghi.Text, txtLuongCoBan.Text);
                if (kt)
                {
                    DLL.QuanLy.DanhSachNhanVien(lvNhanVien);
                    txtThongBao.Text = "Sửa thông tin thành công";
                }
                else
                    MessageBox.Show("Sửa thông tin nhân viên không thành công!");
            }
            else MessageBox.Show("Thông tin không được trống!");
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            if (lvNhanVien.SelectedIndices.Count > 0)
            {
                xóaNhânViênToolStripMenuItem.Enabled = true;
                thanhToánLươngToolStripMenuItem.Enabled = true;
            }
            else
            {
                xóaNhânViênToolStripMenuItem.Enabled = false;
                thanhToánLươngToolStripMenuItem.Enabled = false;
            }
        }

        private void xóaNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lvNhanVien.SelectedIndices.Count > 0)
            {
                try
                {
                    if (!DLL.QuanLy.XoaNhanVien(lvNhanVien.SelectedItems[0].SubItems[1].Text))
                    {
                        lvNhanVien.Items.Clear();
                        DLL.QuanLy.DanhSachNhanVien(lvNhanVien);
                    }
                    else
                    {
                        MessageBox.Show("Xóa nhân viên thất bại!");
                    }
                }
                catch { MessageBox.Show("Không xóa được nhân viên!"); }
            }
        }

        

        private void thanhToánLươngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtThongBao.Text = "Thanh toán lương cho: " + lvNhanVien.SelectedItems[0].SubItems[2].Text + "\r\nSố tiền: " + DLL.QuanLy.TinhLuongNhanVien(lvNhanVien.SelectedItems[0].SubItems[1].Text).ToString(); 
        }

        private void txtMaNhanVien_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}
