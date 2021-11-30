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
    public partial class uctThuChi : UserControl
    {
        public uctThuChi()
        {
            InitializeComponent();
        }
        int flag = 0;
        public static uctThuChi uctTC = new uctThuChi();
        public void HienThiDanhSachThuChi()
        {
            dsthuchi.DataSource = BLL.ThuChiMod.FillDataSetThuChi().Tables[0];
            dsthuchi.Dock = DockStyle.Fill;
            dsthuchi.BorderStyle = BorderStyle.Fixed3D;
            dsthuchi.Dock = DockStyle.Fill;
            dsthuchi.RowHeadersVisible = false;

        }
        void bingding()
        {
            txtidtc.DataBindings.Clear();
            txtidtc.DataBindings.Add("Text", dsthuchi.DataSource, "IdThuChi");
            txtten.DataBindings.Clear();
            txtten.DataBindings.Add("Text", dsthuchi.DataSource, "TenThuChi");
            dtngay.DataBindings.Clear();
            dtngay.DataBindings.Add("Text", dsthuchi.DataSource, "Ngay");
            txtthu.DataBindings.Clear();
            txtthu.DataBindings.Add("Text", dsthuchi.DataSource, "Thu");
            txtchi.DataBindings.Clear();
            txtchi.DataBindings.Add("Text", dsthuchi.DataSource, "Chi");
        }  
           
        //ham dis-end cac buton khi load len
        void dis_end(bool e)
        {
            txtidtc.Enabled = e;
            txtten.Enabled = e;
            dtngay.Enabled = e;
            txtthu.Enabled = e;
            txtchi.Enabled = e;
            btluu.Enabled = e;
            bthuy.Enabled = e;
            btthem.Enabled = !e;
            btsua.Enabled = !e;
            btxoa.Enabled = !e;
        }

        //ham xoa du lieu o textbox
        void cleardData()
        {
            txtidtc.Text = "";
            txtten.Text = "";
            txtthu.Text = "";
            txtchi.Text = "";
              

        }

        private void uctThuChi_Load(object sender, EventArgs e)
        {
            HienThiDanhSachThuChi();
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
        }

        private void bthuy_Click(object sender, EventArgs e)
        {
            uctThuChi_Load(sender, e);
            dis_end(false);
        }

        private void btluu_Click(object sender, EventArgs e)
        {
            string _idThuChi = "";
            try
            {
                _idThuChi = txtidtc.Text;
            }
            catch { }
            string _tenThuChi = "";
            try
            {
                _tenThuChi = txtten.Text;
            }
            catch { }

            DateTime _ngay = dtngay.Value;
            try
            {

            }
            catch { }
            float _thu = 0;
            try
            {
                _thu = Convert.ToInt32(txtthu.Text);
            }
            catch { }
            float _chi = 0;
            try
            {
                _chi = Convert.ToInt32(txtchi.Text);
            }
            catch { }
            
            if (flag == 0)
            {
                //themmoi
                if (_idThuChi == "" || _tenThuChi == "" )
                    MessageBox.Show("Hãy nhập đầy đủ thông tin");
                else
                {
                    int i = 0;
                    i = DAL.ThuChiCtrl.InsertThuChi(_idThuChi, _tenThuChi, _ngay, _thu, _chi);
                    if (i > 0)
                    {
                        MessageBox.Show("Thêm mới thành công!");
                        HienThiDanhSachThuChi();
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
                i = DAL.ThuChiCtrl.UpdateThuChi(_idThuChi, _tenThuChi, _ngay, _thu, _chi);
                if (i > 0)
                {
                    MessageBox.Show("Sửa thành công!");
                    HienThiDanhSachThuChi();
                }
                else
                    MessageBox.Show("Sửa thất bại!");

            }
            uctThuChi_Load(sender, e);
        }

        private void btxoa_Click(object sender, EventArgs e)
        {
            string _idThuChi = "";
            try
            {
                _idThuChi = txtidtc.Text;
            }
            catch { }
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                int i = 0;
                i = DAL.NhanvienCtrl.DeleteNhanVien(_idThuChi);
                if (i > 0)
                {
                    MessageBox.Show("Xóa thành công!");
                    HienThiDanhSachThuChi();
                    uctThuChi_Load(sender, e);
                }
                else
                    MessageBox.Show("Xóa thất bại!");
            }
            else
                return;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
