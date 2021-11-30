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
    public partial class uctKhuVuc : UserControl
    {
        public uctKhuVuc()
        {
            InitializeComponent();
        }
        
        int flag = 0;
        public static uctKhuVuc uctKV = new uctKhuVuc();
        public void HienThiDanhSachKhuVuc()
        {
            dgvKhuVuc.DataSource = BLL.KhuVucMod.FillDataSetKhuVuc().Tables[0];
            dgvKhuVuc.BorderStyle = BorderStyle.Fixed3D;
            dgvKhuVuc.RowHeadersVisible = false;

        }
      

       
        //Ham de tro den du lieu tren datagridview
        void bingding()
        {
            txtIdKhuVuc.DataBindings.Clear();
            txtIdKhuVuc.DataBindings.Add("Text", dgvKhuVuc.DataSource, "IdKhuVuc");
            txtTenKhuVuc.DataBindings.Clear();
            txtTenKhuVuc.DataBindings.Add("Text", dgvKhuVuc.DataSource, "TenKhuVuc");
            txtDienGiai.DataBindings.Clear();
            txtDienGiai.DataBindings.Add("Text", dgvKhuVuc.DataSource, "DienGiai");
            cbTrangThai.DataBindings.Clear();
            cbTrangThai.DataBindings.Add("Text", dgvKhuVuc.DataSource, "TrangThai");

        }
        //ham dis-end cac buton khi load len
        void dis_end(bool e)
        {
            txtIdKhuVuc.Enabled = e;
            txtTenKhuVuc.Enabled = e;
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
            cbTrangThai.Items.Add("Hoạt động");
            cbTrangThai.Items.Add("Ngừng hoạt động");

        }
        //ham xoa du lieu o textbox
        void cleardData()
        {
            txtIdKhuVuc.Text = BLL.connection.ExcuteScalar(string.Format("select IdKhuVuc = dbo.fcgetIdKhuVuc"));
            txtTenKhuVuc.Text = "";
            txtDienGiai.Text = "";
            cbTrangThai.Text = "";
            loadcontrol();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void uctKhuVuc_Load(object sender, EventArgs e)
        {
            HienThiDanhSachKhuVuc();
            dis_end(false);
            bingding();
        }

        private void label6_Click(object sender, EventArgs e)
        {

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
            uctKhuVuc_Load(sender, e);
            dis_end(false);
        }

        private void btluu_Click(object sender, EventArgs e)
        {
            string _idKhuVuc = "";
            try
            {
                _idKhuVuc = txtIdKhuVuc.Text;
            }
            catch { }
            string _tenKhuVuc = "";
            try
            {
                _tenKhuVuc = txtTenKhuVuc.Text;
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
                if (_tenKhuVuc == "")
                    MessageBox.Show("Hãy nhập Tên khu vực");
                else
                {
                    int i = 0;
                    i = DAL.KhuVucCtrl.InsertKhuVuc(_idKhuVuc, _tenKhuVuc, _dienGiai, _trangThai);
                    if (i > 0)
                    {
                        MessageBox.Show("Thêm mới thành công!");
                        HienThiDanhSachKhuVuc();
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
                i = DAL.KhuVucCtrl.UpdateKhuVuc(_idKhuVuc, _tenKhuVuc, _dienGiai, _trangThai);
                if (i > 0)
                {
                    MessageBox.Show("Sửa thành công!");
                    HienThiDanhSachKhuVuc();
                }
                else
                    MessageBox.Show("Sửa thất bại!");

            }
            uctKhuVuc_Load(sender, e);
        }

        private void btxoa_Click(object sender, EventArgs e)
        {
            string _idKhuVuc = "";
            try
            {
                _idKhuVuc = txtIdKhuVuc.Text;
            }
            catch { }
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                int i = 0;
                i = DAL.KhuVucCtrl.DeleteKhuVuc(_idKhuVuc);
                if (i > 0)
                {
                    MessageBox.Show("Xóa thành công!");
                    HienThiDanhSachKhuVuc();
                    uctKhuVuc_Load(sender, e);
                }
                else
                    MessageBox.Show("Xóa thất bại!");
            }
            else
                return;
        }

        private void grqlnhanvien_Enter(object sender, EventArgs e)
        {

        }
    }
}
