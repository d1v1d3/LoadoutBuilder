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
using LoadoutBuilder.Mapping.Contracts;

namespace LoadoutBuilder.Services
{
    public class LoadoutService : ILoadoutService
    {
        private readonly IRepository<Loadout> _repository;
        private readonly ICustomMapper _mapper;
        public LoadoutService(IRepository<Loadout> repository, ICustomMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task AddLoadoutAsync(LoadoutFormModel model)
        {
            Loadout loadout = _mapper.Map<LoadoutFormModel, Loadout>(model);
            await _repository.AddAsync(loadout);
        }

        public async Task<IEnumerable<LoadoutIndexViewModel>> GetLoadoutsByUserIdAsync(string userId)
        {
            IEnumerable<LoadoutIndexViewModel> loadouts = _mapper.Map<IEnumerable<Loadout>, List<LoadoutIndexViewModel>>(await _repository
                .GetAllAttached()
                .Where(l=>l.UserId== userId)
                .ToListAsync());
            return loadouts;
        }
    }
}
