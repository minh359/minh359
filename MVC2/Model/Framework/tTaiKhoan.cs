namespace Model.Framework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tTaiKhoan")]
    public partial class tTaiKhoan
    {
        [Key]
        [StringLength(50)]
        public string TenTK { get; set; }

        [StringLength(50)]
        public string Password { get; set; }

        [StringLength(50)]
        public string TenKH { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgaySinh { get; set; }

        [StringLength(50)]
        public string Email { get; set; }
    }
}
