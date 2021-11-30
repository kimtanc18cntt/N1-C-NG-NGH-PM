namespace NHAHANGBUFFET.UI
{
    partial class uctKhuVuc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uctKhuVuc));
            this.label1 = new System.Windows.Forms.Label();
            this.txtIdKhuVuc = new System.Windows.Forms.TextBox();
            this.cbTrangThai = new System.Windows.Forms.ComboBox();
            this.btthem = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.txtDienGiai = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTenKhuVuc = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lbQL = new System.Windows.Forms.Label();
            this.lbTT = new System.Windows.Forms.Label();
            this.btsua = new System.Windows.Forms.Button();
            this.btxoa = new System.Windows.Forms.Button();
            this.btluu = new System.Windows.Forms.Button();
            this.bthuy = new System.Windows.Forms.Button();
            this.dgvKhuVuc = new System.Windows.Forms.DataGridView();
            this.IdKhuVuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenKhuVuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DienGiai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grqlnhanvien = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhuVuc)).BeginInit();
            this.grqlnhanvien.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id Khu Vực:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtIdKhuVuc
            // 
            this.txtIdKhuVuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdKhuVuc.Location = new System.Drawing.Point(167, 27);
            this.txtIdKhuVuc.Name = "txtIdKhuVuc";
            this.txtIdKhuVuc.Size = new System.Drawing.Size(130, 24);
            this.txtIdKhuVuc.TabIndex = 1;
            // 
            // cbTrangThai
            // 
            this.cbTrangThai.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTrangThai.FormattingEnabled = true;
            this.cbTrangThai.Location = new System.Drawing.Point(167, 121);
            this.cbTrangThai.Name = "cbTrangThai";
            this.cbTrangThai.Size = new System.Drawing.Size(130, 26);
            this.cbTrangThai.TabIndex = 2;
            // 
            // btthem
            // 
            this.btthem.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btthem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btthem.ForeColor = System.Drawing.Color.Black;
            this.btthem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btthem.ImageIndex = 3;
            this.btthem.ImageList = this.imageList1;
            this.btthem.Location = new System.Drawing.Point(16, 360);
            this.btthem.Name = "btthem";
            this.btthem.Size = new System.Drawing.Size(87, 30);
            this.btthem.TabIndex = 3;
            this.btthem.Text = "Thêm";
            this.btthem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btthem.UseVisualStyleBackColor = false;
            this.btthem.Click += new System.EventHandler(this.btthem_Click);
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên Khu Vực:";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtDienGiai
            // 
            this.txtDienGiai.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDienGiai.Location = new System.Drawing.Point(167, 173);
            this.txtDienGiai.Name = "txtDienGiai";
            this.txtDienGiai.Size = new System.Drawing.Size(130, 24);
            this.txtDienGiai.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "Diễn Giải:";
            this.label3.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtTenKhuVuc
            // 
            this.txtTenKhuVuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenKhuVuc.Location = new System.Drawing.Point(167, 74);
            this.txtTenKhuVuc.Name = "txtTenKhuVuc";
            this.txtTenKhuVuc.Size = new System.Drawing.Size(130, 24);
            this.txtTenKhuVuc.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 24);
            this.label4.TabIndex = 0;
            this.label4.Text = "Trạng Thái:";
            this.label4.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbQL
            // 
            this.lbQL.AutoSize = true;
            this.lbQL.BackColor = System.Drawing.SystemColors.Desktop;
            this.lbQL.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbQL.ForeColor = System.Drawing.Color.Red;
            this.lbQL.Location = new System.Drawing.Point(60, 14);
            this.lbQL.Name = "lbQL";
            this.lbQL.Size = new System.Drawing.Size(321, 36);
            this.lbQL.TabIndex = 4;
            this.lbQL.Text = "QUẢN LÝ KHU VỰC";
            // 
            // lbTT
            // 
            this.lbTT.AutoSize = true;
            this.lbTT.BackColor = System.Drawing.SystemColors.Desktop;
            this.lbTT.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbTT.ForeColor = System.Drawing.Color.Red;
            this.lbTT.Location = new System.Drawing.Point(502, 14);
            this.lbTT.Name = "lbTT";
            this.lbTT.Size = new System.Drawing.Size(363, 36);
            this.lbTT.TabIndex = 4;
            this.lbTT.Text = "THÔNG TIN  KHU VỰC";
            this.lbTT.Click += new System.EventHandler(this.label6_Click);
            // 
            // btsua
            // 
            this.btsua.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btsua.ForeColor = System.Drawing.Color.Black;
            this.btsua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btsua.ImageIndex = 2;
            this.btsua.ImageList = this.imageList1;
            this.btsua.Location = new System.Drawing.Point(109, 360);
            this.btsua.Name = "btsua";
            this.btsua.Size = new System.Drawing.Size(72, 30);
            this.btsua.TabIndex = 3;
            this.btsua.Text = "Sửa";
            this.btsua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btsua.UseVisualStyleBackColor = true;
            this.btsua.Click += new System.EventHandler(this.btsua_Click);
            // 
            // btxoa
            // 
            this.btxoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btxoa.ForeColor = System.Drawing.Color.DarkRed;
            this.btxoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btxoa.ImageIndex = 4;
            this.btxoa.ImageList = this.imageList1;
            this.btxoa.Location = new System.Drawing.Point(187, 360);
            this.btxoa.Name = "btxoa";
            this.btxoa.Size = new System.Drawing.Size(75, 30);
            this.btxoa.TabIndex = 3;
            this.btxoa.Text = "Xóa";
            this.btxoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btxoa.UseVisualStyleBackColor = true;
            this.btxoa.Click += new System.EventHandler(this.btxoa_Click);
            // 
            // btluu
            // 
            this.btluu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btluu.ForeColor = System.Drawing.Color.Black;
            this.btluu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btluu.ImageIndex = 6;
            this.btluu.ImageList = this.imageList1;
            this.btluu.Location = new System.Drawing.Point(16, 396);
            this.btluu.Name = "btluu";
            this.btluu.Size = new System.Drawing.Size(87, 31);
            this.btluu.TabIndex = 3;
            this.btluu.Text = "Lưu";
            this.btluu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btluu.UseVisualStyleBackColor = true;
            this.btluu.Click += new System.EventHandler(this.btluu_Click);
            // 
            // bthuy
            // 
            this.bthuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bthuy.ForeColor = System.Drawing.Color.Red;
            this.bthuy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bthuy.ImageKey = "huy.jpg";
            this.bthuy.ImageList = this.imageList1;
            this.bthuy.Location = new System.Drawing.Point(187, 393);
            this.bthuy.Name = "bthuy";
            this.bthuy.Size = new System.Drawing.Size(74, 31);
            this.bthuy.TabIndex = 3;
            this.bthuy.Text = "Hủy";
            this.bthuy.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bthuy.UseVisualStyleBackColor = true;
            this.bthuy.Click += new System.EventHandler(this.bthuy_Click);
            // 
            // dgvKhuVuc
            // 
            this.dgvKhuVuc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKhuVuc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdKhuVuc,
            this.TenKhuVuc,
            this.DienGiai,
            this.TrangThai});
            this.dgvKhuVuc.Location = new System.Drawing.Point(481, 82);
            this.dgvKhuVuc.Name = "dgvKhuVuc";
            this.dgvKhuVuc.Size = new System.Drawing.Size(513, 272);
            this.dgvKhuVuc.TabIndex = 5;
            // 
            // IdKhuVuc
            // 
            this.IdKhuVuc.DataPropertyName = "IdKhuVuc";
            this.IdKhuVuc.HeaderText = "Id Khu Vực";
            this.IdKhuVuc.Name = "IdKhuVuc";
            // 
            // TenKhuVuc
            // 
            this.TenKhuVuc.DataPropertyName = "TenKhuVuc";
            this.TenKhuVuc.HeaderText = "Tên Khu Vực";
            this.TenKhuVuc.Name = "TenKhuVuc";
            // 
            // DienGiai
            // 
            this.DienGiai.DataPropertyName = "DienGiai";
            this.DienGiai.HeaderText = "Diễn giải";
            this.DienGiai.Name = "DienGiai";
            // 
            // TrangThai
            // 
            this.TrangThai.DataPropertyName = "TrangThai";
            this.TrangThai.HeaderText = "Trạng thái";
            this.TrangThai.Name = "TrangThai";
            // 
            // grqlnhanvien
            // 
            this.grqlnhanvien.BackColor = System.Drawing.Color.CadetBlue;
            this.grqlnhanvien.Controls.Add(this.txtTenKhuVuc);
            this.grqlnhanvien.Controls.Add(this.label1);
            this.grqlnhanvien.Controls.Add(this.label2);
            this.grqlnhanvien.Controls.Add(this.label4);
            this.grqlnhanvien.Controls.Add(this.label3);
            this.grqlnhanvien.Controls.Add(this.txtIdKhuVuc);
            this.grqlnhanvien.Controls.Add(this.txtDienGiai);
            this.grqlnhanvien.Controls.Add(this.cbTrangThai);
            this.grqlnhanvien.Location = new System.Drawing.Point(29, 69);
            this.grqlnhanvien.Name = "grqlnhanvien";
            this.grqlnhanvien.Size = new System.Drawing.Size(366, 272);
            this.grqlnhanvien.TabIndex = 26;
            this.grqlnhanvien.TabStop = false;
            this.grqlnhanvien.Enter += new System.EventHandler(this.grqlnhanvien_Enter);
            // 
            // button2
            // 
            this.button2.Image = global::NHAHANGBUFFET.Properties.Resources._1111;
            this.button2.Location = new System.Drawing.Point(379, 360);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(653, 100);
            this.button2.TabIndex = 35;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // uctKhuVuc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::NHAHANGBUFFET.Properties.Resources.v462_n_130_textureidea_1;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.grqlnhanvien);
            this.Controls.Add(this.dgvKhuVuc);
            this.Controls.Add(this.lbTT);
            this.Controls.Add(this.lbQL);
            this.Controls.Add(this.bthuy);
            this.Controls.Add(this.btluu);
            this.Controls.Add(this.btxoa);
            this.Controls.Add(this.btsua);
            this.Controls.Add(this.btthem);
            this.Name = "uctKhuVuc";
            this.Size = new System.Drawing.Size(1150, 500);
            this.Load += new System.EventHandler(this.uctKhuVuc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhuVuc)).EndInit();
            this.grqlnhanvien.ResumeLayout(false);
            this.grqlnhanvien.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIdKhuVuc;
        private System.Windows.Forms.ComboBox cbTrangThai;
        private System.Windows.Forms.Button btthem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDienGiai;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTenKhuVuc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbQL;
        private System.Windows.Forms.Label lbTT;
        private System.Windows.Forms.Button btsua;
        private System.Windows.Forms.Button btxoa;
        private System.Windows.Forms.Button btluu;
        private System.Windows.Forms.Button bthuy;
        private System.Windows.Forms.DataGridView dgvKhuVuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdKhuVuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenKhuVuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn DienGiai;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrangThai;
        private System.Windows.Forms.GroupBox grqlnhanvien;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button button2;
    }
}
