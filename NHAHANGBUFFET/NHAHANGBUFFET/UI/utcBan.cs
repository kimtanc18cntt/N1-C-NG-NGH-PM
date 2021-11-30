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
    public partial class utcBan : UserControl
    {
        public utcBan()
        {
            InitializeComponent();
        }
        int flag = 0;
        public static utcBan uctBAN = new utcBan();
        public void HienThiDanhSachBan()
        {
            dsban.DataSource = BLL.BanMod.FillDataSetBan().Tables[0];
            dsban.BorderStyle = BorderStyle.Fixed3D;
            dsban.RowHeadersVisible = false;
            lbInfor.BackColor = Color.Transparent;
            lbDS.BackColor = Color.Transparent;
        }



        //Ham de tro den du lieu tren datagridview
        void bingding()
        {
            txtIdBan.DataBindings.Clear();
            txtIdBan.DataBindings.Add("Text", dsban.DataSource, "IdBan");
            cbTenKhuVuc.DataBindings.Clear();
            cbTenKhuVuc.DataBindings.Add("Text", dsban.DataSource, "TenKhuVuc");
            txtTenBan.DataBindings.Clear();
            txtTenBan.DataBindings.Add("Text", dsban.DataSource, "TenBan");
            txtDienGiai.DataBindings.Clear();
            txtDienGiai.DataBindings.Add("Text", dsban.DataSource, "DienGiai");
            cbTrangThai.DataBindings.Clear();
            cbTrangThai.DataBindings.Add("Text", dsban.DataSource, "TrangThai");

        }
        //ham dis-end cac buton khi load len
        void dis_end(bool e)
        {
            txtIdBan.Enabled = e;
            cbTenKhuVuc.Enabled = e;
            txtTenBan.Enabled = e;
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
            //lấy cb tên khu vựu thông qua khu vực mod
            cbTenKhuVuc.DataSource = BLL.KhuVucMod.getTenKhuVuc().Tables[0];
            cbTenKhuVuc.DisplayMember = "TenKhuVuc";
        }
        //ham xoa du lieu o textbox
        void cleardData()
        {
            txtIdBan.Text = "";
            cbTenKhuVuc.Text = "";
            txtTenBan.Text = "";          
            txtDienGiai.Text = "";
            cbTrangThai.Text = "";
            loadcontrol();

        }
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void utcBan_Load(object sender, EventArgs e)
        {
            HienThiDanhSachBan();
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
            utcBan_Load(sender, e);
            dis_end(false);
        }

        private void btluu_Click(object sender, EventArgs e)
        {
            string _idBan = "";
            try
            {
                _idBan = txtIdBan.Text;
            }
            catch { }
            string _tenKhuVuc = "";
            try
            {
                _tenKhuVuc = cbTenKhuVuc.Text;
            }
            catch { }
            string _tenBan = "";
            try
            {
                _tenBan = txtTenBan.Text;
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
                if (_tenBan == "")
                    MessageBox.Show("Hãy nhập Tên Bàn");
                else
                {
                    int i = 0;
                    i = DAL.BanCtrl.InsertBan(_idBan, _tenKhuVuc,_tenBan, _dienGiai, _trangThai);
                    if (i > 0)
                    {
                        MessageBox.Show("Thêm mới thành công!");
                        HienThiDanhSachBan();
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
                i = DAL.BanCtrl.UpdateBan(_idBan, _tenKhuVuc,_tenBan, _dienGiai, _trangThai);
                if (i > 0)
                {
                    MessageBox.Show("Sửa thành công!");
                    HienThiDanhSachBan();
                }
                else
                    MessageBox.Show("Sửa thất bại!");

            }
            utcBan_Load(sender, e);
        }

        private void btxoa_Click(object sender, EventArgs e)
        {
            string _idBan = "";
            try
            {
                _idBan = txtIdBan.Text;
            }
            catch { }
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                int i = 0;
                i = DAL.BanCtrl.DeleteBan(_idBan);
                if (i > 0)
                {
                    MessageBox.Show("Xóa thành công!");
                    HienThiDanhSachBan();
                    utcBan_Load(sender, e);
                }
                else
                    MessageBox.Show("Xóa thất bại!");
            }
            else
                return;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
