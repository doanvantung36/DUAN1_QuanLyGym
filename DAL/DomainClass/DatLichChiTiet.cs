using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.DomainClass
{
    [Table("DatLichChiTiet")]
    public partial class DatLichChiTiet
    {
        [Key]
        [Column("MaDatLichCT")]
        [StringLength(30)]
        [Unicode(false)]
        public string MaDatLichCt { get; set; } = null!;
        [StringLength(30)]
        [Unicode(false)]
        public string MaPhieuDatLich { get; set; } = null!;
        [Column(TypeName = "datetime")]
        public DateTime? NhayBatDau { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? GioBatDau { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? GiaKetThu { get; set; }
        [StringLength(50)]
        public string? GhiChu { get; set; }

        [ForeignKey("MaPhieuDatLich")]
        [InverseProperty("DatLichChiTiets")]
        public virtual DatLich MaPhieuDatLichNavigation { get; set; } = null!;
    }
}
