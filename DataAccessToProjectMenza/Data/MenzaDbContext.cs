using Microsoft.EntityFrameworkCore;
using ModelMenza.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessToProjectMenza.Data
{
    public class MenzaDbContext : DbContext
    {
        public DbSet<Person> Persons { get; set; }
        public DbSet<PersonDetail> PersonDetails { get; set; }
        public DbSet<Fakultet> Fakultets { get; set; }
        public DbSet<Obrok> Obroci { get; set; }
        public DbSet<StudentObrok> StudentObroci { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer("Data Source=31.147.206.65;Persist Security Info=True;User ID=RWA2324_edeur22_User;Password=tI}?7>&&;Encrypt=True;Trust Server Certificate=True");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<StudentObrok>().HasKey(u => new { u.Id, u.ObrokId });
        }
    }
}
