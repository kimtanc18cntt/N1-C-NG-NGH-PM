using System;
using System.Collections.Generic;
using System.Windows.Forms;
using NHAHANGBUFFET.UI;
namespace NHAHANGBUFFET
{
    public partial class frmMain : Form
    {
        public static string user;
        public static string idLogin;
        public frmMain()
        {
            InitializeComponent();
            
        }
        internal static List<byte> typePages = new List<byte>();


        public void ThemTabPages(UserControl uct, byte typeControl, string tenTab)
        {
            //kiểm tra tồn tại trang này chưa
            for (int i = 0; i < tabhienthi.TabPages.Count; i++)
            {
                if (tabhienthi.TabPages[i].Contains(uct) == true)
                {
                    tabhienthi.SelectedTab = tabhienthi.TabPages[i];
                    return;
                }
            }
            TabPage tab = new TabPage();
            typePages.Add(typeControl);
            tab.Name = uct.Name;
            tab.Size = tabhienthi.Size;
            tab.Text = tenTab;
            tabhienthi.TabPages.Add(tab);
            tabhienthi.SelectedTab = tab;
            uct.Dock = DockStyle.Fill;
            tab.Controls.Add(uct);
            uct.Focus();
        }
        //đóng tab hiển thị
        public void Dongtabhienthi()
        {
            tabhienthi.TabPages.Remove(tabhienthi.SelectedTab);

        }
        //Đóng all tab
        public void DongAllTab()
        {
            while (tabhienthi.TabPages.Count > 0)
            {
                Dongtabhienthi();
            }
        }
        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void quảnLýNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThemTabPages(UI.uctNhanvien.uctNV, 4, "Quản lý nhân viên");
        }

        private void đóngTabToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dongtabhienthi();
        }

        private void đóngTấtCảCácToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DongAllTab();
        }

        private void hệThốngKhuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThemTabPages(UI.uctKhuVuc.uctKV, 4, "Hệ Thống Khu Vực");
        }

        private void loạiThựcĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThemTabPages(UI.uctLoaiThucDon.uctLTD, 4, "Loại Thực đơn");
        }

        private void quảnLýKhuyếnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThemTabPages(UI.uctKhuyenMai.uctKM, 4, "Khuyến Mãi");
        }

        private void bànKhuVựcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThemTabPages(UI.utcBan.uctBAN, 4, "Bàn Khu vực");
        }

        private void quảnLýToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void thựcĐơnToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ThemTabPages(UI.uctThucDon.uctTDON, 4, "Thực Đơn");
        }

        private void gọiMónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThemTabPages(UI.uctGoiMon.uctGM, 4, "Gọi Món");
        }



        private void thuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThemTabPages(UI.uctThuChi.uctTC, 4, "QL Thu Chi");
        }

        private void đăngXuấtCaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThemTabPages(UI.uctGioiThieu.uctGT, 4, "giới thiệu nhà hàng");
        }

        private void quảnLýKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThemTabPages(UI.uctKhachHang.uctKH, 4, "Khách Hàng");
        }

        private void hệThốngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThemTabPages(UI.uctGioiThieu.uctGT, 4, "giới thiệu nhà hàng");
        }

        

       
        private void dx_Click(object sender, EventArgs e)
        {
           /* Login lg = new Login();
            lg.Show();
            this.Hide();*/
            DialogResult dr = MessageBox.Show("Bạn có muốn thoát", "Xác nhận ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                Login lg = new Login();
                lg.Show();
                this.Hide();
            }
            else
                return;
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát chương trình ?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;

            }
            else {
                Application.Exit();
            }
                
        }
    }
}

      
    

