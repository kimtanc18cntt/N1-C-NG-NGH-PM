namespace NHAHANGBUFFET
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dk = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.mk = new System.Windows.Forms.TextBox();
            this.tdn = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dangnhap = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.trove = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = global::NHAHANGBUFFET.Properties.Resources._15700936;
            this.groupBox1.Controls.Add(this.dk);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.mk);
            this.groupBox1.Controls.Add(this.tdn);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(130, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(380, 202);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Đăng Nhập";
            // 
            // dk
            // 
            this.dk.AutoSize = true;
            this.dk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dk.Location = new System.Drawing.Point(216, 141);
            this.dk.Name = "dk";
            this.dk.Size = new System.Drawing.Size(74, 20);
            this.dk.TabIndex = 3;
            this.dk.TabStop = true;
            this.dk.Text = "Đăng ký";
            this.dk.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.dk_LinkClicked);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Bạn chưa có tài khoản?";
            // 
            // mk
            // 
            this.mk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mk.Location = new System.Drawing.Point(159, 84);
            this.mk.Name = "mk";
            this.mk.PasswordChar = '*';
            this.mk.Size = new System.Drawing.Size(160, 26);
            this.mk.TabIndex = 2;
            // 
            // tdn
            // 
            this.tdn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tdn.Location = new System.Drawing.Point(159, 42);
            this.tdn.Name = "tdn";
            this.tdn.Size = new System.Drawing.Size(160, 26);
            this.tdn.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(65, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mật khẩu:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên đăng nhập:";
            // 
            // dangnhap
            // 
            this.dangnhap.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.dangnhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dangnhap.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dangnhap.ImageIndex = 3;
            this.dangnhap.ImageList = this.imageList1;
            this.dangnhap.Location = new System.Drawing.Point(139, 247);
            this.dangnhap.Name = "dangnhap";
            this.dangnhap.Size = new System.Drawing.Size(121, 39);
            this.dangnhap.TabIndex = 4;
            this.dangnhap.Text = "Đăng nhập";
            this.dangnhap.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.dangnhap.UseVisualStyleBackColor = true;
            this.dangnhap.Click += new System.EventHandler(this.dangnhap_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "dn.jpg");
            this.imageList1.Images.SetKeyName(1, "images (2).png");
            this.imageList1.Images.SetKeyName(2, "images (2).png");
            this.imageList1.Images.SetKeyName(3, "unnamed.jpg");
            this.imageList1.Images.SetKeyName(4, "dx.jpg");
            // 
            // trove
            // 
            this.trove.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.trove.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trove.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.trove.ImageIndex = 4;
            this.trove.ImageList = this.imageList1;
            this.trove.Location = new System.Drawing.Point(373, 247);
            this.trove.Name = "trove";
            this.trove.Size = new System.Drawing.Size(101, 39);
            this.trove.TabIndex = 5;
            this.trove.Text = "Thoát ";
            this.trove.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.trove.UseVisualStyleBackColor = true;
            this.trove.Click += new System.EventHandler(this.trove_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::NHAHANGBUFFET.Properties.Resources.pngtree_food_food_snack_eating_goods_image_14522;
            this.ClientSize = new System.Drawing.Size(668, 376);
            this.Controls.Add(this.trove);
            this.Controls.Add(this.dangnhap);
            this.Controls.Add(this.groupBox1);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập hệ thống";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.LinkLabel dk;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button dangnhap;
        private System.Windows.Forms.Button trove;
        public System.Windows.Forms.TextBox mk;
        public System.Windows.Forms.TextBox tdn;
        private System.Windows.Forms.ImageList imageList1;
    }
}