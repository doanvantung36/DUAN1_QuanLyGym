using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.DomainClass
{
    [Table("PT")]
    public partial class Pt
    {
        public Pt()
        {
            HopDongs = new HashSet<HopDong>();
            LichLamViecs = new HashSet<LichLamViec>();
        }

        [Key]
        [Column("MaPT")]
        [StringLength(30)]
        [Unicode(false)]
        public string MaPt { get; set; } = null!;
        [Column("TenPT")]
        [StringLength(50)]
        public string? TenPt { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? NgaySinh { get; set; }
        [StringLength(5)]
        public string? GioiTinh { get; set; }
        [StringLength(255)]
        public string? DiaChi { get; set; }
        [StringLength(15)]
        [Unicode(false)]
        public string? SoDienThoai { get; set; }
        [StringLength(100)]
        [Unicode(false)]
        public string? Email { get; set; }

        [InverseProperty("MaPtNavigation")]
        public virtual ICollection<HopDong> HopDongs { get; set; }
        [InverseProperty("MaPtNavigation")]
        public virtual ICollection<LichLamViec> LichLamViecs { get; set; }
    }
}
