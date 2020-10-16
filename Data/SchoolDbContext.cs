using Microsoft.EntityFrameworkCore;
using SchoolManager.Models;

namespace SchoolManager.Data
{
    public class SchoolDbContext : DbContext
    {
        public SchoolDbContext(DbContextOptions options)
            : base(options)
        {
        }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<StudentLesson>()
                .HasKey(bc => new { bc.StudentId, bc.LessonId });  
            modelBuilder.Entity<StudentLesson>()
                .HasOne(bc => bc.Student)
                .WithMany(b => b.StudentLessons)
                .HasForeignKey(bc => bc.StudentId);  
            modelBuilder.Entity<StudentLesson>()
                .HasOne(bc => bc.Lesson)
                .WithMany(c => c.StudentLessons)
                .HasForeignKey(bc => bc.StudentId);
        }
        public DbSet<SchoolManager.Models.Student> Students { get; set; }
        public DbSet<SchoolManager.Models.Teacher> Teachers { get; set; }
        public DbSet<SchoolManager.Models.Lesson> Lessons { get; set; }
        public DbSet<SchoolManager.Models.StudentLesson> StudentLessons { get; set; }
    }
}