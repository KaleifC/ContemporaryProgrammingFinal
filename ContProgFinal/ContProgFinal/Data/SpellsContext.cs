using ContProgFinal.Models;
using Microsoft.EntityFrameworkCore;

namespace ContProgFinal.Data
{
    public class SpellsContext: DbContext
    {
        public SpellsContext(DbContextOptions<SpellsContext> options): base(options)
        {

        }
        public DbSet<Spells> Spells { get; set; }
    }
}
