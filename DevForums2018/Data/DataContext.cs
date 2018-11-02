using DevForums2018.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace DevForums2018.Data
{
    public class DataContext : DbContext
    {
        public DbSet<Question> Questions { get; set; }
        public DbSet<Answer> Answers { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\.;Database=DevForums2018;Trusted_Connection=True;");
        }
    }
}
