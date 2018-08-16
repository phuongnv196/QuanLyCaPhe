using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUANLYWIN10.GUI
{
    public partial class frmThongKe : Form
    {
        public frmThongKe()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            TimeSpan ts;
            DateTime Fromday = new DateTime(dateTimePicker1.Value.Year, dateTimePicker1.Value.Month, dateTimePicker1.Value.Day);   //YYYY-MM-DD
            DateTime ToDay = new DateTime(dateTimePicker2.Value.Year, dateTimePicker2.Value.Month, dateTimePicker2.Value.Day);
            ts = ToDay - Fromday;
            if(ts.TotalDays<0)
            {
                dateTimePicker2.Value = dateTimePicker1.Value;
            }
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            TimeSpan ts;
            DateTime Fromday = new DateTime(dateTimePicker1.Value.Year, dateTimePicker1.Value.Month, dateTimePicker1.Value.Day);   //YYYY-MM-DD
            DateTime ToDay = new DateTime(dateTimePicker2.Value.Year, dateTimePicker2.Value.Month, dateTimePicker2.Value.Day);
            ts = ToDay - Fromday;
            if (ts.TotalDays < 0)
            {
                dateTimePicker2.Value = dateTimePicker1.Value;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string ngayBatDau, ngayKetThuc;
            ngayBatDau = dateTimePicker1.Value.Year.ToString() + string.Format("{0:00}", dateTimePicker1.Value.Month) + string.Format("{0:00}", dateTimePicker1.Value.Day);
            ngayKetThuc = dateTimePicker2.Value.Year.ToString() + string.Format("{0:00}", dateTimePicker2.Value.Month) + string.Format("{0:00}", dateTimePicker2.Value.Day);
            MessageBox.Show(ngayBatDau+"  "+ngayKetThuc);
            // DLL.QuanLy.ThongKeTheoNgay(lvThongKe, ngayBatDau, ngayKetThuc);
            QuanLyQuanAnNhaHangDataSetTableAdapters.ThongKeTheoNgayTableAdapter f = new QuanLyQuanAnNhaHangDataSetTableAdapters.ThongKeTheoNgayTableAdapter();
            f.Fill(quanLyQuanAnNhaHangDataSet.ThongKeTheoNgay, ngayBatDau, ngayKetThuc);
            reportViewer1.RefreshReport();
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            
        }

        private void frmThongKe_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }
    }
}
