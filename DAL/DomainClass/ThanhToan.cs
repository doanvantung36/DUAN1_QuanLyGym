using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.DomainClass
{
    [Table("ThanhToan")]
    public partial class ThanhToan
    {
        public ThanhToan()
        {
            HoaDons = new HashSet<HoaDon>();
        }

        [Key]
        [StringLength(30)]
        [Unicode(false)]
        public string MaThanhToan { get; set; } = null!;
        [StringLength(30)]
        [Unicode(false)]
        public string MaPhuongThuc { get; set; } = null!;
        [StringLength(50)]
        public string? TrangThai { get; set; }

        [ForeignKey("MaPhuongThuc")]
        [InverseProperty("ThanhToans")]
        public virtual PhuongThucThanhToan MaPhuongThucNavigation { get; set; } = null!;
        [InverseProperty("MaThanhToanNavigation")]
        public virtual ICollection<HoaDon> HoaDons { get; set; }
    }
}
