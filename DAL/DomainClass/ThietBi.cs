using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.DomainClass
{
    [Table("ThietBi")]
    public partial class ThietBi
    {
        public ThietBi()
        {
            ThongKeThietBis = new HashSet<ThongKeThietBi>();
        }

        [Key]
        [StringLength(30)]
        [Unicode(false)]
        public string MaThietBi { get; set; } = null!;
        [StringLength(30)]
        [Unicode(false)]
        public string MaLoaiThietBi { get; set; } = null!;
        [StringLength(50)]
        public string? TenThietBi { get; set; }
        [Column(TypeName = "decimal(18, 0)")]
        public decimal? Gia { get; set; }
        [StringLength(40)]
        public string? MauSac { get; set; }
        [StringLength(40)]
        public string? ViTri { get; set; }
        public int? KhoiLuong { get; set; }
        [StringLength(50)]
        public string? TrangThai { get; set; }

        [ForeignKey("MaLoaiThietBi")]
        [InverseProperty("ThietBis")]
        public virtual LoaiThietBi MaLoaiThietBiNavigation { get; set; } = null!;
        [InverseProperty("MaThietBiNavigation")]
        public virtual ICollection<ThongKeThietBi> ThongKeThietBis { get; set; }
    }
}
