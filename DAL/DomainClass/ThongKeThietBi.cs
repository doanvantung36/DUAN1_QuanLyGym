using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.DomainClass
{
    [Table("ThongKeThietBi")]
    public partial class ThongKeThietBi
    {
        [Key]
        [Column("MaPhieuCHiTiet")]
        [StringLength(20)]
        [Unicode(false)]
        public string MaPhieuChiTiet { get; set; } = null!;
        [StringLength(30)]
        [Unicode(false)]
        public string MaPhieu { get; set; } = null!;
        [StringLength(30)]
        [Unicode(false)]
        public string MaThietBi { get; set; } = null!;
        public int? SoLuong { get; set; }
        [StringLength(50)]
        public string? TrangThai { get; set; }
        [StringLength(50)]
        public string? NhaCungCap { get; set; }

        [ForeignKey("MaPhieu")]
        [InverseProperty("ThongKeThietBis")]
        public virtual PhieuThongKe MaPhieuNavigation { get; set; } = null!;
        [ForeignKey("MaThietBi")]
        [InverseProperty("ThongKeThietBis")]
        public virtual ThietBi MaThietBiNavigation { get; set; } = null!;
    }
}
