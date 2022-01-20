using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
namespace Yurt_Apart_Bul.Models.Siniflar
{
    public class Context: DbContext
    {
        public DbSet<Admin> Admins { get; set; }
        public DbSet<AdresBlog> AdresBlogs { get; set; }
        public DbSet<AnaSayfa> AnaSayfas { get; set; }
        public DbSet<Iletisim> Iletisims { get; set; }
        public DbSet<Sehirler> Sehirlers { get; set; }
        public DbSet<Universiteler> Universitelers { get; set; }
        public DbSet<Yorumlar> Yorumlars { get; set; }
        public DbSet<YurtApart> YurtAparts { get; set; }
        public DbSet<Bilecik> Bileciks { get; set; }
        public DbSet<Eskisehir> Eskisehirs { get; set; }
        public DbSet<Istanbul> Istanbuls { get; set; }
        public DbSet<Izmir> Izmirs { get; set; }
        public DbSet<Ankara> Ankaras { get; set; }
        public DbSet<Sakarya> Sakaryas { get; set; }
        public DbSet<Antalya> Antalyas { get; set; }
        public DbSet<Kocaeli> Kocaelis { get; set; }
        public DbSet<Bursa> Bursas { get; set; }
        public DbSet<Konya> Konyas { get; set; }
    }
}