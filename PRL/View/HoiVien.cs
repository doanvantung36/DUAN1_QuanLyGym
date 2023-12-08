using BUS;
using BUS.IService;
using BUS.Service;
using DAL.Context;
using DAL.DomainClass;
using DAL.Repositoies;
using Microsoft.EntityFrameworkCore;
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
    public partial class HoiVien : Form
    {
        HoiVienService _khachHangService;
        HopDongRepoSitory _HopDongRepoSitory;
        DichVuRepository _DichVuRepository;
        DBContext _dbContext;
        public HoiVien()
        {
            InitializeComponent();
            _khachHangService = new HoiVienService(new KhachHangRepository(new DBContext()));
            _HopDongRepoSitory = new HopDongRepoSitory(new DBContext());
            _DichVuRepository = new DichVuRepository(new DBContext());
            _dbContext = new DBContext();

            LoadDataHopDong();
        }
        private void LoadDataHopDong()
        {
            // Lấy danh sách dịch vụ từ repository hoặc service
            List<DichVu> dichVuList = _DichVuRepository.GetAll();

            // Xóa dữ liệu cũ
            dtGrit_HopDong.Rows.Clear();
            dtGrit_HopDong.Columns.Clear();

            // Đặt tên và thêm cột
            dtGrit_HopDong.Columns.Add("STT", "STT");
            dtGrit_HopDong.Columns.Add("MaHopDong", "Mã Hợp Đồng");
            dtGrit_HopDong.Columns.Add("MaKhachHang", "Mã Khách Hàng");
            dtGrit_HopDong.Columns.Add("NgayDangKi", "Ngày Đăng Kí");
            dtGrit_HopDong.Columns.Add("NgayKetThuc", "Ngày Kết Thúc");

            // Lấy danh sách hợp đồng từ repository hoặc service
            List<HopDong> hopDongList = _HopDongRepoSitory.GetAll();

            // Thêm dữ liệu vào DataGridView
            int stt = 1;
            foreach (var hopDong in hopDongList)
            {
                dtGrit_HopDong.Rows.Add(stt++, hopDong.MaHopDong, hopDong.MaKhachHang, hopDong.NgayDangKi, hopDong.NgayKetThuc);
            }
        }
        public void LoadData()
        {
            List<KhachHang> khachHangs = _khachHangService.GetAllKhachHangs();

            // Xóa tất cả các cột trước khi thêm mới
            dataGridView1.Columns.Clear();

            // Tạo cột STT
            dataGridView1.Columns.Add("STT", "STT");

            // Tạo và đặt tên cho các cột khác
            dataGridView1.Columns.Add("MaKhachHang", "Mã Khách Hàng");
            dataGridView1.Columns.Add("TenKhachHang", "Tên Khách Hàng");
            dataGridView1.Columns.Add("NgaySinh", "Ngày Sinh");
            dataGridView1.Columns.Add("GioiTinh", "Giới Tính");
            dataGridView1.Columns.Add("DiaChi", "Địa Chỉ");
            dataGridView1.Columns.Add("SoDienThoai", "Số Điện Thoại");
            dataGridView1.Columns.Add("Email", "Email");

            // Đặt tên cho cột STT
            dataGridView1.Columns[0].HeaderText = "STT";

            // Đổ dữ liệu vào DataGridView
            for (int i = 0; i < khachHangs.Count; i++)
            {
                dataGridView1.Rows.Add(i + 1, khachHangs[i].MaKhachHang, khachHangs[i].TenKhachHang,
                                               khachHangs[i].NgaySinh, khachHangs[i].GioiTinh, khachHangs[i].DiaChi,
                                               khachHangs[i].SoDienThoai, khachHangs[i].Email);
            }
        }
        private void btn_Add_Click(object sender, EventArgs e)
        {
            // Lấy thông tin từ các controls trên form chính
            string maKhachHang = tb_MaHoiVien.Text;
            string tenKhachHang = tb_TenHoiVien.Text;
            DateTime ngaySinh = date_NgaySinh.Value;
            string gioiTinh = cb_GioiTinh.SelectedItem.ToString();
            string soDienThoai = tb_SoDienThoai.Text;
            string email = tb_Email.Text;
            string diaChi = tb_DiaChi.Text;

            // Thực hiện thêm mới khách hàng trong CSDL
            _khachHangService.CreateKhachHang(new KhachHang
            {
                MaKhachHang = maKhachHang,
                TenKhachHang = tenKhachHang,
                NgaySinh = ngaySinh,
                GioiTinh = gioiTinh,
                SoDienThoai = soDienThoai,
                Email = email,
                DiaChi = diaChi
            });

            // Cập nhật lại dữ liệu trên DataGridView
            LoadData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Lấy ra mã khách hàng của dòng được chọn
                string maKhachHang = dataGridView1.SelectedRows[0].Cells["MaKhachHang"].Value.ToString();

                // Hiển thị thông báo xác nhận việc xóa
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa khách hàng này?", "Xác Nhận Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    // Thực hiện xóa khách hàng trong CSDL
                    _khachHangService.DeleteKhachHang(maKhachHang);

                    // Cập nhật lại dữ liệu trên DataGridView
                    LoadData();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một khách hàng để xóa.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Lấy mã khách hàng từ dòng được chọn
                string maKhachHang = dataGridView1.SelectedRows[0].Cells["MaKhachHang"].Value.ToString();

                // Lấy đối tượng KhachHang từ cơ sở dữ liệu
                var existingKhachHang = _dbContext.KhachHangs.FirstOrDefault(kh => kh.MaKhachHang == maKhachHang);

                if (existingKhachHang != null)
                {
                    // Cập nhật thông tin trên đối tượng đã tồn tại
                    existingKhachHang.TenKhachHang = tb_TenHoiVien.Text;
                    existingKhachHang.NgaySinh = date_NgaySinh.Value;
                    existingKhachHang.GioiTinh = cb_GioiTinh.SelectedItem?.ToString();
                    existingKhachHang.SoDienThoai = tb_SoDienThoai.Text;
                    existingKhachHang.Email = tb_Email.Text;
                    existingKhachHang.DiaChi = tb_DiaChi.Text;

                    // Lưu thay đổi vào cơ sở dữ liệu
                    _dbContext.SaveChanges();

                    // Load lại dữ liệu sau khi cập nhật


                    // Hiển thị thông báo cập nhật thành công
                    MessageBox.Show("Cập nhật thành công.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Không tìm thấy khách hàng để cập nhật.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một khách hàng để cập nhật.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            LoadData();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            // Lấy keyword từ TextBox tìm kiếm
            string keyword = txtTimKiem.Text;

            // Gọi phương thức tìm kiếm từ service hoặc repository
            List<KhachHang> ketQuaTimKiem = _khachHangService.SearchKhachHangs(keyword);

            // Hiển thị kết quả tìm kiếm lên DataGridVieư
            LoadData();
        }

        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            LoadData();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Lấy dữ liệu từ dòng được click
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                // Kiểm tra giá trị của các ô trước khi sử dụng
                string maKhachHang = row.Cells["MaKhachHang"].Value?.ToString();
                string tenKhachHang = row.Cells["TenKhachHang"].Value?.ToString();
                DateTime? ngaySinh = row.Cells["NgaySinh"].Value as DateTime?;
                string gioiTinh = row.Cells["GioiTinh"].Value?.ToString();
                string soDienThoai = row.Cells["SoDienThoai"].Value?.ToString();
                string email = row.Cells["Email"].Value?.ToString();
                string diaChi = row.Cells["DiaChi"].Value?.ToString();

                // Hiển thị thông tin trên các TextBox tương ứng
                tb_MaHoiVien.Text = maKhachHang;
                tb_TenHoiVien.Text = tenKhachHang;
                date_NgaySinh.Value = ngaySinh ?? DateTime.Now; // Gán giá trị mặc định nếu là null
                cb_GioiTinh.SelectedItem = gioiTinh;
                tb_SoDienThoai.Text = soDienThoai;
                tb_Email.Text = email;
                tb_DiaChi.Text = diaChi;
            }
        }
        private void btn_Add_HopDong_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra các trường thông tin đã được nhập đầy đủ chưa
                if (string.IsNullOrEmpty(txt_MaHopDong.Text) || string.IsNullOrEmpty(txt_TenHoiVien.Text) ||
                    date_NgayDangKi.Value == null || date_NgayHetHan.Value == null)
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin hợp đồng.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Tạo đối tượng HopDong từ các giá trị trong form
                HopDong newHopDong = new HopDong
                {
                    MaHopDong = txt_MaHopDong.Text,
                    MaKhachHang = txt_TenHoiVien.Text,
                    NgayDangKi = date_NgayDangKi.Value,
                    NgayKetThuc = date_NgayHetHan.Value
                    // Set các thuộc tính từ các controls trên form
                };

                // Gọi phương thức Create từ repository
                _HopDongRepoSitory.Create(newHopDong);

                // Load lại dữ liệu sau khi thêm mới
                LoadDataHopDong();

                // Hiển thị thông báo thêm mới thành công
                MessageBox.Show("Thêm mới hợp đồng thành công.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Đặt lại giá trị trống cho các controls sau khi thêm mới
                txt_MaHopDong.Text = "";
                txt_TenHoiVien.Text = "";
                date_NgayDangKi.Value = DateTime.Now;
                date_NgayHetHan.Value = DateTime.Now;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi thêm mới hợp đồng: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Delete_HopDong_Click(object sender, EventArgs e)
        {

        }

        private void btn_Update_HopDong_Click(object sender, EventArgs e)
        {

        }

        private void btn_TimKiem_HOpDong_Click(object sender, EventArgs e)
        {

        }

        private void dtGrit_HopDong_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void HoiVien_Load(object sender, EventArgs e)
        {
            LoadData();
            
        }
    }
}
