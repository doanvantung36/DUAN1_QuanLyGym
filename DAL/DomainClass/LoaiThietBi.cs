using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.DomainClass
{
    [Table("LoaiThietBi")]
    public partial class LoaiThietBi
    {
        public LoaiThietBi()
        {
            ThietBis = new HashSet<ThietBi>();
        }

        [Key]
        [StringLength(30)]
        [Unicode(false)]
        public string MaLoaiThietBi { get; set; } = null!;
        [StringLength(200)]
        public string? TenLoaiThietBi { get; set; }
        [StringLength(40)]
        public string? ChucNang { get; set; }
        [StringLength(50)]
        public string? TrangThai { get; set; }

        [InverseProperty("MaLoaiThietBiNavigation")]
        public virtual ICollection<ThietBi> ThietBis { get; set; }
    }
}
