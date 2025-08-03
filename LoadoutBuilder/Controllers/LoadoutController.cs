using LoadoutBuilder.Data;
using LoadoutBuilder.Services.Contracts;
using LoadoutBuilder.ViewModels.Loadout;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

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
            var userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            var loadouts = await _service.GetLoadoutsByUserIdAsync(userId);
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
                var userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
                model.UserId = userId;
                await _service.AddLoadoutAsync(model);
                return RedirectToAction(nameof(Index));
            }
            return View(model);
        }
    }
}
