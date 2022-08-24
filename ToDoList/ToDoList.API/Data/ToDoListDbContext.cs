using Microsoft.EntityFrameworkCore;
using ToDoList.API.Models.Domain;

namespace ToDoList.API.Data
{
    public class ToDoListDbContext:DbContext
    {
        public ToDoListDbContext(DbContextOptions<ToDoListDbContext>options): base(options) { 

        }
        public DbSet<Region> Regions { get; set; }
        public DbSet<Walk> Walks { get; set; }
        public DbSet<WalkDifficulty> WalkDifficulties { get; set; }
    }
}
