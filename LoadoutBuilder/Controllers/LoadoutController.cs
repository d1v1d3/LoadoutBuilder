using LoadoutBuilder.Data;
using Microsoft.AspNetCore.Mvc;
using LoadoutBuilder.Services.Contracts;
using LoadoutBuilder.ViewModels.Loadout;

namespace LoadoutBuilder.Web.Controllers
{
    public class LoadoutController : Controller
    {
        private readonly ILoadoutService _service;
        public LoadoutController(ILoadoutService loadoutService)
        {
            _service = loadoutService;
        }
        public async Task<IActionResult> Index()
        {
            var loadouts = await _service.GetLoadoutsByUserOrderedByIdAsync();
            return View(loadouts);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(LoadoutFormModel model)
        {
            if (ModelState.IsValid)
            {
                await _service.AddLoadoutAsync(model);
                return RedirectToAction(nameof(Index));
            }
            return View(model);
        }
    }
}
