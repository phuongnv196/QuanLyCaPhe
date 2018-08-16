using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Drawing;
using System.IO;

namespace QUANLYWIN10.DLL
{
    class QuanLy
    {
        public static bool Login(string _User, string _Pass)
        {
            int Count = DAL.QuanLy.Login(_User, _Pass);
            if (Count == 0)
                return false;
            else
                return true;
        }
        public static void KhuVuc(ListView BanAn)
        {
            DataTable tb = new DataTable();
            tb = DAL.QuanLy.KhuVuc();
            foreach (DataRow dr in tb.Rows)
            {
                BanAn.Groups.Add(dr[0].ToString(), dr[1].ToString());
            }
        }
        public static void BanAn(ListView BanAn, ImageList imglist)
        {
            DataTable tb = new DataTable();
            BanAn.Items.Clear();
            tb = DAL.QuanLy.BanAn();
            foreach (DataRow dr in tb.Rows)
            {
                ListViewItem it = new ListViewItem(dr[1].ToString());
                it.Tag = dr[0].ToString();
                foreach (ListViewGroup lvg in BanAn.Groups)
                {
                    if (lvg.Name == dr[3].ToString())
                        it.Group = lvg;
                }

                if (dr[2].ToString() == "0")
                {
                    it.ImageIndex = 0;
                }
                else
                {
                    it.ImageIndex = 1;
                }
                BanAn.Items.Add(it);
            }
        }
        public static void LoaiMonAn(ComboBox cbb)
        {
            DataTable tb = new DataTable();
            tb = DAL.QuanLy.LoaiMonAn();
            cbb.Items.Clear();
            foreach (DataRow dr in tb.Rows)
            {
                cbb.Items.Add(dr[0].ToString() + "-" + dr[1].ToString());
            }
        }
        public static bool ThemMon(string TenMonAn, string DonGia, string MaLoaiMonAn, string HinhAnh)
        {
            if (DAL.QuanLy.ChenMonAn(TenMonAn, DonGia, MaLoaiMonAn, HinhAnh) == 0)
                return false;
            else
                return true;
        }
        public static bool ThemLoaiMon(string TenLoaiMon)
        {
            if (DAL.QuanLy.ThemLoaiMon(TenLoaiMon) == 0)
                return false;
            else
                return true;
        }
        public static void DanhSachMonAn(ListView MonAn, ImageList imlMonAn)
        {
            MonAn.Items.Clear();
            imlMonAn.Images.Clear();

            imlMonAn.Images.Add(Properties.Resources.nia);
            DataTable tb = new DataTable();
            tb = DAL.QuanLy.LoaiMonAn();
            foreach (DataRow dr in tb.Rows)
            {
                MonAn.Groups.Add(dr[0].ToString(), dr[1].ToString());
            }
            tb = DAL.QuanLy.MonAn();
            int i = 1;
            foreach (DataRow dr in tb.Rows)
            {
                ListViewItem it = new ListViewItem(dr[1].ToString());
                it.Tag = dr[0].ToString();
                imlMonAn.Images.Add(Base64ToImage(dr[4].ToString()));
                foreach (ListViewGroup lvg in MonAn.Groups)
                {
                    if (lvg.Name == dr[2].ToString())
                    {
                        it.Group = lvg;
                    }

                }
                it.ImageIndex = i;
                i++;
                MonAn.Items.Add(it);
            }
        }
        public static void DanhSachMonAn(ListView MonAn)
        {
            MonAn.Items.Clear();
            DataTable tb = new DataTable();
            tb = DAL.QuanLy.LoaiMonAn();
            foreach (DataRow dr in tb.Rows)
            {
                MonAn.Groups.Add(dr[0].ToString(), dr[1].ToString());
            }
            tb = DAL.QuanLy.MonAn();
            foreach (DataRow dr in tb.Rows)
            {
                ListViewItem it = new ListViewItem(dr[1].ToString());
                it.SubItems.Add(dr[3].ToString());
                foreach (ListViewGroup lvg in MonAn.Groups)
                {
                    if (lvg.Name == dr[2].ToString())
                    {
                        it.Group = lvg;
                    }
                }
                MonAn.Items.Add(it);
            }
        }
        public static Image Base64ToImage(string base64String)
        {
            try
            {
                byte[] imageBytes = Convert.FromBase64String(base64String);
                MemoryStream ms = new MemoryStream(imageBytes, 0, imageBytes.Length);
                ms.Write(imageBytes, 0, imageBytes.Length);
                Image image = Image.FromStream(ms, true);
                return image;
            }
            catch { return null; }
        }
        public static void LayThongTinMon(string MaMon, TextBox txtTenmon, ComboBox cbbLoaiMon, TextBox DonGia, PictureBox imgMon)
        {
            DataTable tb = new DataTable();
            tb = DAL.QuanLy.ThongTinMon(MaMon);
            txtTenmon.Text = tb.Rows[0][1].ToString();
            txtTenmon.Tag = MaMon;
            cbbLoaiMon.Text = tb.Rows[0][2].ToString();
            DonGia.Text = tb.Rows[0][3].ToString();
            imgMon.Image = Base64ToImage(tb.Rows[0][4].ToString());
        }
        public static bool SuaMonAn(string MaMonAn, string TenMonAn, string DonGia, string MaLoaiMonAn, string HinhAnh)
        {
            if (DAL.QuanLy.SuaMonAn(MaMonAn, TenMonAn, DonGia, MaLoaiMonAn, HinhAnh) == 1)
                return true;
            else
                return false;
        }
        public static bool XoaMon(string MaMon)
        {
            if (DAL.QuanLy.XoaMon(MaMon) == 0)
                return true;
            else
                return false;
        }
        public static void CapNhatGoiMon(TreeView tv, ImageList imgl)
        {
            DataTable tb = new DataTable(), tb2 = new DataTable();
            tb = DAL.QuanLy.LoaiMonAn();
            tb2 = DAL.QuanLy.MonAn();
            tv.Nodes.Clear();
            imgl.Images.Clear();
            int i = 0;
            foreach (DataRow dr in tb.Rows)
            {
                TreeNode node = new TreeNode();
                node.Text = dr[1].ToString();
                node.ImageKey = null;
                node.SelectedImageIndex = -1;
                List<TreeNode> nodelist = new List<TreeNode>();
                foreach (DataRow dr2 in tb2.Rows)
                {
                    if (dr[0].ToString() == dr2[2].ToString())
                    {
                        TreeNode node2 = new TreeNode();
                        node2.Tag = dr2[0].ToString();
                        node2.Text = dr2[1].ToString();
                        imgl.Images.Add(Base64ToImage(dr2[4].ToString()));
                        node2.ImageIndex = i;
                        node2.SelectedImageIndex = i;
                        nodelist.Add(node2);
                        i++;
                    }
                }
                node.Nodes.AddRange(nodelist.ToArray());
                tv.Nodes.Add(node);
            }

        }
        //Quan lý nhân viên
        public static void DanhSachNhanVien(ListView lvNhanVien)
        {
            lvNhanVien.Items.Clear();
            DataTable tb = new DataTable();
            tb = DAL.QuanLy.NhanVien();
            int i = 1;
            foreach (DataRow dr in tb.Rows)
            {
                ListViewItem it = new ListViewItem(i.ToString());
                it.SubItems.Add(dr[0].ToString());
                it.SubItems.Add(dr[1].ToString());
                it.SubItems.Add(dr[2].ToString());
                it.SubItems.Add(dr[3].ToString());
                it.SubItems.Add(dr[6].ToString());
                it.SubItems.Add(dr[7].ToString());
                lvNhanVien.Items.Add(it);
                i++;
            }
        }
        public static int ThemNhanVien(string manv, string tennv, string diachi, string sdt, string chucvu, string luongcoban)
        {
            return DAL.QuanLy.ThemNhanVien(manv, tennv, diachi, sdt, chucvu, luongcoban);
        }
        public static bool SuaNhanVien(string manv, string tennv, string diachi, string sdt, string chucvu, string luongcoban)
        {
            if (DAL.QuanLy.SuaNhanVien(manv, tennv, diachi, sdt, chucvu, luongcoban) == 1)
                return true;
            return false;
        }
        public static bool XoaNhanVien(string manv)
        {
            if (DAL.QuanLy.XoaNhanVien(manv) == 1)
                return true;
            return false;
        }
        public static int TinhLuongNhanVien(string manv)
        {
            return DAL.QuanLy.TinhLuongNhanVien(manv);
        }
        //Gọi món
        public static bool GoiMon(string Soban, string Mamon, string Soluong)
        {
            if (DAL.QuanLy.GoiMon(Soban, Mamon, Soluong) == 1)
                return true;
            return false;
        }
        //Hóa đơn
        public static void DanhSachHoaDon(ListView lvHoaDon)
        {
            lvHoaDon.Items.Clear();
            DataTable tb = new DataTable();
            tb = DAL.QuanLy.CapNhatHoaDon();
            int i = 1;
            foreach (DataRow dr in tb.Rows)
            {
                ListViewItem it = new ListViewItem(i.ToString());
                it.SubItems.Add(dr[0].ToString());
                it.SubItems.Add(dr[1].ToString());
                it.SubItems.Add(dr[2].ToString());
                it.SubItems.Add(dr[3].ToString());
                it.SubItems.Add(dr[4].ToString());
                it.SubItems.Add(dr[5].ToString());
                it.SubItems.Add((int.Parse(dr[4].ToString()) * int.Parse(dr[5].ToString())).ToString());
                lvHoaDon.Items.Add(it);
                i++;
            }
        }
        public static void DanhSachMonAnBan(ListView lvBan, string SoBan)
        {
            lvBan.Items.Clear();
            DataTable tb = new DataTable();
            tb = DAL.QuanLy.HoaDonCuaBan(SoBan);
            int i = 1;
            foreach (DataRow dr in tb.Rows)
            {
                ListViewItem it = new ListViewItem(i.ToString());
                it.SubItems.Add(dr[0].ToString());
                it.SubItems.Add(dr[1].ToString());
                lvBan.Items.Add(it);
                i++;
            }
        }
        public static string HoaDonThanhToan(ListView lvBan, string SoBan, Label lblNhanVien, Label lblTongTien)
        {
            try
            {
                lvBan.Items.Clear();
                DataTable tb = new DataTable();
                tb = DAL.QuanLy.LayThongTinHoaDonSoBan(SoBan);
                lblNhanVien.Text = tb.Rows[0][4].ToString();
                int Tien = 0;
                foreach (DataRow dr in tb.Rows)
                {
                    ListViewItem it = new ListViewItem(dr[1].ToString());
                    it.SubItems.Add(dr[2].ToString());
                    it.SubItems.Add(dr[3].ToString());
                    int S = int.Parse(dr[2].ToString()) * int.Parse(dr[3].ToString());
                    it.SubItems.Add(S.ToString());
                    Tien += S;
                    it.SubItems.Add(Tien.ToString());
                    lvBan.Items.Add(it);
                }
                lblTongTien.Text = Tien.ToString();
                return tb.Rows[0][0].ToString();
            }
            catch { }
            return null;
        }
        public static bool ThanhToanHoaDon(string Soban, string tongtien)
        {
            if (DAL.QuanLy.ThanhToanHoaDon(Soban, tongtien) == 1)
                return true;
            return false;
        }
        public static bool MoBan(string SoBan, string MaNhanVien)
        {
            if (DAL.QuanLy.MoBan(SoBan, MaNhanVien) == 1)
                return true;
            return false;
        }
        public static bool DongBan(string SoBan)
        {
            if (DAL.QuanLy.DongBan(SoBan) == 1)
                return true;
            return false;
        }
        //Thống kê
        public static void ThongKeTheoNgay(ListView lvThongKe, string NgayBatDau, string NgayKetThuc)
        {
            lvThongKe.Items.Clear();
            DataTable tb = new DataTable();
            tb = DAL.QuanLy.ThongKeTheoNgay(NgayBatDau,NgayKetThuc);
            int i = 1;
            foreach (DataRow dr in tb.Rows)
            {
                ListViewItem it = new ListViewItem(i.ToString());
                it.SubItems.Add(dr[0].ToString());
                it.SubItems.Add(dr[1].ToString());
                it.SubItems.Add(dr[2].ToString());
                it.SubItems.Add(dr[3].ToString());
                lvThongKe.Items.Add(it);
                i++;
            }
        }
    }
}
