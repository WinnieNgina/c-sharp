using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TaskManagement.Models;

namespace TaskManagement.TaskDBContext
{
    public class TaskContext : IdentityDbContext<User>
    {
        public TaskContext(DbContextOptions<TaskContext> options) : 
           base(options)
       {
       }
        public DbSet<ProjectTasks> Tasks {get; set;}
        public DbSet<Project> Projects { get; set;}
        public DbSet<Comment> Comments { get; set;}
        
    }
}
