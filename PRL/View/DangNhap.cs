using BUS;
using DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRL.View
{
    public partial class DangNhap : Form
    {
        private readonly UserService _userService;
        private readonly HoaDonService _hoaDon;

        public DangNhap(UserService userService)
        {
            InitializeComponent();
            _userService = userService;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (_userService == null)
            {
                // Thông báo hoặc xử lý khi _userService chưa được thiết lập
                MessageBox.Show("UserService chưa được thiết lập");
                return;
            }
            string username = txtID.Text;
            string phone = "";
            string password = txtPassword.Text;

            User user = _userService.UserLogin(username, phone, password);
            if (user != null)
            {
                TrangChu trangChuForm = new TrangChu(user, _userService, _hoaDon);
                trangChuForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Đăng nhập không thành công");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void link_QuenMMK_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
