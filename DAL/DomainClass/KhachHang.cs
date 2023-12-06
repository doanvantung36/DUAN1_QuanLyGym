using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.DomainClass
{
    [Table("KhachHang")]
    public partial class KhachHang
    {
        public KhachHang()
        {
            DatLiches = new HashSet<DatLich>();
            HoaDons = new HashSet<HoaDon>();
            HopDongs = new HashSet<HopDong>();
        }

        [Key]
        [StringLength(30)]
        [Unicode(false)]
        public string MaKhachHang { get; set; } = null!;
        [StringLength(50)]
        [Unicode(false)]
        public string TenKhachHang { get; set; } = null!;
        [Column(TypeName = "datetime")]
        public DateTime? NgaySinh { get; set; }
        [StringLength(10)]
        public string? GioiTinh { get; set; }
        [StringLength(255)]
        public string? DiaChi { get; set; }
        [StringLength(15)]
        [Unicode(false)]
        public string? SoDienThoai { get; set; }
        [StringLength(255)]
        [Unicode(false)]
        public string? Email { get; set; }

        [InverseProperty("MaKhachHangNavigation")]
        public virtual ICollection<DatLich> DatLiches { get; set; }
        [InverseProperty("MaKhachHangNavigation")]
        public virtual ICollection<HoaDon> HoaDons { get; set; }
        [InverseProperty("MaKhachHangNavigation")]
        public virtual ICollection<HopDong> HopDongs { get; set; }
    }
}
