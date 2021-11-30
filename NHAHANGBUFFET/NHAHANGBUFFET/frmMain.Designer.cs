namespace NHAHANGBUFFET
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.quảnLýToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýNhânViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýKháchHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýKhuyếnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.khuVựcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bànKhuVựcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hệThốngKhuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thựcĐơnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loạiThựcĐơnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thựcĐơnToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.gọiMónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hệThốngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ctmenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.đóngTabToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đóngTấtCảCácToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabhienthi = new System.Windows.Forms.TabControl();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.dx = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.ctmenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnLýToolStripMenuItem,
            this.khuVựcToolStripMenuItem,
            this.thựcĐơnToolStripMenuItem,
            this.gọiMónToolStripMenuItem,
            this.thuToolStripMenuItem,
            this.hệThốngToolStripMenuItem,
            this.thoátToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1234, 40);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // quảnLýToolStripMenuItem
            // 
            this.quảnLýToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnLýNhânViênToolStripMenuItem,
            this.quảnLýKháchHàngToolStripMenuItem,
            this.quảnLýKhuyếnToolStripMenuItem});
            this.quảnLýToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.quảnLýToolStripMenuItem.Image = global::NHAHANGBUFFET.Properties.Resources.tải_xuống1;
            this.quảnLýToolStripMenuItem.Name = "quảnLýToolStripMenuItem";
            this.quảnLýToolStripMenuItem.Size = new System.Drawing.Size(102, 36);
            this.quảnLýToolStripMenuItem.Text = "Quản lý";
            this.quảnLýToolStripMenuItem.Click += new System.EventHandler(this.quảnLýToolStripMenuItem_Click);
            // 
            // quảnLýNhânViênToolStripMenuItem
            // 
            this.quảnLýNhânViênToolStripMenuItem.Name = "quảnLýNhânViênToolStripMenuItem";
            this.quảnLýNhânViênToolStripMenuItem.Size = new System.Drawing.Size(244, 26);
            this.quảnLýNhânViênToolStripMenuItem.Text = "Quản lý nhân viên";
            this.quảnLýNhânViênToolStripMenuItem.Click += new System.EventHandler(this.quảnLýNhânViênToolStripMenuItem_Click);
            // 
            // quảnLýKháchHàngToolStripMenuItem
            // 
            this.quảnLýKháchHàngToolStripMenuItem.Name = "quảnLýKháchHàngToolStripMenuItem";
            this.quảnLýKháchHàngToolStripMenuItem.Size = new System.Drawing.Size(244, 26);
            this.quảnLýKháchHàngToolStripMenuItem.Text = "Quản lý khách hàng";
            this.quảnLýKháchHàngToolStripMenuItem.Click += new System.EventHandler(this.quảnLýKháchHàngToolStripMenuItem_Click);
            // 
            // quảnLýKhuyếnToolStripMenuItem
            // 
            this.quảnLýKhuyếnToolStripMenuItem.Name = "quảnLýKhuyếnToolStripMenuItem";
            this.quảnLýKhuyếnToolStripMenuItem.Size = new System.Drawing.Size(244, 26);
            this.quảnLýKhuyếnToolStripMenuItem.Text = "Quản lý khuyến mãi";
            this.quảnLýKhuyếnToolStripMenuItem.Click += new System.EventHandler(this.quảnLýKhuyếnToolStripMenuItem_Click);
            // 
            // khuVựcToolStripMenuItem
            // 
            this.khuVựcToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bànKhuVựcToolStripMenuItem,
            this.hệThốngKhuToolStripMenuItem});
            this.khuVựcToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.khuVựcToolStripMenuItem.Image = global::NHAHANGBUFFET.Properties.Resources.tải_xuống__3_;
            this.khuVựcToolStripMenuItem.Margin = new System.Windows.Forms.Padding(5);
            this.khuVựcToolStripMenuItem.Name = "khuVựcToolStripMenuItem";
            this.khuVựcToolStripMenuItem.Size = new System.Drawing.Size(106, 26);
            this.khuVựcToolStripMenuItem.Text = "Khu vực";
            // 
            // bànKhuVựcToolStripMenuItem
            // 
            this.bànKhuVựcToolStripMenuItem.Name = "bànKhuVựcToolStripMenuItem";
            this.bànKhuVựcToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.bànKhuVựcToolStripMenuItem.Text = "Bàn khu vực";
            this.bànKhuVựcToolStripMenuItem.Click += new System.EventHandler(this.bànKhuVựcToolStripMenuItem_Click);
            // 
            // hệThốngKhuToolStripMenuItem
            // 
            this.hệThốngKhuToolStripMenuItem.Name = "hệThốngKhuToolStripMenuItem";
            this.hệThốngKhuToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.hệThốngKhuToolStripMenuItem.Text = "Hệ thống khu vực";
            this.hệThốngKhuToolStripMenuItem.Click += new System.EventHandler(this.hệThốngKhuToolStripMenuItem_Click);
            // 
            // thựcĐơnToolStripMenuItem
            // 
            this.thựcĐơnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loạiThựcĐơnToolStripMenuItem,
            this.thựcĐơnToolStripMenuItem1});
            this.thựcĐơnToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.thựcĐơnToolStripMenuItem.Image = global::NHAHANGBUFFET.Properties.Resources.tải_xuống__6_;
            this.thựcĐơnToolStripMenuItem.Margin = new System.Windows.Forms.Padding(5);
            this.thựcĐơnToolStripMenuItem.Name = "thựcĐơnToolStripMenuItem";
            this.thựcĐơnToolStripMenuItem.Size = new System.Drawing.Size(117, 26);
            this.thựcĐơnToolStripMenuItem.Text = "Thực đơn";
            // 
            // loạiThựcĐơnToolStripMenuItem
            // 
            this.loạiThựcĐơnToolStripMenuItem.Name = "loạiThựcĐơnToolStripMenuItem";
            this.loạiThựcĐơnToolStripMenuItem.Size = new System.Drawing.Size(194, 26);
            this.loạiThựcĐơnToolStripMenuItem.Text = "Loại thực đơn";
            this.loạiThựcĐơnToolStripMenuItem.Click += new System.EventHandler(this.loạiThựcĐơnToolStripMenuItem_Click);
            // 
            // thựcĐơnToolStripMenuItem1
            // 
            this.thựcĐơnToolStripMenuItem1.Name = "thựcĐơnToolStripMenuItem1";
            this.thựcĐơnToolStripMenuItem1.Size = new System.Drawing.Size(194, 26);
            this.thựcĐơnToolStripMenuItem1.Text = "Thực đơn";
            this.thựcĐơnToolStripMenuItem1.Click += new System.EventHandler(this.thựcĐơnToolStripMenuItem1_Click);
            // 
            // gọiMónToolStripMenuItem
            // 
            this.gọiMónToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.gọiMónToolStripMenuItem.Image = global::NHAHANGBUFFET.Properties.Resources.tải_xuống__1_;
            this.gọiMónToolStripMenuItem.Margin = new System.Windows.Forms.Padding(5);
            this.gọiMónToolStripMenuItem.Name = "gọiMónToolStripMenuItem";
            this.gọiMónToolStripMenuItem.Size = new System.Drawing.Size(111, 26);
            this.gọiMónToolStripMenuItem.Text = "Gọi Món";
            this.gọiMónToolStripMenuItem.Click += new System.EventHandler(this.gọiMónToolStripMenuItem_Click);
            // 
            // thuToolStripMenuItem
            // 
            this.thuToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thuToolStripMenuItem.Image = global::NHAHANGBUFFET.Properties.Resources.tải_xuống__7_;
            this.thuToolStripMenuItem.Name = "thuToolStripMenuItem";
            this.thuToolStripMenuItem.Size = new System.Drawing.Size(100, 36);
            this.thuToolStripMenuItem.Text = "Thu chi";
            this.thuToolStripMenuItem.Click += new System.EventHandler(this.thuToolStripMenuItem_Click);
            // 
            // hệThốngToolStripMenuItem
            // 
            this.hệThốngToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.hệThốngToolStripMenuItem.Image = global::NHAHANGBUFFET.Properties.Resources.tải_xuống__5_;
            this.hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            this.hệThốngToolStripMenuItem.Size = new System.Drawing.Size(112, 36);
            this.hệThốngToolStripMenuItem.Text = "Hệ thống";
            this.hệThốngToolStripMenuItem.Click += new System.EventHandler(this.hệThốngToolStripMenuItem_Click);
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thoátToolStripMenuItem.Image = global::NHAHANGBUFFET.Properties.Resources._70317;
            this.thoátToolStripMenuItem.Margin = new System.Windows.Forms.Padding(5);
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(87, 26);
            this.thoátToolStripMenuItem.Text = "Thoát";
            this.thoátToolStripMenuItem.Click += new System.EventHandler(this.thoátToolStripMenuItem_Click);
            // 
            // ctmenu
            // 
            this.ctmenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.đóngTabToolStripMenuItem,
            this.đóngTấtCảCácToolStripMenuItem});
            this.ctmenu.Name = "ctmenu";
            this.ctmenu.Size = new System.Drawing.Size(188, 48);
            // 
            // đóngTabToolStripMenuItem
            // 
            this.đóngTabToolStripMenuItem.Name = "đóngTabToolStripMenuItem";
            this.đóngTabToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.đóngTabToolStripMenuItem.Text = "Đóng trang hiển thị";
            this.đóngTabToolStripMenuItem.Click += new System.EventHandler(this.đóngTabToolStripMenuItem_Click);
            // 
            // đóngTấtCảCácToolStripMenuItem
            // 
            this.đóngTấtCảCácToolStripMenuItem.Name = "đóngTấtCảCácToolStripMenuItem";
            this.đóngTấtCảCácToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.đóngTấtCảCácToolStripMenuItem.Text = "Đóng tất cả các trang";
            this.đóngTấtCảCácToolStripMenuItem.Click += new System.EventHandler(this.đóngTấtCảCácToolStripMenuItem_Click);
            // 
            // tabhienthi
            // 
            this.tabhienthi.ContextMenuStrip = this.ctmenu;
            this.tabhienthi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabhienthi.Location = new System.Drawing.Point(0, 40);
            this.tabhienthi.Name = "tabhienthi";
            this.tabhienthi.SelectedIndex = 0;
            this.tabhienthi.Size = new System.Drawing.Size(1234, 471);
            this.tabhienthi.TabIndex = 1;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Violet;
            this.imageList1.Images.SetKeyName(0, "hinh-nen-powerpoint-dep-2.jpg");
            this.imageList1.Images.SetKeyName(1, "khoa.jpg");
            this.imageList1.Images.SetKeyName(2, "dx.jpg");
            this.imageList1.Images.SetKeyName(3, "images (2).png");
            // 
            // dx
            // 
            this.dx.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dx.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dx.ImageIndex = 2;
            this.dx.ImageList = this.imageList1;
            this.dx.Location = new System.Drawing.Point(989, 7);
            this.dx.Name = "dx";
            this.dx.Size = new System.Drawing.Size(116, 33);
            this.dx.TabIndex = 2;
            this.dx.Text = "Đăng xuất";
            this.dx.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.dx.UseVisualStyleBackColor = true;
            this.dx.Click += new System.EventHandler(this.dx_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1234, 511);
            this.Controls.Add(this.dx);
            this.Controls.Add(this.tabhienthi);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Phần mền quản lý nhà hàng Buffet";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ctmenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem quảnLýToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýNhânViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýKhuyếnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem khuVựcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bànKhuVựcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hệThốngKhuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thựcĐơnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loạiThựcĐơnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thựcĐơnToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem thuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hệThốngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip ctmenu;
        private System.Windows.Forms.ToolStripMenuItem đóngTabToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đóngTấtCảCácToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gọiMónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýKháchHàngToolStripMenuItem;
        private System.Windows.Forms.TabControl tabhienthi;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button dx;
    }
}

