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
    public partial class uctKhachHang : UserControl
    {
        public uctKhachHang()
        {
            InitializeComponent();
        }
        int flag = 0;
        public static uctKhachHang uctKH = new uctKhachHang();
        public void HienThiDanhSachKhachHang()
        {
            dskhachhang.DataSource = BLL.KhachHangMod.FillDataSetKhachHang().Tables[0];
            dskhachhang.BorderStyle = BorderStyle.Fixed3D;
            dskhachhang.RowHeadersVisible = false;
            label1.BackColor = Color.Transparent;
            label2.BackColor = Color.Transparent;
            label3.BackColor = Color.Transparent;
            label4.BackColor = Color.Transparent;
            label5.BackColor = Color.Transparent;
            label6.BackColor = Color.Transparent;
            label7.BackColor = Color.Transparent;
            label8.BackColor = Color.Transparent;

        }



        //Ham de tro den du lieu tren datagridview
        void bingding()
        {
            txtidKH.DataBindings.Clear();
            txtidKH.DataBindings.Add("Text", dskhachhang.DataSource, "IdKhachHang");
            txtTen.DataBindings.Clear();
            txtTen.DataBindings.Add("Text", dskhachhang.DataSource, "TenKhachHang");
            txtDT.DataBindings.Clear();
            txtDT.DataBindings.Add("Text", dskhachhang.DataSource, "DienThoai");
            txtEM.DataBindings.Clear();
            txtEM.DataBindings.Add("Text", dskhachhang.DataSource, "Email");
            txtDC.DataBindings.Clear();
            txtDC.DataBindings.Add("Text", dskhachhang.DataSource, "DiaChi");
            cbDQ.DataBindings.Clear();
            cbDQ.DataBindings.Add("Text", dskhachhang.DataSource, "DacQuyen");


        }
        //ham dis-end cac buton khi load len
        void dis_end(bool e)
        {
            txtidKH.Enabled = e;
            txtTen.Enabled = e;
            txtDT.Enabled = e;
            txtEM.Enabled = e;
            txtDC.Enabled = e;
            cbDQ.Enabled = e;
            btluu.Enabled = e;
            bthuy.Enabled = e;
            btthem.Enabled = !e;
            btsua.Enabled = !e;
            btxoa.Enabled = !e;
        }
        //ham load dac quyen
        void loadcontrol()
        {
            cbDQ.Items.Clear();
            cbDQ.Items.Add("Khách Thường");
            cbDQ.Items.Add("Khách Vip");
        }
        //ham xoa du lieu o textbox
        void cleardData()
        {
            txtidKH.Text = "";
            txtTen.Text = "";
            txtDT.Text = "";
            txtEM.Text = "";
            txtDC.Text = "";
            cbDQ.Text = "";
            loadcontrol();

        }
        private void uctKhachHang_Load(object sender, EventArgs e)
        {
            HienThiDanhSachKhachHang();
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
            uctKhachHang_Load(sender, e);
            dis_end(false);
        }

        private void btluu_Click(object sender, EventArgs e)
        {

            string _idKH = "";
            try
            {
                _idKH = txtidKH.Text;
            }
            catch { }
            string _tenKH = "";
            try
            {
                _tenKH = txtTen.Text;
            }
            catch { }
            string _dienThoai = "";
            try
            {
                _dienThoai = txtDT.Text;
            }
            catch { }

            string _email = "";
            try
            {
                _email = txtEM.Text;
            }
            catch { }
            string _diaChi = "";
            try
            {
                _diaChi = txtDC.Text;
            }
            catch { }

            string _dacQuyen = "";
            try
            {
                _dacQuyen = cbDQ.Text;
            }
            catch { }
            if (flag == 0)
            {
                //themmoi
                if (_tenKH == "")
                    MessageBox.Show("Hãy nhập Nội Tên Khách hàng");
                else
                {
                    int i = 0;
                    i = DAL.KhachHangCtrl.InsertKhachHang(_idKH, _tenKH, _dienThoai, _email, _diaChi, _dacQuyen);
                    if (i > 0)
                    {
                        MessageBox.Show("Thêm mới thành công!");
                        HienThiDanhSachKhachHang();
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
                i = DAL.KhachHangCtrl.UpdateKhachHang(_idKH, _tenKH, _dienThoai, _email, _diaChi, _dacQuyen);
                if (i > 0)
                {
                    MessageBox.Show("Sửa thành công!");
                    HienThiDanhSachKhachHang();
                }
                else
                    MessageBox.Show("Sửa thất bại!");

            }
            uctKhachHang_Load(sender, e);
        }

        private void btxoa_Click(object sender, EventArgs e)
        {
            string _idKH = "";
            try
            {
                _idKH = txtidKH.Text;
            }
            catch { }
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                int i = 0;
                i = DAL.KhachHangCtrl.DeleteKhachHang(_idKH);
                if (i > 0)
                {
                    MessageBox.Show("Xóa thành công!");
                    HienThiDanhSachKhachHang();
                    uctKhachHang_Load(sender, e);
                }
                else
                    MessageBox.Show("Xóa thất bại!");
            }
            else
                return;
        }

        private void txtidKH_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
