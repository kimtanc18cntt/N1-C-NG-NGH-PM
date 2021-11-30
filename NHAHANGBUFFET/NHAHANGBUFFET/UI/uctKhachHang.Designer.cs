namespace NHAHANGBUFFET.UI
{
    partial class uctKhachHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uctKhachHang));
            this.bthuy = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.grqlnhanvien = new System.Windows.Forms.GroupBox();
            this.cbDQ = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDT = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDC = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.txtEM = new System.Windows.Forms.TextBox();
            this.txtidKH = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btluu = new System.Windows.Forms.Button();
            this.btthem = new System.Windows.Forms.Button();
            this.btsua = new System.Windows.Forms.Button();
            this.btxoa = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dskhachhang = new System.Windows.Forms.DataGridView();
            this.IDKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dq = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.grqlnhanvien.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dskhachhang)).BeginInit();
            this.SuspendLayout();
            // 
            // bthuy
            // 
            this.bthuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bthuy.ForeColor = System.Drawing.Color.Black;
            this.bthuy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bthuy.ImageIndex = 0;
            this.bthuy.ImageList = this.imageList1;
            this.bthuy.Location = new System.Drawing.Point(221, 409);
            this.bthuy.Name = "bthuy";
            this.bthuy.Size = new System.Drawing.Size(85, 40);
            this.bthuy.TabIndex = 31;
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
            // grqlnhanvien
            // 
            this.grqlnhanvien.Controls.Add(this.cbDQ);
            this.grqlnhanvien.Controls.Add(this.label6);
            this.grqlnhanvien.Controls.Add(this.txtDT);
            this.grqlnhanvien.Controls.Add(this.label5);
            this.grqlnhanvien.Controls.Add(this.txtDC);
            this.grqlnhanvien.Controls.Add(this.label8);
            this.grqlnhanvien.Controls.Add(this.label4);
            this.grqlnhanvien.Controls.Add(this.txtTen);
            this.grqlnhanvien.Controls.Add(this.txtEM);
            this.grqlnhanvien.Controls.Add(this.txtidKH);
            this.grqlnhanvien.Controls.Add(this.label7);
            this.grqlnhanvien.Controls.Add(this.label3);
            this.grqlnhanvien.Location = new System.Drawing.Point(25, 70);
            this.grqlnhanvien.Name = "grqlnhanvien";
            this.grqlnhanvien.Size = new System.Drawing.Size(352, 277);
            this.grqlnhanvien.TabIndex = 25;
            this.grqlnhanvien.TabStop = false;
            // 
            // cbDQ
            // 
            this.cbDQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDQ.FormattingEnabled = true;
            this.cbDQ.Location = new System.Drawing.Point(196, 233);
            this.cbDQ.Name = "cbDQ";
            this.cbDQ.Size = new System.Drawing.Size(132, 26);
            this.cbDQ.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(7, 233);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 24);
            this.label6.TabIndex = 0;
            this.label6.Text = "Đặc quyền:";
            // 
            // txtDT
            // 
            this.txtDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDT.Location = new System.Drawing.Point(196, 101);
            this.txtDT.Name = "txtDT";
            this.txtDT.Size = new System.Drawing.Size(132, 24);
            this.txtDT.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(7, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 24);
            this.label5.TabIndex = 0;
            this.label5.Text = "Địa chỉ:";
            // 
            // txtDC
            // 
            this.txtDC.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDC.Location = new System.Drawing.Point(196, 190);
            this.txtDC.Name = "txtDC";
            this.txtDC.Size = new System.Drawing.Size(132, 24);
            this.txtDC.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(7, 146);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 24);
            this.label8.TabIndex = 0;
            this.label8.Text = "Email:";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(168, 24);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tên khách hàng:";
            // 
            // txtTen
            // 
            this.txtTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTen.Location = new System.Drawing.Point(196, 63);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(132, 24);
            this.txtTen.TabIndex = 1;
            // 
            // txtEM
            // 
            this.txtEM.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEM.Location = new System.Drawing.Point(196, 147);
            this.txtEM.Name = "txtEM";
            this.txtEM.Size = new System.Drawing.Size(132, 24);
            this.txtEM.TabIndex = 1;
            // 
            // txtidKH
            // 
            this.txtidKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtidKH.Location = new System.Drawing.Point(196, 16);
            this.txtidKH.Name = "txtidKH";
            this.txtidKH.Size = new System.Drawing.Size(132, 24);
            this.txtidKH.TabIndex = 1;
            this.txtidKH.TextChanged += new System.EventHandler(this.txtidKH_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(7, 101);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 24);
            this.label7.TabIndex = 0;
            this.label7.Text = "Điện thoại:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "Id Khách hàng:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.Crimson;
            this.label1.Location = new System.Drawing.Point(19, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(394, 36);
            this.label1.TabIndex = 26;
            this.label1.Text = "QUẢN LÝ KHÁCH HÀNG";
            // 
            // btluu
            // 
            this.btluu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btluu.ForeColor = System.Drawing.Color.Black;
            this.btluu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btluu.ImageIndex = 6;
            this.btluu.ImageList = this.imageList1;
            this.btluu.Location = new System.Drawing.Point(57, 409);
            this.btluu.Name = "btluu";
            this.btluu.Size = new System.Drawing.Size(85, 40);
            this.btluu.TabIndex = 30;
            this.btluu.Text = "Lưu";
            this.btluu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btluu.UseVisualStyleBackColor = true;
            this.btluu.Click += new System.EventHandler(this.btluu_Click);
            // 
            // btthem
            // 
            this.btthem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btthem.ForeColor = System.Drawing.Color.Black;
            this.btthem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btthem.ImageIndex = 3;
            this.btthem.ImageList = this.imageList1;
            this.btthem.Location = new System.Drawing.Point(35, 363);
            this.btthem.Name = "btthem";
            this.btthem.Size = new System.Drawing.Size(85, 40);
            this.btthem.TabIndex = 29;
            this.btthem.Text = "Thêm";
            this.btthem.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.btthem.UseVisualStyleBackColor = true;
            this.btthem.Click += new System.EventHandler(this.btthem_Click);
            // 
            // btsua
            // 
            this.btsua.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btsua.ForeColor = System.Drawing.Color.Black;
            this.btsua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btsua.ImageIndex = 2;
            this.btsua.ImageList = this.imageList1;
            this.btsua.Location = new System.Drawing.Point(138, 363);
            this.btsua.Name = "btsua";
            this.btsua.Size = new System.Drawing.Size(85, 40);
            this.btsua.TabIndex = 28;
            this.btsua.Text = "Sửa";
            this.btsua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btsua.UseVisualStyleBackColor = true;
            this.btsua.Click += new System.EventHandler(this.btsua_Click);
            // 
            // btxoa
            // 
            this.btxoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btxoa.ForeColor = System.Drawing.Color.Black;
            this.btxoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btxoa.ImageIndex = 4;
            this.btxoa.ImageList = this.imageList1;
            this.btxoa.Location = new System.Drawing.Point(241, 363);
            this.btxoa.Name = "btxoa";
            this.btxoa.Size = new System.Drawing.Size(85, 40);
            this.btxoa.TabIndex = 27;
            this.btxoa.Text = "Xóa";
            this.btxoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btxoa.UseVisualStyleBackColor = true;
            this.btxoa.Click += new System.EventHandler(this.btxoa_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dskhachhang);
            this.groupBox1.Location = new System.Drawing.Point(424, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(635, 280);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            // 
            // dskhachhang
            // 
            this.dskhachhang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dskhachhang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDKH,
            this.ten,
            this.dt,
            this.email,
            this.dc,
            this.dq});
            this.dskhachhang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dskhachhang.Location = new System.Drawing.Point(3, 16);
            this.dskhachhang.Name = "dskhachhang";
            this.dskhachhang.Size = new System.Drawing.Size(629, 261);
            this.dskhachhang.TabIndex = 0;
            // 
            // IDKH
            // 
            this.IDKH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.IDKH.DataPropertyName = "IdKhachHang";
            this.IDKH.HeaderText = "ID Khách hàng";
            this.IDKH.Name = "IDKH";
            this.IDKH.Width = 96;
            // 
            // ten
            // 
            this.ten.DataPropertyName = "TenKhachHang";
            this.ten.HeaderText = "Tên Khách Hàng";
            this.ten.Name = "ten";
            // 
            // dt
            // 
            this.dt.DataPropertyName = "DienThoai";
            this.dt.HeaderText = "Điện Thoại";
            this.dt.Name = "dt";
            // 
            // email
            // 
            this.email.DataPropertyName = "Email";
            this.email.HeaderText = "Email";
            this.email.Name = "email";
            // 
            // dc
            // 
            this.dc.DataPropertyName = "DiaChi";
            this.dc.HeaderText = "Địa Chỉ";
            this.dc.Name = "dc";
            // 
            // dq
            // 
            this.dq.DataPropertyName = "Dacquyen";
            this.dq.HeaderText = "Đặc quyền";
            this.dq.Name = "dq";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.Color.Crimson;
            this.label2.Location = new System.Drawing.Point(518, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(439, 36);
            this.label2.TabIndex = 26;
            this.label2.Text = "DANH SÁCH KHÁCH HÀNG";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(-15, -15);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 33;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Image = global::NHAHANGBUFFET.Properties.Resources._1111;
            this.button2.Location = new System.Drawing.Point(415, 375);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(653, 100);
            this.button2.TabIndex = 34;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList2.Images.SetKeyName(0, "1111.png");
            // 
            // uctKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::NHAHANGBUFFET.Properties.Resources._3333333333333;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bthuy);
            this.Controls.Add(this.grqlnhanvien);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btluu);
            this.Controls.Add(this.btthem);
            this.Controls.Add(this.btsua);
            this.Controls.Add(this.btxoa);
            this.Name = "uctKhachHang";
            this.Size = new System.Drawing.Size(1150, 623);
            this.Load += new System.EventHandler(this.uctKhachHang_Load);
            this.grqlnhanvien.ResumeLayout(false);
            this.grqlnhanvien.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dskhachhang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bthuy;
        private System.Windows.Forms.GroupBox grqlnhanvien;
        private System.Windows.Forms.TextBox txtDT;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDC;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEM;
        private System.Windows.Forms.TextBox txtidKH;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btluu;
        private System.Windows.Forms.Button btthem;
        private System.Windows.Forms.Button btsua;
        private System.Windows.Forms.Button btxoa;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dskhachhang;
        private System.Windows.Forms.ComboBox cbDQ;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn ten;
        private System.Windows.Forms.DataGridViewTextBoxColumn dt;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn dc;
        private System.Windows.Forms.DataGridViewTextBoxColumn dq;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ImageList imageList2;
    }
}
