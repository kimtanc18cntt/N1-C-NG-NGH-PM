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
    public partial class uctNhanvien : UserControl
    {
        public uctNhanvien()
        {
            InitializeComponent();
        }
        // khai bao bien de phan biet them sua
        int flag = 0;
        public static uctNhanvien uctNV = new uctNhanvien();
        public void HienThiDanhSachNhanVien()
        {
            dsnhanvien.DataSource = BLL.NhanVienMod.FillDataSetNhanVien().Tables[0];
            dsnhanvien.Dock = DockStyle.Fill;
            dsnhanvien.BorderStyle = BorderStyle.Fixed3D;
            dsnhanvien.Dock = DockStyle.Fill;
            dsnhanvien.RowHeadersVisible = false;

        }
        void nhung(Control ctr)
        {
            pnlDSNhanVien.Controls.Clear();
            pnlDSNhanVien.BorderStyle = BorderStyle.Fixed3D;
            ctr.Dock = DockStyle.Fill;
            pnlDSNhanVien.Controls.Add(ctr);
            pnlDSNhanVien.Show();
        }
        

        private void uctNhanvien_Load_1(object sender, EventArgs e)
        {
            HienThiDanhSachNhanVien();
            dis_end(false);
            bingding();
        }
        //Ham de tro den du lieu tren datagridview
        void bingding()
        {
            txtmanv.DataBindings.Clear();
            txtmanv.DataBindings.Add("Text", dsnhanvien.DataSource, "IdNhanVien");
            txttenlot.DataBindings.Clear();
            txttenlot.DataBindings.Add("Text", dsnhanvien.DataSource, "HoTen");
            txtten.DataBindings.Clear();
            txtten.DataBindings.Add("Text", dsnhanvien.DataSource, "ChucVu");
            dtngaysinh.DataBindings.Clear();
            dtngaysinh.DataBindings.Add("Text", dsnhanvien.DataSource, "NgaySinh");
            cbgt.DataBindings.Clear();
            cbgt.DataBindings.Add("Text", dsnhanvien.DataSource, "GioiTinh");
            txtdienthoai.DataBindings.Clear();
            txtdienthoai.DataBindings.Add("Text", dsnhanvien.DataSource, "Dienthoai");
            txtgmail.DataBindings.Clear();
            txtgmail.DataBindings.Add("Text", dsnhanvien.DataSource, "Email");
            txtdiachi.DataBindings.Clear();
            txtdiachi.DataBindings.Add("Text", dsnhanvien.DataSource, "DiaChi");
        }
        //ham dis-end cac buton khi load len
        void dis_end(bool e)
        {
            txtmanv.Enabled = e;
            txttenlot.Enabled = e;
            txtten.Enabled = e;
            dtngaysinh.Enabled = e;
            cbgt.Enabled = e;
            txtdienthoai.Enabled = e;
            txtgmail.Enabled = e;
            txtdiachi.Enabled = e;
            btluu.Enabled = e;
            bthuy.Enabled = e;
            btthem.Enabled = !e;
            btsua.Enabled = !e;
            btxoa.Enabled = !e;
        }
        //ham load gioi tinh cho nhan vien
        void loadcontrol()
        {
            cbgt.Items.Clear();
            cbgt.Items.Add("Nam");
            cbgt.Items.Add("Nữ");
            cbgt.Items.Add("Khác");
        }
        //ham xoa du lieu o textbox
        void cleardData()
        {
            txtmanv.Text = "";
            txttenlot.Text = "";
            txtten.Text = "";
            txtdienthoai.Text = "";
            txtgmail.Text = "";
            txtdiachi.Text = "";
            cbgt.Text = "";
            loadcontrol();

        }

        private void bthuy_Click(object sender, EventArgs e)
        {
            uctNhanvien_Load_1(sender, e);
            dis_end(false);
        }

        private void btsua_Click(object sender, EventArgs e)
        {
            flag = 1;
            dis_end(true);
            loadcontrol();
        }

        private void btthem_Click(object sender, EventArgs e)
        {
            flag = 0;
            cleardData();
            dis_end(true);
        }

        private void btluu_Click(object sender, EventArgs e)
        {
            string _idNhanVien = "";
            try
            {
                _idNhanVien = txtmanv.Text;
            }
            catch { }
            string _hotenNV = "";
            try
            {
                _hotenNV = txttenlot.Text;
            }
            catch { }
            string _chucVuNV = "";
            try
            {
                _chucVuNV = txtten.Text;
            }
            catch { }
            DateTime _ngaysinhNhanVien = dtngaysinh.Value;
            try
            {
            
            }
            catch { }
            string _gioitinhNhanVien = "";
            try
            {
                _gioitinhNhanVien = cbgt.Text;
            }
            catch { }
            string _emailNhanVien = "";
            try
            {
                _emailNhanVien = txtgmail.Text;
            }
            catch { }
            string _dienthoaiNhanVien = "";
            try
            {
                _dienthoaiNhanVien = txtdienthoai.Text;
            }
            catch { }
            string _diachiNhanVien = "";
            try
            {
                _diachiNhanVien = txtdiachi.Text;
            }
            catch { }
            if(flag==0)
            {
                //themmoi
                if (_idNhanVien == "" || _chucVuNV == "" || _hotenNV == "")
                    MessageBox.Show("Hãy nhập đầy đủ thông tin");
                else
                {
                    int i = 0;
                    i = DAL.NhanvienCtrl.InSertNhanVien(_idNhanVien, _hotenNV, _chucVuNV, _ngaysinhNhanVien, _gioitinhNhanVien, _dienthoaiNhanVien, _emailNhanVien, _diachiNhanVien);
                    if (i>0)
                    {
                        MessageBox.Show("Thêm mới thành công!");
                        HienThiDanhSachNhanVien();
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
                i = DAL.NhanvienCtrl.UpdateNhanVien(_idNhanVien, _hotenNV, _chucVuNV, _ngaysinhNhanVien, _gioitinhNhanVien, _dienthoaiNhanVien, _emailNhanVien, _diachiNhanVien);
                if (i > 0)
                {
                    MessageBox.Show("Sửa thành công!");
                    HienThiDanhSachNhanVien();
                }
                else
                    MessageBox.Show("Sửa thất bại!");

            }
            uctNhanvien_Load_1(sender, e);
        }

        private void btxoa_Click(object sender, EventArgs e)
        {
            string _idNhanVien = "";
            try
            {
                _idNhanVien = txtmanv.Text;
            }
            catch { }
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                int i = 0;
                i = DAL.NhanvienCtrl.DeleteNhanVien(_idNhanVien);
                if (i > 0)
                {
                    MessageBox.Show("Xóa thành công!");
                    HienThiDanhSachNhanVien();
                    uctNhanvien_Load_1(sender, e);
                }
                else
                    MessageBox.Show("Xóa thất bại!");
            }
            else
                return;
        }

        private void bttimkiem_Click(object sender, EventArgs e)
        {
            uctSearchNhanVien ucts = new uctSearchNhanVien();
            nhung(ucts);
        }

        private void btan_Click(object sender, EventArgs e)
        {
            pnlDSNhanVien.Controls.Clear();
            pnlDSNhanVien.BorderStyle = BorderStyle.None;
        }

        private void cbgt_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
