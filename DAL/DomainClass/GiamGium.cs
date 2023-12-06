using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.DomainClass
{
    public partial class GiamGium
    {
        public GiamGium()
        {
            HoaDonChiTiets = new HashSet<HoaDonChiTiet>();
        }

        [Key]
        [StringLength(30)]
        [Unicode(false)]
        public string MaGiamGia { get; set; } = null!;
        [StringLength(50)]
        public string? MoTa { get; set; }
        [Column(TypeName = "decimal(18, 0)")]
        public decimal? GiaGiam { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? NgayHetHan { get; set; }

        [InverseProperty("MaGiamGiaNavigation")]
        public virtual ICollection<HoaDonChiTiet> HoaDonChiTiets { get; set; }
    }
}
