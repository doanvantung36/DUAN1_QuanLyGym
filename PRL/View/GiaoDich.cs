using BUS;
using DAL.DomainClass;
using DAL.Interface;
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
    public partial class GiaoDich : Form
    {
        //private readonly HoaDonService hoaDonService;
        readonly HoaDonService hoaDonService;
        List<HoaDon>? hoaDonList = null;


        public GiaoDich()
        {
            InitializeComponent();
            hoaDonService = new HoaDonService();
        }
        private void btn_TimKiemHoaDon_Click(object sender, EventArgs e)
        {

        }
        private void LoadDataGridHoaDon()
        {
            try
            {
                // Lấy danh sách hóa đơn từ service
                List<HoaDon> danhSachHoaDon = hoaDonService.LayDanhSachHoaDon();

                // Tạo DataTable để chứa dữ liệu từ danh sách hóa đơn
                DataTable dataTable = new DataTable();

                // Thêm cột số thứ tự vào DataTable
                dataTable.Columns.Add("STT", typeof(int));

                // Thêm các cột khác từ đối tượng HoaDon vào DataTable
                dataTable.Columns.Add("Mã Hóa Đơn", typeof(string));
                dataTable.Columns.Add("Mã Nhân Viên", typeof(string));
                dataTable.Columns.Add("Mã Khách Hàng", typeof(string));
                dataTable.Columns.Add("Ngày Lập", typeof(DateTime));
                dataTable.Columns.Add("Tổng Tiền", typeof(decimal));
                dataTable.Columns.Add("Giảm Giá", typeof(decimal));
                dataTable.Columns.Add("Thanh Toán", typeof(decimal));
                dataTable.Columns.Add("Trạng Thái Hóa Đơn", typeof(string));
                dataTable.Columns.Add("Trạng Thái Thanh Toán", typeof(string));

                // Đổ dữ liệu từ danh sách hóa đơn vào DataTable
                int stt = 1;
                foreach (var hoaDon in danhSachHoaDon)
                {
                    DataRow row = dataTable.NewRow();
                    row["STT"] = stt++;
                    row["Mã Hóa Đơn"] = hoaDon.MaHoaDon;
                    row["Mã Nhân Viên"] = hoaDon.MaNhanVien;
                    row["Mã Khách Hàng"] = hoaDon.MaKhachHang;
                    row["Ngày Lập"] = hoaDon.NgayLap;
                    row["Tổng Tiền"] = hoaDon.TongTien;
                    row["Giảm Giá"] = hoaDon.GiamGia;
                    row["Thanh Toán"] = hoaDon.ThanhTien;
                    row["Trạng Thái Hóa Đơn"] = hoaDon.TrangThaiHoaDon;
                    row["Trạng Thái Thanh Toán"] = hoaDon.TrangThaiThanhToan;

                    dataTable.Rows.Add(row);
                }

                // Gán DataTable làm nguồn dữ liệu cho DataGridView
                DT_HoaDon.DataSource = dataTable;

                // Cấu hình DataGridView
                DT_HoaDon.Columns["STT"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                DT_HoaDon.Columns["Mã Hóa Đơn"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                DT_HoaDon.Columns["Mã Nhân Viên"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                DT_HoaDon.Columns["Mã Khách hàng"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                DT_HoaDon.Columns["Ngày lập"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                DT_HoaDon.Columns["Tổng tiền"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                DT_HoaDon.Columns["Giảm giá"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                DT_HoaDon.Columns["Thanh toán"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                DT_HoaDon.Columns["Trạng thái hóa đơn"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                DT_HoaDon.Columns["Trạng thái thanh toán"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                // ...Cấu hình các cột khác tương tự...
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
            }
        }
        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy thông tin từ giao diện người dùng
                string maHoaDon = txt_MaHoaDon.Text;
                string maKhachHang = txtTenkhachHang.Text;


                // Tạo đối tượng HoaDon từ thông tin lấy được
                HoaDon hoaDon = new HoaDon
                {
                    MaHoaDon = maHoaDon,
                    MaKhachHang = maKhachHang,

                };

                // Gọi phương thức thêm mới hóa đơn từ tầng service
                bool themMoiThanhCong = hoaDonService.ThemMoiHoaDon(hoaDon);

                if (themMoiThanhCong)
                {
                    // Nếu thêm mới thành công, gọi phương thức xuất hóa đơn Word
                    bool xuatHoaDonThanhCong = hoaDonService.XuatHoaDonWord(hoaDon);

                    if (xuatHoaDonThanhCong)
                    {
                        MessageBox.Show("Thanh toán và xuất hóa đơn thành công!");
                    }
                    else
                    {
                        MessageBox.Show("Lỗi khi xuất hóa đơn!");
                    }
                }
                else
                {
                    MessageBox.Show("Lỗi khi thêm mới hóa đơn!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
            }
        }

        private void GiaoDich_Load(object sender, EventArgs e)
        {
            LoadDataGridHoaDon();
        }
    }
}
