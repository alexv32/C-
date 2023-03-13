using Microsoft.EntityFrameworkCore;
using NetApi.Models;
using System.Security.Policy;

namespace NetApi.Data
{
    public class ApiContext: DbContext
    {
        
        public DbSet<User> Users { get; set; }
        public ApiContext(DbContextOptions<ApiContext> options) : base(options)
        {

        }
        
    }
}
