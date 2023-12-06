using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.DomainClass
{
    [Table("HoaDonCHiTiet")]
    public partial class HoaDonChiTiet
    {
        [Key]
        [StringLength(30)]
        [Unicode(false)]
        public string MaHoaDonCt { get; set; } = null!;
        [StringLength(30)]
        [Unicode(false)]
        public string MaHoaDon { get; set; } = null!;
        [Column(TypeName = "decimal(18, 0)")]
        public decimal? Gia { get; set; }
        [StringLength(30)]
        [Unicode(false)]
        public string MaGiamGia { get; set; } = null!;
        [Column(TypeName = "decimal(18, 0)")]
        public decimal? TienCocTruoc { get; set; }
        [Column(TypeName = "decimal(18, 0)")]
        public decimal? TienCanThanhToan { get; set; }
        [StringLength(30)]
        [Unicode(false)]
        public string MaDichVu { get; set; } = null!;

        [ForeignKey("MaDichVu")]
        [InverseProperty("HoaDonChiTiets")]
        public virtual DichVu MaDichVuNavigation { get; set; } = null!;
        [ForeignKey("MaGiamGia")]
        [InverseProperty("HoaDonChiTiets")]
        public virtual GiamGium MaGiamGiaNavigation { get; set; } = null!;
        [ForeignKey("MaHoaDon")]
        [InverseProperty("HoaDonChiTiets")]
        public virtual HoaDon MaHoaDonNavigation { get; set; } = null!;
    }
}
