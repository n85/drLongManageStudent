using System;
using System.Windows.Forms;
using QLDiemSV.Entities;
using QLDiemSV.BUS;

namespace QLDiemSV.GUI
{
    public partial class frmCapNhatTaiKhoan : Form
    {
        CapNhatTKBUS ndbus = new CapNhatTKBUS(Program.strcon);
        public frmCapNhatTaiKhoan()
        {
            InitializeComponent();
        }

        private void frmCapNhatTaiKhoan_Load(object sender, EventArgs e)
        {
            txtUser.Enabled = false;
            txtFullName.Enabled = false;
            txtPhoneNumber.Enabled = false;
            txtRole.Enabled = false;
            txtEmail.Enabled = false;
            txtSex.Enabled = false;
            btnChange.Enabled = true;
            btnSave.Enabled = false;

            txtUser.Text = Program.user.UserID;
            txtFullName.Text = Program.user.FullName;
            txtSex.Text = Program.user.Sex;
            txtPhoneNumber.Text = Program.user.PhoneNumber;
            txtEmail.Text = Program.user.Email;
            txtRole.Text = Program.user.Role;
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            txtUser.Enabled = false;
            txtFullName.Enabled = true;
            txtPhoneNumber.Enabled = true;
            txtRole.Enabled = false;
            txtEmail.Enabled = true;
            txtSex.Enabled = true;
            btnChange.Enabled = false;
            btnSave.Enabled = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Program.user.FullName = txtFullName.Text;
            Program.user.Sex = txtSex.Text;
            Program.user.PhoneNumber = txtPhoneNumber.Text;
            Program.user.Email = txtEmail.Text;
            ndbus.SuaUser(Program.user);
            MessageBox.Show("Đã cập nhật !", "Thông báo", MessageBoxButtons.OK);
        }
    }
}
