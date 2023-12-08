using BUS;
using BUS.IService;
using DAL.Context;
using DAL.DomainClass;
using DAL.Repositoies;
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
        KhachHangRepository _khachHangRepository;
        HopDongRepoSitory _hopDongRepository;
        PTRepository _ptRepository;
        DichVuRepository _dichVuRepository;

        public HoiVien()
        {
            InitializeComponent();
            _khachHangRepository = new KhachHangRepository(new DBContext()); // Cần điều chỉnh nếu có constructor khác
            _hopDongRepository = new HopDongRepoSitory(new DBContext());
            _dichVuRepository = new DichVuRepository(new DBContext());
            _ptRepository = new PTRepository(new DBContext());
            dataGridView1.CellClick += dataGridView1_CellClick;
           
            LoadData();
            LoadDataHopDong();
        }
        private void LoadDataHopDong()
        {
            try
            {
                // Lấy danh sách hợp đồng từ repository
                List<HopDong> danhSachHopDong = _hopDongRepository.GetAll();

                // Tạo DataTable để chứa dữ liệu từ danh sách hợp đồng
                DataTable dataTable = new DataTable();

                // Thêm cột số thứ tự vào DataTable
                dataTable.Columns.Add("STT", typeof(int));

                // Thêm các cột khác từ đối tượng HopDong vào DataTable
                dataTable.Columns.Add("Mã Hợp Đồng", typeof(string));
                dataTable.Columns.Add("Khách Hàng", typeof(string));
                dataTable.Columns.Add("Phòng Tập", typeof(string));
                dataTable.Columns.Add("Dịch Vụ", typeof(string));
                dataTable.Columns.Add("Ngày Đăng Kí", typeof(DateTime));
                dataTable.Columns.Add("Ngày Kết Thúc", typeof(DateTime));

                // Đổ dữ liệu từ danh sách hợp đồng vào DataTable
                int stt = 1;
                foreach (var hopDong in danhSachHopDong)
                {
                    DataRow row = dataTable.NewRow();
                    row["STT"] = stt++;
                    row["Mã Hợp Đồng"] = hopDong.MaHopDong;

                    // Lấy tên khách hàng từ repository hoặc service
                    var khachHang = _khachHangRepository.LayTheoMaKhachHang(hopDong.MaKhachHang);
                    row["Khách Hàng"] = khachHang?.TenKhachHang;

                    // Lấy tên PT từ repository hoặc service
                    var pt = _ptRepository.GetById(hopDong.MaPt);
                    row["Phòng Tập"] = pt?.TenPt;

                    // Lấy tên dịch vụ từ repository hoặc service
                    var dichVu = _dichVuRepository.GetByID(hopDong.MaDichVu);
                    row["Dịch Vụ"] = dichVu?.TenDichVu;

                    row["Ngày Đăng Kí"] = hopDong.NgayDangKi;
                    row["Ngày Kết Thúc"] = hopDong.NgayKetThuc;

                    dataTable.Rows.Add(row);
                }

                // Gán DataTable làm nguồn dữ liệu cho DataGridView HopDong
                dtGrit_HopDong.DataSource = dataTable;
                // Cấu hình DataGridView
                // ...Cấu hình các cột tương tự như bạn đã làm ở phần LoadDataGridHoaDon...
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi khi load dữ liệu Hợp đồng: " + ex.Message);
            }
        }
        public void LoadData()
        {
            try
            {
                // Lấy danh sách khách hàng từ repository
                List<KhachHang> danhSachKhachHang = _khachHangRepository.GetAll();

                // Tạo DataTable để chứa dữ liệu từ danh sách khách hàng
                DataTable dataTable = new DataTable();

                // Thêm cột số thứ tự vào DataTable
                dataTable.Columns.Add("STT", typeof(int));

                // Thêm các cột khác từ đối tượng KhachHang vào DataTable
                dataTable.Columns.Add("Mã Khách Hàng", typeof(string));
                dataTable.Columns.Add("Tên Khách Hàng", typeof(string));
                dataTable.Columns.Add("Ngày Sinh", typeof(DateTime));
                dataTable.Columns.Add("Giới Tính", typeof(string));
                dataTable.Columns.Add("Địa Chỉ", typeof(string));
                dataTable.Columns.Add("Số Điện Thoại", typeof(string));
                dataTable.Columns.Add("Email", typeof(string));

                // Đổ dữ liệu từ danh sách khách hàng vào DataTable
                int stt = 1;
                foreach (var khachHang in danhSachKhachHang)
                {
                    DataRow row = dataTable.NewRow();
                    row["STT"] = stt++;
                    row["Mã Khách Hàng"] = khachHang.MaKhachHang;
                    row["Tên Khách Hàng"] = khachHang.TenKhachHang;
                    row["Ngày Sinh"] = khachHang.NgaySinh;
                    row["Giới Tính"] = khachHang.GioiTinh;
                    row["Địa Chỉ"] = khachHang.DiaChi;
                    row["Số Điện Thoại"] = khachHang.SoDienThoai;
                    row["Email"] = khachHang.Email;

                    dataTable.Rows.Add(row);
                }

                // Gán DataTable làm nguồn dữ liệu cho DataGridView
                // DT_KhachHang là tên DataGridView của bạn
                dataGridView1.DataSource = dataTable;

                // Cấu hình DataGridView
                // ...Cấu hình các cột tương tự như bạn đã làm ở phần LoadDataGridHoaDon...
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
            }
        }
        private void btn_Add_Click(object sender, EventArgs e)
        {
            try
            {
                // Tạo một đối tượng KhachHang mới từ thông tin trên các ô nhập liệu
                KhachHang khachHang = new KhachHang
                {
                    MaKhachHang = tb_MaHoiVien.Text,
                    TenKhachHang = txt_TenHoiVien.Text,
                    NgaySinh = date_NgaySinh.Value,
                    GioiTinh = cb_GioiTinh.SelectedItem?.ToString(),
                    DiaChi = tb_DiaChi.Text,
                    SoDienThoai = tb_SoDienThoai.Text,
                    Email = tb_Email.Text
                };

                // Thêm khách hàng vào database
                _khachHangRepository.ThemKhachHang(khachHang);

                // Load lại dữ liệu sau khi thêm mới
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi khi thêm mới khách hàng: " + ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy mã khách hàng từ ô Mã Khách Hàng
                string maKhachHang = tb_MaHoiVien.Text;

                // Xóa khách hàng từ database
                _khachHangRepository.XoaKhachHang(maKhachHang);

                // Load lại dữ liệu sau khi xóa
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi khi xóa khách hàng: " + ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy mã khách hàng từ ô Mã Khách Hàng
                string maKhachHang = tb_MaHoiVien.Text;

                // Kiểm tra xem mã khách hàng có tồn tại hay không
                if (_khachHangRepository.Exists(maKhachHang))
                {
                    // Lấy thông tin khách hàng cần cập nhật từ các ô nhập liệu
                    KhachHang khachHangUpdate = new KhachHang
                    {
                        MaKhachHang = tb_MaHoiVien.Text,
                        TenKhachHang = txt_TenHoiVien.Text,
                        NgaySinh = date_NgaySinh.Value,
                        GioiTinh = cb_GioiTinh.SelectedItem?.ToString(),
                        DiaChi = tb_DiaChi.Text,
                        SoDienThoai = tb_SoDienThoai.Text,
                        Email = tb_Email.Text
                    };

                    // Cập nhật thông tin khách hàng trong database
                    _khachHangRepository.CapNhatKhachHang(khachHangUpdate);

                    // Load lại dữ liệu sau khi cập nhật
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy khách hàng có mã: " + maKhachHang);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi khi cập nhật khách hàng: " + ex.Message);
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy thông tin từ ô tìm kiếm (nếu có)
                string tuKhoa = txtTimKiem.Text;

                // Tìm kiếm theo tên khách hàng hoặc mã khách hàng
                List<KhachHang> ketQuaTimKiem = _khachHangRepository.Search(tuKhoa);

                // Hiển thị kết quả tìm kiếm lên DataGridView
                DataTable dataTable = new DataTable();
                dataTable.Columns.Add("STT", typeof(int));
                dataTable.Columns.Add("Mã Khách Hàng", typeof(string));
                dataTable.Columns.Add("Tên Khách Hàng", typeof(string));
                dataTable.Columns.Add("Ngày Sinh", typeof(DateTime));
                dataTable.Columns.Add("Giới Tính", typeof(string));
                dataTable.Columns.Add("Địa Chỉ", typeof(string));
                dataTable.Columns.Add("Số Điện Thoại", typeof(string));
                dataTable.Columns.Add("Email", typeof(string));

                int stt = 1;
                foreach (var khachHang in ketQuaTimKiem)
                {
                    DataRow row = dataTable.NewRow();
                    row["STT"] = stt++;
                    row["Mã Khách Hàng"] = khachHang.MaKhachHang;
                    row["Tên Khách Hàng"] = khachHang.TenKhachHang;
                    row["Ngày Sinh"] = khachHang.NgaySinh;
                    row["Giới Tính"] = khachHang.GioiTinh;
                    row["Địa Chỉ"] = khachHang.DiaChi;
                    row["Số Điện Thoại"] = khachHang.SoDienThoai;
                    row["Email"] = khachHang.Email;

                    dataTable.Rows.Add(row);
                }

                dataGridView1.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi khi tìm kiếm khách hàng: " + ex.Message);
            }
        }

        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            LoadData();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Lấy hàng đầu tiên được chọn
                //DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                //// Lấy giá trị từ các ô trong hàng đó
                //string maKhachHang = selectedRow.Cells["MaKhachHang"].Value?.ToString();
                //string tenKhachHang = selectedRow.Cells["TenKhachHang"].Value?.ToString();
                //DateTime? ngaySinh = selectedRow.Cells["NgaySinh"].Value as DateTime?;
                //string gioiTinh = selectedRow.Cells["GioiTinh"].Value?.ToString();
                //string diaChi = selectedRow.Cells["DiaChi"].Value?.ToString();
                //string soDienThoai = selectedRow.Cells["SoDienThoai"].Value?.ToString();
                //string email = selectedRow.Cells["Email"].Value?.ToString();

                //// Hiển thị thông tin lên các ô tương ứng
                //tb_MaHoiVien.Text = maKhachHang;
                //txt_TenHoiVien.Text = tenKhachHang;
                //date_NgaySinh.Value = ngaySinh ?? DateTime.MinValue; // Ngày sinh
                //cb_GioiTinh.SelectedItem = gioiTinh; // Giới tính
                //tb_DiaChi.Text = diaChi;
                //tb_SoDienThoai.Text = soDienThoai;
                //tb_Email.Text = email; 
            }
        }

        private void btn_Add_HopDong_Click(object sender, EventArgs e)
        {

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
            if (dtGrit_HopDong.SelectedRows.Count > 0)
            {
                // Lấy giá trị từ các ô trong hàng đó
                string maHopDong = dtGrit_HopDong.SelectedRows[0].Cells["Mã Hợp Đồng"].Value?.ToString();
                string maKhachHang = dtGrit_HopDong.SelectedRows[0].Cells["Khách Hàng"].Value?.ToString();
                string maDichVu = dtGrit_HopDong.SelectedRows[0].Cells["Dịch Vụ"].Value?.ToString();
                DateTime ngayDangKi = (DateTime)dtGrit_HopDong.SelectedRows[0].Cells["Ngày Đăng Kí"].Value;
                DateTime ngayKetThuc = (DateTime)dtGrit_HopDong.SelectedRows[0].Cells["Ngày Kết Thúc"].Value;

                // Hiển thị thông tin lên các ô tương ứng
                txt_MaHopDong.Text = maHopDong;
                tb_MaHoiVien.Text = maKhachHang;
                txt_DichVu.Text = maDichVu;
                date_NgayDangKi.Value = ngayDangKi;
                date_NgayHetHan.Value = ngayKetThuc;
                // Các ô khác tương tự
            }
        }
    }
}
