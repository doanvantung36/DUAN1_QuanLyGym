using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.DomainClass
{
    [Table("DatLich")]
    public partial class DatLich
    {
        public DatLich()
        {
            DatLichChiTiets = new HashSet<DatLichChiTiet>();
        }

        [Key]
        [StringLength(30)]
        [Unicode(false)]
        public string MaPhieuDatLich { get; set; } = null!;
        [StringLength(30)]
        [Unicode(false)]
        public string MaKhachHang { get; set; } = null!;
        [Column(TypeName = "datetime")]
        public DateTime? NgayDatLich { get; set; }

        [ForeignKey("MaKhachHang")]
        [InverseProperty("DatLiches")]
        public virtual KhachHang MaKhachHangNavigation { get; set; } = null!;
        [InverseProperty("MaPhieuDatLichNavigation")]
        public virtual ICollection<DatLichChiTiet> DatLichChiTiets { get; set; }
    }
}
