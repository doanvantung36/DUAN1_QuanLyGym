using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.DomainClass
{
    [Table("HopDong")]
    public partial class HopDong
    {
        [Key]
        [StringLength(30)]
        [Unicode(false)]
        public string MaHopDong { get; set; } = null!;
        [StringLength(30)]
        [Unicode(false)]
        public string MaKhachHang { get; set; } = null!;
        [Column("MaPT")]
        [StringLength(30)]
        [Unicode(false)]
        public string MaPt { get; set; } = null!;
        [StringLength(30)]
        [Unicode(false)]
        public string MaDichVu { get; set; } = null!;
        [Column(TypeName = "datetime")]
        public DateTime? NgayDangKi { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? NgayKetThuc { get; set; }

        [ForeignKey("MaDichVu")]
        [InverseProperty("HopDongs")]
        public virtual DichVu MaDichVuNavigation { get; set; } = null!;
        [ForeignKey("MaKhachHang")]
        [InverseProperty("HopDongs")]
        public virtual KhachHang MaKhachHangNavigation { get; set; } = null!;
        [ForeignKey("MaPt")]
        [InverseProperty("HopDongs")]
        public virtual Pt MaPtNavigation { get; set; } = null!;
    }
}
