using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.DomainClass
{
    [Table("PhuongThucThanhToan")]
    public partial class PhuongThucThanhToan
    {
        public PhuongThucThanhToan()
        {
            ThanhToans = new HashSet<ThanhToan>();
        }

        [Key]
        [StringLength(30)]
        [Unicode(false)]
        public string MaPhuongThuc { get; set; } = null!;
        [StringLength(30)]
        [Unicode(false)]
        public string? TenPhuongThuc { get; set; }
        [StringLength(50)]
        public string? TrangThai { get; set; }

        [InverseProperty("MaPhuongThucNavigation")]
        public virtual ICollection<ThanhToan> ThanhToans { get; set; }
    }
}
