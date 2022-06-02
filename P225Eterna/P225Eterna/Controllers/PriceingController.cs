using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using P225Eterna.DAL;
using P225Eterna.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace P225Eterna.Controllers
{
    public class PriceingController : Controller
    {
        private readonly AppDbContext _context;

        public PriceingController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            List<Plan> plans = _context.Plans.Include(p=>p.PlanFeatures).ThenInclude(pl=>pl.FeatureItem).ToList();

            return View(plans);
        }
    }
}
