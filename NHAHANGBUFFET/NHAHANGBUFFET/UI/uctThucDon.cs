using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NHAHANGBUFFET.UI
{
    public partial class uctThucDon : UserControl
    {
        public uctThucDon()
        {
            InitializeComponent();
        }
        int flag = 0;
        public static uctThucDon uctTDON = new uctThucDon();
        public void HienThiDanhSachThucDon()
        {
            dsThucDon.DataSource = BLL.ThucDonMod.FillDataSetThucDon().Tables[0];
            dsThucDon.BorderStyle = BorderStyle.Fixed3D;
            dsThucDon.RowHeadersVisible = false;

        }



        //Ham de tro den du lieu tren datagridview
        void bingding()
        {
            txtIdThucDon.DataBindings.Clear();
            txtIdThucDon.DataBindings.Add("Text", dsThucDon.DataSource, "IdThucDon");
            cbTenLoaiThucDon.DataBindings.Clear();
            cbTenLoaiThucDon.DataBindings.Add("Text", dsThucDon.DataSource, "TenLoaiThucDon");
            txtTenThucDon.DataBindings.Clear();
            txtTenThucDon.DataBindings.Add("Text", dsThucDon.DataSource, "TenThucDon");
            txtDonViTinh.DataBindings.Clear();
            txtDonViTinh.DataBindings.Add("Text", dsThucDon.DataSource, "DonViTinh");
            txtSoLuongTon.DataBindings.Clear();
            txtSoLuongTon.DataBindings.Add("Text", dsThucDon.DataSource, "SoLuongTon");
            txtDonGiaTon.DataBindings.Clear();
            txtDonGiaTon.DataBindings.Add("Text", dsThucDon.DataSource, "DonGiaTon");
            txtTonToiThieu.DataBindings.Clear();
            txtTonToiThieu.DataBindings.Add("Text", dsThucDon.DataSource, "TonToiThieu");
            cbTrangThai.DataBindings.Clear();
            cbTrangThai.DataBindings.Add("Text", dsThucDon.DataSource, "TrangThai");

        }
        //ham dis-end cac buton khi load len
        void dis_end(bool e)
        {
            txtIdThucDon.Enabled = e;
            cbTenLoaiThucDon.Enabled = e;
            txtTenThucDon.Enabled = e;
            txtDonViTinh.Enabled = e;
            txtSoLuongTon.Enabled = e;
            txtDonGiaTon.Enabled = e;
            txtTonToiThieu.Enabled = e;
            cbTrangThai.Enabled = e;
            btluu.Enabled = e;
            bthuy.Enabled = e;
            btthem.Enabled = !e;
            btsua.Enabled = !e;
            btxoa.Enabled = !e;
        }
        //ham load gioi tinh cho nhan vien
        void loadcontrol()
        {
            cbTrangThai.Items.Clear();
            cbTrangThai.Items.Add("Còn");
            cbTrangThai.Items.Add("Hết");
            //lấy cb tên khu vựu thông qua khu vực mod
            cbTenLoaiThucDon.DataSource = BLL.LoaiThucDonMod.getTenLoaiThucDon().Tables[0];
            cbTenLoaiThucDon.DisplayMember = "TenLoaiThucDon";
        }
        //ham xoa du lieu o textbox
        void cleardData()
        {
            txtIdThucDon.Text = "";
            cbTenLoaiThucDon.Text = "";
            txtTenThucDon.Text = "";
            txtDonViTinh.Text = "";
            txtSoLuongTon.Text = "";
            txtDonGiaTon.Text = "";
            txtTonToiThieu.Text = "";
            cbTrangThai.Text = "";
            loadcontrol();

        }
        private void uctThucDon_Load(object sender, EventArgs e)
        {
            HienThiDanhSachThucDon();
            dis_end(false);
            bingding();
        }

        private void btthem_Click(object sender, EventArgs e)
        {
            flag = 0;
            cleardData();
            dis_end(true);
        }

        private void btsua_Click(object sender, EventArgs e)
        {
            flag = 1;
            dis_end(true);
            loadcontrol();
        }

        private void bthuy_Click(object sender, EventArgs e)
        {
            uctThucDon_Load(sender, e);
            dis_end(false);
        }

        private void btluu_Click(object sender, EventArgs e)
        {
            string _idThucDon = "";
            try
            {
                _idThucDon = txtIdThucDon.Text;
            }
            catch { }
            string _tenLoaiThucDon = "";
            try
            {
                _tenLoaiThucDon = cbTenLoaiThucDon.Text;
            }
            catch { }
            string _tenThucDon = "";
            try
            {
                _tenThucDon = txtTenThucDon.Text;
            }
            catch { }
            string _donViTinh = "";
            try
            {
                _donViTinh = txtDonViTinh.Text;
            }
            catch { }
            float _soLuongTon = 0;
            try
            {
                _soLuongTon = Convert.ToInt32(txtSoLuongTon.Text);
            }
            catch { }
            float _donGiaTon = 0;
            try
            {
                _donGiaTon = Convert.ToInt32(txtDonGiaTon.Text);
            }
            catch { }
            float _tonToiThieu = 0;
            try
            {
                _tonToiThieu = Convert.ToInt32(txtTonToiThieu.Text);
            }
            catch { }

            string _trangThai = "";
            try
            {
                _trangThai = cbTrangThai.Text;
            }
            catch { }
            if (flag == 0)
            {
                //themmoi
                if (_tenThucDon == "")
                    MessageBox.Show("Hãy nhập Tên Thực Đơn");
                else
                {
                    int i = 0;
                    i = DAL.ThucDonCtrl.InsertThucDon(_idThucDon, _tenLoaiThucDon, _tenThucDon, _donViTinh, _soLuongTon, _donGiaTon, _tonToiThieu, _trangThai);
                    if (i > 0)
                    {
                        MessageBox.Show("Thêm mới thành công!");
                        HienThiDanhSachThucDon();
                    }
                    else
                    {
                        MessageBox.Show("Thêm mới thất bại!");
                    }
                }

            }
            else
            {
                int i = 0;
                i = DAL.ThucDonCtrl.UpdateThucDon(_idThucDon, _tenLoaiThucDon, _tenThucDon, _donViTinh, _soLuongTon, _donGiaTon, _tonToiThieu, _trangThai);
                if (i > 0)
                {
                    MessageBox.Show("Sửa thành công!");
                    HienThiDanhSachThucDon();
                }
                else
                    MessageBox.Show("Sửa thất bại!");

            }
            uctThucDon_Load(sender, e);
        }

        private void btxoa_Click(object sender, EventArgs e)
        {
            string _idThucDon = "";
            try
            {
                _idThucDon = txtIdThucDon.Text;
            }
            catch { }
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                int i = 0;
                i = DAL.ThucDonCtrl.DeleteThucDon(_idThucDon);
                if (i > 0)
                {
                    MessageBox.Show("Xóa thành công!");
                    HienThiDanhSachThucDon();
                    uctThucDon_Load(sender, e);
                }
                else
                    MessageBox.Show("Xóa thất bại!");
            }
            else
                return;
        }
    }
}
