using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.DomainClass
{
    [Table("NhanVien")]
    public partial class NhanVien
    {
        public NhanVien()
        {
            HoaDons = new HashSet<HoaDon>();
        }

        [Key]
        [StringLength(30)]
        [Unicode(false)]
        public string MaNhanVien { get; set; } = null!;
        [StringLength(50)]
        [Unicode(false)]
        public string TenNhanVien { get; set; } = null!;
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
        [StringLength(50)]
        public string? ChucVu { get; set; }
        [StringLength(20)]
        public string? TrangThai { get; set; }

        [InverseProperty("MaNhanVienNavigation")]
        public virtual ICollection<HoaDon> HoaDons { get; set; }
    }
}
