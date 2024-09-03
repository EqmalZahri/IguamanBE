using Iguaman.Models.Cawangan;
using Iguaman.Models.JenisKes;
using Iguaman.Models.JKM;
using Iguaman.Models.Kategori;
using Iguaman.Models.KhidmatNasihat;
using Iguaman.Models.Negeri;
using Iguaman.Models.Pengguna;
using Iguaman.Models.Penjara;
using Iguaman.Models.Peranan;
using Iguaman.Models.TemuJanji;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Iguaman.Repositories
{
    public class AppDbContext:IdentityDbContext<Pengguna, IdentityRole<Guid>, Guid>
    {
        public AppDbContext(DbContextOptions<AppDbContext>options)
            : base(options) 
        { 
        
        }

        public DbSet<Pengguna> Penggunas { get; set; }
        public DbSet<KhidmatNasihat> KhidmatNasihats { get; set; }
        public DbSet<TemuJanji> TemuJanjis { get; set; }
        public DbSet<Kategori> Kategoris { get; set; }
        public DbSet<JenisKes> JenisKess { get; set; }
        public DbSet<Negeri> Negeris { get; set; }
        public DbSet<CawanganJBG> Cawangans { get; set; }
        public DbSet<Peranan> Peranans { get; set; }
        public DbSet<Penjara> Penjaras { get; set; }
        public DbSet<JKM> JKMs { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);


        }

    }
}
