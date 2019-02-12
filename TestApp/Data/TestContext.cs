using Microsoft.EntityFrameworkCore;
using TestApp.Models;

namespace TestApp.Data
{
    public class TestContext : DbContext
    {
        public virtual DbSet<User> Users { get; set; }
    }
}
