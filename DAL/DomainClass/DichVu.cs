using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.DomainClass
{
    [Table("DichVu")]
    public partial class DichVu
    {
        public DichVu()
        {
            HoaDonChiTiets = new HashSet<HoaDonChiTiet>();
            HopDongs = new HashSet<HopDong>();
        }

        [Key]
        [StringLength(30)]
        [Unicode(false)]
        public string MaDichVu { get; set; } = null!;
        [StringLength(30)]
        public string? TenDichVu { get; set; }
        [Column(TypeName = "decimal(18, 0)")]
        public decimal? Gia { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ThoiHan { get; set; }
        [StringLength(50)]
        public string? GhiChu { get; set; }

        [InverseProperty("MaDichVuNavigation")]
        public virtual ICollection<HoaDonChiTiet> HoaDonChiTiets { get; set; }
        [InverseProperty("MaDichVuNavigation")]
        public virtual ICollection<HopDong> HopDongs { get; set; }
    }
}
