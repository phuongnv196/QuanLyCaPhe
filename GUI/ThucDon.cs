using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUANLYWIN10.GUI
{
    public partial class ThucDon : Form
    {
        public ThucDon()
        {
            InitializeComponent();
            DLL.QuanLy.DanhSachMonAn(listView1, imgThucDon);
            DLL.QuanLy.LoaiMonAn(cbbLoaiMonAn);
            DLL.QuanLy.LoaiMonAn(cbbLoaiMon);
        }
        string HinhAnhBase64;
        public string ImageToBase64(Image image, System.Drawing.Imaging.ImageFormat format)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, format);
                byte[] imageBytes = ms.ToArray();
                string base64String = Convert.ToBase64String(imageBytes);
                return base64String;
            }
        }

        string MaLoaiMonAn;
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtTenMonAn.Text != "" && txtDonGia.Text != "" && cbbLoaiMonAn.SelectedIndex >= 0)
            {
                Bitmap bm = new Bitmap(ptbHinhAnh.Image);
                HinhAnhBase64 = ImageToBase64(bm, System.Drawing.Imaging.ImageFormat.Jpeg);
                if (DLL.QuanLy.SuaMonAn(txtTenMonAn.Tag.ToString(), txtTenMonAn.Text, txtDonGia.Text, MaLoaiMonAn, HinhAnhBase64))
                {
                    MessageBox.Show("Sửa thông tin thành công!");
                    HinhAnhBase64 = "";
                    listView1.Items.Clear();
                    imgThucDon.Images.Clear();
                    DLL.QuanLy.DanhSachMonAn(listView1, imgThucDon);
                }
                else
                    MessageBox.Show("Sửa thông tin không thành công!");
            }
            else
                MessageBox.Show("Thông tin món nhập vào chưa đầy đủ!");
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(cbbLoaiMonAn.SelectedIndex.ToString());
            //MaLoaiMonAn = cbbLoaiMonAn.Items[cbbLoaiMonAn.SelectedIndex].ToString().Split('-')[0];
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            if(listView1.SelectedIndices.Count>0)
            {
                xóaToolStripMenuItem.Enabled = true;
            }
            else
            {
                xóaToolStripMenuItem.Enabled = false;
            }
        }

        private void xóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedIndices.Count > 0)
            {
                if (DLL.QuanLy.XoaMon(listView1.SelectedItems[0].Tag.ToString()))
                {
                    listView1.Items.Clear();
                    imgThucDon.Images.Clear();
                    DLL.QuanLy.DanhSachMonAn(listView1, imgThucDon);
                }
                else
                {
                    MessageBox.Show("Xóa món thất bại!");
                }
            }
        }

        private void btnHinhAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            if (ofd.FileName != "")
            {
                FileStream f = new FileStream(ofd.FileName, FileMode.Open);
                Image img = new Bitmap(f);
                ptbHinhAnh.Image = img;
                f.Close();
            }

        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            DLL.QuanLy.LayThongTinMon(listView1.SelectedItems[0].Tag.ToString(), txtTenMonAn, cbbLoaiMonAn, txtDonGia, ptbHinhAnh);
        }

        private void cbbLoaiMonAn_SelectedIndexChanged(object sender, EventArgs e)
        {
            MaLoaiMonAn = cbbLoaiMonAn.Items[cbbLoaiMonAn.SelectedIndex].ToString().Split('-')[0];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtThemTenMon.Text != "" && txtGiaMon.Text != "" && cbbLoaiMon.SelectedIndex >= 0 && HinhAnhBase64 != "")
            {
                string _maLoai = cbbLoaiMon.Items[cbbLoaiMon.SelectedIndex].ToString().Split('-')[0];
                if (DLL.QuanLy.ThemMon(txtThemTenMon.Text, txtGiaMon.Text, _maLoai, HinhAnhBase64))
                {
                    MessageBox.Show("Thêm thành công!");
                    HinhAnhBase64 = "";
                    txtThemTenMon.Text = "";
                    ptbHinhAnhThem.Image = null;
                    DLL.QuanLy.DanhSachMonAn(listView1, imgThucDon);
                }
                else
                {
                    MessageBox.Show("Thêm thất bại!");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ các trường");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (DLL.QuanLy.ThemLoaiMon(txtThemLoaiMon.Text))
            {
                MessageBox.Show("Thêm loại món thành công");
                DLL.QuanLy.LoaiMonAn(cbbLoaiMon);
            }
            else
                MessageBox.Show("Thêm loại món không thành công");
        }

        private void btnThemLoaiMonAn_Click(object sender, EventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            if (ofd.FileName != "")
            {
                FileStream f = new FileStream(ofd.FileName, FileMode.Open);
                Image img = new Bitmap(f);
                ptbHinhAnhThem.Image = img;
                HinhAnhBase64 = ImageToBase64(img, System.Drawing.Imaging.ImageFormat.Png);
                f.Close();
            }
        }
    }
}
