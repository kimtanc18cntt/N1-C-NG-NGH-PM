namespace NHAHANGBUFFET.UI
{
    partial class uctNhanvien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uctNhanvien));
            this.bthuy = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.grqlnhanvien = new System.Windows.Forms.GroupBox();
            this.cbgt = new System.Windows.Forms.ComboBox();
            this.dtngaysinh = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtdiachi = new System.Windows.Forms.TextBox();
            this.txtten = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtgmail = new System.Windows.Forms.TextBox();
            this.txttenlot = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtdienthoai = new System.Windows.Forms.TextBox();
            this.txtmanv = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btan = new System.Windows.Forms.Button();
            this.bttimkiem = new System.Windows.Forms.Button();
            this.btluu = new System.Windows.Forms.Button();
            this.btthem = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dsnhanvien = new System.Windows.Forms.DataGridView();
            this.IdNhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChucVu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ngaysinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DienThoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btsua = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btxoa = new System.Windows.Forms.Button();
            this.pnlDSNhanVien = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.grqlnhanvien.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsnhanvien)).BeginInit();
            this.SuspendLayout();
            // 
            // bthuy
            // 
            this.bthuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bthuy.ForeColor = System.Drawing.Color.Red;
            this.bthuy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bthuy.ImageIndex = 0;
            this.bthuy.ImageList = this.imageList1;
            this.bthuy.Location = new System.Drawing.Point(368, 249);
            this.bthuy.Name = "bthuy";
            this.bthuy.Size = new System.Drawing.Size(75, 30);
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
            this.imageList1.Images.SetKeyName(7, "images.jpg");
            // 
            // grqlnhanvien
            // 
            this.grqlnhanvien.BackColor = System.Drawing.Color.CadetBlue;
            this.grqlnhanvien.Controls.Add(this.cbgt);
            this.grqlnhanvien.Controls.Add(this.dtngaysinh);
            this.grqlnhanvien.Controls.Add(this.label10);
            this.grqlnhanvien.Controls.Add(this.label6);
            this.grqlnhanvien.Controls.Add(this.txtdiachi);
            this.grqlnhanvien.Controls.Add(this.txtten);
            this.grqlnhanvien.Controls.Add(this.label9);
            this.grqlnhanvien.Controls.Add(this.label5);
            this.grqlnhanvien.Controls.Add(this.txtgmail);
            this.grqlnhanvien.Controls.Add(this.txttenlot);
            this.grqlnhanvien.Controls.Add(this.label8);
            this.grqlnhanvien.Controls.Add(this.label4);
            this.grqlnhanvien.Controls.Add(this.txtdienthoai);
            this.grqlnhanvien.Controls.Add(this.txtmanv);
            this.grqlnhanvien.Controls.Add(this.label7);
            this.grqlnhanvien.Controls.Add(this.label3);
            this.grqlnhanvien.Location = new System.Drawing.Point(6, 54);
            this.grqlnhanvien.Name = "grqlnhanvien";
            this.grqlnhanvien.Size = new System.Drawing.Size(437, 180);
            this.grqlnhanvien.TabIndex = 15;
            this.grqlnhanvien.TabStop = false;
            // 
            // cbgt
            // 
            this.cbgt.FormattingEnabled = true;
            this.cbgt.Location = new System.Drawing.Point(302, 95);
            this.cbgt.Name = "cbgt";
            this.cbgt.Size = new System.Drawing.Size(121, 21);
            this.cbgt.TabIndex = 8;
            this.cbgt.SelectedIndexChanged += new System.EventHandler(this.cbgt_SelectedIndexChanged);
            // 
            // dtngaysinh
            // 
            this.dtngaysinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtngaysinh.Location = new System.Drawing.Point(81, 95);
            this.dtngaysinh.Name = "dtngaysinh";
            this.dtngaysinh.Size = new System.Drawing.Size(132, 20);
            this.dtngaysinh.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(219, 95);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 16);
            this.label10.TabIndex = 0;
            this.label10.Text = "Giới tính:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(7, 95);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "Ngày sinh:";
            // 
            // txtdiachi
            // 
            this.txtdiachi.Location = new System.Drawing.Point(302, 64);
            this.txtdiachi.Name = "txtdiachi";
            this.txtdiachi.Size = new System.Drawing.Size(132, 20);
            this.txtdiachi.TabIndex = 7;
            // 
            // txtten
            // 
            this.txtten.Location = new System.Drawing.Point(81, 65);
            this.txtten.Name = "txtten";
            this.txtten.Size = new System.Drawing.Size(132, 20);
            this.txtten.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(219, 69);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 16);
            this.label9.TabIndex = 0;
            this.label9.Text = "Địa chỉ:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(7, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Chức Vụ:";
            // 
            // txtgmail
            // 
            this.txtgmail.Location = new System.Drawing.Point(302, 38);
            this.txtgmail.Name = "txtgmail";
            this.txtgmail.Size = new System.Drawing.Size(132, 20);
            this.txtgmail.TabIndex = 6;
            // 
            // txttenlot
            // 
            this.txttenlot.Location = new System.Drawing.Point(81, 39);
            this.txttenlot.Name = "txttenlot";
            this.txttenlot.Size = new System.Drawing.Size(132, 20);
            this.txttenlot.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(219, 43);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 16);
            this.label8.TabIndex = 0;
            this.label8.Text = "Email:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Họ Tên:";
            // 
            // txtdienthoai
            // 
            this.txtdienthoai.Location = new System.Drawing.Point(302, 12);
            this.txtdienthoai.Name = "txtdienthoai";
            this.txtdienthoai.Size = new System.Drawing.Size(132, 20);
            this.txtdienthoai.TabIndex = 5;
            // 
            // txtmanv
            // 
            this.txtmanv.Location = new System.Drawing.Point(81, 13);
            this.txtmanv.Name = "txtmanv";
            this.txtmanv.Size = new System.Drawing.Size(132, 20);
            this.txtmanv.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(219, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "Điện thoại:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mã NV:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(314, 32);
            this.label1.TabIndex = 17;
            this.label1.Text = "QUẢN LÝ NHÂN VIÊN";
            // 
            // btan
            // 
            this.btan.Location = new System.Drawing.Point(580, 249);
            this.btan.Name = "btan";
            this.btan.Size = new System.Drawing.Size(75, 30);
            this.btan.TabIndex = 17;
            this.btan.Text = "<<";
            this.btan.UseVisualStyleBackColor = true;
            this.btan.Click += new System.EventHandler(this.btan_Click);
            // 
            // bttimkiem
            // 
            this.bttimkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttimkiem.ForeColor = System.Drawing.Color.Blue;
            this.bttimkiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bttimkiem.ImageIndex = 7;
            this.bttimkiem.ImageList = this.imageList1;
            this.bttimkiem.Location = new System.Drawing.Point(485, 249);
            this.bttimkiem.Name = "bttimkiem";
            this.bttimkiem.Size = new System.Drawing.Size(75, 30);
            this.bttimkiem.TabIndex = 16;
            this.bttimkiem.Text = "Tìm kiếm";
            this.bttimkiem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bttimkiem.UseVisualStyleBackColor = true;
            this.bttimkiem.Click += new System.EventHandler(this.bttimkiem_Click);
            // 
            // btluu
            // 
            this.btluu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btluu.ForeColor = System.Drawing.Color.Green;
            this.btluu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btluu.ImageIndex = 6;
            this.btluu.ImageList = this.imageList1;
            this.btluu.Location = new System.Drawing.Point(287, 249);
            this.btluu.Name = "btluu";
            this.btluu.Size = new System.Drawing.Size(75, 30);
            this.btluu.TabIndex = 12;
            this.btluu.Text = "Lưu";
            this.btluu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btluu.UseVisualStyleBackColor = true;
            this.btluu.Click += new System.EventHandler(this.btluu_Click);
            // 
            // btthem
            // 
            this.btthem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btthem.ForeColor = System.Drawing.Color.Lime;
            this.btthem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btthem.ImageIndex = 3;
            this.btthem.ImageList = this.imageList1;
            this.btthem.Location = new System.Drawing.Point(7, 249);
            this.btthem.Name = "btthem";
            this.btthem.Size = new System.Drawing.Size(75, 30);
            this.btthem.TabIndex = 9;
            this.btthem.Text = "Thêm";
            this.btthem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btthem.UseVisualStyleBackColor = true;
            this.btthem.Click += new System.EventHandler(this.btthem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dsnhanvien);
            this.groupBox1.Location = new System.Drawing.Point(464, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(656, 204);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            // 
            // dsnhanvien
            // 
            this.dsnhanvien.AllowUserToAddRows = false;
            this.dsnhanvien.AllowUserToDeleteRows = false;
            this.dsnhanvien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dsnhanvien.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dsnhanvien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dsnhanvien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdNhanVien,
            this.HoTen,
            this.ChucVu,
            this.Ngaysinh,
            this.GioiTinh,
            this.DienThoai,
            this.Email,
            this.DiaChi});
            this.dsnhanvien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dsnhanvien.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.dsnhanvien.Location = new System.Drawing.Point(3, 16);
            this.dsnhanvien.Name = "dsnhanvien";
            this.dsnhanvien.ReadOnly = true;
            this.dsnhanvien.Size = new System.Drawing.Size(650, 185);
            this.dsnhanvien.TabIndex = 15;
            // 
            // IdNhanVien
            // 
            this.IdNhanVien.DataPropertyName = "IdNhanVien";
            this.IdNhanVien.HeaderText = "Id Nhân Viên";
            this.IdNhanVien.Name = "IdNhanVien";
            this.IdNhanVien.ReadOnly = true;
            // 
            // HoTen
            // 
            this.HoTen.DataPropertyName = "HoTen";
            this.HoTen.HeaderText = "Họ Tên";
            this.HoTen.Name = "HoTen";
            this.HoTen.ReadOnly = true;
            // 
            // ChucVu
            // 
            this.ChucVu.DataPropertyName = "ChucVu";
            this.ChucVu.HeaderText = "Chức Vụ";
            this.ChucVu.Name = "ChucVu";
            this.ChucVu.ReadOnly = true;
            // 
            // Ngaysinh
            // 
            this.Ngaysinh.DataPropertyName = "Ngaysinh";
            this.Ngaysinh.HeaderText = "Ngày Sinh";
            this.Ngaysinh.Name = "Ngaysinh";
            this.Ngaysinh.ReadOnly = true;
            // 
            // GioiTinh
            // 
            this.GioiTinh.DataPropertyName = "GioiTinh";
            this.GioiTinh.HeaderText = "Giỡi Tính";
            this.GioiTinh.Name = "GioiTinh";
            this.GioiTinh.ReadOnly = true;
            // 
            // DienThoai
            // 
            this.DienThoai.DataPropertyName = "DienThoai";
            this.DienThoai.HeaderText = "Điện Thoại";
            this.DienThoai.Name = "DienThoai";
            this.DienThoai.ReadOnly = true;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            // 
            // DiaChi
            // 
            this.DiaChi.DataPropertyName = "DiaChi";
            this.DiaChi.HeaderText = "Địa Chỉ";
            this.DiaChi.Name = "DiaChi";
            this.DiaChi.ReadOnly = true;
            // 
            // btsua
            // 
            this.btsua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btsua.ForeColor = System.Drawing.Color.Blue;
            this.btsua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btsua.ImageIndex = 2;
            this.btsua.ImageList = this.imageList1;
            this.btsua.Location = new System.Drawing.Point(102, 249);
            this.btsua.Name = "btsua";
            this.btsua.Size = new System.Drawing.Size(75, 30);
            this.btsua.TabIndex = 10;
            this.btsua.Text = "Sửa";
            this.btsua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btsua.UseVisualStyleBackColor = true;
            this.btsua.Click += new System.EventHandler(this.btsua_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.Color.Green;
            this.label2.Location = new System.Drawing.Point(479, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(355, 32);
            this.label2.TabIndex = 16;
            this.label2.Text = "DÁNH SÁCH NHÂN VIÊN";
            // 
            // btxoa
            // 
            this.btxoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btxoa.ForeColor = System.Drawing.Color.Red;
            this.btxoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btxoa.ImageIndex = 4;
            this.btxoa.ImageList = this.imageList1;
            this.btxoa.Location = new System.Drawing.Point(195, 249);
            this.btxoa.Name = "btxoa";
            this.btxoa.Size = new System.Drawing.Size(75, 30);
            this.btxoa.TabIndex = 11;
            this.btxoa.Text = "Xóa";
            this.btxoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btxoa.UseVisualStyleBackColor = true;
            this.btxoa.Click += new System.EventHandler(this.btxoa_Click);
            // 
            // pnlDSNhanVien
            // 
            this.pnlDSNhanVien.Location = new System.Drawing.Point(34, 285);
            this.pnlDSNhanVien.Name = "pnlDSNhanVien";
            this.pnlDSNhanVien.Size = new System.Drawing.Size(761, 255);
            this.pnlDSNhanVien.TabIndex = 25;
            // 
            // button1
            // 
            this.button1.Image = global::NHAHANGBUFFET.Properties.Resources._222;
            this.button1.Location = new System.Drawing.Point(884, 249);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(233, 228);
            this.button1.TabIndex = 26;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // uctNhanvien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::NHAHANGBUFFET.Properties.Resources.v462_n_130_textureidea_1;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pnlDSNhanVien);
            this.Controls.Add(this.bthuy);
            this.Controls.Add(this.grqlnhanvien);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btan);
            this.Controls.Add(this.bttimkiem);
            this.Controls.Add(this.btluu);
            this.Controls.Add(this.btthem);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btsua);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btxoa);
            this.Name = "uctNhanvien";
            this.Size = new System.Drawing.Size(1150, 500);
            this.Load += new System.EventHandler(this.uctNhanvien_Load_1);
            this.grqlnhanvien.ResumeLayout(false);
            this.grqlnhanvien.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dsnhanvien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bthuy;
        private System.Windows.Forms.GroupBox grqlnhanvien;
        private System.Windows.Forms.ComboBox cbgt;
        private System.Windows.Forms.DateTimePicker dtngaysinh;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtdiachi;
        private System.Windows.Forms.TextBox txtten;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtgmail;
        private System.Windows.Forms.TextBox txttenlot;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtdienthoai;
        private System.Windows.Forms.TextBox txtmanv;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btan;
        private System.Windows.Forms.Button bttimkiem;
        private System.Windows.Forms.Button btluu;
        private System.Windows.Forms.Button btthem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btsua;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btxoa;
        private System.Windows.Forms.Panel pnlDSNhanVien;
        private System.Windows.Forms.DataGridView dsnhanvien;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChucVu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ngaysinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn GioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn DienThoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
    }
}
