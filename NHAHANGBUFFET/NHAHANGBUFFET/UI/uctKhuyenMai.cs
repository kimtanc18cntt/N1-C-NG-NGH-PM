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
    public partial class uctKhuyenMai : UserControl
    {
        public uctKhuyenMai()
        {
            InitializeComponent();
        }
        int flag = 0;
        public static uctKhuyenMai uctKM = new uctKhuyenMai();
        public void HienThiDanhSachKhuyenMai()
        {
            dskhuyenmai.DataSource = BLL.KhuyenMaiMod.FillDataSetKhuyenMai().Tables[0];
            dskhuyenmai.BorderStyle = BorderStyle.Fixed3D;
            dskhuyenmai.RowHeadersVisible = false;

        }



        //Ham de tro den du lieu tren datagridview
        void bingding()
        {
            txtIdKM.DataBindings.Clear();
            txtIdKM.DataBindings.Add("Text", dskhuyenmai.DataSource, "IdKM");
            txtNoiDung.DataBindings.Clear();
            txtNoiDung.DataBindings.Add("Text", dskhuyenmai.DataSource, "NoiDung");
            txtDienGiai.DataBindings.Clear();
            txtDienGiai.DataBindings.Add("Text", dskhuyenmai.DataSource, "DienGiai");
            cbDoiTuong.DataBindings.Clear();
            cbDoiTuong.DataBindings.Add("Text", dskhuyenmai.DataSource, "DoiTuong");

        }
        //ham dis-end cac buton khi load len
        void dis_end(bool e)
        {
            txtIdKM.Enabled = e;
            txtNoiDung.Enabled = e;
            txtDienGiai.Enabled = e;
            cbDoiTuong.Enabled = e;
            btluu.Enabled = e;
            bthuy.Enabled = e;
            btthem.Enabled = !e;
            btsua.Enabled = !e;
            btxoa.Enabled = !e;
        }
        //ham load gioi tinh cho nhan vien
        void loadcontrol()
        {
            cbDoiTuong.Items.Clear();
            cbDoiTuong.Items.Add("Full Khách");
            cbDoiTuong.Items.Add("Khách Vip");
        }
        //ham xoa du lieu o textbox
        void cleardData()
        {
            txtIdKM.Text = "";
            txtNoiDung.Text = "";
            txtDienGiai.Text = "";
            cbDoiTuong.Text = "";
            loadcontrol();

        }
        private void uctKhuyenMai_Load(object sender, EventArgs e)
        {
            HienThiDanhSachKhuyenMai();
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
            uctKhuyenMai_Load(sender, e);
            dis_end(false);
        }

        private void btluu_Click(object sender, EventArgs e)
        {
            string _idKM = "";
            try
            {
                _idKM = txtIdKM.Text;
            }
            catch { }
            string _noiDung = "";
            try
            {
                _noiDung = txtNoiDung.Text;
            }
            catch { }
            string _dienGiai = "";
            try
            {
                _dienGiai = txtDienGiai.Text;
            }
            catch { }

            string _doiTuong = "";
            try
            {
                _doiTuong = cbDoiTuong.Text;
            }
            catch { }
            if (flag == 0)
            {
                //themmoi
                if (_noiDung == "")
                    MessageBox.Show("Hãy nhập Nội dung");
                else
                {
                    int i = 0;
                    i = DAL.KhuyenMaiCtrl.InsertKhuyenMai(_idKM, _noiDung, _dienGiai, _doiTuong);
                    if (i > 0)
                    {
                        MessageBox.Show("Thêm mới thành công!");
                        HienThiDanhSachKhuyenMai();
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
                i = DAL.KhuyenMaiCtrl.UpdateKhuyenMai(_idKM, _noiDung, _dienGiai, _doiTuong);
                if (i > 0)
                {
                    MessageBox.Show("Sửa thành công!");
                    HienThiDanhSachKhuyenMai();
                }
                else
                    MessageBox.Show("Sửa thất bại!");

            }
            uctKhuyenMai_Load(sender, e);
        }

        private void btxoa_Click(object sender, EventArgs e)
        {
            string _idKM = "";
            try
            {
                _idKM = txtIdKM.Text;
            }
            catch { }
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                int i = 0;
                i = DAL.KhuyenMaiCtrl.DeleteKhuyenMai(_idKM);
                if (i > 0)
                {
                    MessageBox.Show("Xóa thành công!");
                    HienThiDanhSachKhuyenMai();
                    uctKhuyenMai_Load(sender, e);
                }
                else
                    MessageBox.Show("Xóa thất bại!");
            }
            else
                return;
        }
    }
}
