using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ResistanceCalc.Interfaces;
using ResistanceCalc.Models;

namespace ResistanceCalc.Controllers
{
    public class ResistController : Controller
    {
        public IOhmValueCalculator _CalculateResistance { get; }

        public ResistController(IOhmValueCalculator _CalculateResistance)
        {
            this._CalculateResistance = _CalculateResistance;
        }

        public IActionResult Index(ResistViewModel resistVM)
        {
            if (resistVM != null && ModelState.IsValid)
            {
                resistVM.Resistance = _CalculateResistance.CalculateResistance(resistVM.ColorA, resistVM.ColorB, resistVM.ColorC, resistVM.ColorD);
            }
            return View(resistVM);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
