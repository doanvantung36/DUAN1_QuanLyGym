using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.DomainClass
{
    [Table("LichLamViec")]
    public partial class LichLamViec
    {
        [Key]
        [StringLength(30)]
        [Unicode(false)]
        public string MaLich { get; set; } = null!;
        public int? Ca { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? NgayTap { get; set; }
        [StringLength(30)]
        public string? TrangThai { get; set; }
        [Column("MaPT")]
        [StringLength(30)]
        [Unicode(false)]
        public string MaPt { get; set; } = null!;

        [ForeignKey("MaPt")]
        [InverseProperty("LichLamViecs")]
        public virtual Pt MaPtNavigation { get; set; } = null!;
    }
}
