using ContProgFinal.Data;
using Microsoft.AspNetCore.Mvc;

namespace ContProgFinal.Controllers
{
    public class SpellsController: Controller
    {
        private readonly SpellsContext _context;
        public SpellsController(SpellsContext context)
        {
            _context = context;
        }
    }
}
