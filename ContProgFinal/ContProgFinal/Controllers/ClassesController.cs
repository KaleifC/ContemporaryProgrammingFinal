using ContProgFinal.Data;
using Microsoft.AspNetCore.Mvc;

namespace ContProgFinal.Controllers
{
    public class ClassesController: Controller
    {
        private readonly ClassesContext _context;
        public ClassesController(ClassesContext context)
        {
            _context = context;
        }
    }
}
