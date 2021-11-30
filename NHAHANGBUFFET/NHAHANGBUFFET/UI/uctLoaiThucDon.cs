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
    public partial class uctLoaiThucDon : UserControl
    {
        public uctLoaiThucDon()
        {
            InitializeComponent();
        }
        int flag = 0;
        public static uctLoaiThucDon uctLTD = new uctLoaiThucDon();
        public void HienThiDanhSachLoaiThucDon()
        {
            dsthucdon.DataSource = BLL.LoaiThucDonMod .FillDataSetLoaiThucDon().Tables[0];
            dsthucdon.BorderStyle = BorderStyle.Fixed3D;
            dsthucdon.RowHeadersVisible = false;
            lbDS.BackColor = Color.Transparent;
            lbQL.BackColor = Color.Transparent;

        }



        //Ham de tro den du lieu tren datagridview
        void bingding()
        {
            txtIdLoaiThucDon.DataBindings.Clear();
            txtIdLoaiThucDon.DataBindings.Add("Text", dsthucdon.DataSource, "IdLoaiThucDon");
            txtTen.DataBindings.Clear();
            txtTen.DataBindings.Add("Text", dsthucdon.DataSource, "TenLoaiThucDon");
            txtDienGiai.DataBindings.Clear();
            txtDienGiai.DataBindings.Add("Text", dsthucdon.DataSource, "DienGiai");
            cbTrangThai.DataBindings.Clear();
            cbTrangThai.DataBindings.Add("Text", dsthucdon.DataSource, "TrangThai");

        }
        //ham dis-end cac buton khi load len
        void dis_end(bool e)
        {
            txtIdLoaiThucDon.Enabled = e;
            txtTen.Enabled = e;
            txtDienGiai.Enabled = e;
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

            cbTrangThai.Items.Add("Còn");
            cbTrangThai.Items.Add("Hết");


        }
        //ham xoa du lieu o textbox
        void cleardData()
        {
            txtIdLoaiThucDon.Text = "";
            txtTen.Text = "";
            txtDienGiai.Text = "";
            cbTrangThai.Text = "";
            loadcontrol();

        }
        private void uctLoaiThucDon_Load(object sender, EventArgs e)
        {
            HienThiDanhSachLoaiThucDon();
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
            uctLoaiThucDon_Load(sender, e);
            dis_end(false);
        }

        private void btluu_Click(object sender, EventArgs e)
        {
            string _idLoaiThucDon = "";
            try
            {
                _idLoaiThucDon = txtIdLoaiThucDon.Text;
            }
            catch { }
            string _ten = "";
            try
            {
                _ten = txtTen.Text;
            }
            catch { }
            string _dienGiai = "";
            try
            {
                _dienGiai = txtDienGiai.Text;
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
                if (_ten == "")
                    MessageBox.Show("Hãy nhập Tên");
                else
                {
                    int i = 0;
                    i = DAL.LoaiThucDonCtrl.InsertLoaiThucDon(_idLoaiThucDon, _ten, _dienGiai, _trangThai);
                    if (i > 0)
                    {
                        MessageBox.Show("Thêm mới thành công!");
                        HienThiDanhSachLoaiThucDon();
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
                i = DAL.LoaiThucDonCtrl.UpdateLoaiThucDon(_idLoaiThucDon, _ten, _dienGiai, _trangThai);
                if (i > 0)
                {
                    MessageBox.Show("Sửa thành công!");
                    HienThiDanhSachLoaiThucDon();
                }
                else
                    MessageBox.Show("Sửa thất bại!");

            }
            uctLoaiThucDon_Load(sender, e);
        }

        private void btxoa_Click(object sender, EventArgs e)
        {

            string _idLoaiThucDon = "";
            try
            {
                _idLoaiThucDon = txtIdLoaiThucDon.Text;
            }
            catch { }
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                int i = 0;
                i = DAL.LoaiThucDonCtrl.DeleteLoaiThucDon(_idLoaiThucDon);
                if (i > 0)
                {
                    MessageBox.Show("Xóa thành công!");
                    HienThiDanhSachLoaiThucDon();
                    uctLoaiThucDon_Load(sender, e);
                }
                else
                    MessageBox.Show("Xóa thất bại!");
            }
            else
                return;
        }
    }
}
