using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.DomainClass
{
    [Table("PhieuThongKe")]
    public partial class PhieuThongKe
    {
        public PhieuThongKe()
        {
            ThongKeThietBis = new HashSet<ThongKeThietBi>();
        }

        [Key]
        [StringLength(30)]
        [Unicode(false)]
        public string MaPhieu { get; set; } = null!;
        [Column(TypeName = "datetime")]
        public DateTime? NgayLap { get; set; }
        [StringLength(50)]
        public string? TrangThai { get; set; }

        [InverseProperty("MaPhieuNavigation")]
        public virtual ICollection<ThongKeThietBi> ThongKeThietBis { get; set; }
    }
}
