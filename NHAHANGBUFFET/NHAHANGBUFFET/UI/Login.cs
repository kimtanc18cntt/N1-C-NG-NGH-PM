using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace NHAHANGBUFFET
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

    

        private void dangnhap_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=HT-TROPI\SQLEXPRESS;Initial Catalog=Quanlynhahang;Integrated Security=True");
            try
            {
                conn.Open();
                string user = tdn.Text;
                string pass = mk.Text;
                string sql = "select *from Taikhoan where IdDangNhap='" + user + "' and MatKhau='" + pass + "'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader dta = cmd.ExecuteReader();
                if (tdn.Text == "")
                {

                    MessageBox.Show(" hãy nhập tên đăng nhập !");
                }
            
                else
                
                    if (mk.Text == "")
                    {
                        MessageBox.Show(" hãy nhập mật khẩu !");

                    }
                else
                    if (dta.Read() == true)
                {
                    MessageBox.Show(" Đăng nhập thành công!");
                    frmMain fm = new frmMain();
                    fm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show(" Đăng nhập thất bại, kiểm tra lại thông tin đăng nhập!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối");
            }
            
        }

        private void trove_Click(object sender, EventArgs e)
        {
             Application.Exit();
        }
    

        private void dk_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            dangky dk = new dangky();
            dk.Show();
            this.Hide();
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát chương trình ?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }
    }
}
