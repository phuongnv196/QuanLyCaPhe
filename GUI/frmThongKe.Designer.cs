namespace QUANLYWIN10.GUI
{
    partial class frmThongKe
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.quanLyQuanAnNhaHangDataSet = new QUANLYWIN10.QuanLyQuanAnNhaHangDataSet();
            this.quanLyQuanAnNhaHangDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.thongKeTheoNgayBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.thongKeTheoNgayTableAdapter = new QUANLYWIN10.QuanLyQuanAnNhaHangDataSetTableAdapters.ThongKeTheoNgayTableAdapter();
            this.thongKeTheoNgayBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.quanLyQuanAnNhaHangDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyQuanAnNhaHangDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thongKeTheoNgayBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thongKeTheoNgayBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(115, 12);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(96, 20);
            this.dateTimePicker1.TabIndex = 0;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(115, 47);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(96, 20);
            this.dateTimePicker2.TabIndex = 0;
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ngày bắt đầu:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(12, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ngày kết thúc:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(234, 46);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Thống kê";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // reportViewer1
            // 
            reportDataSource3.Name = "DataSet";
            reportDataSource3.Value = this.thongKeTheoNgayBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QUANLYWIN10.GUI.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(13, 81);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(783, 385);
            this.reportViewer1.TabIndex = 5;
            // 
            // quanLyQuanAnNhaHangDataSet
            // 
            this.quanLyQuanAnNhaHangDataSet.DataSetName = "QuanLyQuanAnNhaHangDataSet";
            this.quanLyQuanAnNhaHangDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // quanLyQuanAnNhaHangDataSetBindingSource
            // 
            this.quanLyQuanAnNhaHangDataSetBindingSource.DataSource = this.quanLyQuanAnNhaHangDataSet;
            this.quanLyQuanAnNhaHangDataSetBindingSource.Position = 0;
            // 
            // thongKeTheoNgayBindingSource
            // 
            this.thongKeTheoNgayBindingSource.DataMember = "ThongKeTheoNgay";
            this.thongKeTheoNgayBindingSource.DataSource = this.quanLyQuanAnNhaHangDataSetBindingSource;
            // 
            // thongKeTheoNgayTableAdapter
            // 
            this.thongKeTheoNgayTableAdapter.ClearBeforeFill = true;
            // 
            // thongKeTheoNgayBindingSource1
            // 
            this.thongKeTheoNgayBindingSource1.DataMember = "ThongKeTheoNgay";
            this.thongKeTheoNgayBindingSource1.DataSource = this.quanLyQuanAnNhaHangDataSetBindingSource;
            // 
            // frmThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 469);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximumSize = new System.Drawing.Size(888, 508);
            this.Name = "frmThongKe";
            this.Text = "Thống kê";
            this.Load += new System.EventHandler(this.frmThongKe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.quanLyQuanAnNhaHangDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyQuanAnNhaHangDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thongKeTheoNgayBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thongKeTheoNgayBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource thongKeTheoNgayBindingSource;
        private System.Windows.Forms.BindingSource quanLyQuanAnNhaHangDataSetBindingSource;
        private QuanLyQuanAnNhaHangDataSet quanLyQuanAnNhaHangDataSet;
        private QuanLyQuanAnNhaHangDataSetTableAdapters.ThongKeTheoNgayTableAdapter thongKeTheoNgayTableAdapter;
        private System.Windows.Forms.BindingSource thongKeTheoNgayBindingSource1;
    }
}