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
    public partial class TrangChu : Form
    {
        private readonly User _Logined;
        private readonly UserService _UserService;
        private Button selectedButton;
        private UserService userService;
        private HoaDonService _hoaDonService;

        public TrangChu(User loggedInUser, UserService userService, HoaDonService hoaDonService)
        {
            InitializeComponent();
            _Logined = loggedInUser;
            _UserService = userService;
            _hoaDonService = hoaDonService;
        }
        private Form curentChillForm;

        private void OpentChillForm(Form ChillForm)
        {
            if (curentChillForm != null)
            {
                curentChillForm.Close();
            }
            curentChillForm = ChillForm;
            ChillForm.TopLevel = false;
            ChillForm.FormBorderStyle = FormBorderStyle.None;

            ChillForm.Dock = DockStyle.Fill;
            panel_Body.Controls.Add(curentChillForm);
            panel_Body.Tag = ChillForm;
            ChillForm.BringToFront();
            ChillForm.Show();
        }


        private void SetButtonColor(Button button)
        {
            // Reset the color of the previously selected button
            if (selectedButton != null)
            {
                selectedButton.BackColor = SystemColors.ControlLight;
            }

            // Set the color of the currently selected button
            button.BackColor = Color.YellowGreen;

            // Update the selectedButton reference
            selectedButton = button;
        }
        private void btn_HoiVien_Click(object sender, EventArgs e)
        {
            OpentChillForm(new HoiVien());
            txtChucNang.Text = btn_HoiVien.Text;
            SetButtonColor(btn_HoiVien);
        }

        private void btn_PT_Click(object sender, EventArgs e)
        {
            OpentChillForm(new PT());
            txtChucNang.Text = btn_PT.Text;

            SetButtonColor(btn_PT);
        }

        private void btnDatLich_Click(object sender, EventArgs e)
        {
            OpentChillForm(new DatLich());
            txtChucNang.Text = btnDatLich.Text;
            SetButtonColor(btnDatLich);
        }

        private void btnThietBi_Click(object sender, EventArgs e)
        {
            OpentChillForm(new ThietBi());
            txtChucNang.Text = btnThietBi.Text;
            SetButtonColor(btnThietBi);
        }

        private void btnGiaoDich_Click(object sender, EventArgs e)
        {
            OpentChillForm(new GiaoDich());
            txtChucNang.Text = btnGiaoDich.Text;
            SetButtonColor(btnGiaoDich);
        }

        private void btnKhuyenMai_Click(object sender, EventArgs e)
        {
            if (_UserService.Rules(_Logined, "NhanVien"))
            {
                MessageBox.Show("Bạn không có quyền truy cập vào mục này");
            }
            else
            {
                OpentChillForm(new KhuyenMai());
                txtChucNang.Text = btnKhuyenMai.Text;
                SetButtonColor(btnKhuyenMai);
            }
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            if (_UserService.Rules(_Logined, "NhanVien"))
            {
                MessageBox.Show("Bạn không có quyền truy cập vào mục này");
            }
            else
            {
                OpentChillForm(new NhanVien());
                txtChucNang.Text = btn_HoiVien.Text;
                SetButtonColor(btnNhanVien);
            }
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            DangNhap dangNhap = new DangNhap(userService);
            this.Hide();
            dangNhap.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (curentChillForm != null)
            {
                curentChillForm.Close();
            }
            txtChucNang.Text = "Trang chu";
        }
    }
}
