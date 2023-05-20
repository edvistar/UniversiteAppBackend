using Microsoft.EntityFrameworkCore;
using UniversiteAppBackend.Models.DataModels;

namespace UniversiteAppBackend.DataAccess
{
    public class UniversityDBContext: DbContext
    {
        public UniversityDBContext(DbContextOptions<UniversityDBContext> options): base(options) 
        {

        }
        //TODO: Add DbSets
        public DbSet<User>? Users { get; set; }
        public DbSet<Course>? Courses { get; set;}
        public DbSet<Category>? Categories { get; set; }
        public DbSet<Student>? Students { get; set; }
        public DbSet<Chapter>? Chapters { get; set; }
    }
}
