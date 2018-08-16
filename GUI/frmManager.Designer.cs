namespace QUANLYWIN10
{
    partial class frmManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManager));
            System.Windows.Forms.ListViewGroup listViewGroup4 = new System.Windows.Forms.ListViewGroup("Khu vực 1", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup5 = new System.Windows.Forms.ListViewGroup("Khu vực 2", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup6 = new System.Windows.Forms.ListViewGroup("Khu vực 3", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Cơm", 3, 2);
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("Canh", 3, 2);
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("Đồ ăn", -2, 2, new System.Windows.Forms.TreeNode[] {
            treeNode13,
            treeNode14});
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("Huda");
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("Tiger");
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("Larue");
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("Bia", 0, 1, new System.Windows.Forms.TreeNode[] {
            treeNode16,
            treeNode17,
            treeNode18});
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("Rượu", 0, 1);
            System.Windows.Forms.TreeNode treeNode21 = new System.Windows.Forms.TreeNode("Có cồn", 0, 1, new System.Windows.Forms.TreeNode[] {
            treeNode19,
            treeNode20});
            System.Windows.Forms.TreeNode treeNode22 = new System.Windows.Forms.TreeNode("Nước ngọt", 0, 1);
            System.Windows.Forms.TreeNode treeNode23 = new System.Windows.Forms.TreeNode("Méo có cồn", 0, 1, new System.Windows.Forms.TreeNode[] {
            treeNode22});
            System.Windows.Forms.TreeNode treeNode24 = new System.Windows.Forms.TreeNode("Đồ  uống", 0, 0, new System.Windows.Forms.TreeNode[] {
            treeNode21,
            treeNode23});
            System.Windows.Forms.ListViewItem listViewItem8 = new System.Windows.Forms.ListViewItem(new string[] {
            "1",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"}, -1);
            System.Windows.Forms.ListViewItem listViewItem9 = new System.Windows.Forms.ListViewItem("2");
            System.Windows.Forms.ListViewItem listViewItem10 = new System.Windows.Forms.ListViewItem("3");
            System.Windows.Forms.ListViewItem listViewItem11 = new System.Windows.Forms.ListViewItem("4");
            System.Windows.Forms.ListViewItem listViewItem12 = new System.Windows.Forms.ListViewItem("5");
            System.Windows.Forms.ListViewItem listViewItem13 = new System.Windows.Forms.ListViewItem("6");
            System.Windows.Forms.ListViewItem listViewItem14 = new System.Windows.Forms.ListViewItem("");
            this.ctxStart = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tắtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.imlTable = new System.Windows.Forms.ImageList(this.components);
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.splitContainer5 = new System.Windows.Forms.SplitContainer();
            this.lvBan = new System.Windows.Forms.ListView();
            this.ctmBan = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mởBànToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đóngBànToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnTrangThaiBan = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnGoiMon = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lvCacMonDaGoi = new System.Windows.Forms.ListView();
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblTrangThai = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblKhuVuc = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblBan = new System.Windows.Forms.Label();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pnGoiMon = new System.Windows.Forms.Panel();
            this.btnThemMon = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.txtSoLuongMon = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.lblTenMon = new System.Windows.Forms.Label();
            this.lblLoai = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tvGoiMon = new System.Windows.Forms.TreeView();
            this.imglMonAn = new System.Windows.Forms.ImageList(this.components);
            this.lvHoaDon = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.ctxStart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer5)).BeginInit();
            this.splitContainer5.Panel1.SuspendLayout();
            this.splitContainer5.Panel2.SuspendLayout();
            this.splitContainer5.SuspendLayout();
            this.ctmBan.SuspendLayout();
            this.pnTrangThaiBan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).BeginInit();
            this.splitContainer4.Panel1.SuspendLayout();
            this.splitContainer4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.pnGoiMon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // ctxStart
            // 
            this.ctxStart.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.đăngXuấtToolStripMenuItem,
            this.tắtToolStripMenuItem});
            this.ctxStart.Name = "ctxStart";
            this.ctxStart.Size = new System.Drawing.Size(165, 48);
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            this.đăngXuấtToolStripMenuItem.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem_Click);
            // 
            // tắtToolStripMenuItem
            // 
            this.tắtToolStripMenuItem.Name = "tắtToolStripMenuItem";
            this.tắtToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.tắtToolStripMenuItem.Text = "Đóng phần mềm";
            this.tắtToolStripMenuItem.Click += new System.EventHandler(this.tắtToolStripMenuItem_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            this.toolTip1.OwnerDraw = true;
            // 
            // imlTable
            // 
            this.imlTable.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imlTable.ImageStream")));
            this.imlTable.TransparentColor = System.Drawing.Color.Transparent;
            this.imlTable.Images.SetKeyName(0, "coffee1.jpg");
            this.imlTable.Images.SetKeyName(1, "coffee.jpg");
            this.imlTable.Images.SetKeyName(2, "bol-de-riz-plein-icon.png");
            this.imlTable.Images.SetKeyName(3, "bol-de-riz-vide-icon.png");
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.Control;
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.pictureBox1);
            this.splitContainer1.Panel2MinSize = 2;
            this.splitContainer1.Size = new System.Drawing.Size(1300, 750);
            this.splitContainer1.SplitterDistance = 721;
            this.splitContainer1.SplitterWidth = 1;
            this.splitContainer1.TabIndex = 1;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.IsSplitterFixed = true;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.splitContainer3);
            this.splitContainer2.Size = new System.Drawing.Size(1300, 721);
            this.splitContainer2.SplitterDistance = 25;
            this.splitContainer2.SplitterWidth = 1;
            this.splitContainer2.TabIndex = 0;
            // 
            // splitContainer3
            // 
            this.splitContainer3.BackColor = System.Drawing.SystemColors.Control;
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.BackColor = System.Drawing.Color.Lime;
            this.splitContainer3.Panel1.Controls.Add(this.splitContainer5);
            this.splitContainer3.Panel1MinSize = 500;
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.splitContainer3.Panel2.Controls.Add(this.splitContainer4);
            this.splitContainer3.Panel2MinSize = 500;
            this.splitContainer3.Size = new System.Drawing.Size(1300, 695);
            this.splitContainer3.SplitterDistance = 649;
            this.splitContainer3.SplitterWidth = 1;
            this.splitContainer3.TabIndex = 0;
            // 
            // splitContainer5
            // 
            this.splitContainer5.BackColor = System.Drawing.SystemColors.Control;
            this.splitContainer5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer5.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer5.Location = new System.Drawing.Point(0, 0);
            this.splitContainer5.Name = "splitContainer5";
            // 
            // splitContainer5.Panel1
            // 
            this.splitContainer5.Panel1.Controls.Add(this.lvBan);
            this.splitContainer5.Panel1MinSize = 200;
            // 
            // splitContainer5.Panel2
            // 
            this.splitContainer5.Panel2.Controls.Add(this.pnTrangThaiBan);
            this.splitContainer5.Panel2MinSize = 206;
            this.splitContainer5.Size = new System.Drawing.Size(649, 695);
            this.splitContainer5.SplitterDistance = 439;
            this.splitContainer5.TabIndex = 0;
            // 
            // lvBan
            // 
            this.lvBan.ContextMenuStrip = this.ctmBan;
            this.lvBan.Dock = System.Windows.Forms.DockStyle.Fill;
            listViewGroup4.Header = "Khu vực 1";
            listViewGroup4.Name = "KV1";
            listViewGroup5.Header = "Khu vực 2";
            listViewGroup5.Name = "KV2";
            listViewGroup6.Header = "Khu vực 3";
            listViewGroup6.Name = "KV3";
            this.lvBan.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup4,
            listViewGroup5,
            listViewGroup6});
            this.lvBan.LargeImageList = this.imlTable;
            this.lvBan.Location = new System.Drawing.Point(0, 0);
            this.lvBan.Name = "lvBan";
            this.lvBan.Size = new System.Drawing.Size(439, 695);
            this.lvBan.TabIndex = 7;
            this.lvBan.UseCompatibleStateImageBehavior = false;
            this.lvBan.SelectedIndexChanged += new System.EventHandler(this.lvBan_SelectedIndexChanged);
            this.lvBan.DoubleClick += new System.EventHandler(this.listView1_DoubleClick);
            this.lvBan.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lvBan_MouseDown);
            // 
            // ctmBan
            // 
            this.ctmBan.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mởBànToolStripMenuItem,
            this.đóngBànToolStripMenuItem});
            this.ctmBan.Name = "ctmBan";
            this.ctmBan.Size = new System.Drawing.Size(127, 48);
            // 
            // mởBànToolStripMenuItem
            // 
            this.mởBànToolStripMenuItem.Name = "mởBànToolStripMenuItem";
            this.mởBànToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.mởBànToolStripMenuItem.Text = "Mở bàn";
            this.mởBànToolStripMenuItem.Click += new System.EventHandler(this.mởBànToolStripMenuItem_Click);
            // 
            // đóngBànToolStripMenuItem
            // 
            this.đóngBànToolStripMenuItem.Name = "đóngBànToolStripMenuItem";
            this.đóngBànToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.đóngBànToolStripMenuItem.Text = "Đóng bàn";
            this.đóngBànToolStripMenuItem.Click += new System.EventHandler(this.đóngBànToolStripMenuItem_Click);
            // 
            // pnTrangThaiBan
            // 
            this.pnTrangThaiBan.BackColor = System.Drawing.SystemColors.Control;
            this.pnTrangThaiBan.Controls.Add(this.button1);
            this.pnTrangThaiBan.Controls.Add(this.btnGoiMon);
            this.pnTrangThaiBan.Controls.Add(this.label5);
            this.pnTrangThaiBan.Controls.Add(this.lvCacMonDaGoi);
            this.pnTrangThaiBan.Controls.Add(this.lblTrangThai);
            this.pnTrangThaiBan.Controls.Add(this.label2);
            this.pnTrangThaiBan.Controls.Add(this.lblKhuVuc);
            this.pnTrangThaiBan.Controls.Add(this.label3);
            this.pnTrangThaiBan.Controls.Add(this.lblBan);
            this.pnTrangThaiBan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnTrangThaiBan.Location = new System.Drawing.Point(0, 0);
            this.pnTrangThaiBan.Name = "pnTrangThaiBan";
            this.pnTrangThaiBan.Size = new System.Drawing.Size(206, 695);
            this.pnTrangThaiBan.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.Location = new System.Drawing.Point(7, 346);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 41);
            this.button1.TabIndex = 4;
            this.button1.Text = "Thanh toán";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnGoiMon
            // 
            this.btnGoiMon.Location = new System.Drawing.Point(106, 346);
            this.btnGoiMon.Name = "btnGoiMon";
            this.btnGoiMon.Size = new System.Drawing.Size(93, 41);
            this.btnGoiMon.TabIndex = 3;
            this.btnGoiMon.Text = "Gọi món";
            this.btnGoiMon.UseVisualStyleBackColor = true;
            this.btnGoiMon.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(4, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "Các món đã gọi";
            // 
            // lvCacMonDaGoi
            // 
            this.lvCacMonDaGoi.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11});
            this.lvCacMonDaGoi.Location = new System.Drawing.Point(7, 111);
            this.lvCacMonDaGoi.Name = "lvCacMonDaGoi";
            this.lvCacMonDaGoi.Size = new System.Drawing.Size(194, 226);
            this.lvCacMonDaGoi.TabIndex = 1;
            this.lvCacMonDaGoi.UseCompatibleStateImageBehavior = false;
            this.lvCacMonDaGoi.View = System.Windows.Forms.View.Details;
            this.lvCacMonDaGoi.SelectedIndexChanged += new System.EventHandler(this.lvCacMonDaGoi_SelectedIndexChanged);
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Stt";
            this.columnHeader9.Width = 29;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Tên món";
            this.columnHeader10.Width = 94;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Số lượng";
            this.columnHeader11.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader11.Width = 61;
            // 
            // lblTrangThai
            // 
            this.lblTrangThai.AutoSize = true;
            this.lblTrangThai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTrangThai.Location = new System.Drawing.Point(87, 56);
            this.lblTrangThai.Name = "lblTrangThai";
            this.lblTrangThai.Size = new System.Drawing.Size(0, 17);
            this.lblTrangThai.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(4, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Trạng thái:\r\n";
            // 
            // lblKhuVuc
            // 
            this.lblKhuVuc.AutoSize = true;
            this.lblKhuVuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblKhuVuc.Location = new System.Drawing.Point(56, 2);
            this.lblKhuVuc.Name = "lblKhuVuc";
            this.lblKhuVuc.Size = new System.Drawing.Size(0, 17);
            this.lblKhuVuc.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(87, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 17);
            this.label3.TabIndex = 0;
            // 
            // lblBan
            // 
            this.lblBan.AutoSize = true;
            this.lblBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblBan.Location = new System.Drawing.Point(4, 2);
            this.lblBan.Name = "lblBan";
            this.lblBan.Size = new System.Drawing.Size(0, 17);
            this.lblBan.TabIndex = 0;
            // 
            // splitContainer4
            // 
            this.splitContainer4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer4.Location = new System.Drawing.Point(0, 0);
            this.splitContainer4.Name = "splitContainer4";
            this.splitContainer4.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer4.Panel1
            // 
            this.splitContainer4.Panel1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.splitContainer4.Panel1.Controls.Add(this.groupBox1);
            this.splitContainer4.Panel1MinSize = 600;
            this.splitContainer4.Panel2Collapsed = true;
            this.splitContainer4.Panel2MinSize = 0;
            this.splitContainer4.Size = new System.Drawing.Size(650, 695);
            this.splitContainer4.SplitterDistance = 600;
            this.splitContainer4.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pnGoiMon);
            this.groupBox1.Controls.Add(this.lvHoaDon);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(650, 695);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Các hóa đơn chưa thanh toán";
            // 
            // pnGoiMon
            // 
            this.pnGoiMon.Controls.Add(this.btnThemMon);
            this.pnGoiMon.Controls.Add(this.button3);
            this.pnGoiMon.Controls.Add(this.txtSoLuongMon);
            this.pnGoiMon.Controls.Add(this.label10);
            this.pnGoiMon.Controls.Add(this.lblTenMon);
            this.pnGoiMon.Controls.Add(this.lblLoai);
            this.pnGoiMon.Controls.Add(this.label7);
            this.pnGoiMon.Controls.Add(this.label6);
            this.pnGoiMon.Controls.Add(this.tvGoiMon);
            this.pnGoiMon.Location = new System.Drawing.Point(6, 111);
            this.pnGoiMon.Name = "pnGoiMon";
            this.pnGoiMon.Size = new System.Drawing.Size(408, 334);
            this.pnGoiMon.TabIndex = 2;
            this.pnGoiMon.Visible = false;
            // 
            // btnThemMon
            // 
            this.btnThemMon.Location = new System.Drawing.Point(322, 173);
            this.btnThemMon.Name = "btnThemMon";
            this.btnThemMon.Size = new System.Drawing.Size(68, 23);
            this.btnThemMon.TabIndex = 8;
            this.btnThemMon.Text = "Thêm";
            this.btnThemMon.UseVisualStyleBackColor = true;
            this.btnThemMon.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(239, 173);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(68, 23);
            this.button3.TabIndex = 7;
            this.button3.Text = "Ok";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtSoLuongMon
            // 
            this.txtSoLuongMon.Location = new System.Drawing.Point(322, 138);
            this.txtSoLuongMon.Name = "txtSoLuongMon";
            this.txtSoLuongMon.Size = new System.Drawing.Size(68, 23);
            this.txtSoLuongMon.TabIndex = 6;
            this.txtSoLuongMon.Text = "2";
            this.txtSoLuongMon.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label10.Location = new System.Drawing.Point(239, 138);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 17);
            this.label10.TabIndex = 5;
            this.label10.Text = "Số lượng:";
            // 
            // lblTenMon
            // 
            this.lblTenMon.AutoSize = true;
            this.lblTenMon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTenMon.Location = new System.Drawing.Point(319, 112);
            this.lblTenMon.Name = "lblTenMon";
            this.lblTenMon.Size = new System.Drawing.Size(53, 17);
            this.lblTenMon.TabIndex = 4;
            this.lblTenMon.Text = "Cà phê";
            // 
            // lblLoai
            // 
            this.lblLoai.AutoSize = true;
            this.lblLoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblLoai.Location = new System.Drawing.Point(319, 95);
            this.lblLoai.Name = "lblLoai";
            this.lblLoai.Size = new System.Drawing.Size(62, 17);
            this.lblLoai.TabIndex = 3;
            this.lblLoai.Text = "Đồ uống";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.Location = new System.Drawing.Point(239, 112);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 17);
            this.label7.TabIndex = 2;
            this.label7.Text = "Tên món:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(239, 95);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 17);
            this.label6.TabIndex = 1;
            this.label6.Text = "Loại: ";
            // 
            // tvGoiMon
            // 
            this.tvGoiMon.ImageIndex = 0;
            this.tvGoiMon.ImageList = this.imglMonAn;
            this.tvGoiMon.Location = new System.Drawing.Point(3, 3);
            this.tvGoiMon.Name = "tvGoiMon";
            treeNode13.ImageIndex = 3;
            treeNode13.Name = "Node1";
            treeNode13.SelectedImageIndex = 2;
            treeNode13.Text = "Cơm";
            treeNode14.ImageIndex = 3;
            treeNode14.Name = "Node11";
            treeNode14.SelectedImageIndex = 2;
            treeNode14.Text = "Canh";
            treeNode15.ImageIndex = -2;
            treeNode15.Name = "Node0";
            treeNode15.SelectedImageIndex = 2;
            treeNode15.Text = "Đồ ăn";
            treeNode16.Name = "Node8";
            treeNode16.Text = "Huda";
            treeNode17.Name = "Node9";
            treeNode17.Text = "Tiger";
            treeNode18.Name = "Node10";
            treeNode18.Text = "Larue";
            treeNode19.ImageIndex = 0;
            treeNode19.Name = "Node5";
            treeNode19.SelectedImageIndex = 1;
            treeNode19.Text = "Bia";
            treeNode20.ImageIndex = 0;
            treeNode20.Name = "Node6";
            treeNode20.SelectedImageIndex = 1;
            treeNode20.Text = "Rượu";
            treeNode21.ImageIndex = 0;
            treeNode21.Name = "Node3";
            treeNode21.SelectedImageIndex = 1;
            treeNode21.Text = "Có cồn";
            treeNode22.ImageIndex = 0;
            treeNode22.Name = "Node7";
            treeNode22.SelectedImageIndex = 1;
            treeNode22.Text = "Nước ngọt";
            treeNode23.ImageIndex = 0;
            treeNode23.Name = "Node4";
            treeNode23.SelectedImageIndex = 1;
            treeNode23.Text = "Méo có cồn";
            treeNode24.ImageIndex = 0;
            treeNode24.Name = "Node2";
            treeNode24.SelectedImageIndex = 0;
            treeNode24.Text = "Đồ  uống";
            this.tvGoiMon.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode15,
            treeNode24});
            this.tvGoiMon.SelectedImageIndex = 0;
            this.tvGoiMon.ShowLines = false;
            this.tvGoiMon.Size = new System.Drawing.Size(230, 328);
            this.tvGoiMon.TabIndex = 0;
            this.tvGoiMon.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // imglMonAn
            // 
            this.imglMonAn.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imglMonAn.ImageSize = new System.Drawing.Size(30, 30);
            this.imglMonAn.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // lvHoaDon
            // 
            this.lvHoaDon.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.lvHoaDon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lvHoaDon.FullRowSelect = true;
            this.lvHoaDon.GridLines = true;
            this.lvHoaDon.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem8,
            listViewItem9,
            listViewItem10,
            listViewItem11,
            listViewItem12,
            listViewItem13,
            listViewItem14});
            this.lvHoaDon.Location = new System.Drawing.Point(3, 19);
            this.lvHoaDon.Name = "lvHoaDon";
            this.lvHoaDon.Size = new System.Drawing.Size(644, 673);
            this.lvHoaDon.TabIndex = 1;
            this.lvHoaDon.UseCompatibleStateImageBehavior = false;
            this.lvHoaDon.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "STT";
            this.columnHeader1.Width = 65;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Mã hóa đơn";
            this.columnHeader2.Width = 89;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Thời gian";
            this.columnHeader3.Width = 70;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Nhân viên";
            this.columnHeader4.Width = 102;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Tên món";
            this.columnHeader5.Width = 122;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Số lượng";
            this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader6.Width = 73;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Đơn giá";
            this.columnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader7.Width = 109;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Thành tiền";
            this.columnHeader8.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader8.Width = 95;
            // 
            // pictureBox1
            // 
            this.pictureBox1.ContextMenuStrip = this.ctxStart;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = global::QUANLYWIN10.Properties.Resources.mos9001;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(34, 28);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.BackgroundImage = global::QUANLYWIN10.Properties.Resources.Start2;
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.pictureBox5);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.pictureBox4);
            this.panel3.Controls.Add(this.pictureBox3);
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Location = new System.Drawing.Point(3, 536);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(535, 182);
            this.panel3.TabIndex = 0;
            this.panel3.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(352, 125);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Báo cáo";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::QUANLYWIN10.Properties.Resources.Report;
            this.pictureBox5.Location = new System.Drawing.Point(327, 18);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(100, 100);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 2;
            this.pictureBox5.TabStop = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label13.Location = new System.Drawing.Point(246, 125);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 13);
            this.label13.TabIndex = 1;
            this.label13.Text = "Thống kê";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label12.Location = new System.Drawing.Point(141, 125);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(56, 13);
            this.label12.TabIndex = 1;
            this.label12.Text = "Nhân viên";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label11.Location = new System.Drawing.Point(34, 125);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 13);
            this.label11.TabIndex = 1;
            this.label11.Text = "Thực đơn";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::QUANLYWIN10.Properties.Resources._1f4d1;
            this.pictureBox4.Location = new System.Drawing.Point(9, 18);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(100, 100);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 0;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::QUANLYWIN10.Properties.Resources.User;
            this.pictureBox3.Location = new System.Drawing.Point(115, 18);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(100, 100);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::QUANLYWIN10.Properties.Resources.Report;
            this.pictureBox2.Location = new System.Drawing.Point(221, 18);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 100);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click_1);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = global::QUANLYWIN10.Properties.Resources.Windows101;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1300, 750);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ctxStart.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.splitContainer5.Panel1.ResumeLayout(false);
            this.splitContainer5.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer5)).EndInit();
            this.splitContainer5.ResumeLayout(false);
            this.ctmBan.ResumeLayout(false);
            this.pnTrangThaiBan.ResumeLayout(false);
            this.pnTrangThaiBan.PerformLayout();
            this.splitContainer4.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).EndInit();
            this.splitContainer4.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.pnGoiMon.ResumeLayout(false);
            this.pnGoiMon.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip ctxStart;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tắtToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ImageList imlTable;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.SplitContainer splitContainer4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.SplitContainer splitContainer5;
        private System.Windows.Forms.ListView lvBan;
        private System.Windows.Forms.Panel pnTrangThaiBan;
        private System.Windows.Forms.Button btnGoiMon;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListView lvCacMonDaGoi;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.Label lblTrangThai;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblKhuVuc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblBan;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ImageList imglMonAn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.ContextMenuStrip ctmBan;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel pnGoiMon;
        private System.Windows.Forms.Button btnThemMon;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txtSoLuongMon;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblTenMon;
        private System.Windows.Forms.Label lblLoai;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TreeView tvGoiMon;
        private System.Windows.Forms.ListView lvHoaDon;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ToolStripMenuItem mởBànToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đóngBànToolStripMenuItem;
        private System.Windows.Forms.Button button1;
    }
}