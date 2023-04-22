using AltanDenemeC.Models;
using Microsoft.EntityFrameworkCore;

namespace AltanDenemeC.Data
{
    public class DatabaseContext:DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> opt) : base(opt)
        {

        }

        public DbSet<Users> Users {get;set;}
    }
}