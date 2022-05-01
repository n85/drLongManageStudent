using QLDiemSV.BUS;
using QLDiemSV.Entities;
using System;
using System.Collections.Generic;
using System.Windows.Forms;



namespace QLDiemSV.GUI
{
    public partial class frmQLNguoiDung : Form
    {
        List<Users> lus;
        readonly QLNguoiDungBUS bus = new QLNguoiDungBUS(Program.strcon);

        public frmQLNguoiDung()
        {
            InitializeComponent();
        }

        private void frmQLNguoiDung_Load(object sender, EventArgs e)
        {
            lus = bus.LayUser();
            dgvTTUser.DataSource = lus;
            btnHuy.Enabled = false;
            btnLuu.Enabled = false;
        }
        int flag;
        private void btnMoi_Click(object sender, EventArgs e)
        {
            flag = 0;
            //txtUserID.Clear();
            //txtFullName .Clear();
            //txtPassword .Clear();
            //txtPhoneNumber .Clear();
            //txtEmail.Clear();
            //cboRole.ResetText();
            //cboSex.ResetText();
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnHuy.Enabled = true;
            btnLuu.Enabled=true;
            txtUserID.Focus();

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtUserID.Text == "")
            {
                MessageBox.Show("UserID không được bỏ trống !", "Thông báo", MessageBoxButtons.OK);
                txtUserID.Focus();
            }
            else if (txtPassword.Text == "")
            {
                MessageBox.Show("Password không được bỏ trống !", "Thông báo", MessageBoxButtons.OK);
                txtPassword.Focus();
            }
            else
            {
                if (flag == 0)
                {
                    Users u = lus.Find(user => user.UserID == txtUserID.Text);
                    if (u != null)
                    {
                        MessageBox.Show("UserID đã tồn tại !", "Thông báo", MessageBoxButtons.OK);
                        txtUserID.Focus();
                    }
                    else
                    {
                        Users nuser = new Users
                        {
                            UserID = txtUserID.Text,
                            Password = txtPassword.Text,
                            FullName = txtFullName.Text,
                            Sex = cboSex.Text,
                            PhoneNumber = txtPhoneNumber.Text,
                            Email = txtEmail.Text
                        };
                        if (cboRole.SelectedItem.ToString() != "Admin")
                        {
                            nuser.Role = "Member";
                        }
                        else nuser.Role = cboRole.SelectedItem.ToString();


                        bus.ThemUser(nuser);
                        lus.Add(nuser);
                        MessageBox.Show("Đã thêm tài khoản " + nuser.UserID);
                        dgvTTUser.DataSource = null;
                        dgvTTUser.DataSource = lus;
                        dgvTTUser.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                        // Thiết lập dòng được chọn là dòng cuối cùng vừa thêm
                        dgvTTUser.CurrentCell = dgvTTUser.Rows[dgvTTUser.Rows.Count - 1].Cells[0];
                    } 
                }
                else if (flag == 1)
                {
                    Users editUser = new Users
                    {
                        UserID = txtUserID.Text,
                        Password = txtPassword.Text,
                        FullName = txtFullName.Text,
                        Sex = cboSex.Text,
                        PhoneNumber = txtPhoneNumber.Text,
                        Email = txtEmail.Text
                    };
                    if (cboRole.SelectedItem.ToString() != "Admin")
                    {
                        editUser.Role = "Member";
                    }
                    else editUser.Role = cboRole.SelectedItem.ToString();


                    bus.SuaUser(editUser);
                    Users user = lus.Find(us => us.UserID == editUser.UserID);
                    user.FullName = txtFullName.Text;
                    user.Sex = cboSex.SelectedItem.ToString();
                    user.PhoneNumber = txtPhoneNumber.Text;
                    user.Role = cboRole.SelectedItem.ToString();
                    user.Email = txtEmail.Text;
                    user.Password = txtPassword.Text;
                    MessageBox.Show("Đã sửa tài khoản " + editUser.UserID);
                    dgvTTUser.DataSource = null;
                    dgvTTUser.DataSource = lus;
                    dgvTTUser.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    // Thiết lập dòng được chọn là dòng cuối cùng vừa thêm
                    dgvTTUser.CurrentCell = dgvTTUser.Rows[lus.FindIndex(us => us.UserID == editUser.UserID)].Cells[0];
                }
                else if (flag == 2)
                {
                    
                }    
            }
            txtUserID.Clear();
            txtFullName.Clear();
            txtPassword.Clear();
            txtPhoneNumber.Clear();
            txtEmail.Clear();
            cboRole.ResetText();
            cboSex.ResetText();
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnHuy.Enabled = true;
        }

        private void dgvTTUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtUserID.Text = dgvTTUser.CurrentRow.Cells["UserID"].Value.ToString();
            txtPassword.Text = dgvTTUser.CurrentRow.Cells["Password"].Value.ToString();
            txtFullName.Text = dgvTTUser.CurrentRow.Cells["FullName"].Value.ToString();
            txtPhoneNumber.Text = dgvTTUser.CurrentRow.Cells[4].Value.ToString();
            txtEmail.Text = dgvTTUser.CurrentRow.Cells[5].Value?.ToString();
            cboSex.ResetText();
            cboSex.Text = dgvTTUser.CurrentRow.Cells[3].Value.ToString();
            cboRole.ResetText();
            cboRole.Text = dgvTTUser.CurrentRow.Cells[6].Value.ToString();

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtUserID.Clear();
            txtFullName.Clear();
            txtPassword.Clear();
            txtPhoneNumber.Clear();
            txtEmail.Clear();
            cboRole.ResetText();
            cboSex.ResetText();
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnHuy.Enabled = false;
            btnLuu.Enabled = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            flag = 1;
            txtUserID.Enabled = false;
            btnSua.Enabled = false;
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
            btnXoa.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            btnSua.Enabled = true;
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
            btnXoa.Enabled = true;

            Users u = lus.Find(user => user.UserID == txtUserID.Text);
            if (u == null)
            {
                MessageBox.Show("UserID không tồn tại !", "Thông báo", MessageBoxButtons.OK);
                txtUserID.Focus();
            }
            else
            {
                if (MessageBox.Show("Bạn có muốn xóa tài khoản " + txtUserID.Text.ToString() + " không Y/N", "Xác nhận",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int currentRow = lus.FindIndex(us => us.UserID == txtUserID.Text);
                    if (currentRow == 0) currentRow = 1;
                    bus.XoaUser(txtUserID.Text);
                    Users delUser = lus.Find(us => us.UserID == txtUserID.Text);
                    lus.Remove(delUser);
                    MessageBox.Show("Đã xóa tài khoản " + txtUserID.Text);
                    dgvTTUser.DataSource = null;
                    dgvTTUser.DataSource = lus;
                    dgvTTUser.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    // Thiết lập dòng được chọn là dòng cuối cùng vừa thêm
                    dgvTTUser.CurrentCell = dgvTTUser.Rows[currentRow - 1].Cells[0];
                }
            }
        }

        private void frmQLNguoiDung_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn đóng không Y/N", "Xác nhận",
                                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

    }
}
