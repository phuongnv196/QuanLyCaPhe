using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
namespace QUANLYWIN10.DAL
{
    class QuanLy
    {
        static string ConnectString = "Data Source=DESKTOP-7B5O75O\\SIUSQL;Initial Catalog=QuanLyQuanAnNhaHang;Integrated Security=True";
        //static string ConnectString = "workstation id=QuanLyNhaHang.mssql.somee.com;packet size=4096;user id=ccsiungoc_SQLLogin_1;pwd=sik2zonq15;data source=QuanLyNhaHang.mssql.somee.com;persist security info=False;initial catalog=QuanLyNhaHang";
        
        static SqlConnection connect;
        static SqlCommand command;
        public static int Login(string _username, string _pass)
        {
            int count;
            connect = new SqlConnection(ConnectString);
            connect.Open();
            command = new SqlCommand("select dbo.DangNhap('"+_username+"','"+_pass+"')", connect);
            count = int.Parse(command.ExecuteScalar().ToString());
            connect.Close();
            return count;
        }
        public static DataTable BanAn()
        {
            return LayThongTin("select * from dbo.[bàn ăn]");
        }

        public static DataTable KhuVuc()
        {
            return LayThongTin("select * from dbo.[Khu Vực]");
        }
        public static int ChenMonAn(string TenMonAn, string DonGia, string MaLoaiMonAn, string HinhAnh)
        {
            connect = new SqlConnection(ConnectString);
            connect.Open();
            string _commandString = "DECLARE @return_value int EXEC @return_value=[dbo].[ThemMonAn] @pTenMonAn=N'" + TenMonAn+"', @pDonGia="+DonGia+", @pMaLoaiMonAn="+MaLoaiMonAn+", @pHinhAnh=N'"+HinhAnh+ "' SELECT @return_value";
            command = new SqlCommand(_commandString, connect);
            int count = int.Parse(command.ExecuteScalar().ToString());
            connect.Close();
            return count;
        }
        public static int SuaMonAn(string MaMonAn, string TenMonAn, string DonGia, string MaLoaiMonAn, string HinhAnh)
        {
            connect = new SqlConnection(ConnectString);
            connect.Open();
            string _commandString = "DECLARE @return int EXEC @return = [dbo].[SuaMonAn] @pMaMon = "+MaMonAn+", @pTenMon = N'"+TenMonAn+"', @pMaLoai = "+MaLoaiMonAn+", @pDonGia = "+DonGia+", @pHinhAnh = N'"+HinhAnh+"' SELECT @return";
            command = new SqlCommand(_commandString, connect);
            int count = int.Parse(command.ExecuteScalar().ToString());
            connect.Close();
            return count;
        }
        public static int ThemLoaiMon(string TenLoaiMonAn) //Thêm loại món vào database
        {
            connect = new SqlConnection(ConnectString);
            connect.Open();
            string _commandString = "DECLARE @return int EXEC @return=[dbo].[ThemLoaiMon] @pTenLoaiMon=N'"+TenLoaiMonAn+"' SELECT @return";
            command = new SqlCommand(_commandString, connect);
            int count=int.Parse(command.ExecuteScalar().ToString());
            connect.Close();
            return count;
        }
        public static DataTable LoaiMonAn() //Lấy thông tin loại món ăn
        {
            return LayThongTin("select MaLoaiMonAn, TenLoaiMonAn from dbo.[Loại Món Ăn]");
        }
        public static DataTable MonAn() //Lấy thông tin món ăn
        {
            return LayThongTin("select * from dbo.[Món Ăn] where len(HinhAnh)>0");
        }
        

        public static DataTable LayThongTin(string _commandString) //Lấy thông tin từ database bằng câu lệnh truy vấn _commandString
        {
            connect = new SqlConnection(ConnectString);
            connect.Open();
            command = new SqlCommand(_commandString, connect);
            SqlDataAdapter ad = new SqlDataAdapter(command);
            DataTable tb = new DataTable();
            ad.Fill(tb);
            connect.Close();
            return tb;
        }
        public static DataTable ThongTinMon(string MaMon) //Lấy thông tin món ăn
        {
            return LayThongTin("select * from dbo.[Món Ăn] where MaMonAn='"+MaMon+"'");
        }
        public static int XoaMon(string MaMon)
        {
            connect = new SqlConnection(ConnectString);
            connect.Open();
            string _commandString = "DECLARE @return int EXEC @return=[dbo].[XoaMon] @pMaMon=" + MaMon + " SELECT @return";
            command = new SqlCommand(_commandString, connect);
            int count = int.Parse(command.ExecuteScalar().ToString());
            connect.Close();
            return count;
        }

