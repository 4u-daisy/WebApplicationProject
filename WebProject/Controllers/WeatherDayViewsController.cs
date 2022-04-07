#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DBContexts.DBContexts;
using WebProject.Domain.Models.WeatherTask;

namespace WebProject.Controllers
{
    public class WeatherDayViewsController : Controller
    {
        private readonly DataContext _context;

        public WeatherDayViewsController(DataContext context)
        {
            _context = context;
        }

        // GET: WeatherDayViews
        public async Task<IActionResult> Index()
        {
            return View(await _context.WeatherDayViews.ToListAsync());
        }

        // GET: WeatherDayViews/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var weatherDayView = await _context.WeatherDayViews
                .FirstOrDefaultAsync(m => m.Id == id);
            if (weatherDayView == null)
            {
                return NotFound();
            }

            return View(weatherDayView);
        }

        // GET: WeatherDayViews/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: WeatherDayViews/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,City,WeatherName,WeatherShortDescription,WeatherTemperature,WeatherTemperatureFeelsLikeCels")] WeatherDayView weatherDayView)
        {
            if (ModelState.IsValid)
            {
                _context.Add(weatherDayView);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(weatherDayView);
        }

        // GET: WeatherDayViews/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var weatherDayView = await _context.WeatherDayViews.FindAsync(id);
            if (weatherDayView == null)
            {
                return NotFound();
            }
            return View(weatherDayView);
        }

        // POST: WeatherDayViews/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,City,WeatherName,WeatherShortDescription,WeatherTemperature,WeatherTemperatureFeelsLikeCels")] WeatherDayView weatherDayView)
        {
            if (id != weatherDayView.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(weatherDayView);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!WeatherDayViewExists(weatherDayView.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(weatherDayView);
        }

        // GET: WeatherDayViews/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var weatherDayView = await _context.WeatherDayViews
                .FirstOrDefaultAsync(m => m.Id == id);
            if (weatherDayView == null)
            {
                return NotFound();
            }

            return View(weatherDayView);
        }

        // POST: WeatherDayViews/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var weatherDayView = await _context.WeatherDayViews.FindAsync(id);
            _context.WeatherDayViews.Remove(weatherDayView);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool WeatherDayViewExists(int id)
        {
            return _context.WeatherDayViews.Any(e => e.Id == id);
        }
    }
}
