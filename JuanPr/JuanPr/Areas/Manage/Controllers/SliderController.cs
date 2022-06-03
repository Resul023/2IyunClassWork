using JuanPr.Areas.ViewModel;
using JuanPr.DAL;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JuanPr.Areas.Manage.Controllers
{
    [Area("manage")]
    public class SliderController : Controller
    {
        private readonly AppDbContext _context;

        public SliderController(AppDbContext context)
        {
            this._context = context;
        }
        public IActionResult Index()
        {

            ViewModelSlider sliderVW = new ViewModelSlider
            {
                Sliders = _context.Sliders.ToList(),
            
            };
            return View(sliderVW);
        }
    }
}
