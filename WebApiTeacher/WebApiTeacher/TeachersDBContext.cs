using Microsoft.EntityFrameworkCore;


namespace WebApiTeacher
{
    public class TeachersDBContext : DbContext
    {
        public TeachersDBContext(DbContextOptions <TeachersDBContext> options) : base(options)
        {
        }
        public DbSet <Teacher> Mwalimu { get; set; }
    }
}
