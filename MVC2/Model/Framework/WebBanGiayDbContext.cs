using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Model.Framework
{
    public partial class WebBanGiayDbContext : DbContext
    {
        public WebBanGiayDbContext()
            : base("name=WebBanGiayDbContext")
        {
        }

        public virtual DbSet<tTaiKhoan> tTaiKhoans { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
