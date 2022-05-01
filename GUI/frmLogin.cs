using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLDiemSV.BUS;



namespace QLDiemSV.GUI
{
    public partial class frmLogin : Form
    {
        LoginBUS bus = new LoginBUS(Program.strcon);
        
        public frmLogin()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
                txtPass.PasswordChar = (char)0;
            else
                txtPass.PasswordChar = '*';
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            Program.user = bus.GetUsers(txtUser.Text, txtPass.Text);
            if (Program.user != null)
            {
                frmMain f = new frmMain();
                f.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu sai!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtUser.Focus();
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            txtUser.Focus();
        }
    }
}
