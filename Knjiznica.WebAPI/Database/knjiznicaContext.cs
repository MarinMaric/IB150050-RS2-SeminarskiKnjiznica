using Knjiznica.WebAPI.Database;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Knjiznica.Database
{
    public class knjiznicaContext:DbContext
    {
        public DbSet<Knjiznicar> Knjinicari { get; set; }
        public DbSet<Clan> Clanovi { get; set; }
        public DbSet<Kopija> Kopije { get; set; }
        public DbSet<Stanje> Stanja { get; set; }
        public DbSet<Upozorenje> Upozorenja { get; set; }
        public DbSet<Kazna> Kazne { get; set; }
        public DbSet<Knjiga> Knjige { get; set; }
        public DbSet<Autor> Autori { get; set; }
        public DbSet<Kategorija> Kategorije { get; set; }
        public DbSet<UplataClanarine> Uplate { get; set; }
        public DbSet<Recenzija> Recenzije { get; set; }
        public DbSet<Wishlist> Wishliste { get; set; }
        public DbSet<WishlistStavka> WishlisteStavke { get; set; }
        public DbSet<Rezervacija> Rezervacije { get; set; }
        public DbSet<StatusRezervacije> StatusiRezervacija { get; set; }
        public DbSet<Posudba> Posudbe { get; set; }

        public knjiznicaContext(DbContextOptions options):base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Seed();
        }
    }
}
