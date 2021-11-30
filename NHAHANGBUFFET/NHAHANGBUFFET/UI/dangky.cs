using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NHAHANGBUFFET
{
    public partial class dangky : Form
    {
        public dangky()
        {
            InitializeComponent();
        }
        int flag = 0;
        public static dangky dky = new dangky();

        private void dk_Click(object sender, EventArgs e)
        {
            string _user = tdn.Text;
            string _pass = mk.Text;
            string _passnl = nhaplai.Text;
            if (_user == "")
            {

                MessageBox.Show(" hãy nhập tên đăng nhập !");
            }

            else

                    if (_pass == "")
            {
                MessageBox.Show(" hãy nhập mật khẩu !");

            }
            
            else if (_pass == _passnl)
            {
                int i = 0;
                i = DAL.DangkyCtrl.Insertdangnhap(_user, _pass);
                if (i > 0)
                {
                    MessageBox.Show(" Đăng ký thành công!, Hãy đăng nhập và sử dụng");
                    Login fm = new Login();
                    fm.Show();
                    this.Hide();
                }
                
            }
            else
            {
                MessageBox.Show(" Sai thông tin nào đó, Kiểm tra lại!");
            }
            

        }

        private void huy_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn sẽ quay lại đăng nhập", "Xác nhận ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                Login fm = new Login();
                fm.Show();
                this.Hide();
            }
            else
                return;
        }

        private void dangky_Load(object sender, EventArgs e)
        {

        }
    }
}
    
    
    
