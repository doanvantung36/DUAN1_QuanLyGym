using DAL.DomainClass;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Interface;
using Xceed.Words.NET;
using Xceed.Document.NET;
using DAL.Repositoies;
using DAL.Context;

namespace BUS
{
    public class HoaDonService
    {
        static IHoaDon hoaDonRepository;
        static IKhachHang khachHangRepository;
        private static DBContext context;

        // Constructor để inject dependency
        static HoaDonService()
        {
            hoaDonRepository = new HoaDonRepository(context);
        }

        public List<HoaDon> LayDanhSachHoaDon()
        {
            return hoaDonRepository.LayDanhSachHoaDon();
        }

        // Phương thức để thêm mới hóa đơn
        public bool ThemMoiHoaDon(HoaDon hoaDon)
        {
            return hoaDonRepository.ThemMoiHoaDon(hoaDon);
        }
        // Phương thức để xuất hóa đơn ra file Word
        public bool XuatHoaDonWord(HoaDon hoaDon)
        {

            try
            {
                // Tạo và điền thông tin hóa đơn vào file Word
                using (DocX document = DocX.Create("HoaDon_" + hoaDon.MaHoaDon + ".docx"))
                {
                    document.InsertParagraph("Hóa Đơn").Bold().FontSize(16).Alignment = Alignment.center;

                    // Điền thông tin hóa đơn
                    document.InsertParagraph("Mã Hóa Đơn: " + hoaDon.MaHoaDon);
                    document.InsertParagraph("Ngày Lập: " + (hoaDon.NgayLap?.ToString("dd/MM/yyyy HH:mm:ss") ?? "Không có thông tin"));
                    document.InsertParagraph("Khách Hàng: " + (hoaDon.MaKhachHangNavigation?.TenKhachHang ?? "Không có thông tin"));
                    document.InsertParagraph("Tổng Tiền: " + hoaDon.TongTien);
                    document.InsertParagraph("Trạng Thái Thanh Toán: " + (hoaDon.TrangThaiThanhToan ?? "Không có thông tin"));

                    // Tạo bảng để hiển thị chi tiết hóa đơn
                    Table table = document.AddTable(1, 4);
                    table.Alignment = Alignment.center;

                    // Điền tiêu đề cho bảng
                    table.Rows[0].Cells[0].Paragraphs.First().InsertText("STT");
                    table.Rows[0].Cells[1].Paragraphs.First().InsertText("Dịch Vụ");
                    table.Rows[0].Cells[2].Paragraphs.First().InsertText("Giảm Giá");
                    table.Rows[0].Cells[3].Paragraphs.First().InsertText("Thành Tiền");

                    int stt = 1;

                    // Điền thông tin chi tiết hóa đơn

                    foreach (var chiTiet in hoaDon.HoaDonChiTiets)
                    {
                        table.InsertRow();

                        table.Rows[stt].Cells[0].Paragraphs.First().InsertText(stt.ToString());
                        table.Rows[stt].Cells[1].Paragraphs.First().InsertText(chiTiet.MaDichVuNavigation?.TenDichVu ?? "Không có thông tin");
                        decimal thanhTien = chiTiet.TienCanThanhToan ?? 0;
                        table.Rows[stt].Cells[3].Paragraphs.First().InsertText(thanhTien.ToString());
                        stt++;
                    }

                    // Thêm bảng vào tài liệu
                    document.InsertTable(table);

                    // Lưu tài liệu
                    document.Save();
                }

                return true;
            }
            catch (Exception ex)
            {
                // Xử lý lỗi (ghi log, thông báo, v.v.)
                return false;
            }
        }

        // Phương thức để lấy tên khách hàng theo mã khách hàng
        private string LayTenKhachHangTheoMaKhachHang(string maKhachHang)
        {
            // Sử dụng repository để lấy thông tin khách hàng
            KhachHang khachHang = khachHangRepository.LayTheoMaKhachHang(maKhachHang);

            // Kiểm tra xem khách hàng có tồn tại không
            if (khachHang != null)
            {
                return khachHang.TenKhachHang;
            }

            // Nếu không tìm thấy, có thể trả về một giá trị mặc định hoặc null tùy thuộc vào yêu cầu của bạn
            return "Khách hàng không tồn tại";
        }

    }
}