        //Quản lý nhân viên
        public static DataTable NhanVien() //Lấy thông tin món ăn
        {
            return LayThongTin("select * from dbo.[Nhân Viên]");
        }
        static int ThemSuaNhanVien(string manv, string tennv, string diachi, string sdt, string songaynghi, string luongcoban, string query)
        {
            connect = new SqlConnection(ConnectString);
            connect.Open();
            string _commandString = "DECLARE @return_value int EXEC @return_value=[dbo].["+query+"] @pMaNhanVien = N'" + manv + "', @pTenNhanVien = N'" + tennv + "',@pDiaChi = N'" + diachi + "', @pSoDienThoai = N'" + sdt + "', @pSoNgayNghi = " + songaynghi + ", @pLuongCoBan="+luongcoban+" SELECT @return_value";
            command = new SqlCommand(_commandString, connect);
            int count = int.Parse(command.ExecuteScalar().ToString());
            connect.Close();
            return count;
        }
        public static int ThemNhanVien(string manv, string tennv, string diachi, string sdt, string songaynghi, string LuongCoBan)
        {
            return ThemSuaNhanVien(manv, tennv, diachi, sdt, songaynghi, LuongCoBan, "ThemNhanVien");
        }
        public static int SuaNhanVien(string manv, string tennv, string diachi, string sdt, string songaynghi, string LuongCoBan)
        {
            return ThemSuaNhanVien(manv, tennv, diachi, sdt, songaynghi, LuongCoBan, "SuaNhanVien");
        }
        public static int XoaNhanVien(string manv)
        {
            connect = new SqlConnection(ConnectString);
            connect.Open();
            string _commandString = "DECLARE @return int EXEC @return=[dbo].[XoaNhanVien] @pMaNhanVien='" + manv + "' SELECT @return";
            command = new SqlCommand(_commandString, connect);
            int count = int.Parse(command.ExecuteScalar().ToString());
            connect.Close();
            return count;
        }
        public static int TinhLuongNhanVien(string manv)
        {
            connect = new SqlConnection(ConnectString);
            connect.Open();
            string _commandString = "DECLARE @return int EXEC @return=[dbo].[TinhLuongNhanVien] @pMaNhanVien='" + manv + "' SELECT @return";
            command = new SqlCommand(_commandString, connect);
            int count = int.Parse(command.ExecuteScalar().ToString());
            connect.Close();
            return count;
        }
        public static int GoiMon(string Soban, string Mamon, string Soluong)
        {
            connect = new SqlConnection(ConnectString);
            connect.Open();
            string _commandString = "DECLARE @return int EXEC @return=[dbo].[GoiMon] @pSoBan = " + Soban+", @pMaMonAn = "+Mamon+", @pSoLuong = "+Soluong + "SELECT @return";
            command = new SqlCommand(_commandString, connect);
            int count = int.Parse(command.ExecuteScalar().ToString());
            connect.Close();
            return count;
        }
        //Câp nhật Hóa Đơn chưa thanh toán
        public static DataTable CapNhatHoaDon()
        {
            string query = "select dbo.[Chi Tiết Hóa Đơn].MaHoaDon, NgayVao, TenNhanVien, TenMonAn, SoLuong, DonGia from dbo.[bàn ăn] " 
                            +"join dbo.[Hóa Đơn] on dbo.[bàn ăn].SoBan= dbo.[Hóa Đơn].SoBan "
                            + "join dbo.[Chi Tiết Hóa Đơn] on dbo.[Hóa Đơn].MaHoaDon= dbo.[Chi Tiết Hóa Đơn].MaHoaDon "
                            + "join dbo.[Món Ăn] on dbo.[Món Ăn].MaMonAn= dbo.[Chi Tiết Hóa Đơn].MaMonAn "
                            + "join dbo.[Nhân Viên] on dbo.[Nhân Viên].MaNhanVien= dbo.[Hóa Đơn].MaNhanVien "
                            + "where dbo.[Hóa Đơn].TrangThai= 0";
            return LayThongTin(query);
        }
        public static DataTable HoaDonCuaBan(string SoBan)
        {
            string query = "select TenMonAn, SoLuong from dbo.[bàn ăn] "
                            + "join dbo.[Hóa Đơn] on dbo.[bàn ăn].SoBan= dbo.[Hóa Đơn].SoBan "
                            + "join dbo.[Chi Tiết Hóa Đơn] on dbo.[Hóa Đơn].MaHoaDon= dbo.[Chi Tiết Hóa Đơn].MaHoaDon "
                            + "join dbo.[Món Ăn] on dbo.[Món Ăn].MaMonAn= dbo.[Chi Tiết Hóa Đơn].MaMonAn "
                            + "join dbo.[Nhân Viên] on dbo.[Nhân Viên].MaNhanVien= dbo.[Hóa Đơn].MaNhanVien "
                            + "where dbo.[Hóa Đơn].TrangThai= 0 and dbo.[bàn ăn].SoBan="+SoBan;
            return LayThongTin(query);
        }
        public static DataTable LayThongTinHoaDonSoBan(string soban)
        {
            string Query = "SELECT [Chi Tiết Hóa Đơn].MaHoaDon, [Món Ăn].TenMonAn, [Chi Tiết Hóa Đơn].SoLuong, [Món Ăn].DonGia, [Nhân Viên].TenNhanVien "
                           + "FROM[bàn ăn] INNER JOIN "
                           + "[Hóa Đơn] ON[bàn ăn].SoBan = [Hóa Đơn].SoBan INNER JOIN "
                           + "[Chi Tiết Hóa Đơn] ON[Hóa Đơn].MaHoaDon = [Chi Tiết Hóa Đơn].MaHoaDon INNER JOIN "
                           + "[Món Ăn] ON[Chi Tiết Hóa Đơn].MaMonAn = [Món Ăn].MaMonAn INNER JOIN "
                           + "[Nhân Viên] ON[Hóa Đơn].MaNhanVien = [Nhân Viên].MaNhanVien "
                           + "WHERE [Hóa Đơn].TrangThai = 0 and [bàn ăn].SoBan ="+ soban;
            return LayThongTin(Query);
        }
        public static int ThanhToanHoaDon(string Soban, string tongtien)
        {
       
                connect = new SqlConnection(ConnectString);
                connect.Open();
                string _commandString = "update [Hóa Đơn] set TrangThai=1, TongTien="+tongtien+" where TrangThai=0 and SoBan = " + Soban;
                command = new SqlCommand(_commandString, connect);
                command.ExecuteNonQuery();
                connect.Close();
                return 1;
           
        }
        //Quản lý bàn
        public static int MoBan(string SoBan, string MaNhanVien)
        {
            connect = new SqlConnection(ConnectString);
            connect.Open();
            string _commandString = "DECLARE @return int EXEC @return=[dbo].[MoBan] @pSoBan = "+SoBan+", @pMaNhanVien = N'"+MaNhanVien+"' SELECT @return";
            command = new SqlCommand(_commandString, connect);
            int count = int.Parse(command.ExecuteScalar().ToString());
            connect.Close();
            return count;
        }

        public static int DongBan(string SoBan)
        {
            connect = new SqlConnection(ConnectString);
            connect.Open();
            string _commandString = "DECLARE @return int EXEC @return=[dbo].[DongBan] @pSoBan = " + SoBan + " SELECT @return";
            command = new SqlCommand(_commandString, connect);
            int count = int.Parse(command.ExecuteScalar().ToString());
            connect.Close();
            return count;
        }
        //Thống kê
        public static DataTable ThongKeTheoNgay(string NgayBatDau, string NgayKetThuc)
        {
            return LayThongTin("EXEC [dbo].[ThongKeTheoNgay] @pNgayBatDau = N'"+NgayBatDau+"', @pNgayKetThuc = N'"+NgayKetThuc+"'");
        }
    }
}
