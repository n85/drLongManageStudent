namespace QLDiemSV.GUI
{
    partial class frmMain
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
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hệThốngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCapNhatTaiKhoan = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuQLNguoiDung = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDangXuat = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuThoat = new System.Windows.Forms.ToolStripMenuItem();
            this.qLSinhViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuQLSV = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuQLGV = new System.Windows.Forms.ToolStripMenuItem();
            this.timKiếmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTimSV = new System.Windows.Forms.ToolStripMenuItem();
            this.thốngKêToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuThongKeSV = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTroGiup = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 581);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1107, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel.Text = "Status";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hệThốngToolStripMenuItem,
            this.qLSinhViênToolStripMenuItem,
            this.timKiếmToolStripMenuItem,
            this.thốngKêToolStripMenuItem,
            this.mnuTroGiup,
            this.mnuAbout});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1107, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hệThốngToolStripMenuItem
            // 
            this.hệThốngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuCapNhatTaiKhoan,
            this.mnuQLNguoiDung,
            this.mnuDangXuat,
            this.toolStripSeparator1,
            this.toolStripSeparator2,
            this.mnuThoat});
            this.hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            this.hệThốngToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.hệThốngToolStripMenuItem.Text = "Hệ thống";
            // 
            // mnuCapNhatTaiKhoan
            // 
            this.mnuCapNhatTaiKhoan.Name = "mnuCapNhatTaiKhoan";
            this.mnuCapNhatTaiKhoan.Size = new System.Drawing.Size(180, 22);
            this.mnuCapNhatTaiKhoan.Text = "Cập nhật tài khoản";
            this.mnuCapNhatTaiKhoan.Click += new System.EventHandler(this.mnuCapNhatTaiKhoan_Click);
            // 
            // mnuQLNguoiDung
            // 
            this.mnuQLNguoiDung.Name = "mnuQLNguoiDung";
            this.mnuQLNguoiDung.Size = new System.Drawing.Size(180, 22);
            this.mnuQLNguoiDung.Text = "Quản lý người dùng";
            this.mnuQLNguoiDung.Click += new System.EventHandler(this.mnuQLNguoiDung_Click);
            // 
            // mnuDangXuat
            // 
            this.mnuDangXuat.Name = "mnuDangXuat";
            this.mnuDangXuat.Size = new System.Drawing.Size(180, 22);
            this.mnuDangXuat.Text = "Đăng xuất";
            this.mnuDangXuat.Click += new System.EventHandler(this.mnuDangXuat_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(177, 6);
            // 
            // mnuThoat
            // 
            this.mnuThoat.Name = "mnuThoat";
            this.mnuThoat.Size = new System.Drawing.Size(180, 22);
            this.mnuThoat.Text = "Exit";
            this.mnuThoat.Click += new System.EventHandler(this.mnuThoat_Click);
            // 
            // qLSinhViênToolStripMenuItem
            // 
            this.qLSinhViênToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuQLSV,
            this.mnuQLGV});
            this.qLSinhViênToolStripMenuItem.Name = "qLSinhViênToolStripMenuItem";
            this.qLSinhViênToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.qLSinhViênToolStripMenuItem.Text = "Quản lý";
            this.qLSinhViênToolStripMenuItem.Click += new System.EventHandler(this.qLSinhViênToolStripMenuItem_Click);
            // 
            // mnuQLSV
            // 
            this.mnuQLSV.Name = "mnuQLSV";
            this.mnuQLSV.Size = new System.Drawing.Size(130, 22);
            this.mnuQLSV.Text = "Sinh viên";
            // 
            // mnuQLGV
            // 
            this.mnuQLGV.Name = "mnuQLGV";
            this.mnuQLGV.Size = new System.Drawing.Size(130, 22);
            this.mnuQLGV.Text = "Giảng viên";
            // 
            // timKiếmToolStripMenuItem
            // 
            this.timKiếmToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuTimSV});
            this.timKiếmToolStripMenuItem.Name = "timKiếmToolStripMenuItem";
            this.timKiếmToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.timKiếmToolStripMenuItem.Text = "Tim kiếm ";
            // 
            // mnuTimSV
            // 
            this.mnuTimSV.Name = "mnuTimSV";
            this.mnuTimSV.Size = new System.Drawing.Size(176, 22);
            this.mnuTimSV.Text = "Thông tin sinh viên";
            // 
            // thốngKêToolStripMenuItem
            // 
            this.thốngKêToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuThongKeSV});
            this.thốngKêToolStripMenuItem.Name = "thốngKêToolStripMenuItem";
            this.thốngKêToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.thốngKêToolStripMenuItem.Text = "Thống kê";
            // 
            // mnuThongKeSV
            // 
            this.mnuThongKeSV.Name = "mnuThongKeSV";
            this.mnuThongKeSV.Size = new System.Drawing.Size(179, 22);
            this.mnuThongKeSV.Text = "Danh sách sinh viên";
            // 
            // mnuTroGiup
            // 
            this.mnuTroGiup.Name = "mnuTroGiup";
            this.mnuTroGiup.Size = new System.Drawing.Size(64, 20);
            this.mnuTroGiup.Text = "Trợ giúp";
            // 
            // mnuAbout
            // 
            this.mnuAbout.Name = "mnuAbout";
            this.mnuAbout.Size = new System.Drawing.Size(52, 20);
            this.mnuAbout.Text = "About";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1107, 603);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMain";
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hệThốngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuCapNhatTaiKhoan;
        private System.Windows.Forms.ToolStripMenuItem mnuQLNguoiDung;
        private System.Windows.Forms.ToolStripMenuItem mnuDangXuat;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem mnuThoat;
        private System.Windows.Forms.ToolStripMenuItem qLSinhViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuQLSV;
        private System.Windows.Forms.ToolStripMenuItem mnuQLGV;
        private System.Windows.Forms.ToolStripMenuItem timKiếmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuTimSV;
        private System.Windows.Forms.ToolStripMenuItem thốngKêToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuThongKeSV;
        private System.Windows.Forms.ToolStripMenuItem mnuTroGiup;
        private System.Windows.Forms.ToolStripMenuItem mnuAbout;
    }
}



