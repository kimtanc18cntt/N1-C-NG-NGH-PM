namespace NHAHANGBUFFET.UI
{
    partial class uctThucDon
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uctThucDon));
            this.label5 = new System.Windows.Forms.Label();
            this.bthuy = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btluu = new System.Windows.Forms.Button();
            this.btxoa = new System.Windows.Forms.Button();
            this.btsua = new System.Windows.Forms.Button();
            this.btthem = new System.Windows.Forms.Button();
            this.cbTrangThai = new System.Windows.Forms.ComboBox();
            this.txtTenThucDon = new System.Windows.Forms.TextBox();
            this.txtDonViTinh = new System.Windows.Forms.TextBox();
            this.txtIdThucDon = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTonToiThieu = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbTenLoaiThucDon = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSoLuongTon = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtDonGiaTon = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dsThucDon = new System.Windows.Forms.DataGridView();
            this.IdThucDon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenLoaiThucDon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenThucDon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonViTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuongTon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGiaTon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TonToiThieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dsThucDon)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.ForeColor = System.Drawing.Color.Lime;
            this.label5.Location = new System.Drawing.Point(42, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(349, 36);
            this.label5.TabIndex = 32;
            this.label5.Text = "QUẢN LÝ  THỰC ĐƠN";
            // 
            // bthuy
            // 
            this.bthuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bthuy.ForeColor = System.Drawing.Color.Red;
            this.bthuy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bthuy.ImageIndex = 0;
            this.bthuy.ImageList = this.imageList1;
            this.bthuy.Location = new System.Drawing.Point(193, 438);
            this.bthuy.Name = "bthuy";
            this.bthuy.Size = new System.Drawing.Size(85, 40);
            this.bthuy.TabIndex = 13;
            this.bthuy.Text = "Hủy";
            this.bthuy.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bthuy.UseVisualStyleBackColor = true;
            this.bthuy.Click += new System.EventHandler(this.bthuy_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "huy.jpg");
            this.imageList1.Images.SetKeyName(1, "luu.jpg");
            this.imageList1.Images.SetKeyName(2, "sưa.png");
            this.imageList1.Images.SetKeyName(3, "them.png");
            this.imageList1.Images.SetKeyName(4, "xoa.jpg");
            this.imageList1.Images.SetKeyName(5, "xoa1.png");
            this.imageList1.Images.SetKeyName(6, "tải xuống.jpg");
            // 
            // btluu
            // 
            this.btluu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btluu.ForeColor = System.Drawing.Color.Green;
            this.btluu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btluu.ImageIndex = 6;
            this.btluu.ImageList = this.imageList1;
            this.btluu.Location = new System.Drawing.Point(75, 438);
            this.btluu.Name = "btluu";
            this.btluu.Size = new System.Drawing.Size(85, 40);
            this.btluu.TabIndex = 12;
            this.btluu.Text = "Lưu";
            this.btluu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btluu.UseVisualStyleBackColor = true;
            this.btluu.Click += new System.EventHandler(this.btluu_Click);
            // 
            // btxoa
            // 
            this.btxoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btxoa.ForeColor = System.Drawing.Color.Red;
            this.btxoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btxoa.ImageIndex = 4;
            this.btxoa.ImageList = this.imageList1;
            this.btxoa.Location = new System.Drawing.Point(230, 383);
            this.btxoa.Name = "btxoa";
            this.btxoa.Size = new System.Drawing.Size(85, 40);
            this.btxoa.TabIndex = 11;
            this.btxoa.Text = "Xóa";
            this.btxoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btxoa.UseVisualStyleBackColor = true;
            this.btxoa.Click += new System.EventHandler(this.btxoa_Click);
            // 
            // btsua
            // 
            this.btsua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btsua.ForeColor = System.Drawing.Color.Blue;
            this.btsua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btsua.ImageIndex = 2;
            this.btsua.ImageList = this.imageList1;
            this.btsua.Location = new System.Drawing.Point(117, 383);
            this.btsua.Name = "btsua";
            this.btsua.Size = new System.Drawing.Size(85, 40);
            this.btsua.TabIndex = 10;
            this.btsua.Text = "Sửa";
            this.btsua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btsua.UseVisualStyleBackColor = true;
            this.btsua.Click += new System.EventHandler(this.btsua_Click);
            // 
            // btthem
            // 
            this.btthem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btthem.ForeColor = System.Drawing.Color.Lime;
            this.btthem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btthem.ImageIndex = 3;
            this.btthem.ImageList = this.imageList1;
            this.btthem.Location = new System.Drawing.Point(14, 383);
            this.btthem.Name = "btthem";
            this.btthem.Size = new System.Drawing.Size(85, 40);
            this.btthem.TabIndex = 9;
            this.btthem.Text = "Thêm";
            this.btthem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btthem.UseVisualStyleBackColor = true;
            this.btthem.Click += new System.EventHandler(this.btthem_Click);
            // 
            // cbTrangThai
            // 
            this.cbTrangThai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTrangThai.FormattingEnabled = true;
            this.cbTrangThai.Location = new System.Drawing.Point(180, 290);
            this.cbTrangThai.Name = "cbTrangThai";
            this.cbTrangThai.Size = new System.Drawing.Size(130, 28);
            this.cbTrangThai.TabIndex = 8;
            // 
            // txtTenThucDon
            // 
            this.txtTenThucDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenThucDon.Location = new System.Drawing.Point(179, 87);
            this.txtTenThucDon.Name = "txtTenThucDon";
            this.txtTenThucDon.Size = new System.Drawing.Size(130, 26);
            this.txtTenThucDon.TabIndex = 3;
            // 
            // txtDonViTinh
            // 
            this.txtDonViTinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDonViTinh.Location = new System.Drawing.Point(179, 128);
            this.txtDonViTinh.Name = "txtDonViTinh";
            this.txtDonViTinh.Size = new System.Drawing.Size(130, 26);
            this.txtDonViTinh.TabIndex = 4;
            // 
            // txtIdThucDon
            // 
            this.txtIdThucDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdThucDon.Location = new System.Drawing.Point(180, 17);
            this.txtIdThucDon.Name = "txtIdThucDon";
            this.txtIdThucDon.Size = new System.Drawing.Size(130, 26);
            this.txtIdThucDon.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 24);
            this.label3.TabIndex = 19;
            this.label3.Text = "Đơn vị tính:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(10, 292);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 24);
            this.label4.TabIndex = 20;
            this.label4.Text = "Trạng Thái:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 24);
            this.label2.TabIndex = 21;
            this.label2.Text = "Tên thực đơn :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 24);
            this.label1.TabIndex = 22;
            this.label1.Text = "Id thực đơn:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(10, 258);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 24);
            this.label6.TabIndex = 22;
            this.label6.Text = "Tồn tối thiểu:";
            // 
            // txtTonToiThieu
            // 
            this.txtTonToiThieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTonToiThieu.Location = new System.Drawing.Point(180, 257);
            this.txtTonToiThieu.Name = "txtTonToiThieu";
            this.txtTonToiThieu.Size = new System.Drawing.Size(130, 26);
            this.txtTonToiThieu.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(17, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(129, 24);
            this.label7.TabIndex = 20;
            this.label7.Text = "TL thực đơn:";
            // 
            // cbTenLoaiThucDon
            // 
            this.cbTenLoaiThucDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTenLoaiThucDon.FormattingEnabled = true;
            this.cbTenLoaiThucDon.Location = new System.Drawing.Point(179, 46);
            this.cbTenLoaiThucDon.Name = "cbTenLoaiThucDon";
            this.cbTenLoaiThucDon.Size = new System.Drawing.Size(130, 28);
            this.cbTenLoaiThucDon.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(14, 171);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(143, 24);
            this.label8.TabIndex = 22;
            this.label8.Text = "Số lượng Tồn:";
            // 
            // txtSoLuongTon
            // 
            this.txtSoLuongTon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoLuongTon.Location = new System.Drawing.Point(180, 170);
            this.txtSoLuongTon.Name = "txtSoLuongTon";
            this.txtSoLuongTon.Size = new System.Drawing.Size(130, 26);
            this.txtSoLuongTon.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(14, 217);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(129, 24);
            this.label9.TabIndex = 22;
            this.label9.Text = "Đơn giá tốn :";
            // 
            // txtDonGiaTon
            // 
            this.txtDonGiaTon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDonGiaTon.Location = new System.Drawing.Point(180, 216);
            this.txtDonGiaTon.Name = "txtDonGiaTon";
            this.txtDonGiaTon.Size = new System.Drawing.Size(130, 26);
            this.txtDonGiaTon.TabIndex = 6;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label10.Location = new System.Drawing.Point(504, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(386, 36);
            this.label10.TabIndex = 32;
            this.label10.Text = "DANH SÁCH THỰC ĐƠN";
            // 
            // dsThucDon
            // 
            this.dsThucDon.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dsThucDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dsThucDon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdThucDon,
            this.TenLoaiThucDon,
            this.TenThucDon,
            this.DonViTinh,
            this.SoLuongTon,
            this.DonGiaTon,
            this.TonToiThieu,
            this.TrangThai});
            this.dsThucDon.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dsThucDon.Location = new System.Drawing.Point(439, 38);
            this.dsThucDon.Name = "dsThucDon";
            this.dsThucDon.Size = new System.Drawing.Size(650, 347);
            this.dsThucDon.TabIndex = 33;
            // 
            // IdThucDon
            // 
            this.IdThucDon.DataPropertyName = "IdThucDon";
            this.IdThucDon.HeaderText = "Id Thực Đơn";
            this.IdThucDon.Name = "IdThucDon";
            // 
            // TenLoaiThucDon
            // 
            this.TenLoaiThucDon.DataPropertyName = "TenLoaiThucDon";
            this.TenLoaiThucDon.HeaderText = "Tên Loại Thực Đơn";
            this.TenLoaiThucDon.Name = "TenLoaiThucDon";
            // 
            // TenThucDon
            // 
            this.TenThucDon.DataPropertyName = "TenThucDon";
            this.TenThucDon.HeaderText = "Tên Thực Đơn";
            this.TenThucDon.Name = "TenThucDon";
            // 
            // DonViTinh
            // 
            this.DonViTinh.DataPropertyName = "DonViTinh";
            this.DonViTinh.HeaderText = "Đơn Vị Tính";
            this.DonViTinh.Name = "DonViTinh";
            // 
            // SoLuongTon
            // 
            this.SoLuongTon.DataPropertyName = "SoLuongTon";
            this.SoLuongTon.HeaderText = "Số lượng tồn";
            this.SoLuongTon.Name = "SoLuongTon";
            // 
            // DonGiaTon
            // 
            this.DonGiaTon.DataPropertyName = "DonGiaTon";
            this.DonGiaTon.HeaderText = "Đơn giá tồn";
            this.DonGiaTon.Name = "DonGiaTon";
            // 
            // TonToiThieu
            // 
            this.TonToiThieu.DataPropertyName = "TonToiThieu";
            this.TonToiThieu.HeaderText = "Tồn tối thiểu";
            this.TonToiThieu.Name = "TonToiThieu";
            // 
            // TrangThai
            // 
            this.TrangThai.DataPropertyName = "TrangThai";
            this.TrangThai.HeaderText = "Trạng Thái";
            this.TrangThai.Name = "TrangThai";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtIdThucDon);
            this.groupBox1.Controls.Add(this.cbTenLoaiThucDon);
            this.groupBox1.Controls.Add(this.txtTonToiThieu);
            this.groupBox1.Controls.Add(this.cbTrangThai);
            this.groupBox1.Controls.Add(this.txtDonGiaTon);
            this.groupBox1.Controls.Add(this.txtTenThucDon);
            this.groupBox1.Controls.Add(this.txtSoLuongTon);
            this.groupBox1.Controls.Add(this.txtDonViTinh);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.groupBox1.Location = new System.Drawing.Point(14, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(340, 339);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            // 
            // button2
            // 
            this.button2.Image = global::NHAHANGBUFFET.Properties.Resources._1111;
            this.button2.Location = new System.Drawing.Point(439, 391);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(653, 100);
            this.button2.TabIndex = 35;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // uctThucDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::NHAHANGBUFFET.Properties.Resources.v462_n_130_textureidea_1;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dsThucDon);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.bthuy);
            this.Controls.Add(this.btluu);
            this.Controls.Add(this.btxoa);
            this.Controls.Add(this.btsua);
            this.Controls.Add(this.btthem);
            this.Name = "uctThucDon";
            this.Size = new System.Drawing.Size(1150, 500);
            this.Load += new System.EventHandler(this.uctThucDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsThucDon)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button bthuy;
        private System.Windows.Forms.Button btluu;
        private System.Windows.Forms.Button btxoa;
        private System.Windows.Forms.Button btsua;
        private System.Windows.Forms.Button btthem;
        private System.Windows.Forms.ComboBox cbTrangThai;
        private System.Windows.Forms.TextBox txtTenThucDon;
        private System.Windows.Forms.TextBox txtDonViTinh;
        private System.Windows.Forms.TextBox txtIdThucDon;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTonToiThieu;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbTenLoaiThucDon;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtSoLuongTon;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtDonGiaTon;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dsThucDon;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdThucDon;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenLoaiThucDon;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenThucDon;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonViTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuongTon;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGiaTon;
        private System.Windows.Forms.DataGridViewTextBoxColumn TonToiThieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrangThai;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button button2;
    }
}
