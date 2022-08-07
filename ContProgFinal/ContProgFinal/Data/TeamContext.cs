using ContProgFinal.Models;
using Microsoft.EntityFrameworkCore;

namespace ContProgFinal.Data
{
    public class TeamContext : DbContext
    {
        public TeamContext (DbContextOptions<TeamContext> options): base(options)
        {

        }
        public DbSet<TeamMembers> teamMembers { get; set; }
    }
}
