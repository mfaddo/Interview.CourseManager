using Interview.CourseManager.efCoreCode.efCoreClasses;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Interview.CourseManager.efCoreCode
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {

        }
        public DbSet<SportType> SportTypes { get; set; }
        public DbSet<ClubBranch> ClubBranches { get; set; }
        public DbSet<Academy> Academys { get; set;}
        public DbSet<Course> Courses { get; set; }
        public DbSet<Stadium> Stdiums { get; set; }
        public DbSet<CourseReservation> courseReservations { get; set; }

    }
}
