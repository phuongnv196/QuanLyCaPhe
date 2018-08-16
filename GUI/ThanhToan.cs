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
    public partial class ThanhToan : Form
    {
        public ThanhToan()
        {
            InitializeComponent();
        }
        string Soban;
        public ThanhToan(string SoBan)
        {
            InitializeComponent();
            lblSoHoaDon.Text=DLL.QuanLy.HoaDonThanhToan(lvHoaDon, SoBan, lblHoaDonNhanVien, lblHoaDonTongTien);
            Soban = SoBan;
        }

        private void txtTienNhan_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtTienNhan.Text != "")
                {
                    int TienTraKhachHang = int.Parse(txtTienNhan.Text) - int.Parse(lblHoaDonTongTien.Text);
                    lblTienTraLaiKH.Text = TienTraKhachHang.ToString();
                }
            }
            catch { }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtTienNhan.Text!="" &&int.Parse(lblTienTraLaiKH.Text) > 0)
                if (DLL.QuanLy.ThanhToanHoaDon(Soban, lblHoaDonTongTien.Text))
                {
                    MessageBox.Show("Đã thanh toán!");
                }
                else
                {
                    MessageBox.Show("Thanh toán lỗi!");
                }
            else
                MessageBox.Show("Số tiền khách hàng trả chưa đủ!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                PrintDialog _PrintDialog = new PrintDialog();
                PrintDocument pd = new PrintDocument();
                _PrintDialog.Document = pd; //add the document to the dialog box

                pd.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(printing);
                DialogResult result = _PrintDialog.ShowDialog();

                if (result == DialogResult.OK)
                {
                    pd.Print();
                }
            }
            catch (Exception)
            {

            }
        }
        Graphics graphic;
        void printing(object sender, PrintPageEventArgs
 e)
        {
            /* Bitmap bitmap =
              new Bitmap(groupBox1.Width, groupBox1.Height);
             groupBox1.DrawToBitmap(bitmap, groupBox1.ClientRectangle);
             e.Graphics.DrawImage(bitmap, new
              Point(50, 50));*/

            Graphics graphic = e.Graphics;
            Font font = new Font("Courier New", 12);
            float FontHeight = font.GetHeight();
            int startX = 10;
            int startY = 10;
            int offset = 40;

            graphic.DrawString("\t   QUÁN ĂN LÀO", new Font("Courier New", 18), new SolidBrush(Color.Black), startX, startY);
            graphic.DrawString("\tBàn: "+Soban +" Số hóa đơn: "+lblSoHoaDon.Text,font, new SolidBrush(Color.Black), startX, startY+offset);
            string top = "Tên món".PadRight(5) + " \tSL".PadRight(5)+" \tĐG".PadRight(5)+"\t   VND";
            graphic.DrawString(top, font, new SolidBrush(Color.Black), startX, startY + 2*offset);
            offset = 2 * offset;
            offset = offset + (int)FontHeight; //make the spacing consistent
            graphic.DrawString("----------------------------------------------", font, new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + (int)FontHeight + 5; //make the spacing consistent

            foreach (ListViewItem it in lvHoaDon.Items)
            {
                graphic.DrawString(it.Text, font, new SolidBrush(Color.Black), startX, startY + offset);
                graphic.DrawString(it.SubItems[1].Text, font, new SolidBrush(Color.Black), startX + 150, startY + offset);
                graphic.DrawString(it.SubItems[2].Text, font, new SolidBrush(Color.Black), startX + 200, startY + offset);
                graphic.DrawString(it.SubItems[3].Text, font, new SolidBrush(Color.Black), startX + 300, startY + offset);
                offset = offset + (int)FontHeight + 5;
            }
            graphic.DrawString("----------------------------------------------", font, new SolidBrush(Color.Black), startX, startY + offset);
            /*int index = 0;
            
            foreach (string item in lvNhanVien.Items)
            {
                graphic.DrawString(item, font, new SolidBrush(Color.Black), startX, startY + offset);
                graphic.DrawString(lvNhanVien.Items[index++].ToString(), font, new SolidBrush(Color.Black), startX + 250, startY + offset);
                offset = offset + (int)FontHeight + 5; //make the spacing consistent              
            }*/
        }
    }
}
