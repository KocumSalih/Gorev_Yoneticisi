using Gorev_Yoneticisi.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace Gorev_Yoneticisi.Models.Dal.Context
{
    public class Context:DbContext
    {
        public Context(DbContextOptions options):base(options)
        {

        }

        public DbSet<Event> Events { get; set; }
    }
}
