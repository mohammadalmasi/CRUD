using CRUD.Models;
using Microsoft.EntityFrameworkCore;

namespace CRUD.Repository
{
    public class MyDbContext : DbContext
    {
        public DbSet<Student> Students { get; set; }

        public MyDbContext(DbContextOptions<MyDbContext> context) 
            : base(context)
        {

        }

    }
}
