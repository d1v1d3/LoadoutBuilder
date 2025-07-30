using LoadoutBuilder.Services.Contracts;
using LoadoutBuilder.ViewModels.Loadout;
using LoadoutBuilder.Data.Models;
using LoadoutBuilder.Infrastructure.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace LoadoutBuilder.Services
{
    public class LoadoutService : ILoadoutService
    {
        private readonly IRepository<Loadout> _repository;
        public LoadoutService(IRepository<Loadout> repository)
        {
            _repository = repository;
        }

        public async Task AddLoadoutAsync(LoadoutFormModel model)
        {
            var loadout = new Loadout{ Name = model.Name };
            await _repository.AddAsync(loadout);
        }

        public async Task<IEnumerable<LoadoutIndexViewModel>> GetLoadoutsByUserOrderedByIdAsync()
        {
            IEnumerable<LoadoutIndexViewModel> loadouts = await _repository
                .GetAllAttached()
                .Select(l => new LoadoutIndexViewModel { Id = l.Id, Name = l.Name, WeaponSlotCount = l.WeaponSlots.Count })
                .ToListAsync();
            return loadouts;
        }
    }
}
