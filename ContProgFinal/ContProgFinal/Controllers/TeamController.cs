﻿using ContProgFinal.Data;
using Microsoft.AspNetCore.Mvc;

namespace ContProgFinal.Controllers
{
    public class TeamController: Controller
    {
        private readonly TeamContext _context;
        public TeamController(TeamContext context)
        {
            _context = context;
        }
    }
}
