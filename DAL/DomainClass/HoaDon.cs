using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.DomainClass
{
    [Table("HoaDon")]
    public partial class HoaDon
    {
        public HoaDon()
        {
            HoaDonChiTiets = new HashSet<HoaDonChiTiet>();
        }

        [Key]
        [StringLength(30)]
        [Unicode(false)]
        public string MaHoaDon { get; set; } = null!;
        [StringLength(30)]
        [Unicode(false)]
        public string MaNhanVien { get; set; } = null!;
        [StringLength(30)]
        [Unicode(false)]
        public string MaKhachHang { get; set; } = null!;
        [StringLength(30)]
        [Unicode(false)]
        public string MaThanhToan { get; set; } = null!;
        [Column(TypeName = "datetime")]
        public DateTime? NgayLap { get; set; }
        [Column(TypeName = "decimal(18, 0)")]
        public decimal? TongTien { get; set; }
        [Column(TypeName = "decimal(18, 0)")]
        public decimal? GiamGia { get; set; }
        [Column(TypeName = "decimal(18, 0)")]
        public decimal? ThanhTien { get; set; }
        [StringLength(50)]
        public string? TrangThaiHoaDon { get; set; }
        [StringLength(40)]
        public string? TrangThaiThanhToan { get; set; }

        [ForeignKey("MaKhachHang")]
        [InverseProperty("HoaDons")]
        public virtual KhachHang MaKhachHangNavigation { get; set; } = null!;
        [ForeignKey("MaNhanVien")]
        [InverseProperty("HoaDons")]
        public virtual NhanVien MaNhanVienNavigation { get; set; } = null!;
        [ForeignKey("MaThanhToan")]
        [InverseProperty("HoaDons")]
        public virtual ThanhToan MaThanhToanNavigation { get; set; } = null!;
        [InverseProperty("MaHoaDonNavigation")]
        public virtual ICollection<HoaDonChiTiet> HoaDonChiTiets { get; set; }
    }
}
