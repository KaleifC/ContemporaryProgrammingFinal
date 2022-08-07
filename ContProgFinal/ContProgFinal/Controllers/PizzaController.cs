using ContProgFinal.Data;
using Microsoft.AspNetCore.Mvc;

namespace ContProgFinal.Controllers
{
    public class PizzaController: Controller
    {
        private readonly PizzaContext _context;
        public PizzaController(PizzaContext context)
        {
            _context = context;
        }
    }
}
