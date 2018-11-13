using Microsoft.EntityFrameworkCore;
using NS.Questions.API.Data.Entities;

namespace NS.Questions.API.Data
{
    public partial class DataContext : DbContext
    {
        public DataContext()
        {
        }

        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Answers> Answers { get; set; }
        public virtual DbSet<Entities.Questions> Questions { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=(localdb)\\.;Database=DevForums2018;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Answers>(entity =>
            {
                entity.HasKey(e => e.AnswerId);

                entity.HasIndex(e => e.QuestionId);

                entity.HasOne(d => d.Question)
                    .WithMany(p => p.Answers)
                    .HasForeignKey(d => d.QuestionId);
            });

            modelBuilder.Entity<Entities.Questions>(entity =>
            {
                entity.HasKey(e => e.QuestionId);
            });
        }
    }
}
