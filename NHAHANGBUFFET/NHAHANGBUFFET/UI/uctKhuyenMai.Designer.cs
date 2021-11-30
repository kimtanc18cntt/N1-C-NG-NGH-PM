namespace NHAHANGBUFFET.UI
{
    partial class uctKhuyenMai
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uctKhuyenMai));
            this.lbQL = new System.Windows.Forms.Label();
            this.bthuy = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btluu = new System.Windows.Forms.Button();
            this.btxoa = new System.Windows.Forms.Button();
            this.btsua = new System.Windows.Forms.Button();
            this.btthem = new System.Windows.Forms.Button();
            this.cbDoiTuong = new System.Windows.Forms.ComboBox();
            this.txtNoiDung = new System.Windows.Forms.TextBox();
            this.txtDienGiai = new System.Windows.Forms.TextBox();
            this.txtIdKM = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbDS = new System.Windows.Forms.Label();
            this.dskhuyenmai = new System.Windows.Forms.DataGridView();
            this.IdKM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NoiDung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DienGiai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DoiTuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grqlnhanvien = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dskhuyenmai)).BeginInit();
            this.grqlnhanvien.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbQL
            // 
            this.lbQL.AutoSize = true;
            this.lbQL.BackColor = System.Drawing.SystemColors.Desktop;
            this.lbQL.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbQL.ForeColor = System.Drawing.Color.Red;
            this.lbQL.Location = new System.Drawing.Point(25, 19);
            this.lbQL.Name = "lbQL";
            this.lbQL.Size = new System.Drawing.Size(383, 36);
            this.lbQL.TabIndex = 32;
            this.lbQL.Text = "QUẢN LÝ KHUYẾN MÃI";
            // 
            // bthuy
            // 
            this.bthuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bthuy.ForeColor = System.Drawing.Color.Red;
            this.bthuy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bthuy.ImageKey = "huy.jpg";
            this.bthuy.ImageList = this.imageList1;
            this.bthuy.Location = new System.Drawing.Point(198, 447);
            this.bthuy.Name = "bthuy";
            this.bthuy.Size = new System.Drawing.Size(85, 40);
            this.bthuy.TabIndex = 27;
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
            this.btluu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btluu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btluu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btluu.ImageIndex = 6;
            this.btluu.ImageList = this.imageList1;
            this.btluu.Location = new System.Drawing.Point(96, 447);
            this.btluu.Name = "btluu";
            this.btluu.Size = new System.Drawing.Size(85, 40);
            this.btluu.TabIndex = 28;
            this.btluu.Text = "Lưu";
            this.btluu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btluu.UseVisualStyleBackColor = true;
            this.btluu.Click += new System.EventHandler(this.btluu_Click);
            // 
            // btxoa
            // 
            this.btxoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btxoa.ForeColor = System.Drawing.Color.Red;
            this.btxoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btxoa.ImageIndex = 4;
            this.btxoa.ImageList = this.imageList1;
            this.btxoa.Location = new System.Drawing.Point(265, 401);
            this.btxoa.Name = "btxoa";
            this.btxoa.Size = new System.Drawing.Size(85, 40);
            this.btxoa.TabIndex = 29;
            this.btxoa.Text = "Xóa";
            this.btxoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btxoa.UseVisualStyleBackColor = true;
            this.btxoa.Click += new System.EventHandler(this.btxoa_Click);
            // 
            // btsua
            // 
            this.btsua.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btsua.ForeColor = System.Drawing.Color.Blue;
            this.btsua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btsua.ImageIndex = 2;
            this.btsua.ImageList = this.imageList1;
            this.btsua.Location = new System.Drawing.Point(151, 400);
            this.btsua.Name = "btsua";
            this.btsua.Size = new System.Drawing.Size(85, 40);
            this.btsua.TabIndex = 30;
            this.btsua.Text = "Sửa";
            this.btsua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btsua.UseVisualStyleBackColor = true;
            this.btsua.Click += new System.EventHandler(this.btsua_Click);
            // 
            // btthem
            // 
            this.btthem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btthem.ForeColor = System.Drawing.Color.Lime;
            this.btthem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btthem.ImageIndex = 3;
            this.btthem.ImageList = this.imageList1;
            this.btthem.Location = new System.Drawing.Point(40, 401);
            this.btthem.Name = "btthem";
            this.btthem.Size = new System.Drawing.Size(85, 40);
            this.btthem.TabIndex = 31;
            this.btthem.Text = "Thêm";
            this.btthem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btthem.UseVisualStyleBackColor = true;
            this.btthem.Click += new System.EventHandler(this.btthem_Click);
            // 
            // cbDoiTuong
            // 
            this.cbDoiTuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDoiTuong.FormattingEnabled = true;
            this.cbDoiTuong.Location = new System.Drawing.Point(245, 210);
            this.cbDoiTuong.Name = "cbDoiTuong";
            this.cbDoiTuong.Size = new System.Drawing.Size(130, 28);
            this.cbDoiTuong.TabIndex = 26;
            // 
            // txtNoiDung
            // 
            this.txtNoiDung.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNoiDung.Location = new System.Drawing.Point(245, 94);
            this.txtNoiDung.Name = "txtNoiDung";
            this.txtNoiDung.Size = new System.Drawing.Size(130, 26);
            this.txtNoiDung.TabIndex = 23;
            // 
            // txtDienGiai
            // 
            this.txtDienGiai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDienGiai.Location = new System.Drawing.Point(245, 149);
            this.txtDienGiai.Name = "txtDienGiai";
            this.txtDienGiai.Size = new System.Drawing.Size(130, 26);
            this.txtDienGiai.TabIndex = 24;
            // 
            // txtIdKM
            // 
            this.txtIdKM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdKM.Location = new System.Drawing.Point(245, 36);
            this.txtIdKM.Name = "txtIdKM";
            this.txtIdKM.Size = new System.Drawing.Size(130, 26);
            this.txtIdKM.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 24);
            this.label3.TabIndex = 19;
            this.label3.Text = "Diễn Giải:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(203, 24);
            this.label4.TabIndex = 20;
            this.label4.Text = "Đối Tượng nhận KM:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(224, 24);
            this.label2.TabIndex = 21;
            this.label2.Text = "Nội dung Khuyến mãi :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 24);
            this.label1.TabIndex = 22;
            this.label1.Text = "Id Khuyến mãi:";
            // 
            // lbDS
            // 
            this.lbDS.AutoSize = true;
            this.lbDS.BackColor = System.Drawing.SystemColors.Desktop;
            this.lbDS.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbDS.ForeColor = System.Drawing.Color.Red;
            this.lbDS.Location = new System.Drawing.Point(466, 19);
            this.lbDS.Name = "lbDS";
            this.lbDS.Size = new System.Drawing.Size(428, 36);
            this.lbDS.TabIndex = 32;
            this.lbDS.Text = "DANH SÁCH KHUYẾN MÃI";
            // 
            // dskhuyenmai
            // 
            this.dskhuyenmai.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dskhuyenmai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dskhuyenmai.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdKM,
            this.NoiDung,
            this.DienGiai,
            this.DoiTuong});
            this.dskhuyenmai.Location = new System.Drawing.Point(456, 90);
            this.dskhuyenmai.Name = "dskhuyenmai";
            this.dskhuyenmai.Size = new System.Drawing.Size(507, 268);
            this.dskhuyenmai.TabIndex = 33;
            // 
            // IdKM
            // 
            this.IdKM.DataPropertyName = "IdKM";
            this.IdKM.HeaderText = "Id Khuyến Mãi";
            this.IdKM.Name = "IdKM";
            // 
            // NoiDung
            // 
            this.NoiDung.DataPropertyName = "NoiDung";
            this.NoiDung.HeaderText = "Nội dung KM";
            this.NoiDung.Name = "NoiDung";
            // 
            // DienGiai
            // 
            this.DienGiai.DataPropertyName = "DienGiai";
            this.DienGiai.HeaderText = "Diễn giải";
            this.DienGiai.Name = "DienGiai";
            // 
            // DoiTuong
            // 
            this.DoiTuong.DataPropertyName = "DoiTuong";
            this.DoiTuong.HeaderText = "Đối tượng ưu đãi";
            this.DoiTuong.Name = "DoiTuong";
            // 
            // grqlnhanvien
            // 
            this.grqlnhanvien.BackColor = System.Drawing.Color.CadetBlue;
            this.grqlnhanvien.Controls.Add(this.txtIdKM);
            this.grqlnhanvien.Controls.Add(this.txtDienGiai);
            this.grqlnhanvien.Controls.Add(this.txtNoiDung);
            this.grqlnhanvien.Controls.Add(this.cbDoiTuong);
            this.grqlnhanvien.Controls.Add(this.label1);
            this.grqlnhanvien.Controls.Add(this.label2);
            this.grqlnhanvien.Controls.Add(this.label3);
            this.grqlnhanvien.Controls.Add(this.label4);
            this.grqlnhanvien.Location = new System.Drawing.Point(20, 90);
            this.grqlnhanvien.Name = "grqlnhanvien";
            this.grqlnhanvien.Size = new System.Drawing.Size(388, 268);
            this.grqlnhanvien.TabIndex = 34;
            this.grqlnhanvien.TabStop = false;
            // 
            // button2
            // 
            this.button2.Image = global::NHAHANGBUFFET.Properties.Resources._1111;
            this.button2.Location = new System.Drawing.Point(385, 387);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(653, 100);
            this.button2.TabIndex = 35;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // uctKhuyenMai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::NHAHANGBUFFET.Properties.Resources.v462_n_130_textureidea_1;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.grqlnhanvien);
            this.Controls.Add(this.dskhuyenmai);
            this.Controls.Add(this.lbDS);
            this.Controls.Add(this.lbQL);
            this.Controls.Add(this.bthuy);
            this.Controls.Add(this.btluu);
            this.Controls.Add(this.btxoa);
            this.Controls.Add(this.btsua);
            this.Controls.Add(this.btthem);
            this.Name = "uctKhuyenMai";
            this.Size = new System.Drawing.Size(1150, 500);
            this.Load += new System.EventHandler(this.uctKhuyenMai_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dskhuyenmai)).EndInit();
            this.grqlnhanvien.ResumeLayout(false);
            this.grqlnhanvien.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbQL;
        private System.Windows.Forms.Button bthuy;
        private System.Windows.Forms.Button btluu;
        private System.Windows.Forms.Button btxoa;
        private System.Windows.Forms.Button btsua;
        private System.Windows.Forms.Button btthem;
        private System.Windows.Forms.ComboBox cbDoiTuong;
        private System.Windows.Forms.TextBox txtNoiDung;
        private System.Windows.Forms.TextBox txtDienGiai;
        private System.Windows.Forms.TextBox txtIdKM;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbDS;
        private System.Windows.Forms.DataGridView dskhuyenmai;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdKM;
        private System.Windows.Forms.DataGridViewTextBoxColumn NoiDung;
        private System.Windows.Forms.DataGridViewTextBoxColumn DienGiai;
        private System.Windows.Forms.DataGridViewTextBoxColumn DoiTuong;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.GroupBox grqlnhanvien;
        private System.Windows.Forms.Button button2;
    }
}
