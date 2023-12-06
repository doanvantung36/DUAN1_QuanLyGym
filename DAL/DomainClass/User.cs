using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.DomainClass
{
    public partial class User
    {
        [Key]
        [Column("IdDAngNhap")]
        [StringLength(20)]
        [Unicode(false)]
        public string IdDangNhap { get; set; } = null!;
        [StringLength(20)]
        [Unicode(false)]
        public string SoDienThoai { get; set; } = null!;
        [StringLength(40)]
        [Unicode(false)]
        public string Passwords { get; set; } = null!;
        [StringLength(20)]
        [Unicode(false)]
        public string Roles { get; set; } = null!;
    }
}
