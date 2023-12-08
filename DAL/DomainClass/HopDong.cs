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
        public HopDong()
        {
            DichVus = new HashSet<DichVu>();
        }

        [Key]
        [StringLength(30)]
        [Unicode(false)]
        public string MaHopDong { get; set; } = null!;
        [StringLength(30)]
        [Unicode(false)]
        public string MaKhachHang { get; set; } = null!;
        [Column(TypeName = "datetime")]
        public DateTime? NgayDangKi { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? NgayKetThuc { get; set; }

        [ForeignKey("MaKhachHang")]
        [InverseProperty("HopDongs")]
        public virtual KhachHang MaKhachHangNavigation { get; set; } = null!;
        [InverseProperty("MaHopDongNavigation")]
        public virtual ICollection<DichVu> DichVus { get; set; }
    }
}
